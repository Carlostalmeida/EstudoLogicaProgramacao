using System;
using System.Globalization;

namespace ExercicioUri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, montante, comissao, total;
            string nome;

            Console.WriteLine("Digite o primeiro nome do vendedor:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o salario fixo:");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o montante total das vendas:");
            montante = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = (montante / 100) * 15;
            total = comissao + salario;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}