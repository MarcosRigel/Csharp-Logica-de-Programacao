/* Fazer um programa para executar a seguinte interação com o usuário, lendo os 
 * valores destacados em vermelho, e depois mostrar os dados na tela:
 * 
 * Entre com seu nome completo:
 * Alex Green
 * Quantos quartos tem na sua casa?
 * 3
 * Entre com o preço de um produto:
 * 500.50
 * Entre seu último nome, idade e altura (mesma linha):
 * Green 21 1.73
 * 
 * SAÍDA ESPERADA (NÚMEROS REAIS COM DUAS CASAS DECIMAIS):
 * Alex Green
 * 3
 * 500.50
 * Green
 * 21
 * 1.73
 * 
 */

using System;
using System.Globalization;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            
            string[] vetor = Console.ReadLine().Split(' ');
            string nome2 = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(numero);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
