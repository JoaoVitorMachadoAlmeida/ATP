/*Escreva um algoritmo que lê um valor n inteiro e positivo e que calcula a seguinte soma:
S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
O algoritmo deve escrever cada termo gerado e o valor final de S*/
using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um valor inteiro e positivo para n
        Console.Write("Digite um valor inteiro e positivo para n: ");
        int n = int.Parse(Console.ReadLine());

        // Verifica se n é um número inteiro e positivo
        if (n <= 0)
        {
            Console.WriteLine("O valor de n deve ser um número inteiro e positivo.");
            return;
        }

        double soma = 0;

        // Calcula a soma dos termos
        for (int i = 1; i <= n; i++)
        {
            double termo = 1.0 / i;
            soma += termo;

            // Exibe cada termo gerado
            Console.WriteLine($"Termo {i}: {termo:F6}");
        }

        // Exibe o valor final da soma
        Console.WriteLine($"O valor final de S é: {soma:F6}");
    }
}
