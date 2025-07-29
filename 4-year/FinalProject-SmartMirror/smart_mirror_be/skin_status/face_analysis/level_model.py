import torch
import torch.nn as nn
from torchvision import transforms, models
import cv2
import os
from pathlib import Path

BASE_DIR = Path(__file__).resolve().parent.parent.parent
model_path = os.path.join(BASE_DIR, 'skin_status', 'mobilenet_skin_best.pth')
num_classes = 6
device = torch.device("cpu")

# 🔁 모델을 최초 1회만 로드하도록 전역 변수 사용
_model = None

def get_model():
    global _model
    if _model is None:
        print(">>> 모델 로딩 중...")
        m = models.mobilenet_v2(weights=None)
        m.classifier[1] = nn.Linear(m.classifier[1].in_features, num_classes)
        m.load_state_dict(torch.load(model_path, map_location=device))
        m = m.to(device)
        m.eval()
        _model = m
        print(">>> 모델 로딩 완료")
    return _model

# ✅ 전처리
transform = transforms.Compose([
    transforms.ToPILImage(),
    transforms.Resize((224, 224)),
    transforms.ToTensor(),
    transforms.Normalize([0.5]*3, [0.5]*3)
])

# ✅ 추론 함수
def predict_acne_level(cv2_img):
    model = get_model()
    rgb_img = cv2.cvtColor(cv2_img, cv2.COLOR_BGR2RGB)
    input_tensor = transform(rgb_img).unsqueeze(0).to(device)
    with torch.no_grad():
        outputs = model(input_tensor)
        probs = torch.softmax(outputs, dim=1)
        pred = torch.argmax(probs, dim=1).item()
        confidence = probs[0][pred].item()
    return pred, confidence
