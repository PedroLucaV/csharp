using System;
using System.Globalization;

namespace trianguloEmClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaX, areaY, p;
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Me informe o valor dos lados de X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Me informe o valor dos lados de Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = x.Area();
            areaY = y.Area();

            Console.WriteLine($"Área de X: {areaX:F4}");
            Console.WriteLine($"Área de Y: {areaY:F4}");

            if (areaX > areaY) {
                Console.WriteLine("A maior área é a de X");
            }
            else
            {
                Console.WriteLine("A maior área é a de Y");
            }
        }
    }
}