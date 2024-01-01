class MainReturn
{
static void Main(string[] args)
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };

        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " " );
            PrintArrayReversed(arr, index - 1);
        }
 
    }
}