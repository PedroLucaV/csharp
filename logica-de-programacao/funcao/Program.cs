using System;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros inteiros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine($"{resultado} é o maior numero!");
        }

        static int Maior(int n1, int n2, int n3)
        {
            int Maior;

            if (n1 > n2 && n1 > n3)
            {
                Maior = n1;
            }
            else if (n1 < n2 && n2 > n3)
            {
                Maior = n2;
            }
            else
            {
                Maior = n3;
            }
            return Maior;
        }
    }
}