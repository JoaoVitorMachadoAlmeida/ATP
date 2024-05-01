// Fazer um programa que leia uma sequência de valores inteiros fornecida pelo usuário em uma linha de entrada e conte o número de valores positivos, negativos e zeros.
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

        // Exibindo os resultados
        Console.WriteLine($"Positivos: {positivos}");
        Console.WriteLine($"Negativos: {negativos}");
        Console.WriteLine($"Zeros: {zeros}");
    }
}
