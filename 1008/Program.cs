using System;

class Program
{
    static void Main(string[] args)
    {
        int numeroFuncionario = int.Parse(Console.ReadLine());
        int quantidadeHoras = int.Parse(Console.ReadLine());
        double salario = double.Parse(Console.ReadLine());

        Console.WriteLine($"NUMBER = {numeroFuncionario}");
        Console.WriteLine($"SALARY = U$ {(quantidadeHoras * salario):F2}");
    }
}