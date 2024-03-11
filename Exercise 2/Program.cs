using System;

class Point
{
    private int x;
    private int y;
    private string name;

    public Point(int x, int y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public string Name
    {
        get { return name; }
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point a, Point b, Point c)
    {
        points = new Point[] { a, b, c };
    }

    public Figure(Point a, Point b, Point c, Point d)
    {
        points = new Point[] { a, b, c, d };
    }

    public Figure(Point a, Point b, Point c, Point d, Point e)
    {
        points = new Point[] { a, b, c, d, e };
    }

    public double LengthSide(Point A, Point B)
    {
        double dx = A.X - B.X;
        double dy = A.Y - B.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Point a = points[i];
            Point b = points[(i + 1) % points.Length];
            perimeter += LengthSide(a, b);
        }
        Console.WriteLine("Polygon perimeter: " + perimeter);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point a = new Point(0, 0, "A");
        Point b = new Point(3, 0, "B");
        Point c = new Point(3, 4, "C");
        Point d = new Point(0, 4, "D");

        Figure figure1 = new Figure(a, b, c, d);
        Console.WriteLine("Polygon Name: ABCD");
        figure1.PerimeterCalculator();

        Console.ReadLine();
    }
}
    