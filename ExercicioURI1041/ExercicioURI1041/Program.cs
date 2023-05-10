using System;
using System.Globalization;

namespace ExercicioUri1041
{
    class program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Digite os valores de x e y:");

            string[] valores = (Console.ReadLine().Split(' '));
            x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y = double.Parse(valores[1], CultureInfo.InvariantCulture);
           
                        
            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem.");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo y.");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo x.");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1.");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2.");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3.");
            }
            else
            {
                Console.WriteLine("Q4.");
            }
               
            

        }
    }
}