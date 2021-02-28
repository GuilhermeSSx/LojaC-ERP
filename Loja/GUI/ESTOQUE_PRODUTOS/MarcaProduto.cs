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
    public partial class MarcaProduto : Form
    {
        public MarcaProduto()
        {
            InitializeComponent();
        }

        private void MarcaProduto_Load(object sender, EventArgs e)
        {
            CarregarMarcasProdutos();
        }

        private void CarregarMarcasProdutos()
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            string sqlquery = "SELECT ID_MARCA_PRODUTO, NOME_MARCA FROM MARCA_PRODUTO";

            con.Open();

            SqlCommand cmd = new SqlCommand(sqlquery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dgvMarcaProduto.DataSource = dt;
            con.Close();
        }


        private void InserirNovaMarca()
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            string sqlquery = "INSERT INTO MARCA_PRODUTO(NOME_MARCA) VALUES(@NOME_MARCA)";

            SqlCommand cmd = new SqlCommand(sqlquery, con);

            cmd.Parameters.Add(new SqlParameter("@NOME_MARCA", this.tbMarcaProduto.Text));

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void ibtnNovaMarcaProd_Click(object sender, EventArgs e)
        {
            try
            {
                InserirNovaMarca();
                CarregarMarcasProdutos();

                //CLICK NA LINHA SELECIONADA
                var arg = new DataGridViewCellEventArgs(0, 0);
                dgvMarcaProduto_CellClick(dgvMarcaProduto, arg);

                tbMarcaProduto.Text = "";
                tbMarcaProduto.Focus();

            }
            catch
            {
                MessageBox.Show("Erro ao Adicionar Novo Tipo Contate o Administrador.");
            }
        }

        private void ibtnRemoverMarcaProd_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvMarcaProduto.SelectedRows.Count != 0)
            {
                MessageBox.Show("Nenhum marca produto selecionado.");
                return;
            }

            if (dgvMarcaProduto.Rows.Count == 0)
            {
                MessageBox.Show("Não Existe nenhuma Marca Produto cadastrado.");
            }
            else
            {
                try
                {
                    //criar a conexão
                    SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                    string sqlquery = "DELETE FROM MARCA_PRODUTO WHERE ID_MARCA_PRODUTO = @ID_MARCA_PRODUTO";

                    SqlCommand cmd = new SqlCommand(sqlquery, con);

                    cmd.Parameters.Add(new SqlParameter("@ID_MARCA_PRODUTO", this.lblIdMarca.Text));

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                    CarregarMarcasProdutos();

                    //CLICK NA LINHA SELECIONADA
                    var arg = new DataGridViewCellEventArgs(0, 0);
                    dgvMarcaProduto_CellClick(dgvMarcaProduto, arg);

                    tbMarcaProduto.Text = "";
                    tbMarcaProduto.Focus();
                }
                catch
                {
                    MessageBox.Show("Erro ao Remover Marca Contate o Administrador.");
                }

            }
        }

        private void dgvMarcaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarcaProduto.Rows.Count != 0)
            {
                if(dgvMarcaProduto.SelectedRows.Count > 0)
                {
                    //joga no lblIDpedido o codigo do pedido
                    DataGridViewRow row5 = dgvMarcaProduto.Rows[e.RowIndex];
                    lblIdMarca.Text = row5.Cells[0].Value.ToString();
                }
            }
        }

        private void tbMarcaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }
    }
}
