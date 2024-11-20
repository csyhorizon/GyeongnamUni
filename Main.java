import Service.console.Read;
import java.io.IOException;
import java.util.ArrayList;

public class Main {
    private static final Read read = new Read();

    public static void main(String[] args) throws IOException {
        String inputValue = "Please\nCheck\nData";
        ArrayList<String> functionString = read.ReadFile(inputValue);
        
    }
}
