using System;
using System.Transactions;

class DivideIt
{
    static void Main(string[] args)
    {
        int i, j;
        string temp;

        try
        {
            Console.WriteLine("Enter the first number:");
            temp = Console.ReadLine();
            i = Convert.ToInt32(temp);

            Console.WriteLine("Enter the second number:");
            temp = Console.ReadLine();
            j = Convert.ToInt32(temp);

            int k = i / j;
            Console.WriteLine("Result of division: " + k);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: enter valid integer numbers!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: division by zero is not allowed");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
