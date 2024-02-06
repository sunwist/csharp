using System;
using System.Globalization;

namespace exercicio02
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto += salarioBruto * (porcentagem / 100.0);
        }

        public override string ToString()
        {
            return nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture); ;
        }
    }
}
