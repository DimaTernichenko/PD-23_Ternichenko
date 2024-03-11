using System;

class Program
{
    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && b + c > a && a + c > b;
    }

    static string ClassifyTriangle(double a, double b, double c)
    {
        double[] sides = { a, b, c };
        Array.Sort(sides);

        if (sides[0] == sides[1] && sides[1] == sides[2])
            return "Equilateral triangle";
        else if (sides[0] == sides[1] || sides[1] == sides[2])
            return "Isosceles triangle";
        else
            return "Isosceles triangle";
    }

    static double TriangleArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static double TrianglePerimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the length of the first side: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second side: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the third party: ");
        double c = double.Parse(Console.ReadLine());

        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("The lengths of the sides must be positive numbers.");
            return;
        }

        if (!IsValidTriangle(a, b, c))
        {
            Console.WriteLine("This triangle does not exist.");
            return;
        }

        double perimeter = TrianglePerimeter(a, b, c);
        double area = TriangleArea(a, b, c);
        string triangleType = ClassifyTriangle(a, b, c);

        Console.WriteLine($"Triangle perimeter: {perimeter}");
        Console.WriteLine($"Area of triangle: {area:F2}");
        Console.WriteLine($"Triangle type: {triangleType}");
    }
}

