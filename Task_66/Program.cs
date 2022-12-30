Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Sum(int m, int n, int sum)
{
    if (n >= m)
    {
        sum = sum + n;
        if (n == m)
        {
            System.Console.WriteLine(sum);
            return;
        }
        Sum(m, n-1, sum);
    }
    if (n <= m)
    {
        sum = sum + m;
        if (n == m)
        {
            System.Console.WriteLine(sum);
            return;
        }
        Sum(m-1, n, sum);   
    }
}

Sum(n,m,0);