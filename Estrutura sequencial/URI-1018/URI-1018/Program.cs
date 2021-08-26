using System;

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(N);

            Console.WriteLine(N / 100 + " nota(s) de R$ 100,00");
            N = N % 100;
            Console.WriteLine(N / 50 + " nota(s) de R$ 50,00");
            N = N % 50;
            Console.WriteLine(N / 20 + " nota(s) de R$ 20,00");
            N = N % 20;
            Console.WriteLine(N / 10 + " nota(s) de R$ 10,00");
            N = N % 10;
            Console.WriteLine(N / 5 + " nota(s) de R$ 5,00");
            N = N % 5;
            Console.WriteLine(N / 2 + " nota(s) de R$ 2,00");
            N = N % 2;
            Console.WriteLine(N / 1 + " nota(s) de R$ 1,00");
        }
    }
}
