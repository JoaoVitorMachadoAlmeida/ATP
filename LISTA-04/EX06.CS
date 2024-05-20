using System;

namespace VerificacaoPositividade
{
    public static class Verificador
    {
        public static bool EhPositivo(int valor)
        {
            return valor >= 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de valores: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um valor: ");
                int valor = int.Parse(Console.ReadLine());

                bool isPositivo = Verificador.EhPositivo(valor);
                string resultado = isPositivo ? "positivo" : "negativo";
                Console.WriteLine($"O valor {valor} é {resultado}.");
            }
        }
    }
}


