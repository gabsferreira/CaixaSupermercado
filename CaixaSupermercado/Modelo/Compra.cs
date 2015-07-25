using CaixaSupermercado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaSupermercado.Modelo
{
    public class Compra
    {
        private List<Produto> produtos = new List<Produto>();
        public double Total { get; private set; }

        public void Adiciona(Produto produto)
        {
            this.produtos.Add(produto);
            this.Total += produto.Preco;
        }

        public void FinalizaPagamento(IFormaPagamento formaPagamento)
        {
            this.Total = formaPagamento.CalculaPagamento(this.Total);
        }
    }
}
