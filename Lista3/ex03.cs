/*Faça um programa que receba dez números e verifique se eles são divisíveis por 3 e 9 (ao
mesmo tempo), por 2 e por 5. Caso algum número não seja divisível por nenhum desses
números mostre a mensagem “Número não é divisível pelos valores”. Apresente também ao
final a quantidade de números divisíveis por 3 e 9, por 2 e por 5*/
using System;

class Program
{
    static void Main()
    {
        // Array para armazenar os números
        int[] numeros = new int[10];

        // Variáveis para contar a quantidade de números divisíveis
        int divisiveis_3_9 = 0;
        int divisiveis_2_5 = 0;

        // Solicita ao usuário que insira os números
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());

            // Verifica se o número é divisível por 3 e 9
            if (DivisivelPor3e9(numeros[i]))
            {
                divisiveis_3_9++;
            }

            // Verifica se o número é divisível por 2 e 5
            if (DivisivelPor2e5(numeros[i]))
            {
                divisiveis_2_5++;
            }
            // Se o número não for divisível por nenhum dos dois pares de números
            if (!DivisivelPor3e9(numeros[i]) && !DivisivelPor2e5(numeros[i]))
            {
                Console.WriteLine($"O número {numeros[i]} não é divisível por nenhum dos valores.");
            }
        }

        // Exibe a quantidade de números divisíveis por 3 e 9
        Console.WriteLine($"Quantidade de números divisíveis por 3 e 9: {divisiveis_3_9}");

        // Exibe a quantidade de números divisíveis por 2 e 5
        Console.WriteLine($"Quantidade de números divisíveis por 2 e 5: {divisiveis_2_5}");
    }

    // Método para verificar se o número é divisível por 3 e 9
    static bool DivisivelPor3e9(int numero)
    {
        int somaDigitos = 0;

        // Calcula a soma dos dígitos do número
        while (numero != 0)
        {
            somaDigitos += numero % 10;
            numero /= 10;
        }

        // Verifica se a soma dos dígitos é divisível por 3 e 9
        return somaDigitos % 3 == 0 && somaDigitos % 9 == 0;
    }

    // Método para verificar se o número é divisível por 2 e 5
    static bool DivisivelPor2e5(int numero)
    {
        // Verifica se o último dígito do número é 0 ou 5
        return numero % 10 == 0 || numero % 10 == 5;
    }
}
