using System;
using System.Runtime.Intrinsics;
using System.Globalization;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double v1, v2, v3, media = 0;

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = (((v1 * 2) + (v2 * 3) + (v3 * 5)) / (2 + 3 + 5));

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

