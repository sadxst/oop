using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Варіант 7.");

        Random t1 = new Random();
        List<int> task1 = new List<int>();
        for (int i = 0; i < 20; i++)
            task1.Add(t1.Next(15, 56));
        Console.WriteLine("\nЗавдання 1. Список:");
        foreach (int x in task1)
            Console.Write(x + " ");
        Console.WriteLine();
        for (int i = task1.Count - 1; i >= 0; i--)
        {
            if (task1[i] % 3 == 0 && task1[i] % 10 == 5)
            {
                task1.RemoveAt(i);
                break;
            }
        }
        Console.WriteLine("\nЗмінений список:");
        foreach (int x in task1)
            Console.Write(x + " ");

        Random t2 = new Random();
        List<int> task2 = new List<int>();
        for (int i = 0; i < 20; i++)
            task2.Add(t2.Next(5, 51));
        Console.WriteLine("\n\nЗавдання 2. Список:");
        foreach (int x in task2)
            Console.Write(x + " ");
        Console.WriteLine();
        Console.Write("Введіть X: ");
        int X = int.Parse(Console.ReadLine());
        for (int i = 0; i < task2.Count; i++)
        {
            int last = task2[i] % 10;
            if (last != 0 && task2[i] % last == 0)
            {
                task2.Insert(i, X);
                i++;
            }
        }
        Console.WriteLine("\nЗмінений список:");
        foreach (int x in task2)
            Console.Write(x + " ");

        Random t3 = new Random();
        List<int> task3 = new List<int>();
        for (int i = 0; i < 20; i++)
            task3.Add(t2.Next(-20, 21));
        Console.WriteLine("\n\nЗавдання 3. Список:");
        foreach (int x in task3)
            Console.Write(x + " ");
        Console.WriteLine();

        List<int> one = new List<int>();
        List<int> two = new List<int>();
        foreach (int x in task3)
        {
            if (Math.Abs(x) >= 1 && Math.Abs(x) <= 9)
                one.Add(x);
            else if (Math.Abs(x) >= 10)
                two.Add(x);
        }
        Console.WriteLine("\nОднозначні:");
        foreach (int x in one)
            Console.Write(x + " ");
        Console.WriteLine();
        Console.WriteLine("\nДвозначні:");
        foreach (int x in two)
            Console.Write(x + " ");
        Console.WriteLine("\n");
    }
}