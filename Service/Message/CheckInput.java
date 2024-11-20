package Service.Message;

public enum CheckInput {
    START_INPUT("진짜로"),
    END_INPUT("가고싶다 ㅋㅋㅋ"),

    FUNCTION("집"),  // 집 앞의 값들을 함수로 쓸거임
    PRINT("ㅠ"),     // 출력

    PLUS(","),      // 더하기
    MINUS("."),     // 빼기
    MULTIPLY("!")   // 곱하기
    ;

    private final String message;

    CheckInput(String message) {
        this.message = message;
    }

    @Override
    public String toString() {
        return message;
    }
}
