using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double R = double.Parse(Console.ReadLine());
        double PI = 3.14159;
        double V = (4 / 3.0) * PI * Math.Pow(R, 3);

        /*Tip: Use (4/3.0) or (4.0/3) in your formula, 
         * because some languages (including C++) assume that 
         * the division's result between two integers 
         * is another integer. :)
        */

        Console.WriteLine("VOLUME = " + V.ToString("F3", CultureInfo.InvariantCulture));

    }
}