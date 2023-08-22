using System;
using System.Reflection.Metadata.Ecma335;

class Practice
{
    public static void Main(string[] args)
    {
        //Sum of two numbers
        int a=5, b=6, num1=0, num2=1,sum;
        Console.WriteLine(sum = a + b);

        //Factorial Method
        Console.Write("Please enter a number you wana Factorial of :- ");
        int n = int.Parse(Console.ReadLine());
        int fact = Fact(n);
        Console.WriteLine(fact);

        //Fabonacci Series
        Console.Write("Please enter the number by which you want Fabonacci Series :- ");
        int fab = int.Parse(Console.ReadLine());
        Console.Write(num1 + " " + num2 + " ");
        for(int i = 0 ; i < fab-2 ; i++)
        {
            int temp = num1 + num2;
            Console.Write(temp+" ");
            num1 = num2;
            num2 = temp;
        }
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
