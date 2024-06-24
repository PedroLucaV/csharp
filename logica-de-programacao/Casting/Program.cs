using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.2;
            // float b = a; - Assim irá dar erro por conta dos valores em bytes de ambos os tipos, para resolver faremos o casting
            float b = (float)a;
            int c = (int)b;

            //também, para evitar problema de que caso 2 valores int precisem dar valor double porém por serem int retornam um valor inteiro, podemos usar o casting para previnir isto
            int num1 = 10;
            int num2 = 4;

            double resultadoErrado = num1 / num2;
            double resultadoCorreto = (double) num1 / num2;


            Console.WriteLine($"{resultadoCorreto} x {resultadoErrado}");
        }
    }
}