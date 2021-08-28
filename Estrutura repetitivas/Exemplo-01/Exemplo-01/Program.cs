/* Exemplo
 * 
 * Fazer um programa que lê números inteiros até que um zero seja lido. Ao final mostrar a soma
 * dos números lidos.
 * 
 * Entrada                           Saída
 * ==================================================
 * 5                                 11   
 * 2
 * 4
 * 0
 * 
 */

using System;

namespace Exemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int soma = 0;

            while(x != 0) {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(soma);

        }
    }
}
