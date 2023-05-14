using System;


namespace ExercicioUri1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo;

           
            Console.WriteLine("Digita a distancia:");
            distancia = int.Parse(Console.ReadLine());


            tempo = distancia * 2;

            Console.WriteLine("O tempo necessario: " + tempo + " minutos");
        }
    }
}