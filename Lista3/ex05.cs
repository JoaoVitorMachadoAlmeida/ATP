//Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor de E
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor inteiro e positivo para N: ");
        int N = int.Parse(Console.ReadLine());

        // Verifica se N é um número inteiro e positivo
        if (N <= 0)
        {
            Console.WriteLine("O valor de N deve ser um número inteiro e positivo.");
            return;
        }

        double E = CalcularE(N);

        // Exibe o resultado
        Console.WriteLine($"O valor de E é: {E}");
    }

    static double CalcularE(int N)
    {
        double E = 1; // Inicia com o primeiro termo (1/0!)
        double fatorial = 1; // Fatorial atual

        for (int i = 1; i <= N; i++)
        {
            fatorial *= i; // Calcula o fatorial
            E += 1 / fatorial; // Adiciona o próximo termo à soma
        }

        return E;
    }
}
