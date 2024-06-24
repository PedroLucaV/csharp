using System;

namespace parOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");

            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O Número é Par!");
            }
            else
            {
                Console.WriteLine("O Número é impar!");
            }

        }
    }
}