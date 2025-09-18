using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double PI = 3.14159;

        double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double A = PI * (Math.Pow(R, 2));

        Console.WriteLine("A=" +A.ToString("F4", CultureInfo.InvariantCulture));
    }
}