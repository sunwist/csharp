using System;
using System.Globalization;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valor, salario;

            Console.WriteLine("Número do funcionário:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor recebido por hora:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valor;

            Console.WriteLine($"Funcionário: {numero}");
            Console.WriteLine("Salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}