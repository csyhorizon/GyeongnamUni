#include <HCSR04.h>
#include <Servo.h>
#include <IRremote.h>
#include <math.h>

// 서브 모터
Servo myservo;
int moter = 30;

// 발사 서브 모터
Servo shot;
int shotmoter = 43;

// 리모컨 센서
IRrecv ir(2);
decode_results results;

// 라인 트레이서
int linePin[] = {49, 51, 53};

// 바퀴 Pin [우측 핀 - 좌측 핀]
int rightPin[] = {8, 9, 10};
int leftPin[] = {13, 11, 12};

// 바퀴 이동 [우측 핀 - 좌측 핀]
int go[] = {0, 1, 1, 0};
int back[] = {1, 0, 0, 1};
int right[] = {1, 0, 1, 0};
int left[] = {0, 1, 0, 1};

// 바퀴 이동 배열 [위 참조]
int ck[] = {go, back, left, right};

// 전방 카메라
int SR[] = {4, 3};

// 거리 측정 함수 [전방 - 좌측]
UltraSonicDistanceSensor distance(SR[0], SR[1]);

// 벽 거리
float dist_threshold = 20.0;
long turn_time = 200;

// 측정 불가 값 (-1)
float err = -1.00;
// 특정 값 도달 시 라인 트레이서 종료
int maxout = 0;

// 리모컨 컨트롤 (마지막 값)
int lastInput = 0;

// 리모콘 모드 [0 - 자동 / 1 - 수동]
bool remoteCC;

// 리모컨 바퀴 속도
int LSpeed = 0;
int RSpeed = 0;

void setup() {
  // 라인 트레이서
  pinMode(linePin[0], INPUT);
  pinMode(linePin[1], INPUT);
  pinMode(linePin[2], INPUT);

  // 초음파 모터
  myservo.attach(moter);
  myservo.write(90);

  shot.attach(shotmoter);
  shot.write(140);
  // 140 - 160

  // 출력 연결
  Serial.begin(9600);

  // 리모컨 수신 사용
  ir.enableIRIn();
}

// 이동 함수
void move(int n[], int sL, int sR) {
  speed(sL, sR);

  digitalWrite(rightPin[1], n[0]);
  digitalWrite(rightPin[2], n[1]);

  digitalWrite(leftPin[1], n[2]);
  digitalWrite(leftPin[2], n[3]);
}

// RC 속도 조절 (70 ~ 255 범위)
void speed(int sL, int sR) {
  // 130 ~ 255
  analogWrite(rightPin[0], sR);
  analogWrite(leftPin[0], sL);
}

// RC 정지
void stop() {
  speed(0, 0);
}



void loop() {
  if (remoteCC) {
    remote_control();
  }
  else {
    if (ir.decode(&results) == true) {
      if (results.value == 16761405) {
        remoteCC = true;
        lastInput = 4;
      }
      ir.resume();
    }
    // 특정 조건 도달 전 [라인 트레이서] - 이후 [장애물 회피]
    if (maxout < 700) {
      line();
    }
    else {
      avoidance();
    }
  }
}


// 라인 트레이서 코드
void line() {
  boolean l = digitalRead(linePin[0]) == HIGH ? 1 : 0;
  boolean m = digitalRead(linePin[1]) == HIGH ? 1 : 0;
  boolean r = digitalRead(linePin[2]) == HIGH ? 1 : 0;

  if (l && m && r) {
    maxout = 1000;
  }
  else if (!l && !m && !r) {
  }
  else if (l && m) {
    maxout = 0;
    move(go, 110, 80);
  }
  else if (r && m) {
    maxout = 0;
    move(go, 80, 110);
  }
  else if (r && l) {
    maxout = 0;
    stop();
  }
  else if (l) {
    maxout = 0;
    move(left, 100, 100);
  }
  else if (m) {
    maxout = 0;
    move(go, 85, 85);
  }
  else if (r) {
    maxout = 0;
    move(right, 100, 100);
  }
}


// 장애물 회피
void avoidance() {
    float cm = distance.measureDistanceCm();

  if (cm == -1 || cm > 20) {
      move(go, 75, 75);
  } 
  else {
    stop();
    check_side();
  }

  delay(100);
}

