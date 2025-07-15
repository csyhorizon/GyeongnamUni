package Service.console;

import Service.validator.InputValidator;
import java.util.ArrayList;
import java.util.function.Consumer;

public class CheckData {

    public void checkData(ArrayList<String> arrayList) {
        getInput(InputValidator::validateStartInput, arrayList.get(0));
        getInput(InputValidator::validateEndInput, arrayList.get(arrayList.size() - 1));
    }

    public void getInput(Consumer<String> validator, String input) {
        validator.accept(input);
    }
}
