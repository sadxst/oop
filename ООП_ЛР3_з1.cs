using System;
using System.Text;
class Pr
{
    int x1, y1, x2, y2;
    public Pr(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }
    public int Width() => x2 - x1;
    public int Height() => y1 - y2;
    public int Perimeter() => 2 * (Width() + Height());
    public int Area() => Width() * Height();
    public void PrintVertices()
    {
        Console.WriteLine($"({x1}, {y1})");
        Console.WriteLine($"({x2}, {y1})");
        Console.WriteLine($"({x1}, {y2})");
        Console.WriteLine($"({x2}, {y2})");
    }
}
class ООП_ЛР3_з1
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Pr r = new Pr(1, 5, 6, 2);
        r.PrintVertices();
        Console.WriteLine($"Ширина: {r.Width()}");
        Console.WriteLine($"Висота: {r.Height()}");
        Console.WriteLine($"Периметр: {r.Perimeter()}");
        Console.WriteLine($"Площа: {r.Area()}");
    }
}
