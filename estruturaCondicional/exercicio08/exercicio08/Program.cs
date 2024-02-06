using System;
using System.Globalization;

namespace exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;

            if(valor > 0.0 && valor < 2000.00)
            {
                Console.WriteLine("Isento");
            }else if(valor < 3000.01)
            {
                imposto = (valor - 2000.00) * 8 / 10;
            }
            else if(valor <= 4500.00)
            {
                imposto = (valor - 3000.00) * 18 / 100 + 1000.00 * 8/100;
            }else{
                imposto = (valor - 4500) * 28 / 100 + 1500.0 * 18 / 100 + 1000.0 * 8 / 100;
          
            }
            Console.WriteLine(imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

