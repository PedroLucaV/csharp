using System;
using System.Globalization;

namespace ExercicioDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do Dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você irá comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais: {ConversorDolar.ConverterDolar(cotacao, dolar):F2}");
        }
    }
}
