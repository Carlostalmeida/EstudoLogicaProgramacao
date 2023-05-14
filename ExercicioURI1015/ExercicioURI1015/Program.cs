using System;
using System.Globalization;

namespace ExercicioUri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, A, B, C, D;
            string[] vet;

            Console.WriteLine("Digite dois valores:");
            vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite outros dois valores:");
            vet = Console.ReadLine().Split(' ');
            C = double.Parse(vet[0], CultureInfo.InvariantCulture);
            D = double.Parse(vet[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(C - A, 2.0) + Math.Pow(D - B, 2.0));

            Console.WriteLine("Distancia: " + distancia.ToString("F4", CultureInfo.InvariantCulture));
            

        }
    }
}