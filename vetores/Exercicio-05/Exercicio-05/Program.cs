/* Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela 
 * a média aritmética somente dos números pares lidos.
 * 
 * Exemplo:
 * ================================================
 * Entrada                              Saída
 * ================================================
 * 6                                    11.0
 * 8 2 11 14 13 20
 * 
 */

using System;
using System.Globalization;

namespace Exercicio_05 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int[] vetor = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vetor[i] = int.Parse(s[i]);
            }

            int somaPar = 0;
            for (int i = 0; i < N; i++) {
                if(vetor[i] % 2 == 0) {
                    somaPar = somaPar + vetor[i];
                }
            }

            double media = somaPar / N;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
