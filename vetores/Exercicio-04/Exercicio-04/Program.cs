/* Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de
 * todos elementos. Depois mostrar todos os elementos do vetor que estejam abaixo da média.
 * 
 * Exemplo:
 * =======================================================
 * Entrada                                  Saída
 * =======================================================
 * 4                                        12.125
 * 10.0 15.5 13.2 9.8                       10.0
 *                                          9.8
 * 
 */

using System;
using System.Globalization;

namespace Exercicio_04 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            double[] vetor = new double[N];
            
            double media = 0.0;
            double soma = 0.0;

            string[] s = Console.ReadLine().Split(' '); 

            for (int i = 0; i < N; i++) {
                vetor[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++) {
                soma = soma + vetor[i];
            }

            media = (double) soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++) {
                if(vetor[i] < media) {
                    Console.WriteLine(vetor[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
