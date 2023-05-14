using System;
using System.Globalization;


namespace ExercicioUri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade, distancia;
            double litros;

            Console.WriteLine("Digita o tempo gasto:");
            tempo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digita a velocidade media:");
            velocidade = int.Parse(Console.ReadLine());

            distancia = velocidade * tempo;

            litros = distancia / 12.0;

            
            Console.WriteLine("A quantidade de litros necessaria: " + litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}