using System;

namespace EntradaDeDados1 { 
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine(); //lê o console

            /*
             * string s = Console.ReadLine();
            string[] vetor = s.Split(' '); //transforma o tipo string em um vetor que separa por indice cada texto entre espaços
            */
            //Podemos simplificar assim tbm:

            string[] vetor = Console.ReadLine().Split(" ");

            string p1 = vetor[0];
            string p2 = vetor[1];
            string p3 = vetor[2];

            Console.WriteLine($"{p1} {p2}, {p3}");
        }
    }
}