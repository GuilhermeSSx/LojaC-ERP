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

namespace Loja.GUI.FICHA_CLIENTES
{
    public partial class AlterarDataVencimentoParcela : Form
    {
        public AlterarDataVencimentoParcela(string id_parcela, DateTime DataVencimentoAtual)
        {
            InitializeComponent();
            lblIdParcela.Text = id_parcela;
            dtpDataVencimentoParcela.Value = DataVencimentoAtual;
        }

        private void AlterarDataVencimentoParcela_Load(object sender, EventArgs e)
        {

        }

        private void ibtnAlterarData_Click(object sender, EventArgs e)
        {
            try
            {
                //criar a conexão
                SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PEDIDO_PARCELAMENTO_FINALIZAR SET DATA_PARCELAS = '" + dtpDataVencimentoParcela.Value + "' WHERE ID_PARCELA = '" + lblIdParcela.Text + "'", con);
                cmd.CommandType = CommandType.Text;

                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());

                con.Close();

                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Erro não foi possivel Atualizar data!");
            }


        }
    }
}
