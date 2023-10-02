class Figure
{
    private Point[] points;

    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[] { p1, p2, p3 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0.0;
        int numPoints = points.Length;

        for (int i = 0; i < numPoints; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint = points[(i + 1) % numPoints]; // Wrap around to the first point for the last side
            double sideLength = GetSideLength(currentPoint, nextPoint);
            perimeter += sideLength;
        }

        Console.WriteLine($" {points[0].Name}");
        Console.WriteLine($" {perimeter}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 4, "B");
            Point C = new Point(3, 0, "C");

            Figure triangle = new Figure(A, B, C);
            triangle.CalculatePerimeter();

            Console.ReadLine();
        }
    }