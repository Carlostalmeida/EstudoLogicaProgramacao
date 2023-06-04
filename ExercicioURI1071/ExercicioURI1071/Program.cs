using System;

namespace ExercicioUri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            
            Console.WriteLine("Digite um valor:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor:");
            y = int.Parse(Console.ReadLine());

            int min, max;
            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            int soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}