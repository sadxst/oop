using System;
using System.Text;
class Time
{
    public int H{ get; set; }
    public int M{ get; set; }
    public Time(int h, int m)
    {
        H = h;
        M = m;
    }
    public int Result()
    {
        return H*60 + M;
    }
}
class ООП_ЛР3_з2
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("К-ть годин: ");
        int h = int.Parse(Console.ReadLine());
        Console.Write("К-ть хвилин: ");
        int m = int.Parse(Console.ReadLine());
        Time time = new Time(h, m);
        int Result = time.Result();
        Console.WriteLine($"Загальна к-ть хвилин: {Result}");
    }
}
