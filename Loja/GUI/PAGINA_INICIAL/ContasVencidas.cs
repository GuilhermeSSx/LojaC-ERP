using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.GUI.PAGINA_INICIAL
{
    public partial class ContasVencidas : Form
    {
        public ContasVencidas()
        {
            InitializeComponent();
            dgvContasVencidasCliente.AutoGenerateColumns = false;
        }

        private void ContasVencidas_Load(object sender, EventArgs e)
        {
            CarregarContasVencidas();
        }

        private void CarregarContasVencidas()
        {
            Cliente_DAO cliente_DAO = new Cliente_DAO();

            Cliente_Colecao cliente_Colecao = new Cliente_Colecao();

            cliente_Colecao = cliente_DAO.ContasVencidas(dtpDataAtual.Value.ToString());

            dgvContasVencidasCliente.DataSource = null;

            dgvContasVencidasCliente.DataSource = cliente_Colecao;

            dgvContasVencidasCliente.Update();
            dgvContasVencidasCliente.Refresh();

            calculoContasVencidasCliente();
        }

        private void calculoContasVencidasCliente()
        {
            decimal valorTotal = 0;

            if (dgvContasVencidasCliente.RowCount == 0)
            {
                //MessageBox.Show("A lista esta vazia");
                lblQuantidadeVencida.Text = "0";
                tbTotalVencido.Text = valorTotal.ToString("C");
            }
            else
            {
                dgvContasVencidasCliente.CurrentRow.Cells[1].Value.ToString();
                for (int i = 0; i <= dgvContasVencidasCliente.RowCount - 1; i++)
                {
                    if (dgvContasVencidasCliente.Rows[i].Cells[1].Value != null)
                        valorTotal += Convert.ToDecimal(dgvContasVencidasCliente.Rows[i].Cells[1].Value);
                }
                tbTotalVencido.Text = valorTotal.ToString("C");

                int numeroLinhasCliente = dgvContasVencidasCliente.RowCount;
                lblQuantidadeVencida.Text = Convert.ToString(numeroLinhasCliente);
            }
        }

        private void dgvContasVencidasCliente_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvContasVencidasCliente.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}