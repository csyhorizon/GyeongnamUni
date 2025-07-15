package Service.Message;

public enum Error {
    ERROR_START_INPUT("시작 구문이 진행할 수 없는 구문입니다."),
    ERROR_END_INPUT("끝 구문이 진행할 수 없는 구문입니다."),
    ERROR_NONE_FUNCTION("없는 함수에서 값을 가져올 수 없습니다."),;

    private final String message;

    Error(String message) {
        this.message = message;
    }

    @Override
    public String toString() {
        return message;
    }
}
