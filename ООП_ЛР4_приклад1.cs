public class Rectangle
{
    private double a_;
    private double b_;
    public double a
    {
        get { return a_; }
        set
        {
            if (value > 0) a_ = value;
        }
    }
    public double b
    {
        get { return b_; }
        set
        {
            if (value > 0) b_ = value;
        }
    }
    public double Perimeter()
    {
        return 2 * (a + b);
    }
}
public class RParallelepiped : Rectangle
{
    private double c_;
    public double c
    {
        get { return c_; }
        set
        {
            if (value > 0) c_ = value;
        }
    }
    public double Volume()
    {
        return a * b * c;
    }
}
class ООП_ЛР4_приклад1
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        Console.WriteLine("Enter the length of side a of the rectangle:");
        rect.a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of side b of the rectangle:");
        rect.b = double.Parse(Console.ReadLine());
        RParallelepiped para = new RParallelepiped();
        Console.WriteLine("\nEnter the length of side a of the parallelepiped:");
        para.a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of side b of the parallelepiped:");
        para.b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of side c of the parallelepiped:");
        para.c = double.Parse(Console.ReadLine());
        Console.WriteLine("\nRectangle:");
        Console.WriteLine($"Side a: {rect.a}");
        Console.WriteLine($"Side b: {rect.b}");
        Console.WriteLine($"Perimeter: {rect.Perimeter()}");
        Console.WriteLine("\nParallelepiped:");
        Console.WriteLine($"Side a: {para.a}");
        Console.WriteLine($"Side b: {para.b}");
        Console.WriteLine($"Side c: {para.c}");
        Console.WriteLine($"Volume: {para.Volume()}");
    }
}