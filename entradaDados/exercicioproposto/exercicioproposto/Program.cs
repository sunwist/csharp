using System;
using System.Globalization;

namespace exercicioproposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Exercício Proposto !!");
                Console.WriteLine("Entre com seu nome completo:");
                string nome = Console.ReadLine();
                Console.WriteLine("Quantos quartos tem na sua casa?");
                int quartos = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com o preço do produto:");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha)");

                string[] vetor = Console.ReadLine().Split(' ');

                string ultimonome = vetor[0];
                int idade = int.Parse(vetor[1]);
                double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                Console.WriteLine("Você digitou:");
                Console.WriteLine(nome);
                Console.WriteLine(quartos);
                Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write(ultimonome + " ");
                Console.Write(idade + " ");
                Console.Write(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}