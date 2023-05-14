using System;
using System.Globalization;


namespace ExercicioUri1014
{
    class Program
    {
        static void Main(string[] args)
        {
         
            double A, B, media;

            Console.WriteLine("Digita a primeira nota:");
            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digita a primeira nota:");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}