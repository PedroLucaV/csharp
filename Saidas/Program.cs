using System;
using System.Globalization;

namespace Saidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!"); //Não quebra linha linha
            Console.WriteLine("Olá Mundo");
            Console.WriteLine("-----------------");

            char genero = 'F';
            int idade = 30;
            double saldo = 10.2171;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(saldo);
            //Para modificar a quantidade de casas de uma variavel float ou boleana, podemos converte-la assim:
            Console.WriteLine(saldo.ToString("F2")); //Esse F2 entre aspas duplas define a formatação, tambem acaba arredondando o número
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            //Já para trocar o separador do numero decimal (de , para .) podemos usar essa função:
            Console.WriteLine(saldo.ToString("F2",CultureInfo.InvariantCulture)); //Muda para a versão variante;

        }
    }
}