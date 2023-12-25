/*Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];
Console.Write("Введите позицию строки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());
void mas(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.NextDouble();
            Console.Write($"{ randomArray[i, j]:F2} ");
}
Console.WriteLine();
}
}
mas(m, n);
if (m2 < 1 || n2 < 1)
    Console.Write("озиции строк не могут быть отрицательными");
else if (m2 <= m + 1 && n2 <= n + 1)
    Console.Write($"Значение элемента равно { randomArray[m2 - 1, n2 - 1]:F2} ");
else Console.Write("Такого элемента нет в массиве");*/

//--------------------------------------------------------------------------------------

// Задача 2 
// namespace ConsoleApp4
// {
//     class Programm
//     {
//         static void Main(string[] args)
//         {
//             int[,] array = CreateArray(5, 5, 10, 1);
//             Console.WriteLine("Исходный массив:");
//             PrintArray(array);
//             ReplaceFirstRowWithLastRow(array);
//             Console.WriteLine("После выполнения операций:");
//             PrintArray(array);
//         }
        
//         public static int[,] CreateArray(int Rows, int Columns, int MaxValue, int MinValue)
//         {
//             //Возвращаемый массив
//             int[,] Result = new int[Rows, Columns];
//             Random random = new Random();
//             for (int i = 0; i < Rows; i++)
//             {
//                 for (int j = 0; j < Columns; j++)
//                 {
//                     Result[i, j]=random.Next(MinValue, MaxValue);
//                 }

//             }
//             return Result;

//         }
//         public static void ReplaceFirstRowWithLastRow(int[,] Array)
//         {
//             int tmp;
//             int Rows = Array.GetUpperBound(0)+1;
//             for (int i = 0; i < Array.Length/Rows; i++)
//             {
//                 tmp = Array[0, i];
//                 Array[0, i]=Array[Rows-1, i];
//                 Array[Rows-1, i]=tmp;
//             }

//         }
//         public static void PrintArray(int[,] Array)
//         {
//             int Rows = Array.GetUpperBound(0)+1;
//             for (int i = 0; i < Rows; i++)
//             {
//                 for (int j = 0; j <Array.Length/Rows; j++)
//                 {
//                     Console.Write($"{Array[i, j]}\t");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }
// -------------------------------------------------------------------------------------
// Задача 3
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 namespace ConsoleApp4
{
    class Programm
    {
        static void Main(string[] args)
        {
            int[,] array = {{1,2,3}, {4,5,6}, {7,8,9}, {10,11,12}};
            int minSumRow = 0;
            int minSum = int.MaxValue;
            for (int i=0; i<array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j=0; j<array.GetLength(1); j++)
            {
                sum += array[i,j];

            }
            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }
        Console.WriteLine ("Строка с наименьшейсуммой элементов: ");
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[minSumRow, j] + " ");

        }
        Console.WriteLine();

        }
    }
}