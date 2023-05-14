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
            if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            if(hora >= 18)
            Console.WriteLine("Boa noite!");

        }
    }
}