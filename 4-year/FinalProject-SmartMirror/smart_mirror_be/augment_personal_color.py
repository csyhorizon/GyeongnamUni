import os
import numpy as np
from tqdm import tqdm
from tensorflow.keras.preprocessing.image import ImageDataGenerator, img_to_array, load_img, save_img

# 📁 데이터 경로
BASE_DIR = 'data'  # ← 클래스 폴더들이 위치한 경로로 수정
TARGET_COUNT = 750  # 클래스별 목표 이미지 수

# 🌈 이미지 증강 설정
datagen = ImageDataGenerator(
    rotation_range=20,
    width_shift_range=0.1,
    height_shift_range=0.1,
    shear_range=0.1,
    zoom_range=0.1,
    horizontal_flip=True,
    brightness_range=[0.8, 1.2],
    fill_mode='nearest'
)

# 📂 클래스 폴더 탐색
class_folders = [d for d in os.listdir(BASE_DIR) if os.path.isdir(os.path.join(BASE_DIR, d))]

for class_name in class_folders:
    class_path = os.path.join(BASE_DIR, class_name)
    os.makedirs(class_path, exist_ok=True)

    # 기존 이미지 파일 목록
    existing_files = [f for f in os.listdir(class_path) if f.lower().endswith(('.jpg', '.jpeg', '.png'))]
    n_existing = len(existing_files)
    print(f"📁 {class_name}: {n_existing}장 → 목표 {TARGET_COUNT}장")

    if n_existing >= TARGET_COUNT:
        print("✅ 충분하므로 스킵\n")
        continue

    needed = TARGET_COUNT - n_existing
    generated = 0

    # 진행바 설정
    with tqdm(total=needed, desc=f'📈 증강 중 - {class_name}', unit='img') as pbar:
        while generated < needed:
            for img_name in existing_files:
                img_path = os.path.join(class_path, img_name)
                try:
                    img = load_img(img_path)
                    x = img_to_array(img)
                    x = np.expand_dims(x, axis=0)

                    aug_iter = datagen.flow(x, batch_size=1)
                    aug_img = next(aug_iter)[0].astype(np.uint8)
                    new_name = f'aug_{generated:04d}_{os.path.splitext(img_name)[0]}.jpg'
                    save_img(os.path.join(class_path, new_name), aug_img)
                    generated += 1
                    pbar.update(1)

                    if generated >= needed:
                        break
                except Exception as e:
                    print(f"❌ 이미지 로딩 실패: {img_name} → {e}")
                    continue

    print(f"✅ {class_name} 증강 완료: 총 {n_existing + generated}장\n")

print("🎉 전체 클래스 증강 완료")
