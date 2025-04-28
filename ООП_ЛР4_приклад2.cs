public class Rectangle
{
    public double A { get; set; }
    public double B { get; set; }
    public Rectangle(double A, double B)
    {
        this.A = A;
        this.B = B;
    }
}
public class RParallelepiped : Rectangle
{
    public double C { get; set; }
    public RParallelepiped(double A, double B, double C) : base(A, B)
    {
        this.C = C;
    }
}
class ООП_ЛР4_приклад2
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
        RParallelepiped rPar = new RParallelepiped(A, B, C);
        Console.WriteLine("\nRectangle:");
        Console.WriteLine($"Side a: {rPar.A}");
        Console.WriteLine($"Side b: {rPar.B}");
        Console.WriteLine("\nParallelepiped:");
        Console.WriteLine($"Side a: {rPar.A}");
        Console.WriteLine($"Side b: {rPar.B}");
        Console.WriteLine($"Side c: {rPar.C}");
    }
}
