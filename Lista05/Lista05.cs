using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Selecione o código para executar:");
            Console.WriteLine("1 - Encontrar o menor elemento e sua posição em um vetor de 20 elementos");
            Console.WriteLine("2 - Calcular a média das notas e contar quantas estão acima da média");
            Console.WriteLine("3 - Copiar valores negativos de um vetor para outro");
            Console.WriteLine("4 - Intercalar dois vetores de 10 elementos");
            Console.WriteLine("5 - Tentar acertar um dos números sorteados");
            Console.WriteLine("6 - Analisar temperaturas de outubro");
            Console.WriteLine("7 - Operações em matriz 5x5");
            Console.WriteLine("8 - Operações em matriz 4x4");
            Console.WriteLine("9 - Soma e diferença de duas matrizes 4x6");
            Console.WriteLine("10 - Trocar linhas e colunas em uma matriz 10x10");
            Console.WriteLine("0 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ExecutarCodigo1();
                    break;
                case 2:
                    ExecutarCodigo2();
                    break;
                case 3:
                    ExecutarCodigo3();
                    break;
                case 4:
                    ExecutarCodigo4();
                    break;
                case 5:
                    ExecutarCodigo5();
                    break;
                case 6:
                    ExecutarCodigo6();
                    break;
                case 7:
                    ExecutarCodigo7();
                    break;
                case 8:
                    ExecutarCodigo8();
                    break;
                case 9:
                    ExecutarCodigo9();
                    break;
                case 10:
                    ExecutarCodigo10();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
    }

    static void ExecutarCodigo1()
    {
        int[] N = new int[20];
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o valor para N[{i}]: ");
            N[i] = int.Parse(Console.ReadLine());
        }

        int menorElemento = N[0];
        int posicao = 0;
        for (int i = 1; i < 20; i++)
        {
            if (N[i] < menorElemento)
            {
                menorElemento = N[i];
                posicao = i;
            }
        }

        Console.WriteLine($"O menor elemento de N é {menorElemento} e sua posição dentro do vetor é: {posicao}");
    }

    static void ExecutarCodigo2()
    {
        double[] notas = new double[10];
        PreencherNotas(notas);
        CalcularMediaEContarAcimaDaMedia(notas);
    }

    static void PreencherNotas(double[] vetorNotas)
    {
        Console.WriteLine("Digite as notas dos 10 alunos:");
        for (int i = 0; i < vetorNotas.Length; i++)
        {
            Console.Write($"Nota do aluno {i + 1}: ");
            vetorNotas[i] = double.Parse(Console.ReadLine());
        }
    }

    static void CalcularMediaEContarAcimaDaMedia(double[] vetorNotas)
    {
        double soma = 0;
        int acimaDaMedia = 0;
        foreach (double nota in vetorNotas)
        {
            soma += nota;
        }
        double media = soma / vetorNotas.Length;
        foreach (double nota in vetorNotas)
        {
            if (nota > media)
            {
                acimaDaMedia++;
            }
        }

        Console.WriteLine($"A média da turma é: {media}");
        Console.WriteLine($"Número de alunos com nota acima da média: {acimaDaMedia}");
    }

    static void ExecutarCodigo3()
    {
        int[] X = new int[10];
        PreencherVetor(X);
        Console.WriteLine("Vetor X preenchido:");
        ExibirVetor(X);
        int[] valoresNegativos = CopiarNegativos(X);
        Console.WriteLine("\nValores negativos copiados para um novo vetor:");
        ExibirVetor(valoresNegativos);
    }

    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite os valores para o vetor:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"X[{i}] = ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static int[] CopiarNegativos(int[] vetor)
    {
        int countNegativos = 0;
        foreach (int num in vetor)
        {
            if (num < 0)
            {
                countNegativos++;
            }
        }
        int[] negativos = new int[countNegativos];
        int index = 0;
        foreach (int num in vetor)
        {
            if (num < 0)
            {
                negativos[index] = num;
                index++;
            }
        }
        return negativos;
    }

    static void ExibirVetor(int[] vetor)
    {
        foreach (int num in vetor)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void ExecutarCodigo4()
    {
        int[] X = new int[10];
        int[] Y = new int[10];
        PreencherVetor(X, "X");
        PreencherVetor(Y, "Y");
        Console.WriteLine("Vetor X:");
        ExibirVetor(X);
        Console.WriteLine("\nVetor Y:");
        ExibirVetor(Y);
        int[] intercalado = IntercalarVetores(X, Y);
        Console.WriteLine("\nVetor intercalado:");
        ExibirVetor(intercalado);
    }

    static void PreencherVetor(int[] vetor, string nomeVetor)
    {
        Console.WriteLine($"Digite os valores para o vetor {nomeVetor}:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{nomeVetor}[{i}] = ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static int[] IntercalarVetores(int[] vetor1, int[] vetor2)
    {
        int[] intercalado = new int[vetor1.Length + vetor2.Length];
        int index1 = 0;
        int index2 = 0;
        int indexInter = 0;
        while (index1 < vetor1.Length || index2 < vetor2.Length)
        {
            if (index1 < vetor1.Length)
            {
                intercalado[indexInter] = vetor1[index1];
                indexInter++;
                index1++;
            }
            if (index2 < vetor2.Length)
            {
                intercalado[indexInter] = vetor2[index2];
                indexInter++;
                index2++;
            }
        }
        return intercalado;
    }

    static void ExecutarCodigo5()
    {
        int[] numerosSorteados = SortearNumeros();
        TentarAcertarNumero(numerosSorteados);
    }

    static int[] SortearNumeros()
    {
        Random random = new Random();
        int[] numerosSorteados = new int[3];
        for (int i = 0; i < 3; i++)
        {
            numerosSorteados[i] = random.Next(10, 51);
        }
        return numerosSorteados;
    }

    static void TentarAcertarNumero(int[] numerosSorteados)
    {
        Console.WriteLine("Tente acertar um dos números sorteados entre 10 e 50.");
        while (true)
        {
            Console.Write("Digite sua tentativa: ");
            int tentativa = int.Parse(Console.ReadLine());
            if (tentativa < 10 || tentativa > 50)
            {
                Console.WriteLine("Por favor, digite um número entre 10 e 50.");
                continue;
            }
            bool acertou = false;
            foreach (int numero in numerosSorteados)
            {
                if (tentativa == numero)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número {numero}!");
                    acertou = true;
                    break;
                }
            }
            if (acertou)
            {
                break;
            }
            else
            {
                Console.WriteLine("Não foi dessa vez. Tente novamente!");
            }
        }
    }

    static void ExecutarCodigo6()
    {
        double[] temperaturas = new double[31];
        PreencherTemperaturas(temperaturas);
        double menorTemperatura = EncontrarMenorTemperatura(temperaturas);
        double maiorTemperatura = EncontrarMaiorTemperatura(temperaturas);
        double temperaturaMedia = CalcularTemperaturaMedia(temperaturas);
        int diasAbaixoMedia = ContarDiasAbaixoDaMedia(temperaturas, temperaturaMedia);
        Console.WriteLine($"Menor temperatura: {menorTemperatura} °C");
        Console.WriteLine($"Maior temperatura: {maiorTemperatura} °C");
        Console.WriteLine($"Temperatura média: {temperaturaMedia} °C");
        Console.WriteLine($"Número de dias com temperatura abaixo da média: {diasAbaixoMedia}");
    }

    static void PreencherTemperaturas(double[] temperaturas)
    {
        Console.WriteLine("Digite as temperaturas de outubro:");
        for (int i = 0; i < temperaturas.Length; i++)
        {
            Console.Write($"Temperatura do dia {i + 1}: ");
            temperaturas[i] = double.Parse(Console.ReadLine());
        }
    }

    static double EncontrarMenorTemperatura(double[] temperaturas)
    {
        double menor = temperaturas[0];
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < menor)
            {
                menor = temperaturas[i];
            }
        }
        return menor;
    }

    static double EncontrarMaiorTemperatura(double[] temperaturas)
    {
        double maior = temperaturas[0];
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] > maior)
            {
                maior = temperaturas[i];
            }
        }
        return maior;
    }

    static double CalcularTemperaturaMedia(double[] temperaturas)
    {
        double soma = 0;
        foreach (double temp in temperaturas)
        {
            soma += temp;
        }
        return soma / temperaturas.Length;
    }

    static int ContarDiasAbaixoDaMedia(double[] temperaturas, double media)
    {
        int contador = 0;
        foreach (double temp in temperaturas)
        {
            if (temp < media)
            {
                contador++;
            }
        }
        return contador;
    }

    static void ExecutarCodigo7()
    {
        int[,] matriz = new int[5, 5];
        PreencherMatriz(matriz);
        int somaTotal = CalcularSomaMatriz(matriz);
        int somaDiagonalPrincipal = CalcularSomaDiagonalPrincipal(matriz);
        int somaDiagonalSecundaria = CalcularSomaDiagonalSecundaria(matriz);
        Console.WriteLine("Soma total dos elementos da matriz: " + somaTotal);
        Console.WriteLine("Soma dos elementos da diagonal principal: " + somaDiagonalPrincipal);
        Console.WriteLine("Soma dos elementos da diagonal secundária: " + somaDiagonalSecundaria);
    }

    static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os valores para a matriz 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Matriz[{i},{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int CalcularSomaMatriz(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }

    static int CalcularSomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, i];
        }
        return soma;
    }

    static int CalcularSomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, 4 - i];
        }
        return soma;
    }

    static void ExecutarCodigo8()
    {
        int[,] matriz = new int[4, 4];
        PreencherMatriz4x4(matriz);
        int somaTotal = CalcularSomaMatriz4x4(matriz);
        int somaDiagonalPrincipal = CalcularSomaDiagonalPrincipal4x4(matriz);
        int somaDiagonalSecundaria = CalcularSomaDiagonalSecundaria4x4(matriz);
        Console.WriteLine("Soma total dos elementos da matriz: " + somaTotal);
        Console.WriteLine("Soma dos elementos da diagonal principal: " + somaDiagonalPrincipal);
        Console.WriteLine("Soma dos elementos da diagonal secundária: " + somaDiagonalSecundaria);
    }

    static void PreencherMatriz4x4(int[,] matriz)
    {
        Console.WriteLine("Digite os valores para a matriz 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Matriz[{i},{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int CalcularSomaMatriz4x4(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }

    static int CalcularSomaDiagonalPrincipal4x4(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 4; i++)
        {
            soma += matriz[i, i];
        }
        return soma;
    }

    static int CalcularSomaDiagonalSecundaria4x4(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < 4; i++)
        {
            soma += matriz[i, 3 - i];
        }
        return soma;
    }

    static void ExecutarCodigo9()
    {
        int[,] matrizA = new int[4, 6];
        int[,] matrizB = new int[4, 6];
        PreencherMatriz4x6(matrizA, "A");
        PreencherMatriz4x6(matrizB, "B");
        int[,] matrizSoma = SomarMatrizes(matrizA, matrizB);
        int[,] matrizDiferenca = SubtrairMatrizes(matrizA, matrizB);
        Console.WriteLine("Matriz Soma:");
        ExibirMatriz(matrizSoma);
        Console.WriteLine("Matriz Diferença:");
        ExibirMatriz(matrizDiferenca);
    }

    static void PreencherMatriz4x6(int[,] matriz, string nomeMatriz)
    {
        Console.WriteLine($"Digite os valores para a matriz {nomeMatriz}:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write($"{nomeMatriz}[{i},{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[,] SomarMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizSoma = new int[4, 6];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                matrizSoma[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }
        return matrizSoma;
    }

    static int[,] SubtrairMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizDiferenca = new int[4, 6];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                matrizDiferenca[i, j] = matrizA[i, j] - matrizB[i, j];
            }
        }
        return matrizDiferenca;
    }

    static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void ExecutarCodigo10()
    {
        int[,] matriz = new int[10, 10];
        PreencherMatriz10x10(matriz);
        Console.WriteLine("Matriz Original:");
        ExibirMatriz10x10(matriz);
        TrocarLinhasColunas(matriz);
        Console.WriteLine("Matriz com linhas e colunas trocadas:");
        ExibirMatriz10x10(matriz);
    }

    static void PreencherMatriz10x10(int[,] matriz)
    {
        Console.WriteLine("Digite os valores para a matriz 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Matriz[{i},{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void ExibirMatriz10x10(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void TrocarLinhasColunas(int[,] matriz)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                int temp = matriz[i, j];
                matriz[i, j] = matriz[j, i];
                matriz[j, i] = temp;
            }
        }
    }
}
