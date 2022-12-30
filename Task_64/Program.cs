Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int p = 1;

int Numbers(int n, int p)
{
    if (n == p)
    {
        System.Console.Write($"{n};");
        return n;
    }
    else
    {
        Numbers(n,p+1);
        System.Console.Write($"{p};");
        return p;
    }
}

Numbers(n,p);