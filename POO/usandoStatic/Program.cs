using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi:F2}");
        }
    }
}
