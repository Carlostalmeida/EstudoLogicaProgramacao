using System;

namespace ExercicioUri1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A = 0;

            for(int i = 0; i < 10000; i++)
            {
                int valor = A % N;
                    if(valor != 2)
                    {
                        A = A + 1;
                        
                    }
                    else
                    {
                        int num = A;
                        A = A + 1;
                        Console.WriteLine(num);
                    }
            }
        }
    }
}