using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            double salary, sell, comissao, discount;

            name = (Console.ReadLine());
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sell = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            discount = sell * 0.85;
            comissao = sell - discount;

            Console.WriteLine("TOTAL = R$ " + (salary + comissao).ToString("F2"));
        }
    }
}
