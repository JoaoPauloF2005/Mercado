using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int venda = 1;

        double valor_total;

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtQntd.Text);
            double valor_unitario = double.Parse(txtValor_Unit.Text);

            valor_total += quantidade * valor_unitario;


            dgvMercado.Rows.Add(txtDescricao.Text, txtQntd.Text, txtValor_Unit.Text);


            txtDescricao.Clear();
            txtQntd.Clear();
            txtValor_Unit.Clear();


            lblTotal.Text = valor_total.ToString("C");
            lblItensGrade.Text = dgvMercado.RowCount.ToString();
        }

        private void txtVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvMercado.Rows.Count > 0)
            {
                dgvMercado.Rows.RemoveAt(dgvMercado.CurrentCell.RowIndex);

                MessageBox.Show("Venda Excluida com sucesso", "Exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lblTotal.Text = dgvMercado.RowCount.ToString();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtQIS.Text != "")
            {
                dgvMercado.CurrentRow.Cells[1].Value = txtQIS.Text;

                MessageBox.Show("Venda Alterada com sucesso!", "Exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            txtVenda.Focus();
            txtVenda.Clear();
        }

        private void dgvMercado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMercado.RowCount > 1)
            {
                txtQIS.Text = dgvMercado.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            dgvMercado.Rows.Clear();
            lblTotal.Text = "R$ 0,00";
            lblItensGrade.Text = "0";
        }
    }
}
