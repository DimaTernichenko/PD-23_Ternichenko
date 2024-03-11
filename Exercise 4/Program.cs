using System;

class Program
{
    static void Main(string[] args)
    {
        int lastDigit = 0;

        int arrayLength = 10 + lastDigit;

        int[] X = new int[arrayLength];
        Random random = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            X[i] = random.Next(-99, 100);
        }

        Console.Write("Enter the number M: ");
        int M = int.Parse(Console.ReadLine());

        int[] Y = Array.FindAll(X, x => Math.Abs(x) > Math.Abs(M));

        Console.Write("Array X: ");
        foreach (int value in X)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Number M: {M}");
        Console.Write("Array Y: ");
        foreach (int value in Y)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}

