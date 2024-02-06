using System;
using System.Globalization;

namespace exercicioFixacao
{
    class ConversorDeMoeda
    {
        public static double cotacaoDolar = 3.10;


        public static double Valor(double dolar)
        {
            return (cotacaoDolar + (cotacaoDolar * 6.0/ 100.0)) * dolar;
        }
    }
}
