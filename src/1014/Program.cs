using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());

        double CarAVG = X / Y;
            
       Console.WriteLine(CarAVG.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
    }
}