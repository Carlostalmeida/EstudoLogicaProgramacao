using System;
using System.Globalization;

namespace ExercicioResolvido02
{
    class Program
    {
        static void Main(string[] args) 
        {
            double medbase, altura, area, perimetro, diagonal;

            Console.WriteLine("Digite a base do retangulo:");
            medbase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a altura do retangulo:");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = medbase * altura;
            perimetro = 2 * (altura + medbase);
            diagonal = Math.Sqrt(Math.Pow(altura, 2.0) + Math.Pow(medbase, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}