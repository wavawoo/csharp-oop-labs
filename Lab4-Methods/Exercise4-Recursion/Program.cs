using System;

class Utils
{
    public static int Greater(int a, int b)
    {
        return a > b ? a : b;
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static bool Factorial(int n, out int answer)
    {
        answer = 1;

        if (n < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers");
        }

        if (n > 12)
        {
            throw new ArgumentException("Number too large for integer factorial calculation");
        }

        for (int i = 1; i <= n; i++)
        {
            answer *= i;
        }

        return true;
    }

    public static int RecursiveFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers");
        }

        if (n == 0 || n == 1)
        {
            return 1;
        }

        return n * RecursiveFactorial(n - 1);
    }
}

class Test
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter first integer number:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second integer number:");
            int y = int.Parse(Console.ReadLine());

            int greater = Utils.Greater(x, y);
            Console.WriteLine($"The greater number is: {greater}");

            Console.WriteLine($"\nBefore swap: x = {x}, y = {y}");
            Utils.Swap(ref x, ref y);
            Console.WriteLine($"After swap: x = {x}, y = {y}");

            Console.WriteLine("\nEnter a number to calculate factorial:");
            int n = int.Parse(Console.ReadLine());

            if (Utils.Factorial(n, out int result))
            {
                Console.WriteLine($"Factorial of {n} is: {result}");
            }

            int recursiveResult = Utils.RecursiveFactorial(n);
            Console.WriteLine($"Recursive factorial of {n} is: {recursiveResult}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
