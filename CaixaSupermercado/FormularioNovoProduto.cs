using CaixaSupermercado.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaSupermercado
{
    public partial class FormularioNovoProduto : Form
    {
        private FormularioPrincipal principal;
        public FormularioNovoProduto(FormularioPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novoProduto = new Produto()
            {
                Codigo = Convert.ToInt32(txtCodigo.Text),
                Nome = txtNome.Text,
                Preco = Convert.ToDouble(txtPreco.Text)
            };

            this.principal.AdicionaProduto(novoProduto);
        }
    }
}
