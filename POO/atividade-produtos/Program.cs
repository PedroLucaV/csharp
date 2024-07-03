using System;
using System.Globalization;

namespace atividadeProdutos // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produto.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(produto);
            Console.Write("Digite o número de produtos adicionados ao estoque: ");
            int qnt = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qnt);
            Console.WriteLine(produto);
            Console.Write("Digite o número de produtos removidos do estoque: ");
            qnt = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qnt);
            Console.WriteLine(produto);
        }
    }
}