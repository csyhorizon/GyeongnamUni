var arr = [
	{
		quiz: "비교과 마일리지 장학금 수령 계좌는 본인 또는 본인 가족의 명의여야만 한다.",
		answer: 0,
        help: "본인 명의의 계좌만 등록이 가능하며, 가족 명의는 불가능하므로 정답은 'X' 입니다."
	},
	{
		quiz: "비교과 마일리지는 1년에 2번 장학금을 지급한다.",
		answer: 1,
        help: "마일리지는 한 학기가 끝나고 지급하며, 1년에 2번 지급하므로 정답은 'O' 입니다."
	},
	{
		quiz: "교내 행정부서에서 운영하는 프로그램 및 대회 등은 학생이 개인적으로 등록이 가능하다.",
		answer: 0,
        help: "주관부서에서 입력해야하므로 정답은 'X' 입니다."
	},
	{
		quiz: "계좌 등록은 매 학기마다 해야한다.",
		answer: 0,
        help: "계좌 등록은 최초 1번만 진행하면 되므로 정답은 'X' 입니다."
	}
    // If a Kyungnam University student were to open this, you would be impressed by its simplicity.
];

var quiz1 = document.getElementById('quiz1');
var answer1 = document.getElementById('answer1');

var quiz2 = document.getElementById('quiz2');
var answer2 = document.getElementById('answer2');

var btn = document.getElementById('btn');
var que1;
var que2;



var random1 = Math.floor(Math.random() * arr.length);
var random2 = (random1 + 2) % arr.length;

quiz1.textContent = 'Q1. ' + arr[random1].quiz;
que1 = arr[random1].answer;
//answer1.textContent = arr[random1].answer;

quiz2.textContent = 'Q2. ' + arr[random2].quiz;
que2 = arr[random2].answer;
//answer2.textContent = arr[random2].answer;


var que1_o = document.getElementById('que1_o');
var que1_x = document.getElementById('que1_x');
var reload = -1;

var ck1 = -1, ck2 = -1;
que1_o.addEventListener('click', function() {
    que1_o.style.backgroundColor = "rgba(255, 251, 5, 0.6)";
    que1_x.style.backgroundColor = "rgb(52, 183, 216, 0.6)";
    ck1 = 1;
});
que1_x.addEventListener('click', function() {
    que1_x.style.backgroundColor = "rgba(255, 251, 5, 0.6)";
    que1_o.style.backgroundColor = "rgba(231, 37, 37, 0.6)";
    ck1 = 0;
});


var que2_o = document.getElementById('que2_o');
var que2_x = document.getElementById('que2_x');
que2_o.addEventListener('click', function() {
    que2_o.style.backgroundColor = "rgba(255, 251, 5, 0.6)";
    que2_x.style.backgroundColor = "rgb(52, 183, 216, 0.6)";
    ck2 = 1;
});
que2_x.addEventListener('click', function() {
    que2_x.style.backgroundColor = "rgba(255, 251, 5, 0.6)";
    que2_o.style.backgroundColor = "rgba(231, 37, 37, 0.6)";
    ck2 = 0;
});



var send_v = document.getElementById('send_v');
var hint1 = document.getElementById('hint1');
var hint2 = document.getElementById('hint2');

send_v.addEventListener('click', function() {
    if(ck1 == que1 && ck2 == que2 && reload == -1) {
        alert('정답입니다! 상품을 받아가세요.');
        var link = 'https://chinoel.github.io/Support_Quiz/succ.html';
        location.replace(link);
    }
    else if(ck1 == -1 || ck2 == -1 && reload == -1) {
        alert('풀지 않은 문제가 있습니다!');
    }
    else if(reload == 0) {
        location.reload();
    }
    else {
        reload = 0;
        alert('문제를 틀렸습니다. 오답 확인 후 다시 도전하세요.');
        send_v.textContent = '문제 다시 풀기';

        hint1.textContent = 'A1. ' + arr[random1].help;
        hint2.textContent = 'A2. ' + arr[random2].help; 
    }
});
