//Faça um programa que imprima a soma de todos os elementos da série de Fibonacci menores que L. O valor de L deve ser informado pelo usuário
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de L para calcular a soma dos elementos da série de Fibonacci menores que L: ");
        int L = int.Parse(Console.ReadLine());

        // Verifica se L é um número inteiro e positivo
        if (L <= 0)
        {
            Console.WriteLine("O valor de L deve ser um número inteiro e positivo.");
            return;
        }

        // Calcula a soma dos elementos da série de Fibonacci menores que L
        int soma = 0;
        int termoAtual = 0;
        int termoProximo = 1;

        while (termoAtual < L)
        {
            soma += termoAtual;
            int proximoTermo = termoAtual + termoProximo;
            termoAtual = termoProximo;
            termoProximo = proximoTermo;
        }

        // Exibe a soma dos elementos da série de Fibonacci menores que L
        Console.WriteLine("A soma dos elementos da série de Fibonacci menores que " + L + " é: " + soma);
    }
}
