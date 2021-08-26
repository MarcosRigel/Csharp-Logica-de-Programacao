/* Fazer um programa para ler um valor inteiro de 1 a 7 representando um dia da semana (sendo 1=domingo,
 * 2=segunda, e assim por diante). Escrever na tela o dia da semana correspondente, conforme exemplos.
 * 
 * Exemplo
 * ==========================================================================
 * Entrada                                      Saída
 * ==========================================================================
 * 1                                            Dia da semana: domingo
 * ==========================================================================
 * 4                                            Dia da semana: quarta
 * ==========================================================================
 * 9                                            Dia da semana: valor inválido
 * 
 */

using System;

namespace Exmplo_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x) {
                case 1:
                    dia = "domingo";
                    break;

                case 2:
                    dia = "segunda";
                    break;

                case 3:
                    dia = "terça";
                    break;

                case 4:
                    dia = "quarta";
                    break;

                case 5:
                    dia = "quinta";
                    break;

                case 6:
                    dia = "sexta";
                    break;

                case 7:
                    dia = "sábado";
                    break;

                default:
                    dia = "valor inválido";
                    break;
            }

            Console.WriteLine("Dia da semana: " + dia);
        }
    }
}
