using System;

namespace Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vol, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio: ");

            double raio = double.Parse(Console.ReadLine());

            vol = (4 / 3.0) * pi * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = " + (vol).ToString("F3"));

        }
    }
}
