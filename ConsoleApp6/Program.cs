
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("14:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("44:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($" {rectangle.Area}");
        Console.WriteLine($" {rectangle.Perimeter}");

        Console.ReadLine();
    }
}

