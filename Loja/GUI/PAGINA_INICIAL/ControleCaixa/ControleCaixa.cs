using Loja.GUI.CAIXA;
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

namespace Loja.GUI.PAGINA_INICIAL
{
    public partial class ControleCaixa : Form
    {
        public ControleCaixa()
        {
            InitializeComponent();
        }

        private void ControleCaixa_Load(object sender, EventArgs e)
        {
            CarregarSaldoCaixa();
            CarregarSaldoInicialAtual();
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

        private void CarregarSaldoInicialAtual()
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SALDO_INICIAL FROM CAIXA", con);
            cmd.CommandType = CommandType.Text;

            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());

            
            lblSaldoInicialAtual.Text = dt.Rows[0]["SALDO_INICIAL"].ToString();

            decimal saldo_inicial = Convert.ToDecimal(lblSaldoInicialAtual.Text);

            lblSaldoInicialAtual.Text = saldo_inicial.ToString("C");

            con.Close();
        }

        private void tbSaldoCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ibtnReforcoCaixa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ReforcoCaixa>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                ReforcoCaixa reforcoCaixa = new ReforcoCaixa();
                DialogResult dialogResult = reforcoCaixa.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    CarregarSaldoCaixa();
                }
            }
        }

        private void ibtnSangriaCaixa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SangriaCaixa>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                SangriaCaixa sangriaCaixa = new SangriaCaixa(tbSaldoCaixa.Text);
                DialogResult dialogResult = sangriaCaixa.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    CarregarSaldoCaixa();
                }
            }
        }

        private void ibtnAtualizarSaldoInicial_Click(object sender, EventArgs e)
        {

            if(tbSaldoCaixa.Text == lblSaldoInicialAtual.Text)
            {
                //não fazer nada
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseja mesmo Atualizar o Saldo Inicial do Dia ? \n" +
                    "\n O Saldo Inicial será setado igual ao Saldo Atual em Caixa.",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        //criar a conexão
                        SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE CAIXA SET SALDO_INICIAL = SALDO_CAIXA", con);
                        cmd.CommandType = CommandType.Text;

                        DataTable dt = new DataTable();

                        dt.Load(cmd.ExecuteReader());

                        con.Close();

                        CarregarSaldoInicialAtual();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel atualizar o saldo inicial, Contate o Desenvolvedor. ");
                    }
                }

            }

        }

        private void tbSaldoCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }
    }
}
