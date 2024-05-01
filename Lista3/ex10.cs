/*Escreva o algoritmo para um empresário que deseja fazer o levantamento do lucro das
mercadorias que ele comercializa. O usuário deve informar o preço de compra e de venda de
cada mercadoria. O algoritmo deve interromper a leitura quando o usuário informar o preço
de compra igual a 0. O algoritmo deve:
a) Determinar e escrever quantas mercadorias proporcionaram:
i) Lucro < 10%
ii) 10% <= Lucro <= 20%
iii) Lucro > 20%
b) Determinar e escrever o valor total de compra e de venda de todas as mercadorias,*/
using System;

class Program
{
    static void Main()
    {
        // Variáveis para armazenar os valores totais de compra e venda e os contadores de lucro
        double totalCompra = 0;
        double totalVenda = 0;
        int lucroMenor10 = 0;
        int lucroEntre10e20 = 0;
        int lucroMaior20 = 0;

        // Loop para ler os preços de compra e venda das mercadorias
        while (true)
        {
            // Solicita ao usuário que insira o preço de compra da mercadoria
            Console.Write("Digite o preço de compra da mercadoria (ou 0 para encerrar): ");
            double precoCompra = double.Parse(Console.ReadLine());

            // Verifica se o preço de compra é igual a 0 para encerrar a leitura
            if (precoCompra == 0)
            {
                break;
            }

            // Solicita ao usuário que insira o preço de venda da mercadoria
            Console.Write("Digite o preço de venda da mercadoria: ");
            double precoVenda = double.Parse(Console.ReadLine());

            // Calcula o lucro da mercadoria
            double lucro = (precoVenda - precoCompra) / precoCompra * 100;

            // Atualiza os valores totais de compra e venda
            totalCompra += precoCompra;
            totalVenda += precoVenda;

            // Determina a categoria de lucro e atualiza os contadores correspondentes
            if (lucro < 10)
            {
                lucroMenor10++;
            }
            else if (lucro <= 20)
            {
                lucroEntre10e20++;
            }
            else
            {
                lucroMaior20++;
            }
        }

        // Exibe os resultados
        Console.WriteLine($"Quantidade de mercadorias com lucro < 10%: {lucroMenor10}");
        Console.WriteLine($"Quantidade de mercadorias com 10% <= lucro <= 20%: {lucroEntre10e20}");
        Console.WriteLine($"Quantidade de mercadorias com lucro > 20%: {lucroMaior20}");
        Console.WriteLine($"Valor total de compra: R${totalCompra:F2}");
        Console.WriteLine($"Valor total de venda: R${totalVenda:F2}");
    }
}
