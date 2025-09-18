using System;

class Program
{
    static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');

        int A = int.Parse(valores[0]);
        int B = int.Parse(valores[1]);
        int C = int.Parse(valores[2]);

        int Maior = (A + B + Math.Abs(A - B)) / 2;

        int maiorFinal = (Maior + C + Math.Abs(Maior - C)) / 2;

        Console.WriteLine(maiorFinal + " eh o maior");
    }
}