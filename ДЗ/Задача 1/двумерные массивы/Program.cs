// Задайте двумерный массив символов (типа char [,]]. 
// Создать строку из символов этого массива)
// a b c => "abcdef"
// d e f

Console.Clear();
char[,] array = new char[,]{{'a', 'b', 'c'}, {'d', 'e, 'f'}};
string res = "";
// for(int i = 0; i < array.Length; i++)
//     res += array[i];

foreach(char i in array)
res += i;

Console.WriteLine(res);