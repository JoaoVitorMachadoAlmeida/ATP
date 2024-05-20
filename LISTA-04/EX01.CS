using System;

namespace MediaAlunos
{
    public static class MediaAluno
    {
        public static void CalcularMedia(double nota1, double nota2, double nota3, char tipo)
        {
            if (tipo == 'A')
            {
                double mediaAritmetica = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine($"Média Aritmética: {mediaAritmetica:F2}");
            }
            else if (tipo == 'P')
            {
                double mediaPonderada = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
                Console.WriteLine($"Média Ponderada: {mediaPonderada:F2}");
            }
            else
            {
                Console.WriteLine("Tipo de média inválido!");
            }
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
                Console.WriteLine($"Aluno {i + 1}:");
                Console.Write("Nota 1: ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: ");
                double nota2 = double.Parse(Console.ReadLine());
                Console.Write("Nota 3: ");
                double nota3 = double.Parse(Console.ReadLine());
                Console.Write("Digite 'A' para média aritmética ou 'P' para média ponderada: ");
                char tipoMedia = char.Parse(Console.ReadLine().ToUpper());

                MediaAluno.CalcularMedia(nota1, nota2, nota3, tipoMedia);
            }
        }
    }
}
