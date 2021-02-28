using LiveCharts;
using LiveCharts.Wpf;
using Loja.DAO;
using Loja.DTO;
using Loja.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Loja.GUI.PAGINA_INICIAL
{
    public partial class RelatorioVendasCompras : Form
    {
        public RelatorioVendasCompras()
        {
            InitializeComponent();
            dgvMEidprodutosComprados.AutoGenerateColumns = false;
            dgvTodosClientesPedidos.AutoGenerateColumns = false;
            dgvMEidprodutos.AutoGenerateColumns = false;
        }

        private void RelatorioVendasCompras_Load(object sender, EventArgs e)
        {
            CarregarMEidprodutoComprados();
            CarregarGraficoTop10ProdutosComprados();
            CarregarTodosClientesPedidos();
            CarregarGraficoTop10Clientes();
            CarregarMEidproduto();
            CarregarGraficoTop10Produtos();
        }


        private void CarregarMEidprodutoComprados()
        {
            Movimento_Estoque_DAO movimento_Estoque_DAO = new Movimento_Estoque_DAO();

            Movimento_Estoque_Colecao movimento_Estoque_Colecao = new Movimento_Estoque_Colecao();

            movimento_Estoque_Colecao = movimento_Estoque_DAO.MEidprodutosComprados();

            dgvMEidprodutosComprados.DataSource = null;

            dgvMEidprodutosComprados.DataSource = movimento_Estoque_Colecao;

            dgvMEidprodutosComprados.Update();
            dgvMEidprodutosComprados.Refresh();
        }


        private void CarregarTodosClientesPedidos()
        {
            Pedido_DAO pedido_DAO = new Pedido_DAO();

            Pedido_Colecao pedido_Colecao = new Pedido_Colecao();

            pedido_Colecao = pedido_DAO.TodosClientesPedidos();

            dgvTodosClientesPedidos.DataSource = null;

            dgvTodosClientesPedidos.DataSource = pedido_Colecao;

            dgvTodosClientesPedidos.Update();
            dgvTodosClientesPedidos.Refresh();
        }

        private void CarregarMEidproduto()
        {
            Movimento_Estoque_DAO movimento_Estoque_DAO = new Movimento_Estoque_DAO();

            Movimento_Estoque_Colecao movimento_Estoque_Colecao = new Movimento_Estoque_Colecao();

            movimento_Estoque_Colecao = movimento_Estoque_DAO.MEidprodutos();

            dgvMEidprodutos.DataSource = null;

            dgvMEidprodutos.DataSource = movimento_Estoque_Colecao;

            dgvMEidprodutos.Update();
            dgvMEidprodutos.Refresh();
        }


        private void CarregarGraficoTop10ProdutosComprados()
        {
            //Sistema.ActiveForm.WindowState = FormWindowState.Minimized;

            //verificar se tem algum registro selecionado
            if (dgvMEidprodutosComprados.SelectedRows.Count == 0)
            {
                //MessageBox.Show("Não existe nenhum produto comprado");
                panelTop10ProdutosComprados.BackColor = System.Drawing.Color.Black;
                return;
            }

            //----------------------------------------------------------------------------//

            int numeroTotalProdutosComprados = dgvMEidprodutosComprados.RowCount;

            Dictionary<string, decimal> nomeprodutocomprado_valor = new Dictionary<string, decimal>();

            for (int i = 0; i <= dgvMEidprodutosComprados.Rows.Count - 1; i++)
            {
                string ID_PRODUTO = dgvMEidprodutosComprados.Rows[i].Cells[0].Value.ToString();

                //criar a conexão
                SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                con.Open();
                SqlCommand cmd = new SqlCommand("uspTop10ProdutosComprado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PRODUTO", ID_PRODUTO);

                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());

                string nome_produto;
                string produto_total_comprado;

                nome_produto = dt.Rows[0]["NOME_PRODUTO"].ToString();
                produto_total_comprado = dt.Rows[0]["TOTAL_PRODUTO_COMPRADO"].ToString();

                con.Close();

                nomeprodutocomprado_valor.Add(nome_produto, Convert.ToDecimal(produto_total_comprado));
            }

            for (int x = 0; x < numeroTotalProdutosComprados; x++)
            {
                var top10produtosComprados = nomeprodutocomprado_valor.OrderBy(pair => pair.Value).ElementAt((nomeprodutocomprado_valor.Count - 1) - x);
                listDicionarioProdutosComprados.Items.Add(top10produtosComprados);
            }

            if (numeroTotalProdutosComprados - 1 == 0)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Comprados"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart3.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart3.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutosComprados - 1 == 1)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Comprados"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart3.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart3.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutosComprados - 1 == 2)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Comprados"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart3.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart3.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutosComprados - 1 == 3)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Comprados"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart3.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart3.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutosComprados - 1 == 4)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Comprados"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart3.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart3.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutosComprados - 1 == 5)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                //-------------------------------PRODUTO NOME 6-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 5;
                string nome_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings6 = nome_produto6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_produto6 = subStrings6[0];
                }

                nome_produto6 = nome_produto6.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 6-------------------------------//

                string valor_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings26 = valor_produto6.Split(',');

                valor_produto6 = subStrings26[1];

                string valor_produto6_inteiro = valor_produto6;

                valor_produto6 = subStrings26[2];

                int tamanho6 = valor_produto6.Length;
                valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

                string valor_produto6_virgula = valor_produto6;

                string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Comprados"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart3.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart3.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutosComprados - 1 == 6)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                //-------------------------------PRODUTO NOME 6-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 5;
                string nome_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings6 = nome_produto6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_produto6 = subStrings6[0];
                }

                nome_produto6 = nome_produto6.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 6-------------------------------//

                string valor_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings26 = valor_produto6.Split(',');

                valor_produto6 = subStrings26[1];

                string valor_produto6_inteiro = valor_produto6;

                valor_produto6 = subStrings26[2];

                int tamanho6 = valor_produto6.Length;
                valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

                string valor_produto6_virgula = valor_produto6;

                string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

                //-------------------------------PRODUTO NOME 7-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 6;
                string nome_produto7 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings7 = nome_produto7.Split(',');

                foreach (string str in subStrings7)
                {
                    nome_produto7 = subStrings7[0];
                }

                nome_produto7 = nome_produto7.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 7-------------------------------//

                string valor_produto7 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings27 = valor_produto7.Split(',');

                valor_produto7 = subStrings27[1];

                string valor_produto7_inteiro = valor_produto7;

                valor_produto7 = subStrings27[2];

                int tamanho7 = valor_produto7.Length;
                valor_produto7 = valor_produto7.Substring(0, tamanho7 - 1);

                string valor_produto7_virgula = valor_produto7;

                string valor_produto7_final = valor_produto7_inteiro + "," + valor_produto7_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto7,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto7_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Comprados"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart3.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart3.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutosComprados - 1 == 7)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                //-------------------------------PRODUTO NOME 6-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 5;
                string nome_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings6 = nome_produto6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_produto6 = subStrings6[0];
                }

                nome_produto6 = nome_produto6.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 6-------------------------------//

                string valor_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings26 = valor_produto6.Split(',');

                valor_produto6 = subStrings26[1];

                string valor_produto6_inteiro = valor_produto6;

                valor_produto6 = subStrings26[2];

                int tamanho6 = valor_produto6.Length;
                valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

                string valor_produto6_virgula = valor_produto6;

                string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

                //-------------------------------PRODUTO NOME 7-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 6;
                string nome_produto7 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings7 = nome_produto7.Split(',');

                foreach (string str in subStrings7)
                {
                    nome_produto7 = subStrings7[0];
                }

                nome_produto7 = nome_produto7.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 7-------------------------------//

                string valor_produto7 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings27 = valor_produto7.Split(',');

                valor_produto7 = subStrings27[1];

                string valor_produto7_inteiro = valor_produto7;

                valor_produto7 = subStrings27[2];

                int tamanho7 = valor_produto7.Length;
                valor_produto7 = valor_produto7.Substring(0, tamanho7 - 1);

                string valor_produto7_virgula = valor_produto7;

                string valor_produto7_final = valor_produto7_inteiro + "," + valor_produto7_virgula;

                //-------------------------------PRODUTO NOME 8-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 7;
                string nome_produto8 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings8 = nome_produto8.Split(',');

                foreach (string str in subStrings8)
                {
                    nome_produto8 = subStrings8[0];
                }

                nome_produto8 = nome_produto8.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 8-------------------------------//

                string valor_produto8 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings28 = valor_produto8.Split(',');

                valor_produto8 = subStrings28[1];

                string valor_produto8_inteiro = valor_produto8;

                valor_produto8 = subStrings28[2];

                int tamanho8 = valor_produto8.Length;
                valor_produto8 = valor_produto8.Substring(0, tamanho8 - 1);

                string valor_produto8_virgula = valor_produto8;

                string valor_produto8_final = valor_produto8_inteiro + "," + valor_produto8_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto7,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto7_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto8,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto8_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Comprados"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart3.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart3.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutosComprados - 1 == 8)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                //-------------------------------PRODUTO NOME 6-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 5;
                string nome_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings6 = nome_produto6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_produto6 = subStrings6[0];
                }

                nome_produto6 = nome_produto6.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 6-------------------------------//

                string valor_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings26 = valor_produto6.Split(',');

                valor_produto6 = subStrings26[1];

                string valor_produto6_inteiro = valor_produto6;

                valor_produto6 = subStrings26[2];

                int tamanho6 = valor_produto6.Length;
                valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

                string valor_produto6_virgula = valor_produto6;

                string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

                //-------------------------------PRODUTO NOME 7-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 6;
                string nome_produto7 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings7 = nome_produto7.Split(',');

                foreach (string str in subStrings7)
                {
                    nome_produto7 = subStrings7[0];
                }

                nome_produto7 = nome_produto7.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 7-------------------------------//

                string valor_produto7 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings27 = valor_produto7.Split(',');

                valor_produto7 = subStrings27[1];

                string valor_produto7_inteiro = valor_produto7;

                valor_produto7 = subStrings27[2];

                int tamanho7 = valor_produto7.Length;
                valor_produto7 = valor_produto7.Substring(0, tamanho7 - 1);

                string valor_produto7_virgula = valor_produto7;

                string valor_produto7_final = valor_produto7_inteiro + "," + valor_produto7_virgula;

                //-------------------------------PRODUTO NOME 8-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 7;
                string nome_produto8 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings8 = nome_produto8.Split(',');

                foreach (string str in subStrings8)
                {
                    nome_produto8 = subStrings8[0];
                }

                nome_produto8 = nome_produto8.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 8-------------------------------//

                string valor_produto8 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings28 = valor_produto8.Split(',');

                valor_produto8 = subStrings28[1];

                string valor_produto8_inteiro = valor_produto8;

                valor_produto8 = subStrings28[2];

                int tamanho8 = valor_produto8.Length;
                valor_produto8 = valor_produto8.Substring(0, tamanho8 - 1);

                string valor_produto8_virgula = valor_produto8;

                string valor_produto8_final = valor_produto8_inteiro + "," + valor_produto8_virgula;

                //-------------------------------PRODUTO NOME 9-------------------------------//

                listDicionarioProdutosComprados.SelectedIndex = 8;
                string nome_produto9 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings9 = nome_produto9.Split(',');

                foreach (string str in subStrings9)
                {
                    nome_produto9 = subStrings9[0];
                }

                nome_produto9 = nome_produto9.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 9-------------------------------//

                string valor_produto9 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

                string[] subStrings29 = valor_produto9.Split(',');

                valor_produto9 = subStrings29[1];

                string valor_produto9_inteiro = valor_produto9;

                valor_produto9 = subStrings29[2];

                int tamanho9 = valor_produto9.Length;
                valor_produto9 = valor_produto9.Substring(0, tamanho9 - 1);

                string valor_produto9_virgula = valor_produto9;

                string valor_produto9_final = valor_produto9_inteiro + "," + valor_produto9_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto7,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto7_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto8,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto8_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.Series.Add(new ColumnSeries
                {
                    Title = nome_produto9,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto9_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart3.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Comprados"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart3.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart3.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutosComprados - 1 == 9)
            {
                graficoProduto10Comprados();
            }
            else
            {
                graficoProduto10Comprados();
            }



        }

        private void graficoProduto10Comprados()
        {
            //-------------------------------PRODUTO NOME 1-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 0;
            string nome_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings = nome_produto1.Split(',');

            foreach (string str in subStrings)
            {
                nome_produto1 = subStrings[0];
            }

            nome_produto1 = nome_produto1.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 1-------------------------------//

            string valor_produto1 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings21 = valor_produto1.Split(',');

            valor_produto1 = subStrings21[1];

            string valor_produto1_inteiro = valor_produto1;

            valor_produto1 = subStrings21[2];

            int tamanho1 = valor_produto1.Length;
            valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

            string valor_produto1_virgula = valor_produto1;

            string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

            //-------------------------------PRODUTO NOME 2-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 1;
            string nome_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings2 = nome_produto2.Split(',');

            foreach (string str in subStrings2)
            {
                nome_produto2 = subStrings2[0];
            }

            nome_produto2 = nome_produto2.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 2-------------------------------//

            string valor_produto2 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings22 = valor_produto2.Split(',');

            valor_produto2 = subStrings22[1];

            string valor_produto2_inteiro = valor_produto2;

            valor_produto2 = subStrings22[2];

            int tamanho2 = valor_produto2.Length;
            valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

            string valor_produto2_virgula = valor_produto2;

            string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

            //-------------------------------PRODUTO NOME 3-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 2;
            string nome_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings3 = nome_produto3.Split(',');

            foreach (string str in subStrings3)
            {
                nome_produto3 = subStrings3[0];
            }

            nome_produto3 = nome_produto3.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 3-------------------------------//

            string valor_produto3 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings23 = valor_produto3.Split(',');

            valor_produto3 = subStrings23[1];

            string valor_produto3_inteiro = valor_produto3;

            valor_produto3 = subStrings23[2];

            int tamanho3 = valor_produto3.Length;
            valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

            string valor_produto3_virgula = valor_produto3;

            string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

            //-------------------------------PRODUTO NOME 4-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 3;
            string nome_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings4 = nome_produto4.Split(',');

            foreach (string str in subStrings4)
            {
                nome_produto4 = subStrings4[0];
            }

            nome_produto4 = nome_produto4.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 4-------------------------------//

            string valor_produto4 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings24 = valor_produto4.Split(',');

            valor_produto4 = subStrings24[1];

            string valor_produto4_inteiro = valor_produto4;

            valor_produto4 = subStrings24[2];

            int tamanho4 = valor_produto4.Length;
            valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

            string valor_produto4_virgula = valor_produto4;

            string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

            //-------------------------------PRODUTO NOME 5-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 4;
            string nome_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings5 = nome_produto5.Split(',');

            foreach (string str in subStrings5)
            {
                nome_produto5 = subStrings5[0];
            }

            nome_produto5 = nome_produto5.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 5-------------------------------//

            string valor_produto5 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings25 = valor_produto5.Split(',');

            valor_produto5 = subStrings25[1];

            string valor_produto5_inteiro = valor_produto5;

            valor_produto5 = subStrings25[2];

            int tamanho5 = valor_produto5.Length;
            valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

            string valor_produto5_virgula = valor_produto5;

            string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

            //-------------------------------PRODUTO NOME 6-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 5;
            string nome_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings6 = nome_produto6.Split(',');

            foreach (string str in subStrings6)
            {
                nome_produto6 = subStrings6[0];
            }

            nome_produto6 = nome_produto6.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 6-------------------------------//

            string valor_produto6 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings26 = valor_produto6.Split(',');

            valor_produto6 = subStrings26[1];

            string valor_produto6_inteiro = valor_produto6;

            valor_produto6 = subStrings26[2];

            int tamanho6 = valor_produto6.Length;
            valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

            string valor_produto6_virgula = valor_produto6;

            string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

            //-------------------------------PRODUTO NOME 7-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 6;
            string nome_produto7 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings7 = nome_produto7.Split(',');

            foreach (string str in subStrings7)
            {
                nome_produto7 = subStrings7[0];
            }

            nome_produto7 = nome_produto7.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 7-------------------------------//

            string valor_produto7 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings27 = valor_produto7.Split(',');

            valor_produto7 = subStrings27[1];

            string valor_produto7_inteiro = valor_produto7;

            valor_produto7 = subStrings27[2];

            int tamanho7 = valor_produto7.Length;
            valor_produto7 = valor_produto7.Substring(0, tamanho7 - 1);

            string valor_produto7_virgula = valor_produto7;

            string valor_produto7_final = valor_produto7_inteiro + "," + valor_produto7_virgula;

            //-------------------------------PRODUTO NOME 8-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 7;
            string nome_produto8 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings8 = nome_produto8.Split(',');

            foreach (string str in subStrings8)
            {
                nome_produto8 = subStrings8[0];
            }

            nome_produto8 = nome_produto8.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 8-------------------------------//

            string valor_produto8 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings28 = valor_produto8.Split(',');

            valor_produto8 = subStrings28[1];

            string valor_produto8_inteiro = valor_produto8;

            valor_produto8 = subStrings28[2];

            int tamanho8 = valor_produto8.Length;
            valor_produto8 = valor_produto8.Substring(0, tamanho8 - 1);

            string valor_produto8_virgula = valor_produto8;

            string valor_produto8_final = valor_produto8_inteiro + "," + valor_produto8_virgula;

            //-------------------------------PRODUTO NOME 9-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 8;
            string nome_produto9 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings9 = nome_produto9.Split(',');

            foreach (string str in subStrings9)
            {
                nome_produto9 = subStrings9[0];
            }

            nome_produto9 = nome_produto9.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 9-------------------------------//

            string valor_produto9 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings29 = valor_produto9.Split(',');

            valor_produto9 = subStrings29[1];

            string valor_produto9_inteiro = valor_produto9;

            valor_produto9 = subStrings29[2];

            int tamanho9 = valor_produto9.Length;
            valor_produto9 = valor_produto9.Substring(0, tamanho9 - 1);

            string valor_produto9_virgula = valor_produto9;

            string valor_produto9_final = valor_produto9_inteiro + "," + valor_produto9_virgula;

            //-------------------------------PRODUTO NOME 10-------------------------------//

            listDicionarioProdutosComprados.SelectedIndex = 9;
            string nome_produto10 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings10 = nome_produto10.Split(',');

            foreach (string str in subStrings10)
            {
                nome_produto10 = subStrings10[0];
            }

            nome_produto10 = nome_produto10.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 10-------------------------------//

            string valor_produto10 = listDicionarioProdutosComprados.GetItemText(listDicionarioProdutosComprados.SelectedItem);

            string[] subStrings30 = valor_produto10.Split(',');

            valor_produto10 = subStrings30[1];

            string valor_produto10_inteiro = valor_produto10;

            valor_produto10 = subStrings30[2];

            int tamanho10 = valor_produto10.Length;
            valor_produto10 = valor_produto10.Substring(0, tamanho10 - 1);

            string valor_produto10_virgula = valor_produto10;

            string valor_produto10_final = valor_produto10_inteiro + "," + valor_produto10_virgula;

            /////////////////////////////////////////////////////////////////////////////////

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto1,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto2,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto3,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto4,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto5,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto6,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto7,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto7_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto8,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto8_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto9,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto9_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.Series.Add(new ColumnSeries
            {
                Title = nome_produto10,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto10_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart3.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                        "TOP 10: Produtos mais Comprados"
                    },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                },
                LabelsRotation = 0
            });

            cartesianChart3.AxisY.Add(new Axis
            {
                Title = "Valor Produto (R$)",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart3.LegendLocation = LegendLocation.Right;
        }


        private void CarregarGraficoTop10Clientes()
        {
            if (dgvTodosClientesPedidos.SelectedRows.Count == 0)
            {
                //MessageBox.Show("Não existe nenhuma venda para nenhum cliente");
                panelTop10Clientes.BackColor = System.Drawing.Color.Black;
                return;
            }

            //----------------------------------------------------------------------------//

            int numeroTotalClientes = dgvTodosClientesPedidos.RowCount;

            int numeroClientesCalculados = 0;

            Dictionary<string, decimal> nomecliente_valor = new Dictionary<string, decimal>();

            for (int i = 0; i <= dgvTodosClientesPedidos.Rows.Count - 1; i++)
            {
                string ID_CLIENTE = dgvTodosClientesPedidos.Rows[i].Cells[0].Value.ToString();

                //criar a conexão
                SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                con.Open();
                SqlCommand cmd = new SqlCommand("uspTop10Clientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CLIENTE", ID_CLIENTE);

                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());

                string nome_cliente = "";
                string cliente_total = "";

                if(dt.Rows.Count != 0)
                {
                    nome_cliente = dt.Rows[0]["NOME_CLIENTE"].ToString();
                    cliente_total = dt.Rows[0]["VALOR_TOTAL_CLIENTE"].ToString();

                    if (cliente_total == "")
                    {
                        cliente_total = "0";
                    }

                    nomecliente_valor.Add(nome_cliente, Convert.ToDecimal(cliente_total));

                    numeroClientesCalculados += 1;
                }

                con.Close();
 
            }

            

            for (int x = 0; x < numeroClientesCalculados; x++)
            {
                var top10clientes = nomecliente_valor.OrderBy(pair => pair.Value).ElementAt((nomecliente_valor.Count - 1) - x);
                listDicionarioClientes.Items.Add(top10clientes);
            }

            if (numeroClientesCalculados - 1 == 0)
            {
                //-------------------------------CLIENTE NOME 1-------------------------------//

                listDicionarioClientes.SelectedIndex = 0;
                string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings = nome_cliente1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_cliente1 = subStrings[0];
                }

                nome_cliente1 = nome_cliente1.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 1-------------------------------//

                string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

                valor_cliente1 = valor_cliente1.Replace("]", "");

                valor_cliente1 = valor_cliente1.Replace(" ", "");

                string[] subStrings21 = valor_cliente1.Split(',');

                valor_cliente1 = subStrings21[1];

                string valor_cliente1_inteiro = valor_cliente1;

                if (numVirgulas1 == 2)
                {
                    valor_cliente1 = subStrings21[2];
                }

                int tamanho1 = valor_cliente1.Length;
                valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

                string valor_cliente1_virgula = valor_cliente1;

                string valor_cliente1_final = "0";

                if (valor_cliente1_inteiro != "0")
                {
                    valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
                }

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Clientes que mais Compraram"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart2.AxisY.Add(new Axis
                {
                    Title = "Valor Total Cliente (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart2.LegendLocation = LegendLocation.Right;
            }
            else if (numeroClientesCalculados - 1 == 1)
            {
                //-------------------------------CLIENTE NOME 1-------------------------------//

                listDicionarioClientes.SelectedIndex = 0;
                string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings = nome_cliente1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_cliente1 = subStrings[0];
                }

                nome_cliente1 = nome_cliente1.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 1-------------------------------//

                string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

                valor_cliente1 = valor_cliente1.Replace("]", "");

                valor_cliente1 = valor_cliente1.Replace(" ", "");

                string[] subStrings21 = valor_cliente1.Split(',');

                valor_cliente1 = subStrings21[1];

                string valor_cliente1_inteiro = valor_cliente1;

                if (numVirgulas1 == 2)
                {
                    valor_cliente1 = subStrings21[2];
                }

                int tamanho1 = valor_cliente1.Length;
                valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

                string valor_cliente1_virgula = valor_cliente1;

                string valor_cliente1_final = "0";

                if (valor_cliente1_inteiro != "0")
                {
                    valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
                }

                //-------------------------------CLIENTE NOME 2-------------------------------//

                listDicionarioClientes.SelectedIndex = 1;
                string nome_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings2 = nome_cliente2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_cliente2 = subStrings2[0];
                }

                nome_cliente2 = nome_cliente2.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 2-------------------------------//

                string valor_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas2 = valor_cliente2.Split(',').Length - 1;

                valor_cliente2 = valor_cliente2.Replace("]", "");

                valor_cliente2 = valor_cliente2.Replace(" ", "");

                string[] subStrings22 = valor_cliente2.Split(',');

                valor_cliente2 = subStrings22[1];

                string valor_cliente2_inteiro = valor_cliente2;

                if(numVirgulas2 == 2)
                {
                    valor_cliente2 = subStrings22[2];
                }

                int tamanho2 = valor_cliente2.Length;
                valor_cliente2 = valor_cliente2.Substring(0, tamanho2);

                string valor_cliente2_virgula = valor_cliente2;

                string valor_cliente2_final = "0";

                if (valor_cliente2_inteiro != "0")
                {
                    valor_cliente2_final = valor_cliente2_inteiro + "," + valor_cliente2_virgula;
                }

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Clientes que mais Compraram"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart2.AxisY.Add(new Axis
                {
                    Title = "Valor Total Cliente (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart2.LegendLocation = LegendLocation.Right;
            }
            else if (numeroClientesCalculados - 1 == 2)
            {
                //-------------------------------CLIENTE NOME 1-------------------------------//

                listDicionarioClientes.SelectedIndex = 0;
                string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings = nome_cliente1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_cliente1 = subStrings[0];
                }

                nome_cliente1 = nome_cliente1.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 1-------------------------------//

                string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

                valor_cliente1 = valor_cliente1.Replace("]", "");

                valor_cliente1 = valor_cliente1.Replace(" ", "");

                string[] subStrings21 = valor_cliente1.Split(',');

                valor_cliente1 = subStrings21[1];

                string valor_cliente1_inteiro = valor_cliente1;

                if (numVirgulas1 == 2)
                {
                    valor_cliente1 = subStrings21[2];
                }

                int tamanho1 = valor_cliente1.Length;
                valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

                string valor_cliente1_virgula = valor_cliente1;

                string valor_cliente1_final = "0";

                if (valor_cliente1_inteiro != "0")
                {
                    valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
                }

                //-------------------------------CLIENTE NOME 2-------------------------------//

                listDicionarioClientes.SelectedIndex = 1;
                string nome_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings2 = nome_cliente2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_cliente2 = subStrings2[0];
                }

                nome_cliente2 = nome_cliente2.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 2-------------------------------//

                string valor_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas2 = valor_cliente2.Split(',').Length - 1;

                valor_cliente2 = valor_cliente2.Replace("]", "");

                valor_cliente2 = valor_cliente2.Replace(" ", "");

                string[] subStrings22 = valor_cliente2.Split(',');

                valor_cliente2 = subStrings22[1];

                string valor_cliente2_inteiro = valor_cliente2;

                if (numVirgulas2 == 2)
                {
                    valor_cliente2 = subStrings22[2];
                }

                int tamanho2 = valor_cliente2.Length;
                valor_cliente2 = valor_cliente2.Substring(0, tamanho2);

                string valor_cliente2_virgula = valor_cliente2;

                string valor_cliente2_final = "0";

                if (valor_cliente2_inteiro != "0")
                {
                    valor_cliente2_final = valor_cliente2_inteiro + "," + valor_cliente2_virgula;
                }

                //-------------------------------CLIENTE NOME 3-------------------------------//

                listDicionarioClientes.SelectedIndex = 2;
                string nome_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings3 = nome_cliente3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_cliente3 = subStrings3[0];
                }

                nome_cliente3 = nome_cliente3.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 3-------------------------------//

                string valor_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas3 = valor_cliente3.Split(',').Length - 1;

                valor_cliente3 = valor_cliente3.Replace("]", "");

                valor_cliente3 = valor_cliente3.Replace(" ", "");

                string[] subStrings23 = valor_cliente3.Split(',');

                valor_cliente3 = subStrings23[1];

                string valor_cliente3_inteiro = valor_cliente3;

                if (numVirgulas3 == 2)
                {
                    valor_cliente3 = subStrings23[2];
                }

                int tamanho3 = valor_cliente3.Length;
                valor_cliente3 = valor_cliente3.Substring(0, tamanho3);

                string valor_cliente3_virgula = valor_cliente3;

                string valor_cliente3_final = "0";

                if (valor_cliente3_inteiro != "0")
                {
                    valor_cliente3_final = valor_cliente3_inteiro + "," + valor_cliente3_virgula;
                }

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Clientes que mais Compraram"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart2.AxisY.Add(new Axis
                {
                    Title = "Valor Total Cliente (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart2.LegendLocation = LegendLocation.Right;
            }
            else if (numeroClientesCalculados - 1 == 3)
            {
                //-------------------------------CLIENTE NOME 1-------------------------------//

                listDicionarioClientes.SelectedIndex = 0;
                string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings = nome_cliente1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_cliente1 = subStrings[0];
                }

                nome_cliente1 = nome_cliente1.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 1-------------------------------//

                string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

                valor_cliente1 = valor_cliente1.Replace("]", "");

                valor_cliente1 = valor_cliente1.Replace(" ", "");

                string[] subStrings21 = valor_cliente1.Split(',');

                valor_cliente1 = subStrings21[1];

                string valor_cliente1_inteiro = valor_cliente1;

                if (numVirgulas1 == 2)
                {
                    valor_cliente1 = subStrings21[2];
                }

                int tamanho1 = valor_cliente1.Length;
                valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

                string valor_cliente1_virgula = valor_cliente1;

                string valor_cliente1_final = "0";

                if (valor_cliente1_inteiro != "0")
                {
                    valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
                }

                //-------------------------------CLIENTE NOME 2-------------------------------//

                listDicionarioClientes.SelectedIndex = 1;
                string nome_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings2 = nome_cliente2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_cliente2 = subStrings2[0];
                }

                nome_cliente2 = nome_cliente2.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 2-------------------------------//

                string valor_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas2 = valor_cliente2.Split(',').Length - 1;

                valor_cliente2 = valor_cliente2.Replace("]", "");

                valor_cliente2 = valor_cliente2.Replace(" ", "");

                string[] subStrings22 = valor_cliente2.Split(',');

                valor_cliente2 = subStrings22[1];

                string valor_cliente2_inteiro = valor_cliente2;

                if (numVirgulas2 == 2)
                {
                    valor_cliente2 = subStrings22[2];
                }

                int tamanho2 = valor_cliente2.Length;
                valor_cliente2 = valor_cliente2.Substring(0, tamanho2);

                string valor_cliente2_virgula = valor_cliente2;

                string valor_cliente2_final = "0";

                if (valor_cliente2_inteiro != "0")
                {
                    valor_cliente2_final = valor_cliente2_inteiro + "," + valor_cliente2_virgula;
                }

                //-------------------------------CLIENTE NOME 3-------------------------------//

                listDicionarioClientes.SelectedIndex = 2;
                string nome_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings3 = nome_cliente3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_cliente3 = subStrings3[0];
                }

                nome_cliente3 = nome_cliente3.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 3-------------------------------//

                string valor_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas3 = valor_cliente3.Split(',').Length - 1;

                valor_cliente3 = valor_cliente3.Replace("]", "");

                valor_cliente3 = valor_cliente3.Replace(" ", "");

                string[] subStrings23 = valor_cliente3.Split(',');

                valor_cliente3 = subStrings23[1];

                string valor_cliente3_inteiro = valor_cliente3;

                if (numVirgulas3 == 2)
                {
                    valor_cliente3 = subStrings23[2];
                }

                int tamanho3 = valor_cliente3.Length;
                valor_cliente3 = valor_cliente3.Substring(0, tamanho3);

                string valor_cliente3_virgula = valor_cliente3;

                string valor_cliente3_final = "0";

                if (valor_cliente3_inteiro != "0")
                {
                    valor_cliente3_final = valor_cliente3_inteiro + "," + valor_cliente3_virgula;
                }

                //-------------------------------CLIENTE NOME 4-------------------------------//

                listDicionarioClientes.SelectedIndex = 3;
                string nome_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings4 = nome_cliente4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_cliente4 = subStrings4[0];
                }

                nome_cliente4 = nome_cliente4.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 4-------------------------------//

                string valor_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas4 = valor_cliente4.Split(',').Length - 1;

                valor_cliente4 = valor_cliente4.Replace("]", "");

                valor_cliente4 = valor_cliente4.Replace(" ", "");

                string[] subStrings24 = valor_cliente4.Split(',');

                valor_cliente4 = subStrings24[1];

                string valor_cliente4_inteiro = valor_cliente4;

                if (numVirgulas4 == 2)
                {
                    valor_cliente4 = subStrings24[2];
                }

                int tamanho4 = valor_cliente4.Length;
                valor_cliente4 = valor_cliente4.Substring(0, tamanho4);

                string valor_cliente4_virgula = valor_cliente4;

                string valor_cliente4_final = "0";

                if (valor_cliente4_inteiro != "0")
                {
                    valor_cliente4_final = valor_cliente4_inteiro + "," + valor_cliente4_virgula;
                }
                    
                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Clientes que mais Compraram"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart2.AxisY.Add(new Axis
                {
                    Title = "Valor Total Cliente (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart2.LegendLocation = LegendLocation.Right;
            }
            else if (numeroClientesCalculados - 1 == 4)
            {
                //-------------------------------CLIENTE NOME 1-------------------------------//

                listDicionarioClientes.SelectedIndex = 0;
                string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings = nome_cliente1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_cliente1 = subStrings[0];
                }

                nome_cliente1 = nome_cliente1.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 1-------------------------------//

                string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

                valor_cliente1 = valor_cliente1.Replace("]", "");

                valor_cliente1 = valor_cliente1.Replace(" ", "");

                string[] subStrings21 = valor_cliente1.Split(',');

                valor_cliente1 = subStrings21[1];

                string valor_cliente1_inteiro = valor_cliente1;

                if (numVirgulas1 == 2)
                {
                    valor_cliente1 = subStrings21[2];
                }

                int tamanho1 = valor_cliente1.Length;
                valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

                string valor_cliente1_virgula = valor_cliente1;

                string valor_cliente1_final = "0";

                if (valor_cliente1_inteiro != "0")
                {
                    valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
                }

                //-------------------------------CLIENTE NOME 2-------------------------------//

                listDicionarioClientes.SelectedIndex = 1;
                string nome_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings2 = nome_cliente2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_cliente2 = subStrings2[0];
                }

                nome_cliente2 = nome_cliente2.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 2-------------------------------//

                string valor_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas2 = valor_cliente2.Split(',').Length - 1;

                valor_cliente2 = valor_cliente2.Replace("]", "");

                valor_cliente2 = valor_cliente2.Replace(" ", "");

                string[] subStrings22 = valor_cliente2.Split(',');

                valor_cliente2 = subStrings22[1];

                string valor_cliente2_inteiro = valor_cliente2;

                if (numVirgulas2 == 2)
                {
                    valor_cliente2 = subStrings22[2];
                }

                int tamanho2 = valor_cliente2.Length;
                valor_cliente2 = valor_cliente2.Substring(0, tamanho2);

                string valor_cliente2_virgula = valor_cliente2;

                string valor_cliente2_final = "0";

                if (valor_cliente2_inteiro != "0")
                {
                    valor_cliente2_final = valor_cliente2_inteiro + "," + valor_cliente2_virgula;
                }

                //-------------------------------CLIENTE NOME 3-------------------------------//

                listDicionarioClientes.SelectedIndex = 2;
                string nome_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings3 = nome_cliente3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_cliente3 = subStrings3[0];
                }

                nome_cliente3 = nome_cliente3.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 3-------------------------------//

                string valor_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas3 = valor_cliente3.Split(',').Length - 1;

                valor_cliente3 = valor_cliente3.Replace("]", "");

                valor_cliente3 = valor_cliente3.Replace(" ", "");

                string[] subStrings23 = valor_cliente3.Split(',');

                valor_cliente3 = subStrings23[1];

                string valor_cliente3_inteiro = valor_cliente3;

                if (numVirgulas3 == 2)
                {
                    valor_cliente3 = subStrings23[2];
                }

                int tamanho3 = valor_cliente3.Length;
                valor_cliente3 = valor_cliente3.Substring(0, tamanho3);

                string valor_cliente3_virgula = valor_cliente3;

                string valor_cliente3_final = "0";

                if (valor_cliente3_inteiro != "0")
                {
                    valor_cliente3_final = valor_cliente3_inteiro + "," + valor_cliente3_virgula;
                }

                //-------------------------------CLIENTE NOME 4-------------------------------//

                listDicionarioClientes.SelectedIndex = 3;
                string nome_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings4 = nome_cliente4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_cliente4 = subStrings4[0];
                }

                nome_cliente4 = nome_cliente4.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 4-------------------------------//

                string valor_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas4 = valor_cliente4.Split(',').Length - 1;

                valor_cliente4 = valor_cliente4.Replace("]", "");

                valor_cliente4 = valor_cliente4.Replace(" ", "");

                string[] subStrings24 = valor_cliente4.Split(',');

                valor_cliente4 = subStrings24[1];

                string valor_cliente4_inteiro = valor_cliente4;

                if (numVirgulas4 == 2)
                {
                    valor_cliente4 = subStrings24[2];
                }

                int tamanho4 = valor_cliente4.Length;
                valor_cliente4 = valor_cliente4.Substring(0, tamanho4);

                string valor_cliente4_virgula = valor_cliente4;

                string valor_cliente4_final = "0";

                if (valor_cliente4_inteiro != "0")
                {
                    valor_cliente4_final = valor_cliente4_inteiro + "," + valor_cliente4_virgula;
                }

                //-------------------------------CLIENTE NOME 5-------------------------------//

                listDicionarioClientes.SelectedIndex = 4;
                string nome_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings5 = nome_cliente5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_cliente5 = subStrings5[0];
                }

                nome_cliente5 = nome_cliente5.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 5-------------------------------//

                string valor_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas5 = valor_cliente5.Split(',').Length - 1;

                valor_cliente5 = valor_cliente5.Replace("]", "");

                valor_cliente5 = valor_cliente5.Replace(" ", "");

                string[] subStrings25 = valor_cliente5.Split(',');

                valor_cliente5 = subStrings25[1];

                string valor_cliente5_inteiro = valor_cliente5;

                if (numVirgulas5 == 2)
                {
                    valor_cliente5 = subStrings25[2];
                }

                int tamanho5 = valor_cliente5.Length;
                valor_cliente5 = valor_cliente5.Substring(0, tamanho5);

                string valor_cliente5_virgula = valor_cliente5;

                string valor_cliente5_final = "0";

                if (valor_cliente4_inteiro != "0")
                {
                    valor_cliente5_final = valor_cliente5_inteiro + "," + valor_cliente5_virgula;
                }

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Clientes que mais Compraram"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart2.AxisY.Add(new Axis
                {
                    Title = "Valor Total Cliente (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart2.LegendLocation = LegendLocation.Right;
            }
            else if (numeroClientesCalculados - 1 == 5)
            {
                //-------------------------------CLIENTE NOME 1-------------------------------//

                listDicionarioClientes.SelectedIndex = 0;
                string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings = nome_cliente1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_cliente1 = subStrings[0];
                }

                nome_cliente1 = nome_cliente1.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 1-------------------------------//

                string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

                valor_cliente1 = valor_cliente1.Replace("]", "");

                valor_cliente1 = valor_cliente1.Replace(" ", "");

                string[] subStrings21 = valor_cliente1.Split(',');

                valor_cliente1 = subStrings21[1];

                string valor_cliente1_inteiro = valor_cliente1;

                if (numVirgulas1 == 2)
                {
                    valor_cliente1 = subStrings21[2];
                }

                int tamanho1 = valor_cliente1.Length;
                valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

                string valor_cliente1_virgula = valor_cliente1;

                string valor_cliente1_final = "0";

                if (valor_cliente1_inteiro != "0")
                {
                    valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
                }

                //-------------------------------CLIENTE NOME 2-------------------------------//

                listDicionarioClientes.SelectedIndex = 1;
                string nome_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings2 = nome_cliente2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_cliente2 = subStrings2[0];
                }

                nome_cliente2 = nome_cliente2.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 2-------------------------------//

                string valor_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas2 = valor_cliente2.Split(',').Length - 1;

                valor_cliente2 = valor_cliente2.Replace("]", "");

                valor_cliente2 = valor_cliente2.Replace(" ", "");

                string[] subStrings22 = valor_cliente2.Split(',');

                valor_cliente2 = subStrings22[1];

                string valor_cliente2_inteiro = valor_cliente2;

                if (numVirgulas2 == 2)
                {
                    valor_cliente2 = subStrings22[2];
                }

                int tamanho2 = valor_cliente2.Length;
                valor_cliente2 = valor_cliente2.Substring(0, tamanho2);

                string valor_cliente2_virgula = valor_cliente2;

                string valor_cliente2_final = "0";

                if (valor_cliente2_inteiro != "0")
                {
                    valor_cliente2_final = valor_cliente2_inteiro + "," + valor_cliente2_virgula;
                }

                //-------------------------------CLIENTE NOME 3-------------------------------//

                listDicionarioClientes.SelectedIndex = 2;
                string nome_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings3 = nome_cliente3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_cliente3 = subStrings3[0];
                }

                nome_cliente3 = nome_cliente3.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 3-------------------------------//

                string valor_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas3 = valor_cliente3.Split(',').Length - 1;

                valor_cliente3 = valor_cliente3.Replace("]", "");

                valor_cliente3 = valor_cliente3.Replace(" ", "");

                string[] subStrings23 = valor_cliente3.Split(',');

                valor_cliente3 = subStrings23[1];

                string valor_cliente3_inteiro = valor_cliente3;

                if (numVirgulas3 == 2)
                {
                    valor_cliente3 = subStrings23[2];
                }

                int tamanho3 = valor_cliente3.Length;
                valor_cliente3 = valor_cliente3.Substring(0, tamanho3);

                string valor_cliente3_virgula = valor_cliente3;

                string valor_cliente3_final = "0";

                if (valor_cliente3_inteiro != "0")
                {
                    valor_cliente3_final = valor_cliente3_inteiro + "," + valor_cliente3_virgula;
                }

                //-------------------------------CLIENTE NOME 4-------------------------------//

                listDicionarioClientes.SelectedIndex = 3;
                string nome_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings4 = nome_cliente4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_cliente4 = subStrings4[0];
                }

                nome_cliente4 = nome_cliente4.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 4-------------------------------//

                string valor_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas4 = valor_cliente4.Split(',').Length - 1;

                valor_cliente4 = valor_cliente4.Replace("]", "");

                valor_cliente4 = valor_cliente4.Replace(" ", "");

                string[] subStrings24 = valor_cliente4.Split(',');

                valor_cliente4 = subStrings24[1];

                string valor_cliente4_inteiro = valor_cliente4;

                if (numVirgulas4 == 2)
                {
                    valor_cliente4 = subStrings24[2];
                }

                int tamanho4 = valor_cliente4.Length;
                valor_cliente4 = valor_cliente4.Substring(0, tamanho4);

                string valor_cliente4_virgula = valor_cliente4;

                string valor_cliente4_final = "0";

                if (valor_cliente4_inteiro != "0")
                {
                    valor_cliente4_final = valor_cliente4_inteiro + "," + valor_cliente4_virgula;
                }

                //-------------------------------CLIENTE NOME 5-------------------------------//

                listDicionarioClientes.SelectedIndex = 4;
                string nome_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings5 = nome_cliente5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_cliente5 = subStrings5[0];
                }

                nome_cliente5 = nome_cliente5.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 5-------------------------------//

                string valor_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas5 = valor_cliente5.Split(',').Length - 1;

                valor_cliente5 = valor_cliente5.Replace("]", "");

                valor_cliente5 = valor_cliente5.Replace(" ", "");

                string[] subStrings25 = valor_cliente5.Split(',');

                valor_cliente5 = subStrings25[1];

                string valor_cliente5_inteiro = valor_cliente5;

                if (numVirgulas5 == 2)
                {
                    valor_cliente5 = subStrings25[2];
                }

                int tamanho5 = valor_cliente5.Length;
                valor_cliente5 = valor_cliente5.Substring(0, tamanho5);

                string valor_cliente5_virgula = valor_cliente5;

                string valor_cliente5_final = "0";

                if (valor_cliente5_inteiro != "0")
                {
                    valor_cliente5_final = valor_cliente5_inteiro + "," + valor_cliente5_virgula;
                }

                //-------------------------------CLIENTE NOME 6-------------------------------//

                listDicionarioClientes.SelectedIndex = 5;
                string nome_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings6 = nome_cliente6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_cliente6 = subStrings6[0];
                }

                nome_cliente6 = nome_cliente6.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 6-------------------------------//

                string valor_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas6 = valor_cliente6.Split(',').Length - 1;

                valor_cliente6 = valor_cliente6.Replace("]", "");

                valor_cliente6 = valor_cliente6.Replace(" ", "");

                string[] subStrings26 = valor_cliente6.Split(',');

                valor_cliente6 = subStrings26[1];

                string valor_cliente6_inteiro = valor_cliente6;

                if (numVirgulas6 == 2)
                {
                    valor_cliente6 = subStrings26[2];
                }

                int tamanho6 = valor_cliente6.Length;
                valor_cliente6 = valor_cliente6.Substring(0, tamanho6);

                string valor_cliente6_virgula = valor_cliente6;

                string valor_cliente6_final = "0";

                if (valor_cliente6_inteiro != "0")
                {
                    valor_cliente6_final = valor_cliente6_inteiro + "," + valor_cliente6_virgula;
                }
                
                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Clientes que mais Compraram"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart2.AxisY.Add(new Axis
                {
                    Title = "Valor Total Cliente (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart2.LegendLocation = LegendLocation.Right;
            }
            else if (numeroClientesCalculados - 1 == 6)
            {
                //-------------------------------CLIENTE NOME 1-------------------------------//

                listDicionarioClientes.SelectedIndex = 0;
                string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings = nome_cliente1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_cliente1 = subStrings[0];
                }

                nome_cliente1 = nome_cliente1.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 1-------------------------------//

                string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

                valor_cliente1 = valor_cliente1.Replace("]", "");

                valor_cliente1 = valor_cliente1.Replace(" ", "");

                string[] subStrings21 = valor_cliente1.Split(',');

                valor_cliente1 = subStrings21[1];

                string valor_cliente1_inteiro = valor_cliente1;

                if (numVirgulas1 == 2)
                {
                    valor_cliente1 = subStrings21[2];
                }

                int tamanho1 = valor_cliente1.Length;
                valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

                string valor_cliente1_virgula = valor_cliente1;

                string valor_cliente1_final = "0";

                if (valor_cliente1_inteiro != "0")
                {
                    valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
                }

                //-------------------------------CLIENTE NOME 2-------------------------------//

                listDicionarioClientes.SelectedIndex = 1;
                string nome_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings2 = nome_cliente2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_cliente2 = subStrings2[0];
                }

                nome_cliente2 = nome_cliente2.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 2-------------------------------//

                string valor_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas2 = valor_cliente2.Split(',').Length - 1;

                valor_cliente2 = valor_cliente2.Replace("]", "");

                valor_cliente2 = valor_cliente2.Replace(" ", "");

                string[] subStrings22 = valor_cliente2.Split(',');

                valor_cliente2 = subStrings22[1];

                string valor_cliente2_inteiro = valor_cliente2;

                if (numVirgulas2 == 2)
                {
                    valor_cliente2 = subStrings22[2];
                }

                int tamanho2 = valor_cliente2.Length;
                valor_cliente2 = valor_cliente2.Substring(0, tamanho2);

                string valor_cliente2_virgula = valor_cliente2;

                string valor_cliente2_final = "0";

                if (valor_cliente2_inteiro != "0")
                {
                    valor_cliente2_final = valor_cliente2_inteiro + "," + valor_cliente2_virgula;
                }

                //-------------------------------CLIENTE NOME 3-------------------------------//

                listDicionarioClientes.SelectedIndex = 2;
                string nome_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings3 = nome_cliente3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_cliente3 = subStrings3[0];
                }

                nome_cliente3 = nome_cliente3.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 3-------------------------------//

                string valor_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas3 = valor_cliente3.Split(',').Length - 1;

                valor_cliente3 = valor_cliente3.Replace("]", "");

                valor_cliente3 = valor_cliente3.Replace(" ", "");

                string[] subStrings23 = valor_cliente3.Split(',');

                valor_cliente3 = subStrings23[1];

                string valor_cliente3_inteiro = valor_cliente3;

                if (numVirgulas3 == 2)
                {
                    valor_cliente3 = subStrings23[2];
                }

                int tamanho3 = valor_cliente3.Length;
                valor_cliente3 = valor_cliente3.Substring(0, tamanho3);

                string valor_cliente3_virgula = valor_cliente3;

                string valor_cliente3_final = "0";

                if (valor_cliente3_inteiro != "0")
                {
                    valor_cliente3_final = valor_cliente3_inteiro + "," + valor_cliente3_virgula;
                }

                //-------------------------------CLIENTE NOME 4-------------------------------//

                listDicionarioClientes.SelectedIndex = 3;
                string nome_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings4 = nome_cliente4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_cliente4 = subStrings4[0];
                }

                nome_cliente4 = nome_cliente4.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 4-------------------------------//

                string valor_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas4 = valor_cliente4.Split(',').Length - 1;

                valor_cliente4 = valor_cliente4.Replace("]", "");

                valor_cliente4 = valor_cliente4.Replace(" ", "");

                string[] subStrings24 = valor_cliente4.Split(',');

                valor_cliente4 = subStrings24[1];

                string valor_cliente4_inteiro = valor_cliente4;

                if (numVirgulas4 == 2)
                {
                    valor_cliente4 = subStrings24[2];
                }

                int tamanho4 = valor_cliente4.Length;
                valor_cliente4 = valor_cliente4.Substring(0, tamanho4);

                string valor_cliente4_virgula = valor_cliente4;

                string valor_cliente4_final = "0";

                if (valor_cliente4_inteiro != "0")
                {
                    valor_cliente4_final = valor_cliente4_inteiro + "," + valor_cliente4_virgula;
                }

                //-------------------------------CLIENTE NOME 5-------------------------------//

                listDicionarioClientes.SelectedIndex = 4;
                string nome_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings5 = nome_cliente5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_cliente5 = subStrings5[0];
                }

                nome_cliente5 = nome_cliente5.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 5-------------------------------//

                string valor_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas5 = valor_cliente5.Split(',').Length - 1;

                valor_cliente5 = valor_cliente5.Replace("]", "");

                valor_cliente5 = valor_cliente5.Replace(" ", "");

                string[] subStrings25 = valor_cliente5.Split(',');

                valor_cliente5 = subStrings25[1];

                string valor_cliente5_inteiro = valor_cliente5;

                if (numVirgulas5 == 2)
                {
                    valor_cliente5 = subStrings25[2];
                }

                int tamanho5 = valor_cliente5.Length;
                valor_cliente5 = valor_cliente5.Substring(0, tamanho5);

                string valor_cliente5_virgula = valor_cliente5;

                string valor_cliente5_final = "0";

                if (valor_cliente5_inteiro != "0")
                {
                    valor_cliente5_final = valor_cliente5_inteiro + "," + valor_cliente5_virgula;
                }

                //-------------------------------CLIENTE NOME 6-------------------------------//

                listDicionarioClientes.SelectedIndex = 5;
                string nome_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings6 = nome_cliente6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_cliente6 = subStrings6[0];
                }

                nome_cliente6 = nome_cliente6.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 6-------------------------------//

                string valor_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas6 = valor_cliente6.Split(',').Length - 1;

                valor_cliente6 = valor_cliente6.Replace("]", "");

                valor_cliente6 = valor_cliente6.Replace(" ", "");

                string[] subStrings26 = valor_cliente6.Split(',');

                valor_cliente6 = subStrings26[1];

                string valor_cliente6_inteiro = valor_cliente6;

                if (numVirgulas6 == 2)
                {
                    valor_cliente6 = subStrings26[2];
                }

                int tamanho6 = valor_cliente6.Length;
                valor_cliente6 = valor_cliente6.Substring(0, tamanho6);

                string valor_cliente6_virgula = valor_cliente6;

                string valor_cliente6_final = "0";

                if (valor_cliente6_inteiro != "0")
                {
                    valor_cliente6_final = valor_cliente6_inteiro + "," + valor_cliente6_virgula;
                }

                //-------------------------------CLIENTE NOME 7-------------------------------//

                listDicionarioClientes.SelectedIndex = 6;
                string nome_cliente7 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings7 = nome_cliente7.Split(',');

                foreach (string str in subStrings7)
                {
                    nome_cliente7 = subStrings7[0];
                }

                nome_cliente7 = nome_cliente7.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 7-------------------------------//

                string valor_cliente7 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas7 = valor_cliente7.Split(',').Length - 1;

                valor_cliente7 = valor_cliente7.Replace("]", "");

                valor_cliente7 = valor_cliente7.Replace(" ", "");

                string[] subStrings27 = valor_cliente7.Split(',');

                valor_cliente7 = subStrings27[1];

                string valor_cliente7_inteiro = valor_cliente7;

                if (numVirgulas7 == 2)
                {
                    valor_cliente7 = subStrings27[2];
                }

                int tamanho7 = valor_cliente7.Length;
                valor_cliente7 = valor_cliente7.Substring(0, tamanho7);

                string valor_cliente7_virgula = valor_cliente7;

                string valor_cliente7_final = "0";

                if (valor_cliente7_inteiro != "0")
                {
                    valor_cliente7_final = valor_cliente7_inteiro + "," + valor_cliente7_virgula;
                }

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente7,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente7_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Clientes que mais Compraram"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart2.AxisY.Add(new Axis
                {
                    Title = "Valor Total Cliente (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart2.LegendLocation = LegendLocation.Right;
            }
            else if (numeroClientesCalculados - 1 == 7)
            {
                //-------------------------------CLIENTE NOME 1-------------------------------//

                listDicionarioClientes.SelectedIndex = 0;
                string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings = nome_cliente1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_cliente1 = subStrings[0];
                }

                nome_cliente1 = nome_cliente1.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 1-------------------------------//

                string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

                valor_cliente1 = valor_cliente1.Replace("]", "");

                valor_cliente1 = valor_cliente1.Replace(" ", "");

                string[] subStrings21 = valor_cliente1.Split(',');

                valor_cliente1 = subStrings21[1];

                string valor_cliente1_inteiro = valor_cliente1;

                if (numVirgulas1 == 2)
                {
                    valor_cliente1 = subStrings21[2];
                }

                int tamanho1 = valor_cliente1.Length;
                valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

                string valor_cliente1_virgula = valor_cliente1;

                string valor_cliente1_final = "0";

                if (valor_cliente1_inteiro != "0")
                {
                    valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
                }

                //-------------------------------CLIENTE NOME 2-------------------------------//

                listDicionarioClientes.SelectedIndex = 1;
                string nome_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings2 = nome_cliente2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_cliente2 = subStrings2[0];
                }

                nome_cliente2 = nome_cliente2.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 2-------------------------------//

                string valor_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas2 = valor_cliente2.Split(',').Length - 1;

                valor_cliente2 = valor_cliente2.Replace("]", "");

                valor_cliente2 = valor_cliente2.Replace(" ", "");

                string[] subStrings22 = valor_cliente2.Split(',');

                valor_cliente2 = subStrings22[1];

                string valor_cliente2_inteiro = valor_cliente2;

                if (numVirgulas2 == 2)
                {
                    valor_cliente2 = subStrings22[2];
                }

                int tamanho2 = valor_cliente2.Length;
                valor_cliente2 = valor_cliente2.Substring(0, tamanho2);

                string valor_cliente2_virgula = valor_cliente2;

                string valor_cliente2_final = "0";

                if (valor_cliente2_inteiro != "0")
                {
                    valor_cliente2_final = valor_cliente2_inteiro + "," + valor_cliente2_virgula;
                }

                //-------------------------------CLIENTE NOME 3-------------------------------//

                listDicionarioClientes.SelectedIndex = 2;
                string nome_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings3 = nome_cliente3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_cliente3 = subStrings3[0];
                }

                nome_cliente3 = nome_cliente3.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 3-------------------------------//

                string valor_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas3 = valor_cliente3.Split(',').Length - 1;

                valor_cliente3 = valor_cliente3.Replace("]", "");

                valor_cliente3 = valor_cliente3.Replace(" ", "");

                string[] subStrings23 = valor_cliente3.Split(',');

                valor_cliente3 = subStrings23[1];

                string valor_cliente3_inteiro = valor_cliente3;

                if (numVirgulas3 == 2)
                {
                    valor_cliente3 = subStrings23[2];
                }

                int tamanho3 = valor_cliente3.Length;
                valor_cliente3 = valor_cliente3.Substring(0, tamanho3);

                string valor_cliente3_virgula = valor_cliente3;

                string valor_cliente3_final = "0";

                if (valor_cliente3_inteiro != "0")
                {
                    valor_cliente3_final = valor_cliente3_inteiro + "," + valor_cliente3_virgula;
                }

                //-------------------------------CLIENTE NOME 4-------------------------------//

                listDicionarioClientes.SelectedIndex = 3;
                string nome_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings4 = nome_cliente4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_cliente4 = subStrings4[0];
                }

                nome_cliente4 = nome_cliente4.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 4-------------------------------//

                string valor_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas4 = valor_cliente4.Split(',').Length - 1;

                valor_cliente4 = valor_cliente4.Replace("]", "");

                valor_cliente4 = valor_cliente4.Replace(" ", "");

                string[] subStrings24 = valor_cliente4.Split(',');

                valor_cliente4 = subStrings24[1];

                string valor_cliente4_inteiro = valor_cliente4;

                if (numVirgulas4 == 2)
                {
                    valor_cliente4 = subStrings24[2];
                }

                int tamanho4 = valor_cliente4.Length;
                valor_cliente4 = valor_cliente4.Substring(0, tamanho4);

                string valor_cliente4_virgula = valor_cliente4;

                string valor_cliente4_final = "0";

                if (valor_cliente4_inteiro != "0")
                {
                    valor_cliente4_final = valor_cliente4_inteiro + "," + valor_cliente4_virgula;
                }

                //-------------------------------CLIENTE NOME 5-------------------------------//

                listDicionarioClientes.SelectedIndex = 4;
                string nome_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings5 = nome_cliente5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_cliente5 = subStrings5[0];
                }

                nome_cliente5 = nome_cliente5.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 5-------------------------------//

                string valor_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas5 = valor_cliente5.Split(',').Length - 1;

                valor_cliente5 = valor_cliente5.Replace("]", "");

                valor_cliente5 = valor_cliente5.Replace(" ", "");

                string[] subStrings25 = valor_cliente5.Split(',');

                valor_cliente5 = subStrings25[1];

                string valor_cliente5_inteiro = valor_cliente5;

                if (numVirgulas5 == 2)
                {
                    valor_cliente5 = subStrings25[2];
                }

                int tamanho5 = valor_cliente5.Length;
                valor_cliente5 = valor_cliente5.Substring(0, tamanho5);

                string valor_cliente5_virgula = valor_cliente5;

                string valor_cliente5_final = "0";

                if (valor_cliente5_inteiro != "0")
                {
                    valor_cliente5_final = valor_cliente5_inteiro + "," + valor_cliente5_virgula;
                }

                //-------------------------------CLIENTE NOME 6-------------------------------//

                listDicionarioClientes.SelectedIndex = 5;
                string nome_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings6 = nome_cliente6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_cliente6 = subStrings6[0];
                }

                nome_cliente6 = nome_cliente6.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 6-------------------------------//

                string valor_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas6 = valor_cliente6.Split(',').Length - 1;

                valor_cliente6 = valor_cliente6.Replace("]", "");

                valor_cliente6 = valor_cliente6.Replace(" ", "");

                string[] subStrings26 = valor_cliente6.Split(',');

                valor_cliente6 = subStrings26[1];

                string valor_cliente6_inteiro = valor_cliente6;

                if (numVirgulas6 == 2)
                {
                    valor_cliente6 = subStrings26[2];
                }

                int tamanho6 = valor_cliente6.Length;
                valor_cliente6 = valor_cliente6.Substring(0, tamanho6);

                string valor_cliente6_virgula = valor_cliente6;

                string valor_cliente6_final = "0";

                if (valor_cliente6_inteiro != "0")
                {
                    valor_cliente6_final = valor_cliente6_inteiro + "," + valor_cliente6_virgula;
                }

                //-------------------------------CLIENTE NOME 7-------------------------------//

                listDicionarioClientes.SelectedIndex = 6;
                string nome_cliente7 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings7 = nome_cliente7.Split(',');

                foreach (string str in subStrings7)
                {
                    nome_cliente7 = subStrings7[0];
                }

                nome_cliente7 = nome_cliente7.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 7-------------------------------//

                string valor_cliente7 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas7 = valor_cliente7.Split(',').Length - 1;

                valor_cliente7 = valor_cliente7.Replace("]", "");

                valor_cliente7 = valor_cliente7.Replace(" ", "");

                string[] subStrings27 = valor_cliente7.Split(',');

                valor_cliente7 = subStrings27[1];

                string valor_cliente7_inteiro = valor_cliente7;

                if (numVirgulas7 == 2)
                {
                    valor_cliente7 = subStrings27[2];
                }

                int tamanho7 = valor_cliente7.Length;
                valor_cliente7 = valor_cliente7.Substring(0, tamanho7);

                string valor_cliente7_virgula = valor_cliente7;

                string valor_cliente7_final = "0";

                if (valor_cliente7_inteiro != "0")
                {
                    valor_cliente7_final = valor_cliente7_inteiro + "," + valor_cliente7_virgula;
                }

                //-------------------------------CLIENTE NOME 8-------------------------------//

                listDicionarioClientes.SelectedIndex = 7;
                string nome_cliente8 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings8 = nome_cliente8.Split(',');

                foreach (string str in subStrings8)
                {
                    nome_cliente8 = subStrings8[0];
                }

                nome_cliente8 = nome_cliente8.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 8-------------------------------//

                string valor_cliente8 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas8 = valor_cliente8.Split(',').Length - 1;

                valor_cliente8 = valor_cliente8.Replace("]", "");

                valor_cliente8 = valor_cliente8.Replace(" ", "");

                string[] subStrings28 = valor_cliente8.Split(',');

                valor_cliente8 = subStrings28[1];

                string valor_cliente8_inteiro = valor_cliente8;

                if (numVirgulas8 == 2)
                {
                    valor_cliente8 = subStrings28[2];
                }

                int tamanho8 = valor_cliente8.Length;
                valor_cliente8 = valor_cliente8.Substring(0, tamanho8);

                string valor_cliente8_virgula = valor_cliente8;

                string valor_cliente8_final = "0";

                if (valor_cliente8_inteiro != "0")
                {
                    valor_cliente8_final = valor_cliente8_inteiro + "," + valor_cliente8_virgula;
                }

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente7,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente7_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente8,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente8_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Clientes que mais Compraram"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart2.AxisY.Add(new Axis
                {
                    Title = "Valor Total Cliente (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart2.LegendLocation = LegendLocation.Right;
            }
            else if (numeroClientesCalculados - 1 == 8)
            {
                //-------------------------------CLIENTE NOME 1-------------------------------//

                listDicionarioClientes.SelectedIndex = 0;
                string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings = nome_cliente1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_cliente1 = subStrings[0];
                }

                nome_cliente1 = nome_cliente1.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 1-------------------------------//

                string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

                valor_cliente1 = valor_cliente1.Replace("]", "");

                valor_cliente1 = valor_cliente1.Replace(" ", "");

                string[] subStrings21 = valor_cliente1.Split(',');

                valor_cliente1 = subStrings21[1];

                string valor_cliente1_inteiro = valor_cliente1;

                if (numVirgulas1 == 2)
                {
                    valor_cliente1 = subStrings21[2];
                }

                int tamanho1 = valor_cliente1.Length;
                valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

                string valor_cliente1_virgula = valor_cliente1;

                string valor_cliente1_final = "0";

                if (valor_cliente1_inteiro != "0")
                {
                    valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
                }

                //-------------------------------CLIENTE NOME 2-------------------------------//

                listDicionarioClientes.SelectedIndex = 1;
                string nome_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings2 = nome_cliente2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_cliente2 = subStrings2[0];
                }

                nome_cliente2 = nome_cliente2.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 2-------------------------------//

                string valor_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas2 = valor_cliente2.Split(',').Length - 1;

                valor_cliente2 = valor_cliente2.Replace("]", "");

                valor_cliente2 = valor_cliente2.Replace(" ", "");

                string[] subStrings22 = valor_cliente2.Split(',');

                valor_cliente2 = subStrings22[1];

                string valor_cliente2_inteiro = valor_cliente2;

                if (numVirgulas2 == 2)
                {
                    valor_cliente2 = subStrings22[2];
                }

                int tamanho2 = valor_cliente2.Length;
                valor_cliente2 = valor_cliente2.Substring(0, tamanho2);

                string valor_cliente2_virgula = valor_cliente2;

                string valor_cliente2_final = "0";

                if (valor_cliente2_inteiro != "0")
                {
                    valor_cliente2_final = valor_cliente2_inteiro + "," + valor_cliente2_virgula;
                }

                //-------------------------------CLIENTE NOME 3-------------------------------//

                listDicionarioClientes.SelectedIndex = 2;
                string nome_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings3 = nome_cliente3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_cliente3 = subStrings3[0];
                }

                nome_cliente3 = nome_cliente3.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 3-------------------------------//

                string valor_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas3 = valor_cliente3.Split(',').Length - 1;

                valor_cliente3 = valor_cliente3.Replace("]", "");

                valor_cliente3 = valor_cliente3.Replace(" ", "");

                string[] subStrings23 = valor_cliente3.Split(',');

                valor_cliente3 = subStrings23[1];

                string valor_cliente3_inteiro = valor_cliente3;

                if (numVirgulas3 == 2)
                {
                    valor_cliente3 = subStrings23[2];
                }

                int tamanho3 = valor_cliente3.Length;
                valor_cliente3 = valor_cliente3.Substring(0, tamanho3);

                string valor_cliente3_virgula = valor_cliente3;

                string valor_cliente3_final = "0";

                if (valor_cliente3_inteiro != "0")
                {
                    valor_cliente3_final = valor_cliente3_inteiro + "," + valor_cliente3_virgula;
                }

                //-------------------------------CLIENTE NOME 4-------------------------------//

                listDicionarioClientes.SelectedIndex = 3;
                string nome_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings4 = nome_cliente4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_cliente4 = subStrings4[0];
                }

                nome_cliente4 = nome_cliente4.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 4-------------------------------//

                string valor_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas4 = valor_cliente4.Split(',').Length - 1;

                valor_cliente4 = valor_cliente4.Replace("]", "");

                valor_cliente4 = valor_cliente4.Replace(" ", "");

                string[] subStrings24 = valor_cliente4.Split(',');

                valor_cliente4 = subStrings24[1];

                string valor_cliente4_inteiro = valor_cliente4;

                if (numVirgulas4 == 2)
                {
                    valor_cliente4 = subStrings24[2];
                }

                int tamanho4 = valor_cliente4.Length;
                valor_cliente4 = valor_cliente4.Substring(0, tamanho4);

                string valor_cliente4_virgula = valor_cliente4;

                string valor_cliente4_final = "0";

                if (valor_cliente4_inteiro != "0")
                {
                    valor_cliente4_final = valor_cliente4_inteiro + "," + valor_cliente4_virgula;
                }

                //-------------------------------CLIENTE NOME 5-------------------------------//

                listDicionarioClientes.SelectedIndex = 4;
                string nome_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings5 = nome_cliente5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_cliente5 = subStrings5[0];
                }

                nome_cliente5 = nome_cliente5.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 5-------------------------------//

                string valor_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas5 = valor_cliente5.Split(',').Length - 1;

                valor_cliente5 = valor_cliente5.Replace("]", "");

                valor_cliente5 = valor_cliente5.Replace(" ", "");

                string[] subStrings25 = valor_cliente5.Split(',');

                valor_cliente5 = subStrings25[1];

                string valor_cliente5_inteiro = valor_cliente5;

                if (numVirgulas5 == 2)
                {
                    valor_cliente5 = subStrings25[2];
                }

                int tamanho5 = valor_cliente5.Length;
                valor_cliente5 = valor_cliente5.Substring(0, tamanho5);

                string valor_cliente5_virgula = valor_cliente5;

                string valor_cliente5_final = "0";

                if (valor_cliente5_inteiro != "0")
                {
                    valor_cliente5_final = valor_cliente5_inteiro + "," + valor_cliente5_virgula;
                }

                //-------------------------------CLIENTE NOME 6-------------------------------//

                listDicionarioClientes.SelectedIndex = 5;
                string nome_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings6 = nome_cliente6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_cliente6 = subStrings6[0];
                }

                nome_cliente6 = nome_cliente6.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 6-------------------------------//

                string valor_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas6 = valor_cliente6.Split(',').Length - 1;

                valor_cliente6 = valor_cliente6.Replace("]", "");

                valor_cliente6 = valor_cliente6.Replace(" ", "");

                string[] subStrings26 = valor_cliente6.Split(',');

                valor_cliente6 = subStrings26[1];

                string valor_cliente6_inteiro = valor_cliente6;

                if (numVirgulas6 == 2)
                {
                    valor_cliente6 = subStrings26[2];
                }

                int tamanho6 = valor_cliente6.Length;
                valor_cliente6 = valor_cliente6.Substring(0, tamanho6);

                string valor_cliente6_virgula = valor_cliente6;

                string valor_cliente6_final = "0";

                if (valor_cliente6_inteiro != "0")
                {
                    valor_cliente6_final = valor_cliente6_inteiro + "," + valor_cliente6_virgula;
                }

                //-------------------------------CLIENTE NOME 7-------------------------------//

                listDicionarioClientes.SelectedIndex = 6;
                string nome_cliente7 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings7 = nome_cliente7.Split(',');

                foreach (string str in subStrings7)
                {
                    nome_cliente7 = subStrings7[0];
                }

                nome_cliente7 = nome_cliente7.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 7-------------------------------//

                string valor_cliente7 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas7 = valor_cliente7.Split(',').Length - 1;

                valor_cliente7 = valor_cliente7.Replace("]", "");

                valor_cliente7 = valor_cliente7.Replace(" ", "");

                string[] subStrings27 = valor_cliente7.Split(',');

                valor_cliente7 = subStrings27[1];

                string valor_cliente7_inteiro = valor_cliente7;

                if (numVirgulas7 == 2)
                {
                    valor_cliente7 = subStrings27[2];
                }

                int tamanho7 = valor_cliente7.Length;
                valor_cliente7 = valor_cliente7.Substring(0, tamanho7);

                string valor_cliente7_virgula = valor_cliente7;

                string valor_cliente7_final = "0";

                if (valor_cliente7_inteiro != "0")
                {
                    valor_cliente7_final = valor_cliente7_inteiro + "," + valor_cliente7_virgula;
                }

                //-------------------------------CLIENTE NOME 8-------------------------------//

                listDicionarioClientes.SelectedIndex = 7;
                string nome_cliente8 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings8 = nome_cliente8.Split(',');

                foreach (string str in subStrings8)
                {
                    nome_cliente8 = subStrings8[0];
                }

                nome_cliente8 = nome_cliente8.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 8-------------------------------//

                string valor_cliente8 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas8 = valor_cliente8.Split(',').Length - 1;

                valor_cliente8 = valor_cliente8.Replace("]", "");

                valor_cliente8 = valor_cliente8.Replace(" ", "");

                string[] subStrings28 = valor_cliente8.Split(',');

                valor_cliente8 = subStrings28[1];

                string valor_cliente8_inteiro = valor_cliente8;

                if (numVirgulas8 == 2)
                {
                    valor_cliente8 = subStrings28[2];
                }

                int tamanho8 = valor_cliente8.Length;
                valor_cliente8 = valor_cliente8.Substring(0, tamanho8);

                string valor_cliente8_virgula = valor_cliente8;

                string valor_cliente8_final = "0";

                if (valor_cliente8_inteiro != "0")
                {
                    valor_cliente8_final = valor_cliente8_inteiro + "," + valor_cliente8_virgula;
                }

                //-------------------------------CLIENTE NOME 9-------------------------------//

                listDicionarioClientes.SelectedIndex = 8;
                string nome_cliente9 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                string[] subStrings9 = nome_cliente9.Split(',');

                foreach (string str in subStrings9)
                {
                    nome_cliente9 = subStrings9[0];
                }

                nome_cliente9 = nome_cliente9.Remove(0, 1);

                //-------------------------------CLIENTE VALOR 9-------------------------------//

                string valor_cliente9 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

                int numVirgulas9 = valor_cliente9.Split(',').Length - 1;

                valor_cliente9 = valor_cliente9.Replace("]", "");

                valor_cliente9 = valor_cliente9.Replace(" ", "");

                string[] subStrings29 = valor_cliente9.Split(',');

                valor_cliente9 = subStrings29[1];

                string valor_cliente9_inteiro = valor_cliente9;

                if (numVirgulas9 == 2)
                {
                    valor_cliente9 = subStrings29[2];
                }

                int tamanho9 = valor_cliente9.Length;
                valor_cliente9 = valor_cliente9.Substring(0, tamanho9);

                string valor_cliente9_virgula = valor_cliente9;

                string valor_cliente9_final = "0";

                if (valor_cliente9_inteiro != "0")
                {
                    valor_cliente9_final = valor_cliente9_inteiro + "," + valor_cliente9_virgula;
                }

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente7,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente7_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente8,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente8_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.Series.Add(new ColumnSeries
                {
                    Title = nome_cliente9,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente9_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart2.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Clientes que mais Compraram"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart2.AxisY.Add(new Axis
                {
                    Title = "Valor Total Cliente (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart2.LegendLocation = LegendLocation.Right;
            }
            else if (numeroClientesCalculados - 1 == 9)
            {
                graficoCliente10();
            }
            else
            {
                graficoCliente10();
            }
        }

        private void graficoCliente10()
        {
            //-------------------------------CLIENTE NOME 1-------------------------------//

            listDicionarioClientes.SelectedIndex = 0;
            string nome_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings = nome_cliente1.Split(',');

            foreach (string str in subStrings)
            {
                nome_cliente1 = subStrings[0];
            }

            nome_cliente1 = nome_cliente1.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 1-------------------------------//

            string valor_cliente1 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas1 = valor_cliente1.Split(',').Length - 1;

            valor_cliente1 = valor_cliente1.Replace("]", "");

            valor_cliente1 = valor_cliente1.Replace(" ", "");

            string[] subStrings21 = valor_cliente1.Split(',');

            valor_cliente1 = subStrings21[1];

            string valor_cliente1_inteiro = valor_cliente1;

            if (numVirgulas1 == 2)
            {
                valor_cliente1 = subStrings21[2];
            }

            int tamanho1 = valor_cliente1.Length;
            valor_cliente1 = valor_cliente1.Substring(0, tamanho1);

            string valor_cliente1_virgula = valor_cliente1;

            string valor_cliente1_final = "0";

            if (valor_cliente1_inteiro != "0")
            {
                valor_cliente1_final = valor_cliente1_inteiro + "," + valor_cliente1_virgula;
            }

            //-------------------------------CLIENTE NOME 2-------------------------------//

            listDicionarioClientes.SelectedIndex = 1;
            string nome_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings2 = nome_cliente2.Split(',');

            foreach (string str in subStrings2)
            {
                nome_cliente2 = subStrings2[0];
            }

            nome_cliente2 = nome_cliente2.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 2-------------------------------//

            string valor_cliente2 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas2 = valor_cliente2.Split(',').Length - 1;

            valor_cliente2 = valor_cliente2.Replace("]", "");

            valor_cliente2 = valor_cliente2.Replace(" ", "");

            string[] subStrings22 = valor_cliente2.Split(',');

            valor_cliente2 = subStrings22[1];

            string valor_cliente2_inteiro = valor_cliente2;

            if (numVirgulas2 == 2)
            {
                valor_cliente2 = subStrings22[2];
            }

            int tamanho2 = valor_cliente2.Length;
            valor_cliente2 = valor_cliente2.Substring(0, tamanho2);

            string valor_cliente2_virgula = valor_cliente2;

            string valor_cliente2_final = "0";

            if (valor_cliente2_inteiro != "0")
            {
                valor_cliente2_final = valor_cliente2_inteiro + "," + valor_cliente2_virgula;
            }

            //-------------------------------CLIENTE NOME 3-------------------------------//

            listDicionarioClientes.SelectedIndex = 2;
            string nome_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings3 = nome_cliente3.Split(',');

            foreach (string str in subStrings3)
            {
                nome_cliente3 = subStrings3[0];
            }

            nome_cliente3 = nome_cliente3.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 3-------------------------------//

            string valor_cliente3 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas3 = valor_cliente3.Split(',').Length - 1;

            valor_cliente3 = valor_cliente3.Replace("]", "");

            valor_cliente3 = valor_cliente3.Replace(" ", "");

            string[] subStrings23 = valor_cliente3.Split(',');

            valor_cliente3 = subStrings23[1];

            string valor_cliente3_inteiro = valor_cliente3;

            if (numVirgulas3 == 2)
            {
                valor_cliente3 = subStrings23[2];
            }

            int tamanho3 = valor_cliente3.Length;
            valor_cliente3 = valor_cliente3.Substring(0, tamanho3);

            string valor_cliente3_virgula = valor_cliente3;

            string valor_cliente3_final = "0";

            if (valor_cliente3_inteiro != "0")
            {
                valor_cliente3_final = valor_cliente3_inteiro + "," + valor_cliente3_virgula;
            }

            //-------------------------------CLIENTE NOME 4-------------------------------//

            listDicionarioClientes.SelectedIndex = 3;
            string nome_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings4 = nome_cliente4.Split(',');

            foreach (string str in subStrings4)
            {
                nome_cliente4 = subStrings4[0];
            }

            nome_cliente4 = nome_cliente4.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 4-------------------------------//

            string valor_cliente4 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas4 = valor_cliente4.Split(',').Length - 1;

            valor_cliente4 = valor_cliente4.Replace("]", "");

            valor_cliente4 = valor_cliente4.Replace(" ", "");

            string[] subStrings24 = valor_cliente4.Split(',');

            valor_cliente4 = subStrings24[1];

            string valor_cliente4_inteiro = valor_cliente4;

            if (numVirgulas4 == 2)
            {
                valor_cliente4 = subStrings24[2];
            }

            int tamanho4 = valor_cliente4.Length;
            valor_cliente4 = valor_cliente4.Substring(0, tamanho4);

            string valor_cliente4_virgula = valor_cliente4;

            string valor_cliente4_final = "0";

            if (valor_cliente4_inteiro != "0")
            {
                valor_cliente4_final = valor_cliente4_inteiro + "," + valor_cliente4_virgula;
            }

            //-------------------------------CLIENTE NOME 5-------------------------------//

            listDicionarioClientes.SelectedIndex = 4;
            string nome_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings5 = nome_cliente5.Split(',');

            foreach (string str in subStrings5)
            {
                nome_cliente5 = subStrings5[0];
            }

            nome_cliente5 = nome_cliente5.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 5-------------------------------//

            string valor_cliente5 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas5 = valor_cliente5.Split(',').Length - 1;

            valor_cliente5 = valor_cliente5.Replace("]", "");

            valor_cliente5 = valor_cliente5.Replace(" ", "");

            string[] subStrings25 = valor_cliente5.Split(',');

            valor_cliente5 = subStrings25[1];

            string valor_cliente5_inteiro = valor_cliente5;

            if (numVirgulas5 == 2)
            {
                valor_cliente5 = subStrings25[2];
            }

            int tamanho5 = valor_cliente5.Length;
            valor_cliente5 = valor_cliente5.Substring(0, tamanho5);

            string valor_cliente5_virgula = valor_cliente5;

            string valor_cliente5_final = "0";

            if (valor_cliente5_inteiro != "0")
            {
                valor_cliente5_final = valor_cliente5_inteiro + "," + valor_cliente5_virgula;
            }

            //-------------------------------CLIENTE NOME 6-------------------------------//

            listDicionarioClientes.SelectedIndex = 5;
            string nome_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings6 = nome_cliente6.Split(',');

            foreach (string str in subStrings6)
            {
                nome_cliente6 = subStrings6[0];
            }

            nome_cliente6 = nome_cliente6.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 6-------------------------------//

            string valor_cliente6 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas6 = valor_cliente6.Split(',').Length - 1;

            valor_cliente6 = valor_cliente6.Replace("]", "");

            valor_cliente6 = valor_cliente6.Replace(" ", "");

            string[] subStrings26 = valor_cliente6.Split(',');

            valor_cliente6 = subStrings26[1];

            string valor_cliente6_inteiro = valor_cliente6;

            if (numVirgulas6 == 2)
            {
                valor_cliente6 = subStrings26[2];
            }

            int tamanho6 = valor_cliente6.Length;
            valor_cliente6 = valor_cliente6.Substring(0, tamanho6);

            string valor_cliente6_virgula = valor_cliente6;

            string valor_cliente6_final = "0";

            if (valor_cliente6_inteiro != "0")
            {
                valor_cliente6_final = valor_cliente6_inteiro + "," + valor_cliente6_virgula;
            }

            //-------------------------------CLIENTE NOME 7-------------------------------//

            listDicionarioClientes.SelectedIndex = 6;
            string nome_cliente7 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings7 = nome_cliente7.Split(',');

            foreach (string str in subStrings7)
            {
                nome_cliente7 = subStrings7[0];
            }

            nome_cliente7 = nome_cliente7.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 7-------------------------------//

            string valor_cliente7 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas7 = valor_cliente7.Split(',').Length - 1;

            valor_cliente7 = valor_cliente7.Replace("]", "");

            valor_cliente7 = valor_cliente7.Replace(" ", "");

            string[] subStrings27 = valor_cliente7.Split(',');

            valor_cliente7 = subStrings27[1];

            string valor_cliente7_inteiro = valor_cliente7;

            if (numVirgulas7 == 2)
            {
                valor_cliente7 = subStrings27[2];
            }

            int tamanho7 = valor_cliente7.Length;
            valor_cliente7 = valor_cliente7.Substring(0, tamanho7);

            string valor_cliente7_virgula = valor_cliente7;

            string valor_cliente7_final = "0";

            if (valor_cliente7_inteiro != "0")
            {
                valor_cliente7_final = valor_cliente7_inteiro + "," + valor_cliente7_virgula;
            }

            //-------------------------------CLIENTE NOME 8-------------------------------//

            listDicionarioClientes.SelectedIndex = 7;
            string nome_cliente8 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings8 = nome_cliente8.Split(',');

            foreach (string str in subStrings8)
            {
                nome_cliente8 = subStrings8[0];
            }

            nome_cliente8 = nome_cliente8.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 8-------------------------------//

            string valor_cliente8 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas8 = valor_cliente8.Split(',').Length - 1;

            valor_cliente8 = valor_cliente8.Replace("]", "");

            valor_cliente8 = valor_cliente8.Replace(" ", "");

            string[] subStrings28 = valor_cliente8.Split(',');

            valor_cliente8 = subStrings28[1];

            string valor_cliente8_inteiro = valor_cliente8;

            if (numVirgulas8 == 2)
            {
                valor_cliente8 = subStrings28[2];
            }

            int tamanho8 = valor_cliente8.Length;
            valor_cliente8 = valor_cliente8.Substring(0, tamanho8);

            string valor_cliente8_virgula = valor_cliente8;

            string valor_cliente8_final = "0";

            if (valor_cliente8_inteiro != "0")
            {
                valor_cliente8_final = valor_cliente8_inteiro + "," + valor_cliente8_virgula;
            }

            //-------------------------------CLIENTE NOME 9-------------------------------//

            listDicionarioClientes.SelectedIndex = 8;
            string nome_cliente9 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings9 = nome_cliente9.Split(',');

            foreach (string str in subStrings9)
            {
                nome_cliente9 = subStrings9[0];
            }

            nome_cliente9 = nome_cliente9.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 9-------------------------------//

            string valor_cliente9 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas9 = valor_cliente9.Split(',').Length - 1;

            valor_cliente9 = valor_cliente9.Replace("]", "");

            valor_cliente9 = valor_cliente9.Replace(" ", "");

            string[] subStrings29 = valor_cliente9.Split(',');

            valor_cliente9 = subStrings29[1];

            string valor_cliente9_inteiro = valor_cliente9;

            if (numVirgulas9 == 2)
            {
                valor_cliente9 = subStrings29[2];
            }

            int tamanho9 = valor_cliente9.Length;
            valor_cliente9 = valor_cliente9.Substring(0, tamanho9);

            string valor_cliente9_virgula = valor_cliente9;

            string valor_cliente9_final = "0";

            if (valor_cliente9_inteiro != "0")
            {
                valor_cliente9_final = valor_cliente9_inteiro + "," + valor_cliente9_virgula;
            }

            //-------------------------------CLIENTE NOME 10-------------------------------//

            listDicionarioClientes.SelectedIndex = 9;
            string nome_cliente10 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            string[] subStrings10 = nome_cliente10.Split(',');

            foreach (string str in subStrings10)
            {
                nome_cliente10 = subStrings10[0];
            }

            nome_cliente10 = nome_cliente10.Remove(0, 1);

            //-------------------------------CLIENTE VALOR 10-------------------------------//

            string valor_cliente10 = listDicionarioClientes.GetItemText(listDicionarioClientes.SelectedItem);

            int numVirgulas10 = valor_cliente10.Split(',').Length - 1;

            valor_cliente10 = valor_cliente10.Replace("]", "");

            valor_cliente10 = valor_cliente10.Replace(" ", "");

            string[] subStrings30 = valor_cliente10.Split(',');

            valor_cliente10 = subStrings30[1];

            string valor_cliente10_inteiro = valor_cliente10;

            if (numVirgulas10 == 2)
            {
                valor_cliente10 = subStrings30[2];
            }

            int tamanho10 = valor_cliente10.Length;
            valor_cliente10 = valor_cliente10.Substring(0, tamanho10);

            string valor_cliente10_virgula = valor_cliente10;

            string valor_cliente10_final = "0";

            if (valor_cliente10_inteiro != "0")
            {
                valor_cliente10_final = valor_cliente10_inteiro + "," + valor_cliente10_virgula;
            }

            ///////////////////////////////////////////////////////////////////////////////////

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente1,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente1_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente2,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente2_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente3,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente3_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente4,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente4_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente5,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente5_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente6,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente6_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente7,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente7_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente8,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente8_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente9,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente9_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = nome_cliente10,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_cliente10_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart2.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                        "TOP 10: Clientes que mais Compraram"
                    },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                },
                LabelsRotation = 0
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Valor Total Cliente (R$)",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart2.LegendLocation = LegendLocation.Right;
        }

        private void CarregarGraficoTop10Produtos()
        {
            //Sistema.ActiveForm.WindowState = FormWindowState.Minimized;

            //verificar se tem algum registro selecionado
            if (dgvMEidprodutos.SelectedRows.Count == 0)
            {
                //MessageBox.Show("Não existe nenhum produto vendido");
                panelTop10ProdutosMaisVendidos.BackColor = System.Drawing.Color.Black;
                return;
            }

            //----------------------------------------------------------------------------//

            int numeroTotalProdutos = dgvMEidprodutos.RowCount;

            Dictionary<string, decimal> nomeproduto_valor = new Dictionary<string, decimal>();

            for (int i = 0; i <= dgvMEidprodutos.Rows.Count - 1; i++)
            {
                string ID_PRODUTO = dgvMEidprodutos.Rows[i].Cells[0].Value.ToString();

                //criar a conexão
                SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                con.Open();
                SqlCommand cmd = new SqlCommand("uspTop10Produtos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_PRODUTO", ID_PRODUTO);

                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());

                string nome_produto;
                string produto_total;

                nome_produto = dt.Rows[0]["NOME_PRODUTO"].ToString();
                produto_total = dt.Rows[0]["Retorno"].ToString();

                con.Close();

                nomeproduto_valor.Add(nome_produto, Convert.ToDecimal(produto_total));
            }

            for (int x = 0; x < numeroTotalProdutos; x++)
            {
                //decimal valor_produto = nome_valor.Values.ElementAt((nome_valor.Count - 1) - x);
                var top10produtos = nomeproduto_valor.OrderBy(pair => pair.Value).ElementAt((nomeproduto_valor.Count - 1) - x);
                listDicionarioProdutos.Items.Add(top10produtos);
            }

            if (numeroTotalProdutos - 1 == 0)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutos.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Vendidos"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutos - 1 == 1)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutos.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutos.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                ///////////////////////////////////////////////////////////////////////////////////

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Vendidos"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutos - 1 == 2)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutos.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutos.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutos.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Vendidos"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutos - 1 == 3)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutos.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutos.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutos.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutos.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Vendidos"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutos - 1 == 4)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutos.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutos.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutos.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutos.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutos.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Vendidos"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutos - 1 == 5)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutos.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutos.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutos.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutos.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutos.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                //-------------------------------PRODUTO NOME 6-------------------------------//

                listDicionarioProdutos.SelectedIndex = 5;
                string nome_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings6 = nome_produto6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_produto6 = subStrings6[0];
                }

                nome_produto6 = nome_produto6.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 6-------------------------------//

                string valor_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings26 = valor_produto6.Split(',');

                valor_produto6 = subStrings26[1];

                string valor_produto6_inteiro = valor_produto6;

                valor_produto6 = subStrings26[2];

                int tamanho6 = valor_produto6.Length;
                valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

                string valor_produto6_virgula = valor_produto6;

                string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Vendidos"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutos - 1 == 6)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutos.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutos.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutos.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutos.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutos.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                //-------------------------------PRODUTO NOME 6-------------------------------//

                listDicionarioProdutos.SelectedIndex = 5;
                string nome_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings6 = nome_produto6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_produto6 = subStrings6[0];
                }

                nome_produto6 = nome_produto6.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 6-------------------------------//

                string valor_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings26 = valor_produto6.Split(',');

                valor_produto6 = subStrings26[1];

                string valor_produto6_inteiro = valor_produto6;

                valor_produto6 = subStrings26[2];

                int tamanho6 = valor_produto6.Length;
                valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

                string valor_produto6_virgula = valor_produto6;

                string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

                //-------------------------------PRODUTO NOME 7-------------------------------//

                listDicionarioProdutos.SelectedIndex = 6;
                string nome_produto7 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings7 = nome_produto7.Split(',');

                foreach (string str in subStrings7)
                {
                    nome_produto7 = subStrings7[0];
                }

                nome_produto7 = nome_produto7.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 7-------------------------------//

                string valor_produto7 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings27 = valor_produto7.Split(',');

                valor_produto7 = subStrings27[1];

                string valor_produto7_inteiro = valor_produto7;

                valor_produto7 = subStrings27[2];

                int tamanho7 = valor_produto7.Length;
                valor_produto7 = valor_produto7.Substring(0, tamanho7 - 1);

                string valor_produto7_virgula = valor_produto7;

                string valor_produto7_final = valor_produto7_inteiro + "," + valor_produto7_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto7,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto7_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Vendidos"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutos - 1 == 7)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutos.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutos.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutos.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutos.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutos.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                //-------------------------------PRODUTO NOME 6-------------------------------//

                listDicionarioProdutos.SelectedIndex = 5;
                string nome_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings6 = nome_produto6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_produto6 = subStrings6[0];
                }

                nome_produto6 = nome_produto6.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 6-------------------------------//

                string valor_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings26 = valor_produto6.Split(',');

                valor_produto6 = subStrings26[1];

                string valor_produto6_inteiro = valor_produto6;

                valor_produto6 = subStrings26[2];

                int tamanho6 = valor_produto6.Length;
                valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

                string valor_produto6_virgula = valor_produto6;

                string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

                //-------------------------------PRODUTO NOME 7-------------------------------//

                listDicionarioProdutos.SelectedIndex = 6;
                string nome_produto7 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings7 = nome_produto7.Split(',');

                foreach (string str in subStrings7)
                {
                    nome_produto7 = subStrings7[0];
                }

                nome_produto7 = nome_produto7.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 7-------------------------------//

                string valor_produto7 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings27 = valor_produto7.Split(',');

                valor_produto7 = subStrings27[1];

                string valor_produto7_inteiro = valor_produto7;

                valor_produto7 = subStrings27[2];

                int tamanho7 = valor_produto7.Length;
                valor_produto7 = valor_produto7.Substring(0, tamanho7 - 1);

                string valor_produto7_virgula = valor_produto7;

                string valor_produto7_final = valor_produto7_inteiro + "," + valor_produto7_virgula;

                //-------------------------------PRODUTO NOME 8-------------------------------//

                listDicionarioProdutos.SelectedIndex = 7;
                string nome_produto8 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings8 = nome_produto8.Split(',');

                foreach (string str in subStrings8)
                {
                    nome_produto8 = subStrings8[0];
                }

                nome_produto8 = nome_produto8.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 8-------------------------------//

                string valor_produto8 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings28 = valor_produto8.Split(',');

                valor_produto8 = subStrings28[1];

                string valor_produto8_inteiro = valor_produto8;

                valor_produto8 = subStrings28[2];

                int tamanho8 = valor_produto8.Length;
                valor_produto8 = valor_produto8.Substring(0, tamanho8 - 1);

                string valor_produto8_virgula = valor_produto8;

                string valor_produto8_final = valor_produto8_inteiro + "," + valor_produto8_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto7,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto7_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto8,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto8_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Vendidos"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutos - 1 == 8)
            {
                //-------------------------------PRODUTO NOME 1-------------------------------//

                listDicionarioProdutos.SelectedIndex = 0;
                string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings = nome_produto1.Split(',');

                foreach (string str in subStrings)
                {
                    nome_produto1 = subStrings[0];
                }

                nome_produto1 = nome_produto1.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 1-------------------------------//

                string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings21 = valor_produto1.Split(',');

                valor_produto1 = subStrings21[1];

                string valor_produto1_inteiro = valor_produto1;

                valor_produto1 = subStrings21[2];

                int tamanho1 = valor_produto1.Length;
                valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

                string valor_produto1_virgula = valor_produto1;

                string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

                //-------------------------------PRODUTO NOME 2-------------------------------//

                listDicionarioProdutos.SelectedIndex = 1;
                string nome_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings2 = nome_produto2.Split(',');

                foreach (string str in subStrings2)
                {
                    nome_produto2 = subStrings2[0];
                }

                nome_produto2 = nome_produto2.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 2-------------------------------//

                string valor_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings22 = valor_produto2.Split(',');

                valor_produto2 = subStrings22[1];

                string valor_produto2_inteiro = valor_produto2;

                valor_produto2 = subStrings22[2];

                int tamanho2 = valor_produto2.Length;
                valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

                string valor_produto2_virgula = valor_produto2;

                string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

                //-------------------------------PRODUTO NOME 3-------------------------------//

                listDicionarioProdutos.SelectedIndex = 2;
                string nome_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings3 = nome_produto3.Split(',');

                foreach (string str in subStrings3)
                {
                    nome_produto3 = subStrings3[0];
                }

                nome_produto3 = nome_produto3.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 3-------------------------------//

                string valor_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings23 = valor_produto3.Split(',');

                valor_produto3 = subStrings23[1];

                string valor_produto3_inteiro = valor_produto3;

                valor_produto3 = subStrings23[2];

                int tamanho3 = valor_produto3.Length;
                valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

                string valor_produto3_virgula = valor_produto3;

                string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

                //-------------------------------PRODUTO NOME 4-------------------------------//

                listDicionarioProdutos.SelectedIndex = 3;
                string nome_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings4 = nome_produto4.Split(',');

                foreach (string str in subStrings4)
                {
                    nome_produto4 = subStrings4[0];
                }

                nome_produto4 = nome_produto4.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 4-------------------------------//

                string valor_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings24 = valor_produto4.Split(',');

                valor_produto4 = subStrings24[1];

                string valor_produto4_inteiro = valor_produto4;

                valor_produto4 = subStrings24[2];

                int tamanho4 = valor_produto4.Length;
                valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

                string valor_produto4_virgula = valor_produto4;

                string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

                //-------------------------------PRODUTO NOME 5-------------------------------//

                listDicionarioProdutos.SelectedIndex = 4;
                string nome_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings5 = nome_produto5.Split(',');

                foreach (string str in subStrings5)
                {
                    nome_produto5 = subStrings5[0];
                }

                nome_produto5 = nome_produto5.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 5-------------------------------//

                string valor_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings25 = valor_produto5.Split(',');

                valor_produto5 = subStrings25[1];

                string valor_produto5_inteiro = valor_produto5;

                valor_produto5 = subStrings25[2];

                int tamanho5 = valor_produto5.Length;
                valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

                string valor_produto5_virgula = valor_produto5;

                string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

                //-------------------------------PRODUTO NOME 6-------------------------------//

                listDicionarioProdutos.SelectedIndex = 5;
                string nome_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings6 = nome_produto6.Split(',');

                foreach (string str in subStrings6)
                {
                    nome_produto6 = subStrings6[0];
                }

                nome_produto6 = nome_produto6.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 6-------------------------------//

                string valor_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings26 = valor_produto6.Split(',');

                valor_produto6 = subStrings26[1];

                string valor_produto6_inteiro = valor_produto6;

                valor_produto6 = subStrings26[2];

                int tamanho6 = valor_produto6.Length;
                valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

                string valor_produto6_virgula = valor_produto6;

                string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

                //-------------------------------PRODUTO NOME 7-------------------------------//

                listDicionarioProdutos.SelectedIndex = 6;
                string nome_produto7 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings7 = nome_produto7.Split(',');

                foreach (string str in subStrings7)
                {
                    nome_produto7 = subStrings7[0];
                }

                nome_produto7 = nome_produto7.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 7-------------------------------//

                string valor_produto7 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings27 = valor_produto7.Split(',');

                valor_produto7 = subStrings27[1];

                string valor_produto7_inteiro = valor_produto7;

                valor_produto7 = subStrings27[2];

                int tamanho7 = valor_produto7.Length;
                valor_produto7 = valor_produto7.Substring(0, tamanho7 - 1);

                string valor_produto7_virgula = valor_produto7;

                string valor_produto7_final = valor_produto7_inteiro + "," + valor_produto7_virgula;

                //-------------------------------PRODUTO NOME 8-------------------------------//

                listDicionarioProdutos.SelectedIndex = 7;
                string nome_produto8 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings8 = nome_produto8.Split(',');

                foreach (string str in subStrings8)
                {
                    nome_produto8 = subStrings8[0];
                }

                nome_produto8 = nome_produto8.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 8-------------------------------//

                string valor_produto8 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings28 = valor_produto8.Split(',');

                valor_produto8 = subStrings28[1];

                string valor_produto8_inteiro = valor_produto8;

                valor_produto8 = subStrings28[2];

                int tamanho8 = valor_produto8.Length;
                valor_produto8 = valor_produto8.Substring(0, tamanho8 - 1);

                string valor_produto8_virgula = valor_produto8;

                string valor_produto8_final = valor_produto8_inteiro + "," + valor_produto8_virgula;

                //-------------------------------PRODUTO NOME 9-------------------------------//

                listDicionarioProdutos.SelectedIndex = 8;
                string nome_produto9 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings9 = nome_produto9.Split(',');

                foreach (string str in subStrings9)
                {
                    nome_produto9 = subStrings9[0];
                }

                nome_produto9 = nome_produto9.Remove(0, 1);

                //-------------------------------PRODUTO VALOR 9-------------------------------//

                string valor_produto9 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

                string[] subStrings29 = valor_produto9.Split(',');

                valor_produto9 = subStrings29[1];

                string valor_produto9_inteiro = valor_produto9;

                valor_produto9 = subStrings29[2];

                int tamanho9 = valor_produto9.Length;
                valor_produto9 = valor_produto9.Substring(0, tamanho9 - 1);

                string valor_produto9_virgula = valor_produto9;

                string valor_produto9_final = valor_produto9_inteiro + "," + valor_produto9_virgula;

                /////////////////////////////////////////////////////////////////////////////////

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto1,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto2,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto3,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto4,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto5,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto6,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto7,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto7_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto8,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto8_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.Series.Add(new ColumnSeries
                {
                    Title = nome_produto9,
                    Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto9_final)
                },
                    DataLabels = true,
                    LabelPoint = point => " R$ " + point.Y,
                    MaxColumnWidth = double.PositiveInfinity
                });

                cartesianChart1.AxisX.Add(new Axis
                {
                    Labels = new[]
                    {
                        "TOP 10: Produtos mais Vendidos"
                    },
                    Separator = new Separator
                    {
                        Step = 1,
                        IsEnabled = false
                    },
                    LabelsRotation = 0
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Valor Produto (R$)",
                    LabelFormatter = value => value.ToString("C")
                });

                cartesianChart1.LegendLocation = LegendLocation.Right;
            }
            else if (numeroTotalProdutos - 1 == 9)
            {
                graficoProduto10();
            }
            else
            {
                graficoProduto10();
            }
        }

        private void graficoProduto10()
        {
            //-------------------------------PRODUTO NOME 1-------------------------------//

            listDicionarioProdutos.SelectedIndex = 0;
            string nome_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings = nome_produto1.Split(',');

            foreach (string str in subStrings)
            {
                nome_produto1 = subStrings[0];
            }

            nome_produto1 = nome_produto1.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 1-------------------------------//

            string valor_produto1 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings21 = valor_produto1.Split(',');

            valor_produto1 = subStrings21[1];

            string valor_produto1_inteiro = valor_produto1;

            valor_produto1 = subStrings21[2];

            int tamanho1 = valor_produto1.Length;
            valor_produto1 = valor_produto1.Substring(0, tamanho1 - 1);

            string valor_produto1_virgula = valor_produto1;

            string valor_produto1_final = valor_produto1_inteiro + "," + valor_produto1_virgula;

            //-------------------------------PRODUTO NOME 2-------------------------------//

            listDicionarioProdutos.SelectedIndex = 1;
            string nome_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings2 = nome_produto2.Split(',');

            foreach (string str in subStrings2)
            {
                nome_produto2 = subStrings2[0];
            }

            nome_produto2 = nome_produto2.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 2-------------------------------//

            string valor_produto2 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings22 = valor_produto2.Split(',');

            valor_produto2 = subStrings22[1];

            string valor_produto2_inteiro = valor_produto2;

            valor_produto2 = subStrings22[2];

            int tamanho2 = valor_produto2.Length;
            valor_produto2 = valor_produto2.Substring(0, tamanho2 - 1);

            string valor_produto2_virgula = valor_produto2;

            string valor_produto2_final = valor_produto2_inteiro + "," + valor_produto2_virgula;

            //-------------------------------PRODUTO NOME 3-------------------------------//

            listDicionarioProdutos.SelectedIndex = 2;
            string nome_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings3 = nome_produto3.Split(',');

            foreach (string str in subStrings3)
            {
                nome_produto3 = subStrings3[0];
            }

            nome_produto3 = nome_produto3.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 3-------------------------------//

            string valor_produto3 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings23 = valor_produto3.Split(',');

            valor_produto3 = subStrings23[1];

            string valor_produto3_inteiro = valor_produto3;

            valor_produto3 = subStrings23[2];

            int tamanho3 = valor_produto3.Length;
            valor_produto3 = valor_produto3.Substring(0, tamanho3 - 1);

            string valor_produto3_virgula = valor_produto3;

            string valor_produto3_final = valor_produto3_inteiro + "," + valor_produto3_virgula;

            //-------------------------------PRODUTO NOME 4-------------------------------//

            listDicionarioProdutos.SelectedIndex = 3;
            string nome_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings4 = nome_produto4.Split(',');

            foreach (string str in subStrings4)
            {
                nome_produto4 = subStrings4[0];
            }

            nome_produto4 = nome_produto4.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 4-------------------------------//

            string valor_produto4 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings24 = valor_produto4.Split(',');

            valor_produto4 = subStrings24[1];

            string valor_produto4_inteiro = valor_produto4;

            valor_produto4 = subStrings24[2];

            int tamanho4 = valor_produto4.Length;
            valor_produto4 = valor_produto4.Substring(0, tamanho4 - 1);

            string valor_produto4_virgula = valor_produto4;

            string valor_produto4_final = valor_produto4_inteiro + "," + valor_produto4_virgula;

            //-------------------------------PRODUTO NOME 5-------------------------------//

            listDicionarioProdutos.SelectedIndex = 4;
            string nome_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings5 = nome_produto5.Split(',');

            foreach (string str in subStrings5)
            {
                nome_produto5 = subStrings5[0];
            }

            nome_produto5 = nome_produto5.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 5-------------------------------//

            string valor_produto5 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings25 = valor_produto5.Split(',');

            valor_produto5 = subStrings25[1];

            string valor_produto5_inteiro = valor_produto5;

            valor_produto5 = subStrings25[2];

            int tamanho5 = valor_produto5.Length;
            valor_produto5 = valor_produto5.Substring(0, tamanho5 - 1);

            string valor_produto5_virgula = valor_produto5;

            string valor_produto5_final = valor_produto5_inteiro + "," + valor_produto5_virgula;

            //-------------------------------PRODUTO NOME 6-------------------------------//

            listDicionarioProdutos.SelectedIndex = 5;
            string nome_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings6 = nome_produto6.Split(',');

            foreach (string str in subStrings6)
            {
                nome_produto6 = subStrings6[0];
            }

            nome_produto6 = nome_produto6.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 6-------------------------------//

            string valor_produto6 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings26 = valor_produto6.Split(',');

            valor_produto6 = subStrings26[1];

            string valor_produto6_inteiro = valor_produto6;

            valor_produto6 = subStrings26[2];

            int tamanho6 = valor_produto6.Length;
            valor_produto6 = valor_produto6.Substring(0, tamanho6 - 1);

            string valor_produto6_virgula = valor_produto6;

            string valor_produto6_final = valor_produto6_inteiro + "," + valor_produto6_virgula;

            //-------------------------------PRODUTO NOME 7-------------------------------//

            listDicionarioProdutos.SelectedIndex = 6;
            string nome_produto7 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings7 = nome_produto7.Split(',');

            foreach (string str in subStrings7)
            {
                nome_produto7 = subStrings7[0];
            }

            nome_produto7 = nome_produto7.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 7-------------------------------//

            string valor_produto7 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings27 = valor_produto7.Split(',');

            valor_produto7 = subStrings27[1];

            string valor_produto7_inteiro = valor_produto7;

            valor_produto7 = subStrings27[2];

            int tamanho7 = valor_produto7.Length;
            valor_produto7 = valor_produto7.Substring(0, tamanho7 - 1);

            string valor_produto7_virgula = valor_produto7;

            string valor_produto7_final = valor_produto7_inteiro + "," + valor_produto7_virgula;

            //-------------------------------PRODUTO NOME 8-------------------------------//

            listDicionarioProdutos.SelectedIndex = 7;
            string nome_produto8 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings8 = nome_produto8.Split(',');

            foreach (string str in subStrings8)
            {
                nome_produto8 = subStrings8[0];
            }

            nome_produto8 = nome_produto8.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 8-------------------------------//

            string valor_produto8 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings28 = valor_produto8.Split(',');

            valor_produto8 = subStrings28[1];

            string valor_produto8_inteiro = valor_produto8;

            valor_produto8 = subStrings28[2];

            int tamanho8 = valor_produto8.Length;
            valor_produto8 = valor_produto8.Substring(0, tamanho8 - 1);

            string valor_produto8_virgula = valor_produto8;

            string valor_produto8_final = valor_produto8_inteiro + "," + valor_produto8_virgula;

            //-------------------------------PRODUTO NOME 9-------------------------------//

            listDicionarioProdutos.SelectedIndex = 8;
            string nome_produto9 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings9 = nome_produto9.Split(',');

            foreach (string str in subStrings9)
            {
                nome_produto9 = subStrings9[0];
            }

            nome_produto9 = nome_produto9.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 9-------------------------------//

            string valor_produto9 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings29 = valor_produto9.Split(',');

            valor_produto9 = subStrings29[1];

            string valor_produto9_inteiro = valor_produto9;

            valor_produto9 = subStrings29[2];

            int tamanho9 = valor_produto9.Length;
            valor_produto9 = valor_produto9.Substring(0, tamanho9 - 1);

            string valor_produto9_virgula = valor_produto9;

            string valor_produto9_final = valor_produto9_inteiro + "," + valor_produto9_virgula;

            //-------------------------------PRODUTO NOME 10-------------------------------//

            listDicionarioProdutos.SelectedIndex = 9;
            string nome_produto10 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings10 = nome_produto10.Split(',');

            foreach (string str in subStrings10)
            {
                nome_produto10 = subStrings10[0];
            }

            nome_produto10 = nome_produto10.Remove(0, 1);

            //-------------------------------PRODUTO VALOR 10-------------------------------//

            string valor_produto10 = listDicionarioProdutos.GetItemText(listDicionarioProdutos.SelectedItem);

            string[] subStrings30 = valor_produto10.Split(',');

            valor_produto10 = subStrings30[1];

            string valor_produto10_inteiro = valor_produto10;

            valor_produto10 = subStrings30[2];

            int tamanho10 = valor_produto10.Length;
            valor_produto10 = valor_produto10.Substring(0, tamanho10 - 1);

            string valor_produto10_virgula = valor_produto10;

            string valor_produto10_final = valor_produto10_inteiro + "," + valor_produto10_virgula;

            /////////////////////////////////////////////////////////////////////////////////

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto1,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto1_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto2,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto2_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto3,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto3_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto4,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto4_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto5,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto5_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto6,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto6_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto7,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto7_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto8,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto8_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto9,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto9_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = nome_produto10,
                Values = new ChartValues<decimal>
                {
                    Convert.ToDecimal(valor_produto10_final)
                },
                DataLabels = true,
                LabelPoint = point => " R$ " + point.Y,
                MaxColumnWidth = double.PositiveInfinity
            });

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[]
                {
                        "TOP 10: Produtos mais Vendidos"
                    },
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                },
                LabelsRotation = 0
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Valor Produto (R$)",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;
        }



        private void ibtnCompradosEClientes_Click(object sender, EventArgs e)
        {

        }
    }
}