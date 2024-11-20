package Service.Message;

public enum checkInput {
    START_INPUT("진짜로"),
    END_INPUT("가고싶다 ㅋㅋㅋ"),

    PLUS(","),      // 더하기
    MINUS("."),     // 빼기
    MULTIPLY("!"),  // 곱셈

    FUNCTION("집"),  // 집 앞의 값들을 함수로 쓸거임
    PRINT("ㅠ");     // 출력

    private final String message;

    checkInput(String message) {
        this.message = message;
    }
}
