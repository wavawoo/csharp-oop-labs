using System;

class MatrixMultiply
{
    static void Main(string[] args)
    {
        int[,] a = new int[2, 2];
        int[,] b = new int[2, 2];
        int[,] result = new int[2, 2];

        Console.WriteLine("Enter numbers for matrix A:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"A[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter numbers for matrix B:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"B[{i},{j}] = ");
                b[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        Console.WriteLine("Result matrix C = A * B:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
