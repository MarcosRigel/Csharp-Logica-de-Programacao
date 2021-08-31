/* Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde
 * cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.
 * 
 * Exemplo:
 * ======================================================
 * Entrada                              Saída
 * ======================================================
 * 6                                    13 12 14 15 23 27
 * 8 2 11 14 13 20
 * 5 10 3 1 10 7
 * 
 */

using System;

namespace Exercicio_03 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            int[] vetor = new int[N];
            int[] vetor02 = new int[N];

            string[] primeiro = Console.ReadLine().Split(' ');
            string[] segundo = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {    
                vetor[i] = int.Parse(primeiro[i]);
            }

            for (int i = 0; i < N; i++) {
                vetor02[i] = int.Parse(segundo[i]);
            }

            int[] soma = new int[N];
            for (int i = 0; i < N; i++) {
                soma[i] = vetor[i] + vetor02[i];
                Console.Write(soma[i] + " ");
            }

        }
    }
}
