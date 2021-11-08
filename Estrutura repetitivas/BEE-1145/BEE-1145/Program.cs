using System;

namespace BEE_1145
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int x = int.Parse(vetor[0]);
            int y = int.Parse(vetor[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);

                if (i % x == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
