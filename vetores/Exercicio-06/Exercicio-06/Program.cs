/* Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome
 * da pessoa mais velha.
 * 
 * Exemplo
 * ==============================================================
 * Entrada                              Saída
 * ==============================================================
 * 5                                    Pessoa mais velha: Carlos
 * Joao 16
 * Maria 21
 * Teresa 15
 * Carlos 23
 * Paulo 17
 * 
 */

using System;

namespace Exercicio_06 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            int[] idades = new int[N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

            int maisVelha = 0;
            string nomeMaisVelha = null;
            for (int i = 0; i < N; i++) {
                if(idades[i] > maisVelha) {
                    maisVelha = idades[i];
                    nomeMaisVelha = nome[i];
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nomeMaisVelha);

        }
    }
}
