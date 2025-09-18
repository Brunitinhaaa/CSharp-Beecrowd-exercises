using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] READ_LINE1 = Console.ReadLine().Split(' ');
        int CODE_P1 = int.Parse(READ_LINE1[0]);
        int AMOUNT_P1 = int.Parse(READ_LINE1[1]);
        double PRICE_P1 = double.Parse(READ_LINE1[2], CultureInfo.InvariantCulture);

        string[] READ_LINE2 = Console.ReadLine().Split(' ');
        int CODE_P2 = int.Parse(READ_LINE2[0]);
        int AMOUNT_P2 = int.Parse(READ_LINE2[1]);
        double PRICE_P2 = double.Parse(READ_LINE2[2], CultureInfo.InvariantCulture);

        Console.WriteLine(
            "VALOR A PAGAR: R$ " + (
                (AMOUNT_P1 * PRICE_P1) + (AMOUNT_P2 * PRICE_P2)).ToString(
                "F2", CultureInfo.InvariantCulture)
            );
    }
}