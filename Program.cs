using System;

class Fibonachi
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number in Fibonachi equals to: " + fib(number));
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    public static int fib(int number)
    {
        int a = 0;
        int b = 1;
        for (int i = 1; i < number; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }
}