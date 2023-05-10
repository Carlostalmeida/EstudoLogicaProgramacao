using System;

namespace ExercicioUri1113
{
    class Program
    {
        static void Main(string[] args) 
        {
            int x, y;

            Console.WriteLine("Digite uma dupla de valores");
            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while(x != y)
            {
                if(x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                Console.WriteLine("Digite uma dupla de valores");
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}