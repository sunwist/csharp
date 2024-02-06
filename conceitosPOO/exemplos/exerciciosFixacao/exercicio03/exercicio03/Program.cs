using System;
using System.Globalization;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args) 
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFInal().ToString("F2", CultureInfo.InvariantCulture));

            if(aluno.Resultado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno.Resto().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
            

        }
    }

}