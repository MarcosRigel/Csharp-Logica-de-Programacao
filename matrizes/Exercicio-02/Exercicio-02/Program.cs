/*  Ler um número N e depois uma matriz quadrada NxN com números inteiros. Depois, mostrar na tela a soma dos
 *  elementos de cada linha da matriz.
 *  
 *  Entrada:
 *  A entrada contém o número N, depois os dados da matriz.
 *  
 *  Saída:
 *  A saída contém os números representando a soma dos elementos de cada linha da matriz.
 *  
 *  Exemplo:
 *  =====================================================
 *  Entrada                                 Saída
 *  =====================================================
 *  3                                       11
 *  5 2 4                                   19
 *  10 3 6                                  29
 *  9 8 12
 * 
 */

using System;

namespace Exercicio_02 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            int soma;
            for (int i = 0; i < N; i++) {
                soma = 0;
                for (int j = 0; j < N; j++) {
                    soma = soma + matriz[i, j];
                }
                Console.WriteLine(soma);
            }

        }
    }
}
