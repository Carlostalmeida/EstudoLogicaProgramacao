using System;
using System.Globalization;

namespace ExercicioUri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, volume;
            int R;

            Console.WriteLine("Digite o valor do raio:");
            R = int.Parse(Console.ReadLine());

            pi = 3.14159;
            volume = (4 / 3.0) * pi * Math.Pow(R, 3.0);
                   

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}