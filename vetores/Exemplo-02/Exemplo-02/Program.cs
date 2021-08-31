/* Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostrar na 
 * tela todos os números negativos lidos.
 * 
 * Exemplo
 * ======================================================
 * Entrada                              Saída
 * ======================================================
 * 6                                    -2
 * 8 -2 9 10 -3 -7                      -3
 *                                      -7
 */


using System;

namespace Exemplo_02 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            for(int i=0; i<N; i++) {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++) {
                if(vet[i] < 0) {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
