using System;
using System.Globalization;


namespace ExercicioUri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivel, media;

            Console.WriteLine("Digita a distancia total percorrida:");
            distancia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de combustivel gasto:");
            combustivel = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            media = distancia / combustivel;

            Console.WriteLine("Consumo Medio: " + media.ToString("F3",CultureInfo.InvariantCulture) + "Km/l");
        }
    }
}