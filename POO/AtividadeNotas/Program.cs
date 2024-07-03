using System;
using System.Globalization;

namespace AtividadeNotas
{
    internal class Program
    {
        static void Main(string[] args) { 
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while(aluno.nota1 > 30.00 || aluno.nota1 < 0.00)
            {
                Console.WriteLine("A Primeira nota não pode ser maior doque 30 ou menor que 0");
                aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (aluno.nota2 > 35.00 || aluno.nota2 < 0.00)
            {
                Console.WriteLine("A Segunda nota não pode ser maior doque 35 ou menor que 0");
                aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (aluno.nota3 > 35.00 || aluno.nota3 < 0.00)
            {
                Console.WriteLine("A Terceira nota não pode ser maior doque 35 ou menor que 0");
                aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine(aluno);
            Console.WriteLine(aluno.resultado());
        } 
    }
}
