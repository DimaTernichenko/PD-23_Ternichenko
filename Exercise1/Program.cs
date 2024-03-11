using System;

class Program
{
    static void Main(string[] args)
    {
        int lastDigit = 0;

        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter another number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        int startInterval = 1;
        int endInterval = 10 + lastDigit;

        Console.WriteLine("Numbers that lie on the interval [{0}, {1}]:", startInterval, endInterval);
        if (num1 >= startInterval && num1 <= endInterval)
            Console.WriteLine(num1);
        if (num2 >= startInterval && num2 <= endInterval)
            Console.WriteLine(num2);
        if (num3 >= startInterval && num3 <= endInterval)
            Console.WriteLine(num3);

        Console.ReadKey();
    }
}