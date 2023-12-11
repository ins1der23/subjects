import java.util.HashMap;
import java.util.Map;

import javax.swing.RowFilter.Entry;

public class Request {
    private HashMap<String, String> request;
    
    public Request()
    {
        request = new HashMap<>();
        request.put("brandName", new String());
        request.put("model", new String());
        request.put("cpuName", new String());
        request.put("cpuModel", new String());
        request.put("ramVolume", new String());
        request.put("ssdVolume", new String());
        request.put("os", new String());
        request.put("price", new String());
    }

    public void add(String key, String value){
        request.put(key, value);
    }

    public HashMap<String, String> toHashMap()
    {
        HashMap<String,String> output = request;
        return output;
    }


}