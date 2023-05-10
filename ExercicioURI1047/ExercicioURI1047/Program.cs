using System;

namespace ExercicioUri1047
{
    class Program
    {
        static void Main(string[] args) 
        {
            int horaini, minutoini, horafim, minutofim, duracaohora, duracaojh, duracaojm, instini, instfim;

            Console.WriteLine("Digite a hora e o minuto do inicio e do fim do jogo:");
            string[] valores = Console.ReadLine().Split(' ');
            horaini = int.Parse(valores[0]);
            minutoini = int.Parse(valores[1]);
            horafim = int.Parse(valores[2]);
            minutofim = int.Parse(valores[3]);

            instini = horaini * 60 + minutoini;
            instfim = horafim * 60 + minutofim;

            if (horaini < horafim) 
            {
                duracaohora = instfim - instini;

            }
            else
            {
                duracaohora =(24 * 60 - instini) + instfim;
            }

            duracaojh = duracaohora / 60;
            duracaojm = duracaohora % 60;


            Console.WriteLine("O JOGO DUROU " + duracaojh + "HORA(S) E " + duracaojm + "MINUTO(S)");

        }
    }
}