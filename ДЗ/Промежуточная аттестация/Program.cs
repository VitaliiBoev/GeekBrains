Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void che(int m = 2, int n = 1)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.Write("{m}, ");
    }
    che(m + 1, n);

}
che(m, n);