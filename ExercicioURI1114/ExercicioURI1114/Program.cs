using System;

namespace ExercicioUri1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.WriteLine("Digite a senha:");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002) 
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}