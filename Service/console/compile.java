package Service.console;

import static Service.Message.CheckInput.MINUS;
import static Service.Message.CheckInput.MULTIPLY;
import static Service.Message.CheckInput.PLUS;

import Service.DataHandler.HashMapHandler;
import Service.DataHandler.InputDataHandler;

public class compile {

    private final InputDataHandler handler;

    public compile() {
        handler = new HashMapHandler();
    }

    public String compileValue(String inputValue) {
        StringBuilder output = new StringBuilder();
        int value;
        String Function;
        boolean check = false;

        for(int i = 0; i < inputValue.length(); i++) {
            String now = inputValue.substring(i, i + 1);

            if (check && math(now) != 0) {

            }
            else {
                // '집' 글자 확인하기 >> 맞다면 이전 값들은 함수
                // 'ㅠ' 글자 확인하기 >> 맞다면 value에 값이 있다면 출력, 아니라면 Function 비교 출력, 아니라면 에러 출력
                // 아니라면 Function에 명칭 추가
            }
        }

        return output.toString();
    }

    private int math(String now) {
        if (now.equals(MINUS.toString())) {
            return -1;
        }
        if (now.equals(PLUS.toString())) {
            return 1; // 플러스를 1이라고 칭함
        }
        if (now.equals(MULTIPLY.toString())) {
            return 2;
        }
        return 0;
    }


    public int returntest() {
        return handler.getData("너무");
    }
}
