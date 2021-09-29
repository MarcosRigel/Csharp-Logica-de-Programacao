/* Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior elemento de cada linha.Suponha não haver empates
 * 
 * Entrada:
 * A entrada contém o número N, depois os dados da matriz.
 * 
 * Saída:
 * A saída contém os números representando o maior elemento de cada linha da matriz
 * 
 * Exemplo:
 * ========================================================
 * Entrada                              Saída
 * ========================================================
 * 4                                    12 
 * 10 5 12 3                            7
 * 4 7 0 6                              8
 * 3 3 8 1                              15
 * 15 13 4 7
 * 
 */

using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            
            for (int i = 0; i < N; i++)
            {
                int maiorLinha = matriz[i,0];
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i,j] > maiorLinha)
                    {
                        maiorLinha = matriz[i,j];
                    }
                }
                Console.WriteLine(maiorLinha);
            }
        }
    }
}
