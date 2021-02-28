using Loja.DAO;
using Loja.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loja.GUI.PAGINA_INICIAL
{
    public partial class MovimentoEstoque : Form
    {
        public MovimentoEstoque()
        {
            InitializeComponent();
            dgvMovimentoEstoque.AutoGenerateColumns = false;
        }

        private void MovimentoEstoque_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now; // get the current DateTime

            var firstDay = new DateTime(now.Year, now.Month, 1);

            dtpInicial.Value = firstDay;

            dtpFinal.Value = DateTime.Now;

            carregarMovimentoEstoque();
        }

        private void carregarMovimentoEstoque()
        {
            Movimento_Estoque_DAO movimento_Estoque_DAO = new Movimento_Estoque_DAO();

            Movimento_Estoque_Colecao movimento_Estoque_Colecao = new Movimento_Estoque_Colecao();

            movimento_Estoque_Colecao = movimento_Estoque_DAO.consultarMovimentoEstoque(dtpInicial.Value, dtpFinal.Value);

            dgvMovimentoEstoque.DataSource = null;

            dgvMovimentoEstoque.DataSource = movimento_Estoque_Colecao;

            dgvMovimentoEstoque.Update();
            dgvMovimentoEstoque.Refresh();
        }

        private void dgvMovimentoEstoque_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvMovimentoEstoque.ClearSelection();
        }

        private void dgvMovimentoEstoque_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //PINTAR LINHA DE VERMELHO SE ESTIVER VENCIDA

            string linhaEntrouSaiu = Convert.ToString(dgvMovimentoEstoque.Rows[e.RowIndex].Cells[4].Value);

            if (linhaEntrouSaiu == "SAÍDA")
            {
                dgvMovimentoEstoque.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
            }
            else if(linhaEntrouSaiu == "REMOÇÃO")
            {
                dgvMovimentoEstoque.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else if (linhaEntrouSaiu == "RETORNO")
            {
                dgvMovimentoEstoque.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                dgvMovimentoEstoque.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
            }
        }

        private void ibtnFiltrarBusca_Click(object sender, EventArgs e)
        {
            carregarMovimentoEstoque();
        }
    }
}