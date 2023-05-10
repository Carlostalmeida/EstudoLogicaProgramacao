using System;
using System.Globalization;

namespace ExercicioUri1045
{
    class Program
    {
        static void Main(string[] args) 
        {

            float n1, n2, n3;

            Console.WriteLine("Digite os tres valores do triangulo:");
            string[] valores = (Console.ReadLine().Split(' '));
            n1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(valores[2], CultureInfo.InvariantCulture);

            float A, B, C;
            if (n1 > n2 && n1 > n3)
            {
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3)
            {
                A = n2;
                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }


            if (A >= B + C)
            {
                Console.WriteLine("NÃO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))

                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSONGULO");
                }
                else 
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}