using System;

namespace ExercicioUri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, tempo;
            Console.WriteLine("Digite a hora de inicio e a hora de fim:");
            string[] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);

            if (A < B)
            {
                tempo = B - A;
            }
            else
            {
                tempo = 24 - A + B;
            }
            Console.WriteLine("Tempo de jogo = " + tempo);
        }
    }
}