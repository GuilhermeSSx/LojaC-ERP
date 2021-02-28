using Loja.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.GUI.ESTOQUE_PRODUTOS
{
    public partial class TipoProduto : Form
    {
        public TipoProduto()
        {
            InitializeComponent();
            dgvTipoProduto.AutoGenerateColumns = false;
        }

        private void TipoProduto_Load(object sender, EventArgs e)
        {
            CarregarTiposProdutos();

            if (dgvTipoProduto.Rows.Count != 0)
            {
                //joga no lblIDpedido o codigo do pedido
                DataGridViewRow row5 = dgvTipoProduto.Rows[0];
                lblIdTipo.Text = row5.Cells[0].Value.ToString();
            }

        }


        private void CarregarTiposProdutos()
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            string sqlquery = "SELECT ID_TIPO_PRODUTO, NOME_TIPO FROM TIPO_PRODUTOS";

            con.Open();

            SqlCommand cmd = new SqlCommand(sqlquery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgvTipoProduto.DataSource = dt;
            con.Close();
        }


        private void InserirNovoTipo()
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            string sqlquery = "INSERT INTO TIPO_PRODUTOS(NOME_TIPO) VALUES(@NOME_TIPO)";

            SqlCommand cmd = new SqlCommand(sqlquery, con);

            cmd.Parameters.Add(new SqlParameter("@NOME_TIPO", this.tbTipoProduto.Text));

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void ibtnNovoTipoProd_Click(object sender, EventArgs e)
        {
            try
            {
                InserirNovoTipo();
                CarregarTiposProdutos();

                //CLICK NA LINHA SELECIONADA
                var arg = new DataGridViewCellEventArgs(0, 0);
                dgvTipoProduto_CellClick(dgvTipoProduto, arg);

                tbTipoProduto.Text = "";
                tbTipoProduto.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao Adicionar Novo Tipo Contate o Administrador.");
            }

        }

        private void ibtnRemoverTipoProd_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvTipoProduto.SelectedRows.Count != 0)
            {
                MessageBox.Show("Nenhum tipo produto selecionado.");
                return;
            }

            if(dgvTipoProduto.Rows.Count == 0)
            {
                MessageBox.Show("Não Existe nenhum Tipo Produto cadastrado.");
            }
            else
            {
                try
                {
                    //criar a conexão
                    SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                    string sqlquery = "DELETE FROM TIPO_PRODUTOS WHERE ID_TIPO_PRODUTO = @ID_TIPO_PRODUTO";

                    SqlCommand cmd = new SqlCommand(sqlquery, con);

                    cmd.Parameters.Add(new SqlParameter("@ID_TIPO_PRODUTO", this.lblIdTipo.Text));

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                    CarregarTiposProdutos();

                    //CLICK NA LINHA SELECIONADA
                    var arg = new DataGridViewCellEventArgs(0, 0);
                    dgvTipoProduto_CellClick(dgvTipoProduto, arg);

                    tbTipoProduto.Text = "";
                    tbTipoProduto.Focus();
                }
                catch
                {
                    MessageBox.Show("Erro ao Remover Tipo Contate o Administrador.");
                }


            }


        }

        private void dgvTipoProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTipoProduto.Rows.Count != 0)
            {
                if(dgvTipoProduto.SelectedRows.Count > 0)
                {
                    //joga no lblIDpedido o codigo do pedido
                    DataGridViewRow row5 = dgvTipoProduto.Rows[e.RowIndex];
                    lblIdTipo.Text = row5.Cells[0].Value.ToString();
                }

            }
        }

        private void tbTipoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }
    }
}
