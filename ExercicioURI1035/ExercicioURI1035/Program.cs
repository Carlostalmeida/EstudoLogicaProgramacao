using System;

namespace ExercicioUri1035
{
    class program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, soma1, soma2, variavel;

            Console.WriteLine("Digite 4 valores inteiros:");
            string[] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);
            D = int.Parse(valores[3]);

            soma1 = C + D;
            soma2 = A + B;

            if (B > C && D > A && soma1 > soma2 && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores Aceitos!");
            }
            else
            {
                Console.WriteLine("Valores Nao Aceitos");
            }
        }
    }
}