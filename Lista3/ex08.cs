//Faça um programa que imprima os L primeiros elementos da série de Fibonacci. Por exemplo, se o usuário digitou o número 40, deverão ser apresentados os 40 números da sequência na tela.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de elementos da sequência de Fibonacci a serem exibidos: ");
        int L = int.Parse(Console.ReadLine());

        // Verifica se L é um número inteiro e positivo
        if (L <= 0)
        {
            Console.WriteLine("O número de elementos deve ser um número inteiro e positivo.");
            return;
        }

        // Imprime os L primeiros elementos da sequência de Fibonacci
        Console.WriteLine("Os primeiros " + L + " elementos da sequência de Fibonacci são:");
        for (int i = 0; i < L; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    // Função para calcular o termo da sequência de Fibonacci dado o índice
    static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            int a = 0;
            int b = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }
    }
}
