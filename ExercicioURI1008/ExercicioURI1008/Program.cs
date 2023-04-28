using System;
using System.Globalization;

namespace ExercicioUri1008
{
    class program
    {
        static void Main(string[] args)
        {
            int NunFuncionario, HorasTrab;
            double ValHorasTrab, Salario;

            Console.WriteLine("Digite o numero do funcionario: ");
            NunFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de horas trabalhadas: ");
            HorasTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            ValHorasTrab = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         

            Salario = (HorasTrab * ValHorasTrab);

            Console.WriteLine("NUMBER = " + NunFuncionario);
            Console.WriteLine("SALARY = U$ " + Salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}