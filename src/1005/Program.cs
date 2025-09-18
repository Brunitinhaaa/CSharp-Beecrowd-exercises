using System;
using System.Globalization;

public class  Program 
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        double AVR = ((A * 3.5 + B * 7.5)/ 11);
        Console.WriteLine("MEDIA = " + AVR.ToString("F5", CultureInfo.InvariantCulture));
    }
}