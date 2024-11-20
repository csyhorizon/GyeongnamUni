package Service.console;

import Service.validator.InputValidator;
import java.util.ArrayList;
import java.util.function.Consumer;

public class CheckData {

    public void checkData(ArrayList<String> arrayList) {
        getInput(InputValidator::validateStartInput, arrayList.getFirst());
        getInput(InputValidator::validateEndInput, arrayList.getLast());
    }

    public void getInput(Consumer<String> validator, String input) {
        validator.accept(input);
    }
}
