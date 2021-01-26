using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
            if (Quantidade < 0)
            {
                Quantidade = 0;
            }
        }
        public override string ToString()
        {
            return _nome
                + ", $: "
                + Preco.ToString("F2")
                + ", Quantidade: "
                + Quantidade
                + ", Total: "
                + (Preco * Quantidade).ToString("F2");
        }
    }
}
