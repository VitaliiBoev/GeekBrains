/*Напишите метод, который сжимает строку. Пример: вход aaaabbbcdd.
результат a4b3c1d2 */

public class StringCompression {
    public static void main(String[] args) {
        String str = "aaabbbcdd";
        System.out.println(StringCompression(str));

    }

    public static String StringCompression(String str) {
        StringBuilder sb = new StringBuilder();
        int count = 1;
        char currentChar = str.charAt(0);
        for (int i = 0; i < str.length(); i++) {
            if (str.charAt(i) == currentChar) {
                count++;
            } else {
                sb.append(currentChar).append(count);
                count = 1;
                currentChar = str.charAt(i);

            }
        }
        sb.append(currentChar).append(count);
        return sb.toString();
    }
}
