using System;
using System.Globalization;

namespace ExercicioUri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o salario:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int percentual;
            double reajuste;
            if (salario <= 400.00)
            {
                percentual = 15;
                reajuste = (salario / 100) * percentual;
                
            }

            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12;
                reajuste = (salario / 100) * percentual;
                
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10;
                reajuste = (salario / 100) * percentual;
                
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7;
                reajuste = (salario / 100) * percentual;
                
            }
            else
            {
                percentual = 4;
                reajuste = (salario / 100) * percentual;
                
            }

            double novosalario = salario + reajuste;

            Console.WriteLine("Novo Salario = " + novosalario.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste = " + reajuste.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Percentual = " + percentual + "%");
        }
    }
}