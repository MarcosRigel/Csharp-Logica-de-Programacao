/* Fazer um programa para ler dois números inteiros M e N. Em seguida, ler uma matriz
 * de M linhas e N colunas contendo números inteiros. Gerar um vetor de modo que cada 
 * elemento do vetor seja a soma dos elementos da linha correspondente da matriz. 
 * Mostrar o vetor gerado.
 * 
 * Exemplo:
 * ==========================================
 * Entrada                          Saída
 * ==========================================
 * 2 3                              25
 * 7 8 10                           10
 * 2 3 5
 * 
 */

using System;

namespace Exemplo_03 {
    class Program {
        static void Main(string[] args) {

            string[] s = Console.ReadLine().Split(' ');
            int M = int.Parse(s[0]);
            int N = int.Parse(s[1]);

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[M];

            for (int i = 0; i < M; i++) {
                int soma = 0;
                for (int j = 0; j < N; j++) {
                    soma = soma + mat[i, j];
                }
                vet[i] = soma;
            }

            for (int i = 0; i < M; i++) {
                Console.WriteLine(vet[i]);
            }

        }
    }
}
