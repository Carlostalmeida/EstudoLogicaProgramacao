using System;

namespace ExercicioUri1004
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int A, B, PROD;

            Console.WriteLine("Digite um numero");
            A= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            B = int.Parse(Console.ReadLine());

            PROD = A * B;

            Console.WriteLine("PROD = " + PROD);


        }
    }
}