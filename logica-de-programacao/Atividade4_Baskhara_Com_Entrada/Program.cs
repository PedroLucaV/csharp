using System;
using System.Globalization;

namespace Atividade4_Baskhara_Com_Entrada
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira o valor de A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de C");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2.0) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}