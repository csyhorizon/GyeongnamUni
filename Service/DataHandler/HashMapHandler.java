package Service.DataHandler;

import Service.Message.Error;
import java.util.HashMap;

public class HashMapHandler implements InputDataHandler {
    private HashMap<String, Integer> datamap;

    public HashMapHandler() {
        this.datamap = new HashMap<>();
    }

    @Override
    public void addData(String Function, int Value) {
        System.out.println("Adding data: " + Function + " = " + Value);
        datamap.put(Function, Value);
    }


    @Override
    public int getData(String Function) {
        return datamap.getOrDefault(Function, 0); // null 대신 기본값 반환
    }

    @Override
    public void updateData(String Function, int Value) {
        if (datamap.containsKey(Function)) {
            datamap.put(Function, Value);
        } else {
            throw new IllegalStateException(Error.ERROR_NONE_FUNCTION.toString());
        }
    }

    @Override
    public boolean containsVariable(String Function) {
        return datamap.containsKey(Function);
    }
}
