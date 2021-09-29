/* Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar a soma dos elementos acima 
 * da diagonal principal
 * 
 * Entrada:
 * A entrada contém o valor N, depois os dados da matriz
 * 
 * Saída:
 * A saída contém a soma dos elementos da diagonal principal
 * 
 * Exemplo:
 * =============================================================
 * Entrada                                      Saída
 * =============================================================
 * 3                                            12
 * 10 3 2
 * 5 15 7
 * 8 6 4
 * 
 */

using System;

namespace Exercicio_04
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
                    matriz[i, j] = int.Parse((s[j]));
                }
            }

            int soma = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < N; j++)
                {
                    soma = soma + matriz[i, j];
                }                
            }
            Console.WriteLine(soma);
        }
    }
}
