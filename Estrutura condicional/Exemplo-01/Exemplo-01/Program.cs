/* Fazer um programa para ler as duas notas que um aluno obteve no primeiro e segundo semestres de uma 
 * disciplina anual. Em seguida, mostrar a nota final que o aluno obteve no ano juntamente com um texto explicativo.
 * Caso a nota final do aluno do aluno seja inferior a 60.00, mostrar a mensagem "REPROVADO", conforme exemplos. Todos
 * os valores devem ter uma casa decimal.
 * 
 * Exemplos:
 * ==========================================================================
 * Entrada                                                  Saída
 * ==========================================================================
 * 45.5                                                     NOTA FINAL = 76.8
 * 31.1
 * ==========================================================================
 * 34.0                                                     NOTA FINAL = 57.5
 * 23.5                                                     REPROVADO
 * 
 */

using System;
using System.Globalization;

namespace Exemplo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));

            if(soma < 60.0) {
                Console.WriteLine("REPROVADO");
            }
            
        }
    }
}
