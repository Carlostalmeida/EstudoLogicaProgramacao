﻿using System;

namespace ExercicioUri1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Digite dois valores:");
            string[] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
                Console.WriteLine("Sao Multiplos");
            else
                Console.WriteLine("Nao Sao Multiplos");

        }
    }
}