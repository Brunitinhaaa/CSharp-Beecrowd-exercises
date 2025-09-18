using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int EMP_ID = int.Parse(Console.ReadLine());
        int NUM_HOURS = int.Parse(Console.ReadLine());
        double VALUE_HOUR = double.Parse(Console.ReadLine());

        Console.WriteLine("NUMBER = " + EMP_ID);
        Console.WriteLine("SALARY = U$ " + (NUM_HOURS * VALUE_HOUR).ToString("F2", CultureInfo.InvariantCulture));
    }
}