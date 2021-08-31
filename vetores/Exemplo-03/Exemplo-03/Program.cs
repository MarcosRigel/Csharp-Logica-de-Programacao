/* Faça um programa que leia N números rais e armazene-os em um vetor. Em seguida:
 * - Imprimir todos os elementos do vetor
 * - Mostrar na tela a soma e a média dos elementos do vetor
 * 
 * Exemplo
 * ==================================================
 * Entrada                          Saída
 * ==================================================
 * 4                                8.0 4.0 10.0 14.0
 * 8.0 4.0 10.0 14.0                36.00
 *                                  9.00
 */

using System;
using System.Globalization;

namespace Exemplo_03 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            double[] A = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++) {
                Console.Write(A[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                soma = soma + A[i];
            }
            double media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
