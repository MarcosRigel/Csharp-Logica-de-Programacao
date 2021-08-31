/* Problema exemplo
 * Fazer um programa para ler um número inteiro positivo N, depois ler N números quaisquer e armazená-los
 * em um vetor. Em seguida, mostrar na tela todos elementos do vetor
 * 
 * Exemplo
 * ===================================================
 * Entrada                                  Saída
 * ===================================================
 * 4                                        10.5
 * 10.5                                     4.2
 * 4.2                                      -7.1
 * -7.1                                     15.0
 * 15.0
 * 
 * 
 */


using System;
using System.Globalization;

namespace Exemplo_01 {
    class Program {
        static void Main(string[] args) {

            double[] vet;
           
            int N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i=0; i < N; i++) {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++) {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
