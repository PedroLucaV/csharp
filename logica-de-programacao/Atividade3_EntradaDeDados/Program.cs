using System;
using System.Globalization;

namespace Atividade3_EntradaDeDados
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos você tem em casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do produto você quer comprar?");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Agora diga seu ultimo nome, sua idade e sua altura (mesma linha separado por espaço)");
            string[] vet = Console.ReadLine().Split(" ");

            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine($"{nome}, {quartos}, {preco.ToString("F2", CultureInfo.InvariantCulture)}, {ultimoNome}, {idade} e {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}