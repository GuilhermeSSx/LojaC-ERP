using Loja.DAO;
using Loja.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loja.GUI.PAGINA_INICIAL
{
    public partial class ContasReceber : Form
    {
        public ContasReceber()
        {
            InitializeComponent();
            dgvContasReceberCliente.AutoGenerateColumns = false;
        }

        private void ContasReceber_Load(object sender, EventArgs e)
        {
            ConsultaBancoMes();

            calculoContasReceberClientes();

            dataAtualMes();

            numero = 0;

            desativarAtivarVisibleBtn();
        }

        private void desativarAtivarVisibleBtn()
        {
            if (lblNumero.Text == "0")
            {
                ibtnMesAnterior.Visible = false;
            }
            else
            {
                ibtnMesAnterior.Visible = true;
            }

            if (lblNumero.Text == "4")
            {
                ibtnProximoMes.Visible = false;
            }
            else
            {
                ibtnProximoMes.Visible = true;
            }
        }

        private void dataAtualMes()
        {
            if (dgvContasReceberCliente.SelectedRows.Count == 0)
            {
                //MessageBox.Show("Não existe --");

                string myString = dtpMesAno.Value.ToString();
                string[] subStrings = myString.Split('/');

                foreach (string str in subStrings)
                {
                    lblMes.Text = subStrings[1];
                }
            }
            else
            {
                string myString = dtpMesAno.Value.ToString();
                string[] subStrings = myString.Split('/');

                foreach (string str in subStrings)
                {
                    lblMes.Text = subStrings[1];
                }
            }
        }

        private void calculoContasReceberClientes()
        {
            decimal valorTotal = 0;

            if (dgvContasReceberCliente.RowCount == 0)
            {
                //MessageBox.Show("A lista esta vazia");
                lblQuantidadeAtiva.Text = "0";
                tbTotalDebitos.Text = valorTotal.ToString("C");
            }
            else
            {
                dgvContasReceberCliente.CurrentRow.Cells[1].Value.ToString();
                for (int i = 0; i <= dgvContasReceberCliente.RowCount - 1; i++)
                {
                    if (dgvContasReceberCliente.Rows[i].Cells[1].Value != null)
                        valorTotal += Convert.ToDecimal(dgvContasReceberCliente.Rows[i].Cells[1].Value);
                }
                tbTotalDebitos.Text = valorTotal.ToString("C");

                int numeroLinhasCliente = dgvContasReceberCliente.RowCount;
                lblQuantidadeAtiva.Text = Convert.ToString(numeroLinhasCliente);
            }
        }

        private void ConsultaBancoMes()
        {
            Cliente_DAO cliente_DAO = new Cliente_DAO();

            Cliente_Colecao cliente_Colecao = new Cliente_Colecao();

            cliente_Colecao = cliente_DAO.ContasReceberMes(dtpMesAno.Value.ToString());

            dgvContasReceberCliente.DataSource = null;

            dgvContasReceberCliente.DataSource = cliente_Colecao;

            dgvContasReceberCliente.Update();
            dgvContasReceberCliente.Refresh();

            calculoContasReceberClientes();
        }

        private static int numero = 0;

        private void ibtnProximoMes_Click(object sender, EventArgs e)
        {
            if (numero <= 3)
            {
                numero++;

                lblNumero.Text = numero.ToString();

                //adicionar 1 mes
                dtpMesAno.Value = dtpMesAno.Value.AddMonths(1);
            }

            ConsultaBancoMes();

            dataAtualMes();

            desativarAtivarVisibleBtn();
        }

        private void ibtnMesAnterior_Click(object sender, EventArgs e)
        {
            if (numero >= 1)
            {
                numero--;

                lblNumero.Text = numero.ToString();

                //retroceder 1 mes
                dtpMesAno.Value = dtpMesAno.Value.AddMonths(-1);
            }

            ConsultaBancoMes();

            dataAtualMes();

            desativarAtivarVisibleBtn();
        }

        private void dgvContasReceberCliente_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //PINTAR LINHA DE VERMELHO SE ESTIVER VENCIDA

            DateTime linhaData = Convert.ToDateTime(dgvContasReceberCliente.Rows[e.RowIndex].Cells[2].Value);

            lblDataSemHoras.Text = Convert.ToDateTime(dtpVencido.Value).ToShortDateString();

            DateTime DataAtual = Convert.ToDateTime(lblDataSemHoras.Text);

            if (DataAtual > linhaData)
            {
                dgvContasReceberCliente.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
            }
        }

        private void dgvContasReceberCliente_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvContasReceberCliente.ClearSelection();
        }
    }
}