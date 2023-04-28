using System;
using System.Globalization;

namespace ExercicioUri1007
{
    class program
    {
        static void Main(string[] args)
        {
            double ValorTotal;
         
         
            Console.WriteLine("Digite o primeiro item: ");
            string item1 = Console.ReadLine();
            string[] vet1 = item1.Split(' ');
            int codigo1 = int.Parse(vet1[0]);
            int numero1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o segundo item: ");
            string item2 = Console.ReadLine();
            string[] vet2 = item2.Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            int numero2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2],CultureInfo.InvariantCulture);

            ValorTotal = (numero1 * valor1) + (numero2 * valor2);

            

            Console.WriteLine("VALOR A PAGAR: R$ " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}