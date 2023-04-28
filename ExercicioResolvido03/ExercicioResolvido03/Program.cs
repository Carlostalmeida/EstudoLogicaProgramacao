using System;
using System.Globalization;

namespace ExercicioResolvido03
{
    class Program
    {
        static void Main(string[] args) 
        {
            string nome1, nome2;
            double idade1, idade2, idademedia;

            Console.WriteLine("Digite o nome:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade de " + nome1);
            idade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite outro nome:");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade de " + nome2);
            idade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            idademedia = (idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + idademedia + " anos.");


        }
    }
}