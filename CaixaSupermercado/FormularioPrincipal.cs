using CaixaSupermercado.Interfaces;
using CaixaSupermercado.Modelo;
using CaixaSupermercado.Pagamento;
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
    public partial class FormularioPrincipal : Form
    {
        private Compra compra;
        private List<Produto> produtosDisponiveis;

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormularioNovoProduto formNovo = new FormularioNovoProduto(this);
            formNovo.ShowDialog();
        }

        public void AdicionaProduto(Produto produto)
        {
            this.produtosDisponiveis.Add(produto);
            MessageBox.Show("Produto adicionado com sucesso!");
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            this.compra = new Compra();
            this.produtosDisponiveis = new List<Produto>();

            PreencheProdutosPadrao();
            PreencheComboFormaPagamento();
        }

        private void PreencheProdutosPadrao()
        {
            var novoProduto1 = new Produto()
            {
                Codigo = 1,
                Nome = "Nova Schin sem álcool",
                Preco = 1.50
            };

            var novoProduto2 = new Produto()
            {
                Codigo = 2,
                Nome = "Amendoim sem gosto",
                Preco = 5
            };

            var novoProduto3 = new Produto()
            {
                Codigo = 3,
                Nome = "Iogurte vencido",
                Preco = 3.50
            };

            this.produtosDisponiveis.Add(novoProduto1);
            this.produtosDisponiveis.Add(novoProduto2);
            this.produtosDisponiveis.Add(novoProduto3);
        }

        private void PreencheComboFormaPagamento()
        {
            cboFormaPagamento.Items.Add(new Debito());
            cboFormaPagamento.Items.Add(new Credito());
            cboFormaPagamento.Items.Add(new Dinheiro());
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var produto = BuscaProduto(Convert.ToInt32(txtCodigoProduto.Text));

            AtualizaValores(produto);
        }

        private void AtualizaValores(Produto produto)
        {
            //atualiza valor do label
            double valorParcial = Convert.ToDouble(lblTotal.Text);
            valorParcial += produto.Preco;
            lblTotal.Text = valorParcial.ToString("#.##");
            //adiciona produto na listagem
            listaProdutosComprados.Items.Add(produto.Nome);

            //adiciona produto na compra
            this.compra.Adiciona(produto);
        }

        private Produto BuscaProduto(int codigoProduto)
        {
            return this.produtosDisponiveis.Where(p => p.Codigo == codigoProduto).FirstOrDefault();
        }

        private void btnFinaliza_Click(object sender, EventArgs e)
        {
            FinalizaCompra((IFormaPagamento)cboFormaPagamento.SelectedItem);
        }

        private void FinalizaCompra(IFormaPagamento formaPagamento)
        {
            this.compra.FinalizaPagamento(formaPagamento);

            MessageBox.Show("O valor total é " + this.compra.Total.ToString("#.##"));
        }
    }
}
