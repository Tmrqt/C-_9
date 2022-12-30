Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int LeviMikasa(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return LeviMikasa(m - 1, 1);
    }
    else
    {
        return LeviMikasa(m - 1, LeviMikasa(m, n - 1));
    }
}

int ackr = LeviMikasa(m,n);
System.Console.WriteLine(ackr);