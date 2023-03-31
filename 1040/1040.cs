using System;

class URI
{
    static void Main(string[] args)
    {
        double n1, n2, n3, n4, nFinal, nRec;

        string entrada = Console.ReadLine();
        string[] entradas = entrada.Split();

        n1 = double.Parse(entradas[0]);
        n2 = double.Parse(entradas[1]);
        n3 = double.Parse(entradas[2]);
        n4 = double.Parse(entradas[3]);

        nFinal = Math.Round(((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10);

        if (nFinal >= 7.0)
        {
            Console.WriteLine($"Media: {nFinal:F1}");
            Console.WriteLine("Aluno aprovado.");
        }
        else if (nFinal < 5.0)
        {
            Console.WriteLine($"Media: {nFinal:F1}");
            Console.WriteLine("Aluno reprovado.");
        }

        else
        {
            Console.WriteLine($"Media: {nFinal:F1}");
            Console.WriteLine("Aluno em exame.");
            nRec = double.Parse(Console.ReadLine());
            double nExam = (nFinal + nRec) / 2;

            Console.WriteLine($"Nota do exame: {nRec:F1}");
            if (nExam >= 5)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");

            }
            Console.WriteLine($"Media final: {nExam:F1}");
        }

    }
}



