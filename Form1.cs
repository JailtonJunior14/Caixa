using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa
{
    
    public partial class Form1 : Form
    {
        double totalt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            double quantidade = double.Parse(txtQtde.Text);
            double valor = double.Parse(txtValor.Text);

            string item = produto + "/" + quantidade + "/" + valor.ToString("C");

            lstProdutos.Items.Add(item);

            totalt += quantidade * valor;

            lblTotal.Text = totalt.ToString("C");


            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();
            txtProduto.Focus();





        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();
            lstProdutos.Items.Clear();
            lblTotal.Text = "";
            totalt = 0;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
