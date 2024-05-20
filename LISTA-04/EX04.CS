using System;

namespace ClassificacaoTriangulos
{
    public static class Triangulo
    {
        public static void ClassificarTriangulo(double x, double y, double z)
        {
            if (PodeSerTriangulo(x, y, z))
            {
                if (x == y && y == z)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (x == y || y == z || x == z)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não forma um triângulo");
            }
        }

        private static bool PodeSerTriangulo(double x, double y, double z)
        {
            return (x < y + z) && (y < x + z) && (z < x + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite os lados do triângulo (ou -1 para sair):");
                Console.Write("Lado X: ");
                double x = double.Parse(Console.ReadLine());
                if (x == -1) break;
                Console.Write("Lado Y: ");
                double y = double.Parse(Console.ReadLine());
                Console.Write("Lado Z: ");
                double z = double.Parse(Console.ReadLine());

                Triangulo.ClassificarTriangulo(x, y, z);
            }
        }
    }
}


