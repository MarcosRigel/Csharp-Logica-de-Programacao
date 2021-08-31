/* Fazer um programa para ler um valor N e depois o nome de N pessoas. Em seguida, mostrar os nomes
 * lidos.
 * 
 * Exemplo:
 * ====================================================
 * Entrada                              Saída
 * ====================================================
 * 3                                    Nomes lidos:
 * Maria                                Maria
 * Joaquim                              Joaquim
 * Ana                                  Ana
 * 
 */

using System;

namespace Exemplo_05 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++) {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            foreach (string x in vet) {
                Console.WriteLine(x);
            }

        }
    }
}