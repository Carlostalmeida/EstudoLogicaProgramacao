using System;

namespace ProvaExerc02
{
    class Progam
    {
        static void Main(string[] args)
        {

            //solicita a entrada de uma senha de numero inteiro
            Console.WriteLine("Digite a senha:");
            int senha = int.Parse(Console.ReadLine());

            //enquanto a condicao nao for atendida
            while(senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            //quando a condicao for atendida imprime na tela
            Console.WriteLine("Acesso Permitido");
            

        }
    }
}