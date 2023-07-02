using System;
using System.Globalization;

namespace ExercicioProposto01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet, maior;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i < N; i++)
            {
                vet[i] = int.Parse(s[i],CultureInfo.InvariantCulture);
            }
            maior = vet[0];
            for (int i = 0; i < N; i++)
            {
                if(vet[i] > maior)
                {
                    vet[i] = maior;

                }
            } 
        }
    }
}