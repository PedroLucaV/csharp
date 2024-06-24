using System;
using System.Globalization;

namespace ExercicioMaiorSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            Pessoa pessoa1, pessoa2;
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            pessoa1.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            pessoa2.salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (pessoa2.salario + pessoa1.salario) / 2;
            Console.WriteLine($"Média do salário: {media:F2}");
        }
    }
}