package Service.DataHandler;

public interface InputDataHandler {
    void addData(String Function, int Value);
    int getData(String Function);
    void updateData(String Function, int Value);
    boolean containsVariable(String Function);
}
