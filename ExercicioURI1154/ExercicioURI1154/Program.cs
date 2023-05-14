using System;
using System.Globalization;

namespace ExercicioUri1154
{
    class Programa
    {
        static void Main(string[] args)
        {
            int idade, totalidade, cont;
            double media;

            Console.WriteLine("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            //zerar contador de total de idade e contador de quantidade de idades
            totalidade = 0;
            cont = 0;

            while(idade >= 0)
            {
                //soma a idade digitada com a idade anterior registrada
                totalidade = totalidade + idade;
                //conta quantas idades doram digitadas
                cont = cont + 1;

                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            //calcula a media das idades digitadas pela quantidade de idades
            media = (double)totalidade / cont;
            Console.WriteLine("Media: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}