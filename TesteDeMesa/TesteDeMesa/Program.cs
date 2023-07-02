using System;

namespace TesteDeMesa
{
    class program
    {
        static void Main(string[] args)
        {
            int x, m, n;

            x = 0;
            m = 2;
            n = 3;

            int[,] mat = new int[m, n];

            int[] v = new int[x];
           

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    x = x + 2;
                    mat[i, j] = x;
                }
                v[i] = x;
            }
            Console.WriteLine(mat);

        }
    }
}