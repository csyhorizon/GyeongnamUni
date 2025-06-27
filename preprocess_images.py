import os
import cv2
import numpy as np
from tqdm import tqdm
from tensorflow.keras.preprocessing.image import load_img, img_to_array, save_img

# 원본 이미지 폴더
SRC_BASE = 'data/personal_color'
# 전처리된 이미지 저장 폴더
DST_BASE = 'data/personal_color_preprocessed'
# 샘플 이미지 확인용 폴더
CHECK_BASE = 'check_preprocessed'

# 1. 히스토그램 평활화
def apply_hist_eq(img):
    ycrcb = cv2.cvtColor(img, cv2.COLOR_RGB2YCrCb)
    ycrcb[:, :, 0] = cv2.equalizeHist(ycrcb[:, :, 0])
    return cv2.cvtColor(ycrcb, cv2.COLOR_YCrCb2RGB)

# 2. 자동 화이트 밸런싱
def simple_white_balance(img):
    img = img.astype(np.float32)
    result = cv2.cvtColor(img, cv2.COLOR_RGB2LAB)
    avg_a = np.average(result[:, :, 1])
    avg_b = np.average(result[:, :, 2])
    result[:, :, 1] -= ((avg_a - 128) * (result[:, :, 0] / 255.0) * 1.1)
    result[:, :, 2] -= ((avg_b - 128) * (result[:, :, 0] / 255.0) * 1.1)
    result = np.clip(result, 0, 255)
    result = result.astype(np.uint8)
    return cv2.cvtColor(result, cv2.COLOR_LAB2RGB)

# 3. CLAHE 적용
def apply_clahe(img):
    lab = cv2.cvtColor(img, cv2.COLOR_RGB2LAB)
    clahe = cv2.createCLAHE(clipLimit=2.0, tileGridSize=(8, 8))
    lab[:, :, 0] = clahe.apply(lab[:, :, 0])
    return cv2.cvtColor(lab, cv2.COLOR_LAB2RGB)

# 전체 보정 적용
def apply_all_preprocessing(img):
    img = apply_hist_eq(img)
    img = simple_white_balance(img)
    img = apply_clahe(img)
    return img

# 이미지 전처리 및 저장
for class_name in os.listdir(SRC_BASE):
    src_dir = os.path.join(SRC_BASE, class_name)
    dst_dir = os.path.join(DST_BASE, class_name)
    check_dir = os.path.join(CHECK_BASE, class_name)
    
    os.makedirs(dst_dir, exist_ok=True)
    os.makedirs(check_dir, exist_ok=True)

    count = 0
    for img_name in tqdm(os.listdir(src_dir), desc=f"Processing {class_name}"):
        if img_name.lower().endswith(('.jpg', '.jpeg', '.png')):
            img_path = os.path.join(src_dir, img_name)
            img = load_img(img_path)
            img = img_to_array(img).astype(np.uint8)
            img = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)

            processed_img = apply_all_preprocessing(img)

            # 전처리 결과 저장
            save_img(os.path.join(dst_dir, img_name), processed_img)

            # 앞 10장 샘플 이미지 저장
            if count < 10:
                save_img(os.path.join(check_dir, f"sample_{img_name}"), processed_img)
                count += 1
