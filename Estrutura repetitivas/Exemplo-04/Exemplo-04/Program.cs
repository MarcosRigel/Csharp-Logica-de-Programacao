/* Fazer um programa que lê um valor inteiro N e depois N números inteiros. Ao final, mostra
 * a soma dos N números lidos
 * 
 * Exemplo
 * ==========================================
 * Entrada                  Saída
 * ==========================================
 * 3                        11
 * 5
 * 2
 * 4
 * 
 */

using System;

namespace Exemplo_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            N = int.Parse(Console.ReadLine());

            soma = 0;
            for(int i = 1; i <= N; i++) {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }

            Console.WriteLine(soma);
        }
    }
}
