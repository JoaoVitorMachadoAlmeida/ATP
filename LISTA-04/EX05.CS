using System;

namespace AlgoritmoEuclides
{
    public static class Euclides
    {
        public static int CalcularMDC(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int mdc = Euclides.CalcularMDC(a, b);
            Console.WriteLine($"MDC de {a} e {b} é {mdc}");
             }
        }
    }
}

