using System;
using System.Globalization;


namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args) {
            // ex1: 
            /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos.

            Console.WriteLine("Informe o primeiro número:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            int x2 = int.Parse(Console.ReadLine());

            int soma = x1 + x2;

            Console.WriteLine($"{x1} + {x2} = {soma}");*/

            // ex2:
            /*
             Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
             casas decimais conforme exemplos.
             Fórmula da área: area = π . raio2
             Considere o valor de π = 3.14159

            double pi = 3.14159;
            Console.WriteLine("digite o raio do circulo:");
            int raio = int.Parse(Console.ReadLine());
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine($"{area:F4}");
            */

            // ex3:
            /*
             Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
             de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            Console.WriteLine("Informe o valor de A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de D");
            int D = int.Parse(Console.ReadLine());

            int Resultado = (A * B - C * D);

            Console.WriteLine(Resultado);
            */

            //ex4:
            /*
             Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
             hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
             decimais.
            Console.WriteLine("Informe o número do funcionario");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de horas do funcionario");
            int numeroHora = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valorHora do funcionario");
            double valorHora = int.Parse(Console.ReadLine());

            double salario = valorHora * numeroHora;

            Console.WriteLine($"Funcionario de número {numero}, seu salario é de {salario}");
            */

            //ex5:
            /*
             Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
             código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
            
            Console.WriteLine("Me informe o codigo, quantidade e valor de cada peca do produto 1");
            string[] peca1 = Console.ReadLine().Split(' ');
            int qnt1 = int.Parse(peca1[1]);
            double val1 = double.Parse(peca1[2], CultureInfo.InvariantCulture); //Nescessidade do Invariant para ler o valor como decimal de uma string

            Console.WriteLine("Me informe o codigo, quantidade e valor de cada peca do produto 2");
            string[] peca2 = Console.ReadLine().Split(' ');
            int qnt2 = int.Parse(peca2[1]);
            double val2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double valorFinal = (qnt1 * val1) + (val2 * qnt2);
            Console.WriteLine($"Valor a pagar: {valorFinal:F2}");
             */

            //ex6:
            /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B
            
             Console.WriteLine("Informe os valores de A, B e C:");
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double areaTriangulo = (A * C) / 2;
            double pi = 3.14159;
            double areaCirculo = pi * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine($"Área do triângulo: {areaTriangulo:F3}");
            Console.WriteLine($"Área do círculo: {areaCirculo:F3}");
            Console.WriteLine($"Área do trapézio: {areaTrapezio:F3}");
            Console.WriteLine($"Área do quadrado: {areaQuadrado:F3}");
            Console.WriteLine($"Área do retângulo: {areaRetangulo:F3}");
            */

            //finished!
        }
    }
}