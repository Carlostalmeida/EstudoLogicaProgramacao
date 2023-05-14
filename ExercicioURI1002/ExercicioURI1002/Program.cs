using System;
using System.Globalization;

namespace ExercicioUri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, n, a;

            Console.WriteLine("Digite o valor do raio:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            n = 3.14159;

            a = n * Math.Pow(raio, 2.0);

            Console.WriteLine("A = " + a.ToString("F4", CultureInfo.InvariantCulture));


        }
    }
}