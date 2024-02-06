using System;
using System.Globalization;

namespace entradaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parte 1 - Entrada de Dados");

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            // comando Split
            // string s = Console.ReadLine();

            // a cada espaco em branco armazena em um vetor de split
            string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.Write(a + " ");
            Console.Write(b + " ");
            Console.Write(c);

            // parte 2
            Console.WriteLine("Parte 2 - Entrada de Dados");

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] v = Console.ReadLine().Split(' ');

            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write(nome + " ");
            Console.Write(sexo + " ");
            Console.Write(idade + " ");
            Console.Write(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}