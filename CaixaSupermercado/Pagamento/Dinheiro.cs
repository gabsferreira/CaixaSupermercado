using CaixaSupermercado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaSupermercado.Pagamento
{
    public class Dinheiro : IFormaPagamento
    {
        public double CalculaPagamento(double valor)
        {
            return valor - (valor * 0.05);
        }

        public override string ToString()
        {
            return "Dinheiro";
        }
    }
}
