using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;

            Console.WriteLine("Digite um horario:");
            hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else
            {
                if (hora >= 12 && hora < 18)
                {
                    Console.WriteLine("Boa tarde!");
                }
                else 
                        {
                            Console.WriteLine("Boa noite!");
                        }  
            }
            

        }
    }
}