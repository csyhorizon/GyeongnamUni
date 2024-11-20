import Service.console.CheckData;
import Service.console.Read;
import java.io.IOException;
import java.util.ArrayList;
import javax.xml.crypto.Data;

public class Main {
    private static final Read read = new Read();
    private static final CheckData checkData = new CheckData();

    public static void main(String[] args) throws IOException {
        String inputValue = "진짜로\nCheck\n가고싶다 ㅋㅋㅋ";
        ArrayList<String> functionString = read.ReadFile(inputValue);

        // 데이터 검증 -> 실패 시 실패 반환
        boolean allTestData = true;
        try {
            checkData.checkData(functionString);
        } catch (IllegalStateException e) {
            System.out.println(e.getMessage());
            allTestData = false;
        }
        System.out.println(allTestData);
    }

    public String getHomeLanguageResult(String inputValue) {
        ArrayList<String> functionString = read.ReadFile(inputValue);
        String result = "";

        boolean allTestData = true;
        try {
            checkData.checkData(functionString);
        } catch (IllegalStateException e) {
            throw new IllegalStateException(e);
        }
        return result;
    }

}
