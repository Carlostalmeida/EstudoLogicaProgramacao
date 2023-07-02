using System;
using System.Globalization;

namespace ProvaExerc02
{
    class Progam
    {
        static void Main(string[] args)
        {

            //solicita e coleta os valores do item em uma string
            Console.WriteLine("Digite o Codigo e a quantidade:");
            string[] vet = (Console.ReadLine().Split(' '));
                        
            //transforma os valores da sting de acordo com a necessidade
            int codigo = int.Parse(vet[0]);
            double quantidade = double.Parse(vet[1], CultureInfo.InvariantCulture);

            double valor;
            //codigo 1 cachorro quente
            if(codigo == 1)
            {
                valor = 4.00;
            }
            //codigo 2 X-Salada
            else if (codigo == 2)
            {
                valor = 4.50;
            }
            //codigo 3 X-Bagcon
            else if (codigo == 3)
            {
                valor = 5.00;
            }
            //codigo 4 Torrada simples
            else if (codigo == 4)
            {
                valor = 2.00;
            }
            //codigo 5 Refrigerante
            else
            {
                valor = 1.50;
            }


            //calcula o valor total baseado na quantidade e valor
            double valorTotal = (quantidade * valor);

            //imprime o valor total na tela
            Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}