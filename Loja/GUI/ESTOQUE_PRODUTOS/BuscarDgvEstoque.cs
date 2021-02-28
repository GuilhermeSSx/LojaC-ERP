using Loja.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Loja.GUI.ESTOQUE_PRODUTOS
{
    public partial class BuscarDgvEstoque : Form
    {

        public string ParametroNomeProduto
        {
            get { return nomeProduto; }
        }

        public string nomeProduto = "";

        public BuscarDgvEstoque()
        {
            InitializeComponent();
            dgvBuscarProdutos.AutoGenerateColumns = false;
        }

        private void BuscarDgvEstoque_Load(object sender, EventArgs e)
        {
            cbBuscarProduto_TextChanged(sender, e);
            this.ActiveControl = cbBuscarProduto;
        }

        private void cbBuscarProduto_TextChanged(object sender, EventArgs e)
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            string sqlquery = "SELECT NOME_PRODUTO, QUANT_PROD FROM [dbo].[ESTOQUE_PRODUTOS] WHERE NOME_PRODUTO LIKE '%" + cbBuscarProduto.Text + "%'";

            con.Open();

            SqlCommand cmd = new SqlCommand(sqlquery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgvBuscarProdutos.DataSource = dt;
            con.Close();
        }

        private void ibtnSelecionarProduto_Click(object sender, EventArgs e)
        {
            if(dgvBuscarProdutos.CurrentRow == null)
            {
                //se não tiver linhas selecionadas não fazer nada
            }
            else
            {
                if (dgvBuscarProdutos.CurrentRow.Index == 0)
                {
                    DataGridViewRow row = dgvBuscarProdutos.Rows[0];
                    nomeProduto = row.Cells[0].Value.ToString();
                }
                this.DialogResult = DialogResult.Yes;
            }

        }

        private void dgvBuscarProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBuscarProdutos.Rows[e.RowIndex];
                nomeProduto = row.Cells[0].Value.ToString();
            }
        }

        private void cbBuscarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                ibtnSelecionarProduto_Click(this, new EventArgs());
            }

        }
    }
}
