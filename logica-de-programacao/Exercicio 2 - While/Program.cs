using System;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int correta = 1234;
            Console.WriteLine("Me informe a senha");
            int senha = int.Parse(Console.ReadLine());

            string resultado = Senha(senha, correta);
            Console.WriteLine(resultado);
        }

        static String Senha(int senha, int correta) {
            while (senha != correta)
            {
                Console.WriteLine("Senha invalida!");
                Console.WriteLine("Me informe a senha");
                senha = int.Parse(Console.ReadLine());
            }
            return "Passou";
        }
    }
}