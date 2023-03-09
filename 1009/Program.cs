using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string nomeFuncionario = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double vendasDinheiro = double.Parse(Console.ReadLine());

            Console.WriteLine($"TOTAL = R$ {(salario + (vendasDinheiro * 0.15)):F2}");
        }
    }
}