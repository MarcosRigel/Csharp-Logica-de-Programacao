/* Fazer um programa para ler um número inteiro N e uma matriz quadrada de ordem N contendo números 
 * inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz.
 * 
 * Exemplo:
 * ====================================================
 * Entrada                  Saída
 * ====================================================
 * 3                        DIAGONAL PRINCIPAL:
 * 5 -3 10                  5 8 -4
 * 15 8 2                   QUANTIDADE DE NEGATIVOS = 2
 * 7 9 -4
 * 
 */

using System;

namespace Exemplo_02 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < N; i++) {
                Console.Write(A[i,i] + " ");
            }
            Console.WriteLine();

            int cont = 0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if(A[i, j] < 0) {
                        cont = cont + 1;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);

        }
    }
}
