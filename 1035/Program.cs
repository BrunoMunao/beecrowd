using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string entrada = Console.ReadLine();
            string[] entradas;
            entradas = entrada.Split();
            int A, B, C, D;
            A = int.Parse(entradas[0]);
            B = int.Parse(entradas[1]);
            C = int.Parse(entradas[2]);
            D = int.Parse(entradas[3]);

            if (B > C)
            {
                if (D > A)
                {
                    if ((C + D) > (A + B))
                    {
                        if (C > 0 && D > 0)
                        {
                            if (A % 2 == 0)
                            {
                                Console.WriteLine("Valores aceitos");
                            }

                        }
                    }
                }
            }
            else { Console.WriteLine("Valores nao aceitos"); }
        }
    }
}