import os

# 데이터 디렉토리 경로
DATA_DIR = 'data'  # 또는 'data/personal_color_preprocessed' 등 해당 경로로 수정

# 클래스별 이미지 수 출력
for class_name in sorted(os.listdir(DATA_DIR)):
    class_path = os.path.join(DATA_DIR, class_name)
    if os.path.isdir(class_path):
        img_count = len([
            f for f in os.listdir(class_path)
            if f.lower().endswith(('.jpg', '.jpeg', '.png'))
        ])
        print(f"📂 {class_name}: {img_count}장")
