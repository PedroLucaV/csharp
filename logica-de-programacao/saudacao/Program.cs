using System;

namespace parOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um horario");

            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if(hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if(hora >= 18 && hora < 24) 
            {
                Console.WriteLine("Boa Noite!");
            }
            else
            {
                Console.WriteLine("Bom...? Digite um valor entre 00 e 24");
            }
        }
    }
}