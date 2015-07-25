using CaixaSupermercado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaSupermercado.Pagamento
{
    public class Debito : IFormaPagamento
    {
        public double CalculaPagamento(double valor)
        {
            return valor;
        }

        public override string ToString()
        {
            return "Débito";
        }
    }
}
