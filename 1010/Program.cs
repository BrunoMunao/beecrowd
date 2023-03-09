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
            double total = (int.Parse(linha1Input[1]) * double.Parse(linha1Input[2])) + (int.Parse(linha2Input[1]) * double.Parse(linha2Input[2]));

            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");

        }
    }
}