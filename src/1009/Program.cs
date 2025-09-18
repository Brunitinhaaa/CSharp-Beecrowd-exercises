using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string NAME = Console.ReadLine();
        double SALARY = double.Parse(Console.ReadLine());
        double SALES = double.Parse(Console.ReadLine());

        double TOTAL = SALARY + (SALES * 0.15);

        Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2", CultureInfo.InvariantCulture));
    }
}