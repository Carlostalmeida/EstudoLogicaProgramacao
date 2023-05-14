using System;
using System.Globalization;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, total ;

            Console.WriteLine("Digite a primeira nota:");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota:");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = nota1 + nota2;

            if (total > 60.0)
            {
                Console.WriteLine("Nota Final = " + total);
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("Nota Final = " + total);
                Console.WriteLine("REPROVADO");
            }


        }
    }
}