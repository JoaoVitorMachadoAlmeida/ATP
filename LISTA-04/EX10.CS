using System;

namespace CategoriaNadadores
{
    public static class Nadador
    {
        public static string IdentificarCategoria(int idade)
        {
            if (idade >= 5 && idade <= 7)
            {
                return "F";
            }
            else if (idade >= 8 && idade <= 10)
            {
                return "E";
            }
            else if (idade >= 11 && idade <= 13)
            {
                return "D";
            }
            else if (idade >= 14 && idade <= 15)
            {
                return "C";
            }
            else if (idade >= 16 && idade <= 17)
            {
                return "B";
            }
            else if (idade >= 18)
            {
                return "A";
            }
            else
            {
                return "Idade inválida";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            string categoria = Nadador.IdentificarCategoria(idade);
            Console.WriteLine($"A categoria do nadador é: {categoria}");
        }
    }
}

