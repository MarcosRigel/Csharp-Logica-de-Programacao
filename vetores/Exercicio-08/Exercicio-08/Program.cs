/* Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas. Fazer um programa que calcule e escreva:
 * a maior e a menor altura do grupo
 * a média de altura das mulheres
 * o número de homens
 * 
 * Exemplo:
 * ==========================================================================================
 * Entrada                                              Saída
 * ==========================================================================================
 * 5                                                    Menor altura = 1.54
 * 1.70 F                                               Maior altura = 1.83
 * 1.83 M                                               Media das alturas das mulheres = 1.69
 * 1.54 M                                               Numero de homens = 2
 * 1.61 F
 * 1.75 F
 * 
 */

using System;
using System.Globalization;

namespace Exercicio_08 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            char[] sexo = new char[N];
            double contadorMulheres = 0.0;
            double somaAlturaMulheres = 0.0;
            int contadorHomens = 0;

            for (int i = 0; i < N; i++) {
                string[] vetor = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(vetor[1]);

                if (sexo[i] == 'F') {
                    contadorMulheres++;
                    somaAlturaMulheres += altura[i];
                } else {
                    contadorHomens++;
                }
            }

            Console.Write("Menor altura = ");
            double menorAltura = 2.0;
            for (int i = 0; i < N; i++) {
                if (altura[i] < menorAltura) {
                    menorAltura = altura[i];
                }
            }
            Console.WriteLine(menorAltura.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Maior altura = ");
            double maiorAltura = 0.0;
            for (int i = 0; i < N; i++) {
                if (altura[i] > maiorAltura) {
                    maiorAltura = altura[i];
                }
            }
            Console.WriteLine(maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

            double media = somaAlturaMulheres / contadorMulheres;
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + contadorHomens);
        }
    }
}
