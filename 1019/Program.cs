using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());

            int horas = n / 3600;
            int minutos = n % 3600 / 60;
            int segundos = n % 3600 % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");

        }
    }
}