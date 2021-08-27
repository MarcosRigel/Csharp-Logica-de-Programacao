using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(vetor[0]);
            int horaFinal = int.Parse(vetor[1]);
            int horaToTal = 0;

            if (horaInicial < horaFinal)
            {
                horaToTal = horaFinal - horaInicial;
            }
            else
            {
                horaToTal = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + horaToTal + " HORA(S)");

        }
    }
}