// 전방 탐지 확인 과정
void check_side() {
  int left = 0;
  int right = 0;
  myservo.write(180);
  delay(100);
  for(int i = 180; i >= 150; i-= 5) {
    myservo.write(i);
    delay(100);
    int ck = distance.measureDistanceCm();

    if (ck == -1) {
      left = -1;
      break;
    }
    else {
      left = max(left, ck);
    }
    delay(50);
  }
  myservo.write(90);
  delay(100);

  if (left == -1) {
    left_moter();
  }
  else {
    myservo.write(0);
    delay(500);

    for(int i = 0; i < 30; i+= 5) {
      myservo.write(i);
      delay(100);
      int ck = distance.measureDistanceCm();
      
      if (ck == -1) {
        right = -1;
        break;
      }
      else {
        right = max(right, ck);
      }
      delay(50);
    }
    myservo.write(90);
    delay(100);

    if (right == -1) {
      right_moter();
    }
    else if (right > left) {
      right_moter();
    }
    else {
      left_moter();
    }
  }
}

// 좌회전
void left_moter() {
  delay(100);
  move(left, 100, 100);
  delay(220);
  stop();
  delay(100);

  float ck = distance.measureDistanceCm();
  delay(500);

  if (ck < 25 && ck != err) {
    left_moter();
  }
  else {
    move(back, 70, 70);
    delay(150);
    stop();
    delay(100);
    move(left, 100, 100);
    delay(200);
    stop();

    move(go, 80, 80);
    delay(500);
  }
}

// 우회전
void right_moter() {
  delay(100);
  move(right, 100, 100);
  delay(220);
  stop();
  delay(100);

  float ck = distance.measureDistanceCm();
  delay(500);

  if (ck < 25 && ck != err) {
    right_moter();
  } else {
    move(back, 70, 70);
    delay(150);
    stop();
    delay(100);
    move(right, 100, 100);
    delay(200);
    stop();

    move(go, 80, 80);
    delay(500);
  }
}



// 리모컨 컨트롤
void remote_control() {
  if (ir.decode(&results) == true) {
    Serial.println(results.value, HEX);
    switch(results.value) {
      case 0xFFE21D:
        // 발사
        shot.write(190);
        lastInput = 4;
        stop();
        break;
      case 0xFFA25D:
        // 재장전
        shot.write(140);
        lastInput = 4;
        stop();
        break;
      case 16712445:
        // 컨트롤 변경 (>>|)
        break;
      case 16724175:
        // 좌회전(1)
        lastInput = 0;
        LSpeed = 0;
        RSpeed = 80;
        move(ck[lastInput], LSpeed, RSpeed);
        break;
      case 16743045:
        // 우회전(3)
        lastInput = 0;
        LSpeed = 80;
        RSpeed = 0;
        move(ck[lastInput], LSpeed, RSpeed);
        break;
      case 16728765:
        // 좌후진(7)
        lastInput = 1;
        LSpeed = 0;
        RSpeed = 80;
        move(ck[lastInput], LSpeed, RSpeed);
        break;
      case 16732845:
        // 우후진(9)
        lastInput = 1;
        LSpeed = 80;
        RSpeed = 0;
        move(ck[lastInput], LSpeed, RSpeed);
        break;
      case 16718055:
        // 전진(2)
        lastInput = 0;
        LSpeed = 80;
        RSpeed = 80;
        move(ck[lastInput], LSpeed, RSpeed);
        break;
      case 16730805:
        // 후진(8)
        lastInput = 1;
        LSpeed = 80;
        RSpeed = 80;
        move(ck[lastInput], LSpeed, RSpeed);
        break;
      case 16716015:
        // 좌회전(4)
        lastInput = 2;
        LSpeed = 80;
        RSpeed = 80;
        move(ck[lastInput], LSpeed, RSpeed);
        break;
      case 16734885:
        // 우회전(6)
        lastInput = 3;
        LSpeed = 80;
        RSpeed = 80;
        move(ck[lastInput], LSpeed, RSpeed);
        break;
      case 16726215:
        // 정지(5)
        lastInput = 4;
        stop();
        break;
      case 4294967295:
        // 지속 클릭 시 [마지막 입력 값 사용]
        if (lastInput == 4) {
          stop();
          break;
        }
        move(ck[lastInput], LSpeed, RSpeed);
        break;
    }
    ir.resume();
  }
}