using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml.Schema;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] p1, p2;
            double valor1, valor2, quant1, quant2, total1, total2;

            p1 = Console.ReadLine().Split(' ');
            p2 = Console.ReadLine().Split(' ');

            valor1 = (double.Parse(p1[1]));
            quant1 = (double.Parse(p1[2]));

            total1 = valor1 * quant1;

            valor2 = (double.Parse(p2[1]));
            quant2 = (double.Parse(p2[2]));

            total2 = valor2 * quant2;

            Console.WriteLine("VALOR A PAGAR: R$ " + (total1 + total2).ToString("F2"));

        }
    }
}
