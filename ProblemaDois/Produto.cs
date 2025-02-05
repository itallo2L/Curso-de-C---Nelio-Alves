﻿namespace ProblemaDois
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;  
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            var valorTotal = Quantidade * Preco;
            return valorTotal;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
    }
}