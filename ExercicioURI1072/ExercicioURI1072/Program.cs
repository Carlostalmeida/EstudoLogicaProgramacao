using System;

namespace ExercicioUri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de numeros que serao inseridos:");
            int N = int.Parse(Console.ReadLine());

            int cont2 = 0;
            int cont1 = 0;

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                { 
                    cont1 = cont1 +1 ;
                }
                else
                {
                    cont2 = cont2 +1 ;
                }
            }
            Console.WriteLine(cont1 + " in");
            Console.WriteLine(cont2 + " out");
        }
    }
}