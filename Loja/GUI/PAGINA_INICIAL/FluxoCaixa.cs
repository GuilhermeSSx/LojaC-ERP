using LiveCharts;
using LiveCharts.Wpf;
using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.GUI.PAGINA_INICIAL
{
    public partial class FluxoCaixa : Form
    {
        public FluxoCaixa()
        {
            InitializeComponent();
            dgvFluxoCaixa.AutoGenerateColumns = false;
        }

        private void FluxoCaixa_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now; // get the current DateTime

            var firstDay = new DateTime(now.Year, now.Month, 1);

            dtpInicial.Value = firstDay;

            dtpFinal.Value = DateTime.Now;

            CarregarFluxoCaixa();
            calculoTotalCompraVenda();
        }

        private void CarregarFluxoCaixa()
        {
            Fluxo_Caixa_DAO fluxo_Caixa_DAO = new Fluxo_Caixa_DAO();

            Fluxo_Caixa_Colecao fluxo_Caixa_Colecao = new Fluxo_Caixa_Colecao();

            fluxo_Caixa_Colecao = fluxo_Caixa_DAO.consultarFluxoCaixa(dtpInicial.Value, dtpFinal.Value);

            dgvFluxoCaixa.DataSource = null;
            dgvFluxoCaixa.DataSource = fluxo_Caixa_Colecao;

            dgvFluxoCaixa.Update();
            dgvFluxoCaixa.Refresh();
        }

        private void calculoTotalCompraVenda()
        {
            decimal valorTotalCompra = 0;
            decimal valorTotalVenda = 0;
            decimal valorTotalRetirado = 0;
            decimal valorTotalDevolucao = 0;
            decimal valorTotalPagamento = 0;
            //decimal valorTotalSaque = 0;
            //decimal valorTotalReforco = 0;

            if (dgvFluxoCaixa.RowCount == 0)
            {
                //MessageBox.Show("A lista esta vazia");
                tbTotalCompra.Text = valorTotalCompra.ToString("C");
                tbTotalVenda.Text = valorTotalVenda.ToString("C");
            }
            else
            {
                for (int i = 0; i <= dgvFluxoCaixa.RowCount - 1; i++)
                {
                    if (dgvFluxoCaixa.Rows[i].Cells[0].Value.ToString() == "RETIRADA")
                        valorTotalRetirado += Convert.ToDecimal(dgvFluxoCaixa.Rows[i].Cells[2].Value);
                }
                for (int i = 0; i <= dgvFluxoCaixa.RowCount - 1; i++)
                {
                    if (dgvFluxoCaixa.Rows[i].Cells[0].Value.ToString() == "DEVOLVEU")
                        valorTotalDevolucao += Convert.ToDecimal(dgvFluxoCaixa.Rows[i].Cells[2].Value);
                }
                for (int i = 0; i <= dgvFluxoCaixa.RowCount - 1; i++)
                {
                    if (dgvFluxoCaixa.Rows[i].Cells[0].Value.ToString() == "PAGAMENTO")
                        valorTotalPagamento += Convert.ToDecimal(dgvFluxoCaixa.Rows[i].Cells[2].Value);
                }
                /*
                for (int i = 0; i <= dgvFluxoCaixa.RowCount - 1; i++)
                {
                    if (dgvFluxoCaixa.Rows[i].Cells[0].Value.ToString() == "SAQUE")
                        valorTotalSaque += Convert.ToDecimal(dgvFluxoCaixa.Rows[i].Cells[2].Value);
                }
                for (int i = 0; i <= dgvFluxoCaixa.RowCount - 1; i++)
                {
                    if (dgvFluxoCaixa.Rows[i].Cells[0].Value.ToString() == "REFORÇO")
                        valorTotalReforco += Convert.ToDecimal(dgvFluxoCaixa.Rows[i].Cells[2].Value);
                }
                */
                dgvFluxoCaixa.CurrentRow.Cells[0].Value.ToString();
                for (int i = 0; i <= dgvFluxoCaixa.RowCount - 1; i++)
                {
                    if (dgvFluxoCaixa.Rows[i].Cells[0].Value.ToString() == "COMPRA")
                        valorTotalCompra += Convert.ToDecimal(dgvFluxoCaixa.Rows[i].Cells[2].Value);
                }

                valorTotalCompra = valorTotalCompra - valorTotalRetirado;

                tbTotalCompra.Text = valorTotalCompra.ToString("C");

                for (int i = 0; i <= dgvFluxoCaixa.RowCount - 1; i++)
                {
                    if (dgvFluxoCaixa.Rows[i].Cells[0].Value.ToString() == "VENDA")
                        valorTotalVenda += Convert.ToDecimal(dgvFluxoCaixa.Rows[i].Cells[2].Value);
                }

                valorTotalVenda = valorTotalVenda - valorTotalDevolucao;

                valorTotalVenda = valorTotalVenda + valorTotalPagamento;

                tbTotalVenda.Text = valorTotalVenda.ToString("C");

            }

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("R$ " + "{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "VENDAS",
                    Values = new ChartValues<decimal> {valorTotalVenda},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "COMPRAS",
                    Values = new ChartValues<decimal> {valorTotalCompra},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;

            decimal lucro_liquido = 0;

            lucro_liquido = valorTotalVenda - valorTotalCompra;
            //lucro_liquido = lucro_liquido - valorTotalSaque;
            //lucro_liquido = lucro_liquido + valorTotalReforco;

            tbLucroDeficit.Text = lucro_liquido.ToString("C");

            if (lucro_liquido < 0)
            {
                this.tbLucroDeficit.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.tbLucroDeficit.ForeColor = System.Drawing.Color.Green;
            }


        }

        private void ibtnFiltrarBusca_Click(object sender, EventArgs e)
        {
            CarregarFluxoCaixa();
            calculoTotalCompraVenda();
        }

        private void dgvFluxoCaixa_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dgvFluxoCaixa_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ibtnPopupInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os Valores de vendas com pagamentos por débito e crédito, os JUROS não são contabilizados" +
                " Então tenha em mente que o Lucro ou deficit para estarem certos, terão que ser subtraidos os juros. ", "Informação");
        }
    }
}