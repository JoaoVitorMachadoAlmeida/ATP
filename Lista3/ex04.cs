/*Escreva um algoritmo que calcule o fatorial de um número.
O algoritmo deve ler um número natural informado pelo usuário a partir do teclado e
informar o fatorial desse número. Se o usuário inserir um número negativo, o algoritmo deve
informar que o número é inválido*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número natural para calcular o fatorial: ");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número é negativo
        if (numero < 0)
        {
            Console.WriteLine("Número inválido. Por favor, insira um número natural.");
        }
        else
        {
            // Calcula o fatorial do número
            int fatorial = CalcularFatorial(numero);

            // Exibe o resultado
            Console.WriteLine($"{numero}! = {fatorial}");
        }
    }

    // Método para calcular o fatorial de um número
    static int CalcularFatorial(int numero)
    {
        // Caso base: se o número for 0 ou 1, o fatorial é 1
        if (numero == 0 || numero == 1)
        {
            return 1;
        }
        else
        {
            // Inicializa o fatorial como 1
            int fatorial = 1;

            // Itera de 2 até o número, multiplicando o fatorial pelo valor atual
            for (int i = 2; i <= numero; i++)
            {
                fatorial *= i;
            }

            return fatorial;
        }
    }
}
