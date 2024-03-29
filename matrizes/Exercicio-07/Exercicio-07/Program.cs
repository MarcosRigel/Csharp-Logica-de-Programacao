﻿/* O sargento Silva organiza seu pelotão em M filas numeradas a partir de 1, sendo cada fila com a mesma quantidade de soldados. Por exemplo, a 
 * figura abaixo mostra a organização do pelotão em 3 filas com 8 soldados em cada uma. Um dos exercícios que o sargento Silva realiza com o 
 * pelotão é o exercício "girar fila", que consiste em dizer o número de uma fila, de modo que os soldados desta fila devem se mover para a direita,
 * e o último soldado da direita vai para a posição mais à esquerda. Você deve fazer um programa para ler a formação do pelotão e executar o exercício 
 * "girar fila".
 * 
 * Entrada:
 * A entrada consiste em um inteiro M representando o número de filas, um inteiro N representado a quantidade de soldados
 * por fila, as M filas de soldados (cada soldado é representado por um número inteiro), e o número inteiro para o exercício "girar fila".
 * 
 * Saída:
 * A saída contém a formação do pelotão após a execução do exercício "girar fila".
 * 
 * Exemplo:
 * =============================================================
 * Entrada                              Saída
 * =============================================================
 * 3                                    1034 2271 9013 9281 1138
 * 5                                    7201 2837 1827 1074 9271
 * 1034 2271 9013 9281 1138             1822 1977 1821 2278 1821
 * 2837 1827 1074 9271 7201
 * 1822 1977 1821 2278 1821
 * 2
 */

using System;

namespace Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(vetor[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());
            fila = fila - 1;
            int ultimoDaFila = matriz[fila, n - 1];
           
            for (int j = n - 1; j > 0; j--)
            {
                matriz[fila, j] = matriz[fila, j - 1];
            }

            matriz[fila, 0] = ultimoDaFila;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}