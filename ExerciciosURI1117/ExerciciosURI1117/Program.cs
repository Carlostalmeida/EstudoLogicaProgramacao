using System;
using System.Globalization;

namespace ExercicioUri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, media;

            Console.WriteLine("Digite a primeira nota:");
            N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (N1 < 0 || N1 > 10)
            {
                Console.WriteLine("nota invalida" );

                Console.WriteLine("Digite a primeira nota:");
                N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
            }
            Console.WriteLine("Digite a segunda nota:");
            N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (N2 < 0 || N2 > 10) 
            {
                Console.WriteLine("nota invalida");

                Console.WriteLine("Digite a segunda nota:");
                N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }
            media = (N1 + N2) / 2;
            Console.WriteLine("media = " + media);
        }
    }
}