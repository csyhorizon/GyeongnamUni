import Service.console.CheckData;
import Service.console.Read;
import Service.console.compile;
import java.io.IOException;
import java.util.ArrayList;

public class Main {

    private static final Read read = new Read();
    private static final CheckData checkData = new CheckData();
    private static final compile compile = new compile();

    public static void main(String[] args) throws IOException {
        // main 함수는 테스트를 위해 작성한 코드입니다.
        String inputValue = "진짜로\n너무집,!!!!,\n너무ㅠ\n너무ㅠㅠ\n가고싶다 ㅋㅋㅋ";
        String result = getHomeLanguageResult(inputValue);

        System.out.println(result);
    }

    public static String getHomeLanguageResult(String inputValue) {

        ArrayList<String> functionString = read.ReadFile(inputValue);
        StringBuilder sb = new StringBuilder();

        try {
            checkData.checkData(functionString);

            for (int i = 1; i < functionString.size() - 1; i++) {
                sb.append(compile.compileValue(functionString.get(i)));
            }

        } catch (IllegalStateException e) {
            throw new IllegalStateException(e);
        }

        return sb.toString();
    }

}

