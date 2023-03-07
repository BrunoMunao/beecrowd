using System;

class Program
{
    static void Main(string[] args)
    {
        double raio = double.Parse(Console.ReadLine());
        double n = 3.14159;

        Console.WriteLine($"A={(n * (raio * raio)):F4}");
    }
}