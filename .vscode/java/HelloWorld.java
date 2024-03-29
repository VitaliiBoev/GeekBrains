import java.time.LocalDateTime;
import java.util.Scanner;

public class HelloWorld {
    public static void main(String[] args) {
        // System.out.println("Hello,world");
        System.out.println(LocalDateTime.now());
        Scanner scanner = new Scanner(System.in);
        Scanner str = scanner.nextLine();
        scanner.close();
    }
}
