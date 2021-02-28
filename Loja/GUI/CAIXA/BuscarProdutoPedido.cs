using Loja.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Loja.GUI.CAIXA
{
    public partial class BuscarProdutoPedido : Form
    {
        public string ParametroNomeProduto
        {
            get { return nomeProduto; }
        }

        public string ParametreIDProduto
        {
            get { return idProduto; }
        }

        public string nomeProduto = "";
        public string idProduto = "";

        public BuscarProdutoPedido()
        {
            InitializeComponent();
            dgvBuscarProdutosPedido.AutoGenerateColumns = false;
        }

        private void BuscarProdutoPedido_Load(object sender, EventArgs e)
        {
            cbBuscarProduto_TextChanged(sender, e);
            this.ActiveControl = cbBuscarProduto;
        }

        private void cbBuscarProduto_TextChanged(object sender, EventArgs e)
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            string sqlquery = "SELECT ID_PRODUTO,NOME_PRODUTO,VALOR_PRODUTO, QUANT_PROD FROM [dbo].[ESTOQUE_PRODUTOS] WHERE QUANT_PROD > 0" +
                " AND NOME_PRODUTO LIKE '%" + cbBuscarProduto.Text+"%'";

            con.Open();

            SqlCommand cmd = new SqlCommand(sqlquery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgvBuscarProdutosPedido.DataSource = dt;
            con.Close();
        }

        private void ibtnSelecionarProduto_Click(object sender, EventArgs e)
        {
            if (dgvBuscarProdutosPedido.CurrentRow == null)
            {
                //se não tiver linhas selecionadas não fazer nada
            }
            else
            {
                if (dgvBuscarProdutosPedido.CurrentRow.Index == 0)
                {
                    DataGridViewRow row = dgvBuscarProdutosPedido.Rows[0];
                    nomeProduto = row.Cells[1].Value.ToString();
                    idProduto = row.Cells[0].Value.ToString();
                }
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void dgvBuscarProdutosPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBuscarProdutosPedido.Rows[e.RowIndex];
                nomeProduto = row.Cells[1].Value.ToString();
                idProduto = row.Cells[0].Value.ToString();
            }
        }

        private void cbBuscarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
