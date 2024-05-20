using System;

namespace PesquisaPrefeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            PesquisaSalariosRealizada();
        }

        static void PesquisaSalariosRealizada()
        {
            Console.WriteLine("Digite os dados dos habitantes (salário e número de filhos). Digite -1 para finalizar.");
            double totalSalarios = 0;
            int totalHabitantes = 0;

            while (true)
            {
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                if (salario == -1) break;

                Console.Write("Número de filhos: ");
                int filhos = int.Parse(Console.ReadLine());

                totalSalarios += salario;
                totalHabitantes++;
            }

            if (totalHabitantes > 0)
            {
                double mediaSalarios = totalSalarios / totalHabitantes;
                Console.WriteLine($"Média de salário da população: {mediaSalarios:F2}");
            }
            else
            {
                Console.WriteLine("Nenhum dado foi inserido.");
            }
        }
    }
}
