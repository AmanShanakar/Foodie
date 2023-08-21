using System;
using System.Reflection.Metadata.Ecma335;

class Practice
{
    public static void Main(string[] args)
    {
        int a=5, b=6, sum;
        Console.WriteLine(sum = a + b);
    }
    public static int Fact(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return n*Fact(n - 1);
    }
}
