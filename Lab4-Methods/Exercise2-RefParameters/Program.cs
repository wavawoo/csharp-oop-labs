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
}

class Test
{
    static void Main(string[] args)
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
    }
}
