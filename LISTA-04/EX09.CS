using System;

namespace MediaNotasAprovados
{
    public static class CalculadoraNotas
    {
        public static double CalcularMediaAprovados(int n)
        {
            double somaNotas = 0;
            int countAprovados = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                double nota = double.Parse(Console.ReadLine());

                if (nota >= 6)
                {
                    somaNotas += nota;
                    countAprovados++;
                }
            }

            return countAprovados > 0 ? somaNotas / countAprovados : 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de alunos: ");
            int n = int.Parse(Console.ReadLine());

            double mediaAprovados = CalculadoraNotas.CalcularMediaAprovados(n);
            Console.WriteLine($"A média das notas dos alunos aprovados é: {mediaAprovados:F2}");
        }
    }
}

