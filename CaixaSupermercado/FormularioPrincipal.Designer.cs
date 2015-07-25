namespace CaixaSupermercado
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaProdutosComprados = new System.Windows.Forms.ListBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaProdutosComprados
            // 
            this.listaProdutosComprados.FormattingEnabled = true;
            this.listaProdutosComprados.Location = new System.Drawing.Point(12, 12);
            this.listaProdutosComprados.Name = "listaProdutosComprados";
            this.listaProdutosComprados.Size = new System.Drawing.Size(268, 212);
            this.listaProdutosComprados.TabIndex = 0;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(297, 12);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProduto.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(404, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 257);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(126, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo produto";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(327, 83);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "0";
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Location = new System.Drawing.Point(300, 161);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(128, 23);
            this.btnFinaliza.TabIndex = 7;
            this.btnFinaliza.Text = "Finalizar compra";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // cboFormaPagamento
            // 
            this.cboFormaPagamento.FormattingEnabled = true;
            this.cboFormaPagamento.Location = new System.Drawing.Point(300, 123);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(121, 21);
            this.cboFormaPagamento.TabIndex = 8;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(297, 107);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(110, 13);
            this.lblFormaPagamento.TabIndex = 9;
            this.lblFormaPagamento.Text = "Forma de pagamento:";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 319);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.cboFormaPagamento);
            this.Controls.Add(this.btnFinaliza);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.listaProdutosComprados);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaProdutosComprados;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinaliza;
        private System.Windows.Forms.ComboBox cboFormaPagamento;
        private System.Windows.Forms.Label lblFormaPagamento;
    }
}

