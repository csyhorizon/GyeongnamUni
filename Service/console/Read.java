package Service.console;

import java.util.ArrayList;
import java.util.StringTokenizer;

public class Read {
    public ArrayList<String> ReadFile(String file) {
        StringTokenizer st = new StringTokenizer(file, "\n");
        ArrayList<String> arrayList = new ArrayList<>();
        String s;
        while(st.hasMoreTokens()) {
            s = st.nextToken();
            arrayList.add(s);
        }
        return arrayList;
    }
}
