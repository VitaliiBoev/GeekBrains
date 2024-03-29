Console.Clear();
// int n1 = new Random().Next(0, 1) == 0 ... 0
// int n2 = new Random().Next(10,10 or 11) == 10 ... 10
int a = new Random().Next(0, 1000); 
int b = new Random().Next(0, 1000); 
Console.Write("a=");
Console.Write(a);
if (a > b)
{
    Console.Write(" больше ");
}
else if (a == b)
{
    Console.Write(" равен ");
}
else
{
    Console.Write(" меньше ");
};
Console.Write("b=");
Console.WriteLine(b);