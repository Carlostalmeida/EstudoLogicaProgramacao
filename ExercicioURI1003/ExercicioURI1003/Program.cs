using System;

namespace ExercicioUri1003
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int A, B, SOMA;

            Console.WriteLine("Digite um numero");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);


        }
    }
}