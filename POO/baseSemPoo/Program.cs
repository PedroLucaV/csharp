using System;
using System.Globalization;

namespace semPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor das medidas de X:");
            double xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o valor das medidas de Y:");
            double ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xa + xb + xc) / 2;
            double areaX = Math.Sqrt(p * (p-xa) * (p-xb) * (p-xc));

            p = (ya + yb + yc) / 2;
            double areaY = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));

            Console.WriteLine($"Area de X = {areaX:F4, CultureInfo.InvariantCulture}");
            Console.WriteLine($"Area de Y = {areaY:F4, CultureInfo.InvariantCulture}");

            if(areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}