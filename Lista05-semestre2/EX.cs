/*
Ex1 - Escreva um procedimento que preencha um vetor de 15 números inteiros. Depois, crie uma
função que retorne um novo vetor apenas com os números que estão armazenados nas
posições pares do vetor gerado pelo procedimento

Ex2 - Faça um procedimento que preencha um vetor com as notas de uma turma de 10 alunos. Faça
um outro procedimento que receba um vetor preenchido com as notas, calcule a média da
turma e conte quantos alunos obtiveram nota acima da média. Esse procedimento deve exibir
a média e o resultado da contagem. Faça um programa que declare as devidas variáveis e
acione os procedimentos

Ex3 - Faça um procedimento que preencha um vetor de N elementos, conforme entrada de dados.
Depois, crie uma função que retorne a posição do menor elemento deste vetor

Ex4 - Faça um procedimento que preencha 2 vetores X e Y com 10 elementos cada um (ocupando
as posições de 0 a 9 em cada vetor). Faça um outro procedimento que receba dois vetores
preenchidos e gera um novo vetor com os elementos desses 2 vetores intercalados de tal
forma que nas posições ímpares do novo vetor estejam os elementos do primeiro vetor e nas
posições pares os elementos do segundo vetor recebido por parâmetro. Faça um
procedimento que receba e exiba o conteúdo de um vetor. Faça um programa que faça as
devidas declarações e acione os módulos para exemplificar o seu uso.

Ex5 - Faça uma função que sorteie 5 números (entre 10 e 30) e retorne em um vetor. Depois crie
um procedimento que leia as tentativas do usuário para acertar um destes números. O
programa só deve parar quando o usuário acertar um número sorteado

Ex6 - Em uma cidade, sabe-se hipoteticamente que, em outubro de 2024, não ocorreu temperatura
inferior a 15°C, nem superior a 40°C. Faça um programa que armazene as temperaturas de
cada dia de outubro em um vetor (de 31 posições), calcule e imprima:
a) A menor e a maior temperatura ocorrida;
b) A temperatura média;
c) O número de dias nos quais a temperatura foi inferior à temperatura média

EX7 - Desenvolva um procedimento que preencha uma matriz 3x3 com números aleatórios de 1 a
30. Depois, crie uma função que encontre, mostre todos os números primos presentes na
matriz e retorne a soma das posições desses números primos

Ex8 - Faça um procedimento que preencha uma matriz M 5 x 5. Faça uma função que receba
uma matriz preenchida, calcule e retorne cada uma das somas a seguir (uma função para
cada item abaixo):
a) da linha 3 de M
b) da coluna 2 de M
c) da diagonal principal
d) da diagonal secundária
e) de todos os elementos da matriz
*/
using System;
class Program {
  static void Main() {
    Console.WriteLine("|Ex1 - 1| |Ex2 - 2| |Ex3 - 3| |Ex4 - 4| |Ex5 - 5| |Ex6 - 6| |Ex7 - 7| |Ex8 - 8| ");
    string escolha = Console.ReadLine();

    switch(escolha)
    {
    case "1":
    Ex1 ex1 = new Ex1();

      ex1.Info();
      break;

    case "2":
      Ex2 ex2 = new Ex2();

      ex2.Info();
      break;

    case "3":
      Ex3 ex3 = new Ex3();

      ex3.Info();

      break;

    case "4":
      Ex4 ex4 = new Ex4();

      ex4.Info();

      break;

    case "5":
      Ex5 ex5 = new Ex5();

      ex5.Info();

      break;
      
    case "6":
    Ex6 ex6 = new Ex6();
    
    ex6.Info();
    
    break;
			
	case "7":
	Ex7 ex7 = new Ex7();		
			
	ex7.Info();
			
	break;	
	
	case "8":
	Ex8 ex8 = new Ex8();
	
	ex8.Info();
	
	break;
    }
  }
}
/******************************************************/
class Ex1
{
  public void Info()
  {
    int[] vect = new int[15];
    for(int i = 0; i < vect.Length; i++)
    {
      Console.Write($"Digite o {i}º número: ");
      int num = int.Parse(Console.ReadLine());

      vect[i] = num;
    }
    Console.WriteLine("Os numeros da posição par no vetor são: ");
    int [] vectPar = ParVect(vect);
  for(int i = 0; i < vectPar.Length; i++)
    {
      Console.WriteLine(vectPar[i]);
    }
  }
  public int[] ParVect(int[] vect)
  {
    int[] vectPar = new int[8];
    int j = 0;

    for(int i = 0; i < vect.Length; i++)
    {
      if(i % 2 == 0)
      {
        vectPar[j] = vect[i];

        j++;
      }
    }
    return vectPar;
  }
}
/****************************************************/
class Ex2
{
  public void Info()
  {
    double[] vect = new double[10];
    
    for(int i = 0; i < vect.Length; i++)
    {
      Console.Write($"Digite a nota do aluno {i + 1}: ");
      double num = double.Parse(Console.ReadLine());

      vect[i] = num;
    }
    Media(vect);
  }
  public void Media(double[] vect)
  {
    double mediaTurma = 0;
    int acimaMedia = 0;
    
    for(int i = 0; i < vect.Length; i++)
    {
      mediaTurma += vect[i];
    }
    double mediaTotal = mediaTurma / vect.Length;
    for(int i = 0; i < vect.Length; i++)
    {
      if(vect[i] > mediaTotal)
      acimaMedia++;
    }
    Console.WriteLine($"Média da turma: {mediaTotal:F2}");
    Console.WriteLine($"Crianças acima da média: {acimaMedia}");
  }
}
/************************************************************/
class Ex3
{
  public void Info()
  {
    Console.Write("Quantos numeros terá o vetor? ");
    int n = int.Parse(Console.ReadLine());

    int[]vect = new int[n];

    for(int i = 0; i < vect.Length; i++)
    {
      Console.Write("Digite um numero: ");
      int num = int.Parse(Console.ReadLine());

      vect[i] = num;
    }

    Console.WriteLine($"O menor numero está na posição: {MenorPosicao(vect)}");
  }
  public int MenorPosicao(int[] vect)
  {
  int index = vect[0];
    int menorPos = 0;

    for(int i = 1; i < vect.Length; i++)
    {
      if(vect[i] < index)
      {
        index = vect[i];
        menorPos = i;
      }
    }
    return menorPos;
  }
}
/**************************************************/
class Ex4
{
  public void Info()
  {
    int[] vectX = new int[10];
    int[] vectY = new int[10];

      Console.WriteLine("Preenche o primeiro vetor: ");
    for(int i = 0; i < vectX.Length; i++)
    {
      Console.Write($"Digite o numero da posição {i}: ");
      vectX[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine("Preenche o segundo vetor: ");
    for(int i = 0; i < vectX.Length; i++)
    {
      Console.Write($"Digite o numero da posição {i}: ");
      vectY[i] = int.Parse(Console.ReadLine());
    }

    NewVect(vectX, vectY);
  }
  public void NewVect(int[] vectX,int[] vectY)
  {
    int[] vectXY = new int[20];

    /*for(int i = 0, j = 2; i < 10; i++)
      {
        if(i == 0)
        {
          vectXY[i] = vectY[i];
          vectXY[i + 1] = vectX[i];
        }

        else
        {
          vectXY[j] = vectY[i];
          vectXY[j + 1] = vectX[i];

          j+=2;
        }
      }
    */

    for(int i = 0; i < 10; i++)
    {
      vectXY[i * 2] = vectY[i];
      vectXY[i * 2 + 1] = vectX[i];
    }
    for(int i = 0; i < vectXY.Length; i++)
    {
      Console.WriteLine(vectXY[i]);
    }
   }
}
/**********************************************/
class Ex5
{
  public static int[] NewVect()
  {
    Random random = new Random();

    int[] vect = new int[5];

    for(int i = 0; i < vect.Length; i++)
    {
      int temp = random.Next(10,31);

      vect[i] = temp;
    }
    return vect;
  }

  public void Info()
  {
    int[] vect = NewVect();

    string vectString = String.Join(", ", vect);

    Console.WriteLine(vectString);

    bool acertou = false;
    int chuteCount = 0;
    int certoCount = 0;

    while(acertou == false)
    {
      Console.WriteLine("Digite o numero do chute até acertar: ");
      int chute = int.Parse(Console.ReadLine());

      chuteCount++;

      for(int i = 0; i < vect.Length; i++)
      {
        if(vect[i] == chute)
        {
          certoCount++;
        }
      }
      if(certoCount != 0)
      {
        Console.WriteLine($"Acertou!!! Você precisou de {chuteCount} tentativas");
        acertou = true;
      }
      else
      Console.WriteLine("Continue tentando");
    }
  }
}
/********************************/
class Ex6
{
    public void Info()
    {
        int[] temperaturas = new int[31];
        Random random = new Random();
        int menorTemp = 41;
        int maiorTemp = 14;
        int somaTemp = 0;
        int countDays = 0;
        
        for(int i = 0; i < temperaturas.Length; i++)
        {
            int temp = random.Next(15,41);
            somaTemp += temp;
            temperaturas[i] = temp;
            
            if(temp > maiorTemp) maiorTemp = temp;
            
            if(temp < menorTemp) menorTemp = temp;
        }
        
        double tempMedia = (double)somaTemp / temperaturas.Length;
        
        foreach(int temp in temperaturas)
        {
            if(temp < tempMedia) countDays++;
        }
        
        Console.WriteLine(String.Join(", ",temperaturas));
        
        Console.WriteLine($"A menor temperatura foi: {menorTemp}°. Já a maior foi {maiorTemp}°");
        Console.WriteLine($"A temperatura média foi: {tempMedia:F2}");
        Console.WriteLine($"Numero de dias que a temperatura foi menor que a media: {countDays}");
    }
}
/*********************/
class Ex7
{
	
	public void Info()
	{
	int[,] matriz = new int[3,3];
		
		PreencherMatriz(matriz);
		
		int somaPrimo = SomaMatriz(matriz);
		
		Console.WriteLine($"A soma das posições que contem numeros primos é: {somaPrimo}");
		
		
	}
	// Desenvolva um procedimento que preencha uma matriz 3x3 com números aleatórios de 1 a 30
	public static void PreencherMatriz(int[,] matriz)
	{
		Random random = new Random();
		
		for(int i = 0; i < matriz.GetLength(0); i++)
		{
			for(int j = 0; j < matriz.GetLength(1); j++)
			{
				Console.Write($"{matriz[i,j] = random.Next(1,31)}\t");
			}
			Console.WriteLine();
		}
	}
	
	// Depois, crie uma função que encontre, mostre todos os números primos presentes na matriz e retorne a soma das posições desses números primos
	public static int SomaMatriz(int[,] matriz)
	{
		int numero = 0;
		int somaPosicao = 0;
		
		for(int i = 0; i < matriz.GetLength(0); i++)
		{
			for(int j = 0; j < matriz.GetLength(1); j++)
			{
				numero = matriz[i,j];
				
				if(EhPrimo(numero))
					somaPosicao += (i+j);
			}
		}
		return somaPosicao;
	}
	
	private static bool EhPrimo(int numero)
	{
		if (numero < 2) return false;
		
		for(int i = 2; i < Math.Sqrt(numero); i++)
		{
			if(numero % i == 0) return false;
			
		}
		return true;
	}
}
/******************************/
/*
Faça um procedimento que preencha uma matriz M 5 x 5. Faça uma função que receba
uma matriz preenchida, calcule e retorne cada uma das somas a seguir (uma função para
cada item abaixo):
a) da linha 3 de M
b) da coluna 2 de M
c) da diagonal principal
d) da diagonal secundária
e) de todos os elementos da matriz
*/
class Ex8
{
    public  void Info()
    {
        int[,] matriz = new int [5,5];
        
        PreencherMatriz(matriz);
        MostrarMatriz(matriz);
        Escolha(matriz);
    }
    
    public static void Escolha(int [,] matriz)
    {
        Console.WriteLine();
        Console.WriteLine("Qual soma deseja fazer? |linha 3 - a| |coluna 2 - b| |diagonal principal - c| |diagonal secundaria - d| |todos os elementos - e|");
        char escolha = char.Parse(Console.ReadLine());
        int soma = 0;
        switch(escolha)
        {
            case 'a':
            
            soma = SomaLinha(matriz);
            
            Console.WriteLine($"A soma da linha 3 é: {soma}");
            
            break;
            
            case 'b': 
            soma = SomaColuna(matriz);
            
            Console.WriteLine($"A soma da coluna 2 é: {soma}");
            
            break;
            
            case 'c':
            soma = SomaPrincipal(matriz);
            
            Console.WriteLine($"A soma da coluna princial é {soma}");
            
            break;
            
            case 'd':
            soma = SomaSecundaria(matriz);
            
            Console.WriteLine($"A soma da coluna secundaria é {soma}");
            
            break;
            
            case 'e':
            soma = SomaTodos(matriz);
            
            Console.WriteLine($"A soma de todas as posições da matriz é {soma}");
            
            break;
        }
    }
    
    public static void PreencherMatriz(int[,] matriz)
    {
        
        Random random = new Random();
        
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i,j] = random.Next(1,31);
            }
        }
    }
    public static void MostrarMatriz(int[,] matriz)
    {
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }
    //da linha 3 de M
    public static int SomaLinha(int [,] matriz)
    {
        int soma = 0;
        for(int j = 0; j < matriz.GetLength(1); j++)
        {
          soma += matriz[3,j];  
        }
        
        return soma;
    }
    //da coluna 2 de M
    public static int SomaColuna(int [,] matriz)
    {
        int soma = 0;
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i,2];
        }
        return soma;
    }
    //da diagonal principal
    public static int SomaPrincipal(int [,] matriz)
    {
        int soma = 0;
        for(int i = 0, j = 0; i < matriz.GetLength(0); i++, j++)
        {
            soma += matriz[i,j];
        }
        return soma;
    }
    //da diagonal secundária
    public static int SomaSecundaria(int [,] matriz)
    {
        int soma = 0;
        for(int i = matriz.GetLength(0) - 1, j = 0; i >= 0 ; i--, j++)
        {
            soma += matriz[i,j];
        }
        return soma;
    }
    // todos elementos
    public static int SomaTodos(int [,] matriz)
    {
        int soma = 0;
        for(int i = 0; i < matriz.GetLength(0); i++)
        {
            for(int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[i,j];
            }
        }
        return soma;
    }
}
