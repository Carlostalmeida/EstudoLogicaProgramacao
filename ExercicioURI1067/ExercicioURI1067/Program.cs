﻿using System;

namespace ExercicioUri1067
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite um numeo inteiro:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i < x; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}