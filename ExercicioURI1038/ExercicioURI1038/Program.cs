using System;
using System.Globalization;

namespace ExercicioUri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade; 
            

            Console.WriteLine("Digite o Codigo do lanche:");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade:");
            quantidade = int.Parse(Console.ReadLine());

            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.00;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;
            }
            else
            {
                Console.WriteLine("Codigo Digitado Inexistente");
            }

            Console.WriteLine("Valor Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

