/* Fazer um programa para ler duas matrizes de números inteiros A e B, contendo de M linhas e N colunas cada. Depois,
 * gerar uma terceira matriz C onde cada elemento desta é a soma dos elementos correspondentes das matrizes originais.
 * Imprimir na tela a matriz gerada.
 * 
 * Entrada:
 * A entrada contém os valores de M e N, depois os valores da primeira matriz A, depois os valores da segunda matriz B,
 * conforme exemplo.
 * 
 * Saída:
 * A saída contém os valores da matriz gerada C, conforme exemplo.
 * 
 * Exemplo:
 * ===============================================================================
 * Entrada                                              Saída
 * ===============================================================================
 * 2 3                                                  5 9 7
 * 3 5 2                                                6 9 6
 * 4 5 1
 * 2 4 5
 * 2 4 5
 */

using System;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int m = int.Parse(vetor[0]);
            int n = int.Parse(vetor[1]);

            int[,] A = new int[m, n];
            int[,] B = new int[m, n];
            int[,] C = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(vetor[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = int.Parse(vetor[j]);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}