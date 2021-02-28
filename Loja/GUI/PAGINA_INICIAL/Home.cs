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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CarregarContasReceberHoje();
            CarregarEstatiscaVenda();
        }

        private void CarregarContasReceberHoje()
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            con.Open();
            SqlCommand cmd = new SqlCommand("uspContasReceberHoje", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());

            dgvReceberHoje.DataSource = dt;

            con.Close();

            decimal valorTotalReceberHoje = 0;

            if (dgvReceberHoje.RowCount == 0)
            {
                //MessageBox.Show("A lista esta vazia");
                lblTotalReceberHoje.Text = valorTotalReceberHoje.ToString("C");
            }
            else
            {
                for (int i = 0; i <= dgvReceberHoje.RowCount - 1; i++)
                {
                    if (dgvReceberHoje.Rows[i].Cells[0].Value != null)
                        valorTotalReceberHoje += Convert.ToDecimal(dgvReceberHoje.Rows[i].Cells[1].Value);
                }

                lblTotalReceberHoje.Text = valorTotalReceberHoje.ToString("C");
            }

        }



        private void CarregarEstatiscaVenda()
        {
            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            con.Open();
            SqlCommand cmd = new SqlCommand("uspEstatisticasHome", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());

            lblVendasHoje.Text = dt.Rows[0]["VALOR_TOTAL_VENDA_HOJE"].ToString();
            lblVendasMes.Text = dt.Rows[0]["VALOR_TOTAL_VENDA_MES"].ToString();
            lblClientesAtendidos.Text = dt.Rows[0]["CLIENTES_ATENDIDOS_HOJE"].ToString();
            lblPagamentosRecebidosHoje.Text = dt.Rows[0]["PAGAMENTOS_RECEBIDOS_HOJE"].ToString();
            lblSaldoInicial.Text = dt.Rows[0]["SALDO_INICIAL"].ToString();
            lblSaldoFinal.Text = dt.Rows[0]["SALDO_FINAL"].ToString();

            decimal vendas_hoje = Convert.ToDecimal(lblVendasHoje.Text);
            decimal vendas_mes = Convert.ToDecimal(lblVendasMes.Text);
            decimal pagamentos_hoje = Convert.ToDecimal(lblPagamentosRecebidosHoje.Text);
            decimal saldo_inicial = Convert.ToDecimal(lblSaldoInicial.Text);
            decimal saldo_final = Convert.ToDecimal(lblSaldoFinal.Text);

            lblVendasHoje.Text = vendas_hoje.ToString("C");
            lblVendasMes.Text = vendas_mes.ToString("C");
            lblPagamentosRecebidosHoje.Text = pagamentos_hoje.ToString("C");
            lblSaldoInicial.Text = saldo_inicial.ToString("C");
            lblSaldoFinal.Text = saldo_final.ToString("C");

            con.Close();

        }






    }
}
