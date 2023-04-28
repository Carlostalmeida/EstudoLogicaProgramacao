using System;
using System.Globalization;

namespace ExercicioFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string ultNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Quantidade de quartos: " +  quartos);
            Console.WriteLine("Preço produto: " + preco, CultureInfo.InvariantCulture);
            Console.WriteLine("Ultimo nome: " + vet[0]);
            Console.WriteLine("Idade: " + vet[1]);
            Console.WriteLine("Altura: " + vet[2], CultureInfo.InvariantCulture);
        }
    }
}
