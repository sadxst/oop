public class Rectangle
{
    public double a { get; set; }
    public double b { get; set; }
    public Rectangle(double a, double b)
    {
        this.a = a;
        this.b = b;
    }
    public double Square()
    {
        return a * b;
    }
    public double Perimeter()
    {
        return 2 * (a + b);
    }
}
public class RParallelepiped : Rectangle
{
    public double c { get; set; }
    public RParallelepiped(double a, double b, double c) : base(a, b)
    {
        this.c = c;
    }
    public new double Square()
    {
        return base.Perimeter() * c + 2 * base.Square();
    }
}
class ООП_ЛР4_приклад3
{
    static void Main(string[] args)
    {
        double A, B, C;
        Console.WriteLine("Enter the length of side a of the rectangle:");
        A = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of side b of the rectangle:");
        B = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of side c of the parallelepiped:");
        C = double.Parse(Console.ReadLine());
        Rectangle rect = new Rectangle(A, B);
        Console.WriteLine("Square of your rectangle: " + rect.Square());
        RParallelepiped parallell = new RParallelepiped(A, B, C);
        Console.WriteLine("Square of your parallelepiped: " + parallell.Square());
    }
}
