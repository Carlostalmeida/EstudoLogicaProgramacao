using System;

namespace ExercicioUri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resto, hora, minuto, segundo;
           
            Console.WriteLine("Digite o tempo:");
            N = int.Parse(Console.ReadLine());

            hora = N / 3600;
            resto = N % 3600;
            minuto = N / 60;
            segundo = N % 60;
            



            Console.WriteLine(hora + ":" + minuto + ":" + segundo);



        }
    }
}