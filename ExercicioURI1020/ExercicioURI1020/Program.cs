using System;

namespace ExercicioUri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, ano, mes, dia, resto;

            Console.WriteLine("Digite a idade em dias:");
            idade = int.Parse(Console.ReadLine());

            ano = idade / 365;
            resto = idade % 365;
            mes = resto / 30;
            dia = resto % 30;




            Console.WriteLine(ano + " ano (s)");
            Console.WriteLine(mes + " mes (s)");
            Console.WriteLine(dia + " dia (s)");



        }
    }
}