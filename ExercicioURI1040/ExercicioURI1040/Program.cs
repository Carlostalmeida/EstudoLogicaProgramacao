using System;
using System.Globalization;

namespace ExercicioUri1040
{
    class program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, notaexame, mediafinal;

            Console.WriteLine("Digite as 4 notas do aluno:");

            string[] notas = (Console.ReadLine().Split(' '));
            N1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(notas[3], CultureInfo.InvariantCulture);

            media = ((N1 * 2) + (N2 * 3) + ( N3 * 4) + (N4 * 1)) / 10;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media <= 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else 
            {
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Digite nota do exame:");
                notaexame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                mediafinal = (media + notaexame) / 2;

                if(mediafinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else 
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media: " + mediafinal.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }
    }
}