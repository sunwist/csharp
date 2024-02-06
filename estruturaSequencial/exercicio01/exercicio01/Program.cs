using System;
using System.Runtime.Serialization;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            Console.WriteLine("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("Soma: " + soma);
        }
    }
}