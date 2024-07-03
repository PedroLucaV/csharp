using System;

namespace atividadeProdutos
{
    internal class Produto
    {
        public string nome;
        public double valor;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return valor * quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            quantidade -= quantity;
        }

        public override string ToString()
        {
            return $"{nome}, {quantidade} unidades, R${ValorTotalEmEstoque():F2}";
        }
    }
}
