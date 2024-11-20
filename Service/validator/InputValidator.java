package Service.validator;

import static Service.Message.CheckInput.*;
import static Service.Message.Error.*;

public class InputValidator {
    public static void validateStartInput(String checkValue) {
        if (!checkValue.equals(START_INPUT.toString())) {
            throw new IllegalStateException(ERROR_START_INPUT.toString());
        }
    }

    public static void validateEndInput(String checkValue) {
        if (!checkValue.equals(END_INPUT.toString())) {
            throw new IllegalStateException(ERROR_END_INPUT.toString());
        }
    }
}
