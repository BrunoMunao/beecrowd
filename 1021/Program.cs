using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            double n = double.Parse(Console.ReadLine());

            int moedas = (int)((n - ((int)n)) * 100);
            int dinheiro = (int)n;

            // Notas
            int cem = dinheiro / 100;
            int cinquenta = dinheiro % 100 / 50;
            int vinte = dinheiro % 100 % 50 / 20;
            int dez = dinheiro % 100 % 50 % 20 / 10;
            int cinco = dinheiro % 100 % 50 % 20 % 10 / 5;
            int dois = dinheiro % 100 % 50 % 20 % 10 % 5 / 2;

            // Moedas
            int um = dinheiro % 100 % 50 % 20 % 10 % 5 % 2 / 1;
            int cincent = moedas / 50;
            int cinvincin = moedas % 50 / 25;
            int cindez = moedas % 50 % 25 / 10;
            int cincinco = moedas % 50 % 25 % 10 / 5;
            int cinum = moedas % 50 % 25 % 10 % 5;


            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{cem} nota(s) de R$ 100.00");
            Console.WriteLine($"{cinquenta} nota(s) de R$ 50.00");
            Console.WriteLine($"{vinte} nota(s) de R$ 20.00");
            Console.WriteLine($"{dez} nota(s) de R$ 10.00");
            Console.WriteLine($"{cinco} nota(s) de R$ 5.00");
            Console.WriteLine($"{dois} nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{um} moeda(s) de R$ 1.00");
            Console.WriteLine($"{cincent} moeda(s) de R$ 0.50");
            Console.WriteLine($"{cinvincin} moeda(s) de R$ 0.25");
            Console.WriteLine($"{cindez} moeda(s) de R$ 0.10");
            Console.WriteLine($"{cincinco} moeda(s) de R$ 0.05");
            Console.WriteLine($"{cinum} moeda(s) de R$ 0.01");


        }
    }
}