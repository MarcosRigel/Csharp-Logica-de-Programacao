/* Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
 * - todos os números pares
 * - a quantidade de números pares
 * 
 * Exemplo:
 * =========================================
 * Entrada                      Saída
 * =========================================
 * 6                            8 2 14 20
 * 8 2 11 14 13 20              4
 * 
 */

using System;

namespace Exercicio_02 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int[] vetor = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vetor[i] = int.Parse(s[i]);
            }

            int NumerosPares = 0;
            int quantidadeDeNumerosPares = 0;
            for (int i = 0; i < N; i++) {
                if (vetor[i] % 2 == 0) {
                    Console.Write(vetor[i] + " ");
                    quantidadeDeNumerosPares++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(quantidadeDeNumerosPares);

        }
    }
}
