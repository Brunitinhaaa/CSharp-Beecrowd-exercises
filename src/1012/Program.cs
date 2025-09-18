using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');

        double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double Area1 = (A * C) / 2;
        double Area2 = 3.14159 * Math.Pow(C, 2);
        double Area3 = ((A + B) * C) / 2;
        double Area4 = B * B;
        double Area5 = A * B;

        Console.WriteLine(
            "TRIANGULO: " + Area1.ToString("F3", CultureInfo.InvariantCulture) + "\n" +
            "CIRCULO: " + Area2.ToString("F3", CultureInfo.InvariantCulture) + "\n" +
            "TRAPEZIO: " + Area3.ToString("F3", CultureInfo.InvariantCulture) + "\n" +
            "QUADRADO: " + Area4.ToString("F3", CultureInfo.InvariantCulture) + "\n" +
            "RETANGULO: " + Area5.ToString("F3", CultureInfo.InvariantCulture)
        );
    }
}