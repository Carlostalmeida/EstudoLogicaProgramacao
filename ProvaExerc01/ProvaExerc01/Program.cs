using System;
using System.Globalization;

namespace ProvaExerc01
{
    class Progam
    {
        static void Main(string[] args)
        {
          
            //solicita e coleta os valores da primeira peca em uma string
            Console.WriteLine("Digite o Codigo, quantidade e valor da peca 1:");
            string[] vet1 = (Console.ReadLine().Split(' '));

            //solicita e coleta os valores da segunda peca em uma string
            Console.WriteLine("Digite o Codigo, quantidade e valor da peca 2:");
            string[] vet2 = (Console.ReadLine().Split(' '));

            //transforma os valores das stings 1 e 2 de acordo com a necessidade
            int codigo1 = int.Parse(vet1[0]);
            int codigo2 = int.Parse(vet2[0]);
            double quantidade1 = double.Parse(vet1[1],CultureInfo.InvariantCulture);
            double quantidade2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            //calcula o valor total baseado na quantidade e valor
            double valorTotal = (quantidade1 * valor1) + (quantidade2 * valor2);

            //imprime o valor total na tela
            Console.WriteLine("Valor a pagar: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}