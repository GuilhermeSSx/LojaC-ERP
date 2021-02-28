using Loja.GUI.SISTEMA;
using Loja.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Loja
{
    public partial class TelaLogin : Form
    {

        //criar a conexão
        SqlConnection conexao = new SqlConnection(Settings.Default.stringConexao);


        public TelaLogin()
        {
            InitializeComponent();
        }

        public static string nomeUsuario = "NaM";
        public static int nivelAcessoUsuario = 3;
        public static bool loginCorreto = false;

        private void IbtnEntrar_Click(object sender, EventArgs e)
        {

            conexao.Open();
            string query = "SELECT * FROM USUARIO WHERE NOME_USUARIO = '" + tblogin.Text + "' AND SENHA_USUARIO = '" + tbsenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                saldoInicialDiaSaldoCaixa();

                nomeUsuario = tblogin.Text;
                Sistema sistema = new Sistema();
                this.Hide();
                sistema.Show();
                conexao.Close();

                loginCorreto = true;
            }
            else
            {
                MessageBox.Show("Senha ou Login incorreto!");
                conexao.Close();
                loginCorreto = false;
            }

            if(loginCorreto == true)
            {
                conexao.Open();
                string query2 = "SELECT NIVEL_ACESSO FROM USUARIO WHERE NOME_USUARIO = '" + tblogin.Text + "'";
                SqlDataAdapter dp2 = new SqlDataAdapter(query2, conexao);
                DataTable dt2 = new DataTable();
                dp2.Fill(dt2);

                if (dt2.Rows.Count == 1)
                {
                    nivelAcessoUsuario = Convert.ToInt32(dt2.Rows[0]["NIVEL_ACESSO"]);
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("erro de nivel de acesso");
                    conexao.Close();
                }
            }

        }

        private void saldoInicialDiaSaldoCaixa()
        {
            DateTime data_atual = DateTime.Now;

            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            con.Open();
            SqlCommand cmd = new SqlCommand("uspSaldoInicialIgualAoCaixa", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DATA_ATUAL", data_atual);

            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());

            con.Close();
        }

        private void tbsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.AcceptButton = IbtnEntrar;
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 700, WinAPI.BLEND);
        }

        private void TelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}