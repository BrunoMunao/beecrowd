using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string linha1 = Console.ReadLine();
            string linha2 = Console.ReadLine();

            string[] linha1Input = linha1.Split();
            string[] linha2Input = linha2.Split();

            double x1, x2, y1, y2;
            x1 = double.Parse(linha1Input[0]);
            y1 = double.Parse(linha1Input[1]);
            x2 = double.Parse(linha2Input[0]);
            y2 = double.Parse(linha2Input[1]);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{distancia:F4}");

        }
    }
}