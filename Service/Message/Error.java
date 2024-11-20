package Service.Message;

public enum Error {
    NONE_INPUT("값 입력이 정상적으로 이뤄지지 않았습니다."),
    ERROR_INPUT("결과를 출력할 수 없는 문제가 발생했습니다."),
    WHAT_START("시작 구문이 진행할 수 없는 구문입니다."),
    WHAT_END("끝 구문이 진행할 수 없는 구문입니다."),
    WHAT_FUNCTION("결코 진행할 수 없을 명령입니다.");

    private final String message;

    Error(String message) {
        this.message = message;
    }
}
