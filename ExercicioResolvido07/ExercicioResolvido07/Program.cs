using System;

namespace ExercicioResolvido07
{
    class program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] mat;

            Console.WriteLine("Digite o tamanhon da matriz quadrada:");
            N = int.Parse(Console.ReadLine());

            mat = new int[N, N];
            
        

            for(int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine(("Diagonal Principal:"));
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }

            int cont = 0;
            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i , j] < 0)
                    {
                        cont++;
                    }
                }
                
            }

            Console.WriteLine("Quantidade de Negativos = " + cont);
        }
    }
}