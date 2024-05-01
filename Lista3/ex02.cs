//Adaptar o programa acima para que ele calcule o percentual dos valores positivos, negativos e zeros em relação ao total de valores fornecidos.
using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira uma sequência de valores inteiros
        Console.WriteLine("Digite uma sequência de valores inteiros separados por espaço:");

        // Lê a entrada do usuário
        string input = Console.ReadLine();

        // Dividindo a entrada em uma matriz de strings, utilizando o espaço como separador
        string[] valoresString = input.Split(' ');

        // Variáveis para contar os números positivos, negativos e zeros
        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        // Iterando sobre os valores e contando
        foreach (string valorString in valoresString)
        {
            // Converte a string para um valor inteiro
            int valor = int.Parse(valorString);

            // Verifica se o valor é positivo, negativo ou zero e incrementa o contador apropriado
            if (valor > 0)
            {
                positivos++;
            }
            else if (valor < 0)
            {
                negativos++;
            }
            else
            {
                zeros++;
            }
        }

        // Calcula o total de valores
        int totalValores = positivos + negativos + zeros;

        // Calcula os percentuais
        double percentualPositivos = (positivos / (double)totalValores) * 100;
        double percentualNegativos = (negativos / (double)totalValores) * 100;
        double percentualZeros = (zeros / (double)totalValores) * 100;

        // Exibe os resultados
        Console.WriteLine($"Positivos: {positivos} ({percentualPositivos:F2}%)");
        Console.WriteLine($"Negativos: {negativos} ({percentualNegativos:F2}%)");
        Console.WriteLine($"Zeros: {zeros} ({percentualZeros:F2}%)");
    }
}

