using System;

namespace ConceitoAlunos
{
    public static class Conceito
    {
        public static void IdentificarConceito(double mediaFinal)
        {
            char conceito;
            if (mediaFinal <= 39)
            {
                conceito = 'F';
            }
            else if (mediaFinal <= 59)
            {
                conceito = 'E';
            }
            else if (mediaFinal <= 69)
            {
                conceito = 'D';
            }
            else if (mediaFinal <= 79)
            {
                conceito = 'C';
            }
            else if (mediaFinal <= 89)
            {
                conceito = 'B';
            }
            else
            {
                conceito = 'A';
            }

            Console.WriteLine($"Conceito: {conceito}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de alunos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a média final do aluno {i + 1}: ");
                double mediaFinal = double.Parse(Console.ReadLine());

                Conceito.IdentificarConceito(mediaFinal);
            }
        }
    }
}


