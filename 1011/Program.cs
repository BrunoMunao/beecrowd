using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"VOLUME = {((4.0/3) * pi * Math.Pow(raio, 3)):F}");
        }
    }
}