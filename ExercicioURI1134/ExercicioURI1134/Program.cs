using System;

namespace ExercicioUsi1134
{
    class Program
    {
        static void Main(string[] args) 
        {
            int tipo, cont1, cont2, cont3;
            Console.WriteLine("Digite 1.Alcool, 2.Gasolina, 3.Diesel, 4.Fim:");
            tipo = int.Parse(Console.ReadLine());

            cont1 = 0;
            cont2 = 0;
            cont3 = 0;

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    cont1 = cont1 + 1;
                                   }
                else if (tipo == 2)
                {
                    cont2 = cont2 + 1;
                 
                }
                else if (tipo == 3)
                {
                    cont3 = cont3 + 1;
                   

                }
                Console.WriteLine("Digite 1.Alcool, 2.Gasolina, 3.Diesel, 4.Fim:");
                tipo = int.Parse(Console.ReadLine());
   

            }
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine("Alcool: " + cont1);
            Console.WriteLine("Gasolina: " + cont2);
            Console.WriteLine("Diesel: " + cont3);
        }
    }
}