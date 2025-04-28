using System;
using System.Text;

class Time
{
    public int H { get; set; }
    public int M { get; set; }
    public Time(int h, int m)
    {
        H = h;
        M = m;
    }
    public int Result()
    {
        return H * 60 + M;
    }
}
class FullTime : Time
{
    public int OperationTime { get; set; }
    public FullTime(int h, int m, int operationTime) : base(h, m)
    {
        OperationTime = operationTime;
    }
    public int Count()
    {
        int totalM = Result();
        if (OperationTime == 0)
            return 0;
        return totalM / OperationTime;
    }
}
class ООП_ЛР4_завдання
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("К-ть годин: ");
        int h = int.Parse(Console.ReadLine());
        Console.Write("К-ть хвилин: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Тривалість однієї операції (у хвилинах): ");
        int operationTime = int.Parse(Console.ReadLine());
        FullTime fullTime = new FullTime(h, m, operationTime);
        Console.WriteLine($"Загальна к-ть хвилин: {fullTime.Result()}");
        Console.WriteLine($"Кількість операцій, які можна виконати: {fullTime.Count()}");
    }
}