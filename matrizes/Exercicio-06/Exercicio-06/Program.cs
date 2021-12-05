/* Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:
 * a) calcular e imprimir a soma de todos os elementos positivos da matriz.
 * b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
 * c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
 * d) imprimir os elementos da diagonal principal da matriz.
 * e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.
 * 
 * Entrada:
 * A entrada contém o número inteiro N, seguido dos valores da matriz com uma casa decimal cada, seguido do índice de uma linha, seguido do índice de uma coluna, conforma exemplo.
 * 
 * Saída:
 * A saída contém os valores de saída de cada ação, com uma casa decimal, na ordem em que foram apresentadas no enunciado, conforme exemplo.
 * 
 * Exemplo
 * ====================================================================
 * Entrada                             Saída
 * ====================================================================
 * 3                                   SOMA DOS POSITIVOS: 40.0 
 * 7.0 -8.0 10.0                       LINHA ESCOLHIDA: -2.0 3.0 5.0 
 * -2.0 3.0 5.0                        COLUNA ESCOLHIDA: 10.0 5.0 4.0
 * 11.0 -15.0 4.0                      DIAGONAL PRINCIAPAL: 7.0 3.0 4.0
 * 1                                   MATRIZ ALTERADA:
 * 2                                   7.0 64.0 10.0
 *                                     4.0 3.0 5.0
 *                                     11.0 225.0 4.0
 */

using System;
using System.Globalization;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[,] matriz = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = double.Parse(vetor[j], CultureInfo.InvariantCulture);
                }
            }

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] > 0.0)
                    {
                        soma = soma + matriz[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));
	
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0.0)
                    {
                        matriz[i, j] = matriz[i, j] * matriz[i, j];
                    }
                }
            }

            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
