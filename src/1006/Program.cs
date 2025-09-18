using System;
using System.Globalization;

class Program {
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        double AVR = (A * 2 + B * 3 + C * 5) / 10;

        Console.WriteLine("MEDIA = " + AVR.ToString("F1", CultureInfo.InvariantCulture));
    }
}