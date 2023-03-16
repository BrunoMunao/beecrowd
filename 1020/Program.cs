using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());

            int anos = n / 365;
            int meses = n % 365 / 30;
            int dias = n % 365 % 30;

            Console.WriteLine(anos + " anos(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

        }
    }
}