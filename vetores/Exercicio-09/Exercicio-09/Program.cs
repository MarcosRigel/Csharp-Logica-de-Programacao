/* Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, mandou digitar
 * um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda das mesmas. Fazer um
 * programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
 * 
 * lucro< 10%
 * 10% ≤ lucro ≤ 20%
 * lucro> 20%
 * 
 * Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.
 * 
 * Exemplo
 * =========================================================================
 * Entrada                                                  Saída
 * =========================================================================
 * 4                                                        Lucro abaixo de 10%: 1
 * Feijao 10.00 11.00                                       Lucro entre 10% e 20%: 2
 * Arroz 12.00 12.80
 * Oleo 5.00 5.70
 * Sal 3.00 4.00
 */

using System;
using System.Globalization;

namespace Exercicio_09 {
    class Program {
        static void Main(string[] args) {

            int lucroAbaixo10 = 0;
            int lucroEntre10e20 = 0;
            int lucroAcimaDe20 = 0;
            double valorTotalCompra = 0.0;
            double valorTotalVenda = 0.0;
            double lucroTotal = 0.0;

            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];


            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                precoCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++) {

                double lucro = precoVenda[i] - precoCompra[i];
                double porcentagemLucro = lucro / precoCompra[i] * 100.0;

                if(porcentagemLucro < 10.0) {
                    lucroAbaixo10++;
                }
                else if (porcentagemLucro <= 20.0) {
                    lucroEntre10e20++;
                }
                else {
                    lucroAcimaDe20++;
                }
            }

            for (int i = 0; i < n; i++) {
                valorTotalCompra = valorTotalCompra + precoCompra[i];
                valorTotalVenda = valorTotalVenda + precoVenda[i];
            }

            lucroTotal = valorTotalVenda - valorTotalCompra;

            Console.WriteLine("Lucro abaixo de 10%: " + lucroAbaixo10);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroEntre10e20);
            Console.WriteLine("Lucro acima de 20%: " + lucroAcimaDe20);
            Console.WriteLine("Valor total de compra: " + valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
