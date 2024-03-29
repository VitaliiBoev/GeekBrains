/* 6 march 2024. Напишите функцию printPrimeNums, которая выведет 
на экран все простые числа в промежутке от 1 до 1000, 
каждое на новой строке.

Напишите свой код в методе printPrimeNums класса Answer.
*/

public class printPrimeNums {
    public static void main(String[] args) {
        for (int i = 2; i < 1000; i++) {
            boolean isPrime = true;
            for (int j = 2; j < i; j++) {
                if (i % j == 0) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) {
                System.out.println(i);
                ;
            }
        }
    }
}

// public class Printer {
// public static void main(String[] args) {

// Answer ans = new Answer();
// ans.printPrimeNums();
// }
// }