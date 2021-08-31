/* Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
 * do vetor (supor não haver empates). Mostrar também a posição do maior elemento.
 * 
 * Exemplo:
 * =====================================================
 * Entrada                              Saída
 * =====================================================
 * 6                                    14.0
 * 8.0 4.0 10.0 14.0 13.0 7.0           3
 */

using System;
using System.Globalization;

namespace Exercicio_01 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            double[] vetor = new double[N];

            string[] s = Console.ReadLine().Split();

            for (int i = 0; i < N; i++) {
                vetor[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double maior = 0.0;
            double proximo = 0.0;
            int posicao = 0;

            for (int i = 0; i < N; i++) {
                proximo = vetor[i];
                if(proximo > maior) {
                    maior = proximo;
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
