using System;

namespace ExercicioUri1049
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite se o animal é 'vertabrado' ou 'invertebrado':");
             string opc1 = Console.ReadLine();

            Console.WriteLine("Digite se o animal é 'ave','mamifero', 'inseto' ou 'anelideo':");
            string opc2 = Console.ReadLine();

            Console.WriteLine("Digite se o animal é 'carnivoro', 'onivoro', 'herbivoro' ou 'hematofogo':");
            string opc3 = Console.ReadLine();

            if (opc1 == "vertebrado")
            {
                if (opc2 == "ave")
                {
                    if (opc3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else 
                {
                    if(opc3 =="onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else 
                    {
                        Console.WriteLine("vaca");
                    }
                    
                }
            }
            else
            {
                if( opc2 == "inseto")
                {
                    if(opc3 == "hematofogo")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarto");
                    }
                }
                else
                {
                    if(opc3 =="hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}