using System;

namespace OrdenacaoValores
{
    public static class Ordenador
    {
        // Método para ordenar e exibir valores em ordem crescente
        public static void OrdenarValores(int valor1, int valor2, int valor3)
        {
            int[] valores = new int[] { valor1, valor2, valor3 };
            Array.Sort(valores);

            Console.WriteLine("Valores em ordem crescente: ");
            foreach (var valor in valores)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        // Método principal que executa a lógica do programa
        static void Main(string[] args)
        {
            Console.Write("Digite o número de conjuntos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Conjunto {i + 1}:");
                Console.Write("Valor 1: ");
                int valor1 = int.Parse(Console.ReadLine());
                Console.Write("Valor 2: ");
                int valor2 = int.Parse(Console.ReadLine());
                Console.Write("Valor 3: ");
                int valor3 = int.Parse(Console.ReadLine());

                Ordenador.OrdenarValores(valor1, valor2, valor3);
            }
        }
    }
}
