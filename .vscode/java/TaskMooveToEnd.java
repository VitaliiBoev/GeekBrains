/*Дан массив nums=[3,2,2,3]и число val=3. Если в 
массиве есть числа,равные заданному,нужно перенести 
эти элементы в конец массива.Таким образом,первые несколько
(или все)элементов массива должны быть отличны от заданного,
а остальные-равны ему.
*/
public class TaskMooveToEnd {
    public static void main(String[] args) {
        final int[] array = { 3, 2, 2, 3 };
        final int val = 3;
        int leftIndex = 0;
        int righthIndex = array.length - 1;
        while (leftIndex < righthIndex) {
            while (array[righthIndex] == val) {
                righthIndex--;
            }
            if (array[leftIndex] == val) {
                array[leftIndex] = array[righthIndex];
                array[righthIndex] = val;
                righthIndex--;
            }
            leftIndex++;
        }

    }
}
