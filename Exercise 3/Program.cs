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
            X[i] = random.Next(100);
        }

        int minValue = X[0];
        int maxValue = X[0];
        for (int i = 1; i < arrayLength; i++)
        {
            if (X[i] < minValue)
            {
                minValue = X[i];
            }
            else if (X[i] > maxValue)
            {
                maxValue = X[i];
            }
        }

        Console.Write("Array X: ");
        foreach (int value in X)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Minimum value: {minValue}");
        Console.WriteLine($"Maximum value: {maxValue}");
    }
}

