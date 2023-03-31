using System;

class URI
{
    static void Main(string[] args)
    {
        int produto, quantidade;
        string entrada = Console.ReadLine();
        string[] entradas = entrada.Split();
        
        produto = int.Parse(entradas[0]);
        quantidade = int.Parse(entradas[1]);

        double[] produtos = { 0, 4, 4.50, 5, 2, 1.50 };

        Console.WriteLine($"Total: R$ {(produtos[produto] * quantidade):F2}");

    }
}



