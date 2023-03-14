/*

Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.
Entrada

O arquivo de entrada contém três valores inteiros.
Saída

Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string entrada = Console.ReadLine();
            string[] entradaToDouble = entrada.Split();
            int A = int.Parse(entradaToDouble[0]);
            int B = int.Parse(entradaToDouble[1]);
            int C = int.Parse(entradaToDouble[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;


            Console.WriteLine(maiorABC + " eh o maior");

        }
    }
}