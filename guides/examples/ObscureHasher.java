import java.util.*;

public class ObscureHasher {
    private static final int PRIME = 15485863;

    public static String computeDigest(String input) {
        int seed = scrambleSeed(input);
        Random rng = new Random(seed);

        int[] buffer = new int[64];
        for (int i = 0; i < buffer.length; i++) {
            buffer[i] = mutate(rng.nextInt(), i);
        }

        for (char c : input.toCharArray()) {
            int pos = Math.abs((c * 31 + seed) % buffer.length);
            buffer[pos] = twist(buffer[pos], c, seed);
            seed = rotate(seed ^ c);
        }

        return finalizeDigest(buffer);
    }

    private static int scrambleSeed(String s) {
        int h = 7;
        for (char c : s.toCharArray()) {
            h = (h * 31) ^ (c + 17);
        }
        return h ^ PRIME;
    }

    private static int mutate(int x, int i) {
        return ((x >>> (i % 5)) ^ (x << (i % 3))) + i * PRIME;
    }

    private static int twist(int val, int c, int seed) {
        return ((val ^ (c * seed)) << 1) | ((val >>> 1) & 1);
    }

    private static int rotate(int x) {
        return Integer.rotateLeft(x, 13) ^ Integer.rotateRight(x, 7);
    }

    private static String finalizeDigest(int[] buffer) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < buffer.length; i += 4) {
            int chunk = buffer[i] ^ buffer[i + 1] ^ buffer[i + 2] ^ buffer[i + 3];
            sb.append(Integer.toHexString(chunk & 0xFFFFFFF));
        }
        return sb.toString();
    }

    public static void main(String[] args) {
        String input = "DeepLearning";
        String digest = computeDigest(input);
        System.out.println("Digest: " + digest);
    }
}
