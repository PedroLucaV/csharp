using System;
using System.Globalization;

namespace usandoClasseCalc
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculadora calc = new();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine($"Circunferência: {circ:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
            Console.WriteLine($"Valor de PI: {calc.Pi:F2}");
        }

        
    }
}
