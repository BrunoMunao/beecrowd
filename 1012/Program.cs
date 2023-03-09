using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string entrada = Console.ReadLine();
            string[] entradaToDouble = entrada.Split();
            double A = double.Parse(entradaToDouble[0]);
            double B = double.Parse(entradaToDouble[1]);
            double C = double.Parse(entradaToDouble[2]);

            double triangulo = A * C / 2;
            double circulo = 3.14159 * (C * C);
            double trapezio = (A + B) * C / 2;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");

        }
    }
}