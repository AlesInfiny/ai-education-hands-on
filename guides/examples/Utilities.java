import java.util.*;

public class Utilities {
    public static List<String> util1(List<String> input) {
        Set<String> set = new HashSet<>(input);
        List<String> result = new ArrayList<>(set);
        Collections.sort(result);
        return result;
    }
} 
