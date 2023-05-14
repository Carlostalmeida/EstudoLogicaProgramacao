using System;

namespace ExercicioUri1001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            int b = int.Parse(Console.ReadLine());

            int x = a + b;

            Console.WriteLine("X = " + x);


        }
    }
}