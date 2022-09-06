using System;
using System.Globalization;

namespace Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vet;

            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo, pi;

            vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            pi = 3.14159;
            triangulo = (a * c) / 2;
            circulo = (Math.Pow(c, 2.0)) * pi;
            trapezio = ((a + b) * c) / 2;
            quadrado = Math.Pow(b, 2.0);
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));




        }
    }
}
