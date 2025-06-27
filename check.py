import os
from collections import Counter
from tensorflow.keras.preprocessing.image import ImageDataGenerator

DATA_DIR = 'data/personal_color_preprocessed'

datagen = ImageDataGenerator(rescale=1./255, validation_split=0.2)

train_data = datagen.flow_from_directory(
    DATA_DIR,
    target_size=(224, 224),
    batch_size=32,
    class_mode='categorical',
    subset='training',
    shuffle=True,
    seed=42
)

# 클래스 인덱스
print("class_indices:", train_data.class_indices)

# 클래스 분포 (클래스별 이미지 개수)
print("class_distribution:", Counter(train_data.classes))
