/*A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o
salário e número de filhos de cada habitante. A prefeitura deseja saber:
a) A média do salário da população;
b) A média do número de filhos;
c) O maior salário;
d) O percentual de pessoas com salário até R$100,00.
O final da leitura de dados se dará com a entrada de um salário negativo*/
using System;

class Program
{
    static void Main()
    {
        // Variáveis para as estatísticas
        double somaSalario = 0;
        int totalHabitantes = 0;
        int totalFilhos = 0;
        double maiorSalario = double.MinValue;
        int pessoasAte100 = 0;

        // Loop para ler os dados dos habitantes
        while (true)
        {
            // Solicita ao usuário que insira o salário do habitante
            Console.Write("Digite o salário do habitante (ou um número negativo para encerrar): ");
            double salario = double.Parse(Console.ReadLine());

            // Verifica se o salário é negativo para encerrar a leitura
            if (salario < 0)
            {
                break;
            }

            // Solicita ao usuário que insira o número de filhos do habitante
            Console.Write("Digite o número de filhos do habitante: ");
            int filhos = int.Parse(Console.ReadLine());

            // Atualiza as estatísticas
            somaSalario += salario;
            totalHabitantes++;
            totalFilhos += filhos;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }

            if (salario <= 100)
            {
                pessoasAte100++;
            }
        }

        // Calcula as médias
        double mediaSalario = somaSalario / totalHabitantes;
        double mediaFilhos = (double)totalFilhos / totalHabitantes;

        // Calcula o percentual de pessoas com salário até R$100,00
        double percentualAte100 = (double)pessoasAte100 / totalHabitantes * 100;

        // Exibe as estatísticas
        Console.WriteLine($"Média do salário da população: R${mediaSalario:F2}");
        Console.WriteLine($"Média do número de filhos: {mediaFilhos:F2}");
        Console.WriteLine($"Maior salário: R${maiorSalario:F2}");
        Console.WriteLine($"Percentual de pessoas com salário até R$100,00: {percentualAte100:F2}%");
    }
}


