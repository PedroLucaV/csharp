using System;

namespace Atividade2_Baskhara {
    class Program
    {
        static void Main(string[] args) { 
            double a = 12, b = 12, c = 12;
            double delta = Math.Pow(b, 2.0) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}