using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaSupermercado.Interfaces
{
    public interface IFormaPagamento
    {
        double CalculaPagamento(double valor);
    }
}
