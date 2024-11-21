package Service.console;

import static Service.Message.CheckInput.FUNCTION;
import static Service.Message.CheckInput.MINUS;
import static Service.Message.CheckInput.MULTIPLY;
import static Service.Message.CheckInput.PLUS;
import static Service.Message.CheckInput.PRINT;

import Service.DataHandler.HashMapHandler;
import Service.DataHandler.InputDataHandler;
import Service.Message.Error;
import java.util.HashMap;

public class compile {

    private final InputDataHandler handler;

    public compile() {
        handler = new HashMapHandler();
    }

    public String compileValue(String inputValue) {
        StringBuilder input = new StringBuilder();
        StringBuilder output = new StringBuilder();
        String last = "";
        String function = "";

        for(int i = 0; i < inputValue.length(); i++) {
            String s = inputValue.substring(i, i + 1);
            if (print(s) || function(s)) {
                if (print(s)) {
                    // 출력 함수인 경우
                    if (countCheck(input.toString())) {
                        // 만약 숫자만 존재하는 경우 : 계산 값 출력
                        int returnValue = returnMath(input.toString());
                        output.append(returnValue).append("\n");

                        // 함수 입력이 있었다면?
                        if (!function.isEmpty()) {
                            handler.updateData(function, returnValue);
                            function = "";
                        }
                    }
                    else {
                        // 아닌 경우 : 변수명으로 판단 후 변수 명 데이터 출력
                        if (!function.isEmpty()) {
                            output.append(handler.getData(function)).append("\n");
                        }
                        else {
                            output.append(handler.getData(input.toString())).append("\n");
                            function = input.toString();
                        }
                    }
                    input = new StringBuilder();
                }
                else {
                    // 함수 생성의 경우
                    handler.addData(input.toString(), 0);
                    function = input.toString();
                    input = new StringBuilder();
                }
            }
            else {
                input.append(s);
            }
        }

        if (!input.isEmpty()) {
            String test = input.toString();
            for (int i = 0; i < test.length(); i++) {
                String s = test.substring(i, i + 1);
                if (!countCheck(s)) throw new IllegalArgumentException(Error.ERROR_NONE_FUNCTION.toString());
            }
            int returnValue = returnMath(test);
            if (!function.isEmpty()) {
                handler.updateData(function, returnValue);
            }
        }

        return output.toString();
    }

    public int returnMath(String inputValue) {
        int result = 0;
        for (int i = 0; i < inputValue.length(); i++) {
            String s = inputValue.substring(i, i + 1);
            int ck = math(s);
            if (ck == 2) result *= 2;
            else result += ck;
        }
        return result;
    }

    public boolean countCheck(String inputValue) {
        if (inputValue.isEmpty()) return false;
        for (int i = 0; i < inputValue.length(); i++) {
            String s = inputValue.substring(i, i + 1);
            if (math(s) == 0) return false;
        }
        return true;
    }

    public boolean print(String inputValue) {
        if (inputValue.equals(PRINT.toString())) return true;
        return false;
    }

    public boolean function(String inputValue) {
        if (inputValue.equals(FUNCTION.toString())) return true;
        return false;
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
}
