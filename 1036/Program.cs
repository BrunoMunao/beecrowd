using System;

class URI
{

    static void Main(string[] args)
    {
        double a, b, c, r1, r2;

        string entrada = Console.ReadLine();
        string[] entradas = entrada.Split();

        a = double.Parse(entradas[0]);
        b = double.Parse(entradas[1]);
        c = double.Parse(entradas[2]);

        double delta = (b * b) - 4 * a * c;
        r1 = ((b * -1) + Math.Sqrt(delta)) / (2 * a);
        r2 = ((b * -1) - Math.Sqrt(delta)) / (2 * a);

        if (delta <= 0 || a == 0)
            Console.WriteLine("Impossivel calcular");
        else
        {
            Console.WriteLine($"R1 = {r1:F5}");
            Console.WriteLine($"R2 = {r2:F5}");
        }
    }
}



