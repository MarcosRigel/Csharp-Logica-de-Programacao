/* Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar
 * na tela somente os números negativos da matriz.
 * 
 * Entrada:
 * A entrada contém os números M e N na mesma linha, depois os dados da matriz.
 * Saída:
 * A saída contém uma mensagem e depois os números negativos da matriz, conforme exemplo.
 * 
 * Exemplo:
 * ===================================================
 * Entrada                          Saída
 * ===================================================
 * 2 3                              VALORES NEGATIVOS:
 * 12 -8 5                          -8
 * -13 10 -6                        -13
 *                                  -6
 */


using System;

namespace Exercicio_01 {
    class Program {
        static void Main(string[] args) {

            string[] s = Console.ReadLine().Split(' ');
            int M = int.Parse(s[0]);
            int N = int.Parse(s[1]);

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if(matriz[i,j] < 0) {
                        Console.WriteLine(matriz[i,j]);
                    }
                }
            }

        }
    }
}
