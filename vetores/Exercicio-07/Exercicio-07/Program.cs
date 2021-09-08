/* Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres.
 * Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
 * considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.
 * 
 * Exemplo:
 * ===========================================================
 * Entrada                                  Saída
 * ===========================================================
 * 4                                        Alunos aprovados:
 * Joao 7.0 8.5                             Joao
 * Maria 9.2 6.5                            Maria
 * Carlos 5.0 6.0                           Teresa
 * Teresa 5.5 6.5
 * 
 */

using System;
using System.Globalization;

namespace Exercicio_07 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];
            double[] media = new double[n];
            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                nota1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
                soma = nota1[i] + nota2[i];
                media[i] = soma / 2.0;
            }

            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0; i < n; i++) {
                if (media[i] >= 6.0) {
                    Console.WriteLine(nome[i]);
                }
            }

        }
    }
}
