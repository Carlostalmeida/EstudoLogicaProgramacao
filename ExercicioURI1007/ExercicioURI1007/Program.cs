using System;
    namespace ExercicioUri1007
{
    class program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFERENCA; 

            Console.WriteLine("Digite o primeiro numero: ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto numero: ");
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);

        }
    }
}