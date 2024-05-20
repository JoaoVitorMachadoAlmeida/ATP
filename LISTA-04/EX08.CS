using System;

namespace CalculoS
{
    public static class Calculadora
    {
        public static double CalcularS(int n)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += (Math.Pow(i, 2) + 1) / (i + 3);
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor positivo para N: ");
            int n = int.Parse(Console.ReadLine());

            double resultado = Calculadora.CalcularS(n);
            Console.WriteLine($"O valor de S para N = {n} é: {resultado:F2}");
        }
    }
}


