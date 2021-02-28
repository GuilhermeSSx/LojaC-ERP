using Loja.DAO;
using Loja.DTO;
using Loja.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Loja.GUI.FICHA_CLIENTES
{
    public partial class ValorDevolucaoCaixa : Form
    {
        public ValorDevolucaoCaixa(string NomeCliente)
        {
            InitializeComponent();
            lblNomeCliente.Text = NomeCliente;
        }

        private void ValorDevolucaoCaixa_Load(object sender, EventArgs e)
        {
            CarregarSaldoCaixa();
            tbValorDevolucao.Text = "0";
            this.ActiveControl = tbValorDevolucao;
        }

        private void CarregarSaldoCaixa()
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SALDO_CAIXA FROM CAIXA", con);
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());

            tbSaldoCaixa.Text = dt.Rows[0]["SALDO_CAIXA"].ToString();

            decimal saldo_caixa = Convert.ToDecimal(tbSaldoCaixa.Text);

            tbSaldoCaixa.Text = saldo_caixa.ToString("C");

            con.Close();
        }

        private void tbValorDevolucao_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tbValorDevolucao);
        }

        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {
            }
        }

        private void tbSaldoCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DevolucaoCliente()
        {
            Caixa_DTO caixa_DTO = new Caixa_DTO();

            caixa_DTO.VALOR_DEVOLUCAO = Convert.ToDecimal(tbValorDevolucao.Text);
            caixa_DTO.NOME_CLIENTE = Convert.ToString(lblNomeCliente.Text);
            caixa_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

            Caixa_DAO caixa_DAO = new Caixa_DAO();

            string retorno = caixa_DAO.devolucaoDinheiroCliente(caixa_DTO);

            try
            {
                decimal VALOR_DEVOLUCAO = Convert.ToDecimal(retorno);

                MessageBox.Show("Devolução feita, no valor: " + retorno);

                CarregarSaldoCaixa();
            }
            catch
            {
                MessageBox.Show("Não foi possivel realizar a Devolução: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ibtnDevolucaoDinheiroCliente_Click(object sender, EventArgs e)
        {
            if (tbValorDevolucao.Text == "0,00")
            {
                MessageBox.Show("Adicione um valor acima de zero para Realizar uma Devolução.");
                return;
            }
            else
            {
                DevolucaoCliente();
            }
        }
    }
}
