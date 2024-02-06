using System;
using System.Globalization;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args) 
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Funcionário: " + func);

            Console.WriteLine(); Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + func);
        }
    }

}
