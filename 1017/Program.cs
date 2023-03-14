using System;

class Program
{
    static void Main(string[] args)
    {
       int horas = int.Parse(Console.ReadLine());
       int kmh = int.Parse(Console.ReadLine());

       Console.WriteLine($"{(kmh * horas / 12.0):F3}");
    }
}