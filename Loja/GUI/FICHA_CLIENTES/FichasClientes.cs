using Loja.DAO;
using Loja.DTO;
using Loja.GUI.FICHA_CLIENTES;
using Loja.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Loja
{
    public partial class FichasClientes : Form
    {
        public FichasClientes()
        {
            InitializeComponent();
            //não gerar colunas automatico
            dgvSelecionarPedido.AutoGenerateColumns = false;
            dgvPedidoProdutosCliente.AutoGenerateColumns = false;
            dgvPedidoParcelas.AutoGenerateColumns = false;
            dgvConsultaTodasParcelas.AutoGenerateColumns = false;
            lblNivelAcesso.Text = TelaLogin.nivelAcessoUsuario.ToString();
        }

        private void FichasClientes_Load(object sender, EventArgs e)
        {
            cbBuscarCliente.Focus();
            BuscarClienteComboBox();
            lblNomeCliente.Text = "";
            lblPedidoSelecionadoDGV.Text = "";
            tbValorPagoPedido.Text = "R$ 0,00";
        }

        private void BuscarClienteComboBox()
        {

            Cliente_DAO cliente_DAO = new Cliente_DAO();

            Cliente_Colecao cliente_Colecao = new Cliente_Colecao();

            cliente_Colecao = cliente_DAO.ConsultarPorNome(cbBuscarCliente.Text);

            //combobox
            cbBuscarCliente.DataSource = cliente_Colecao;
            cbBuscarCliente.ValueMember = "ID_CLIENTE";
            cbBuscarCliente.DisplayMember = "NOME_CLIENTE";

            cbBuscarCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbBuscarCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbBuscarCliente.Text = "";
            lblClienteSelecionado.Text = "";
        }

        private void cbBuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cbBuscarCliente.SelectedValue;
            lblClienteSelecionado.Text = selected.ToString();
            lblNomeCliente.Text = cbBuscarCliente.Text;
        }

        private void ibtnSelecionarCliente_Click(object sender, EventArgs e)
        {
            //////// SELECIONAR PEDIDO DO CLIENTE /////////

            if (cbBuscarCliente.Text == "")
            {
                MessageBox.Show("Você precisa Escolher um Cliente", "Escolha um Cliente.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CarregarPedidoCliente();

                setarImagemPedidoDGV();

                //verificar se tem algum registro selecionado
                if (dgvSelecionarPedido.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Esse cliente não tem nenhum pedido");
                    tbTotalDebitos.Text = "R$ 0,00";
                    tbValorPagoPedido.Text = "R$ 0,00";
                    return;
                }
                else
                {
                    //joga no lblIDpedido o codigo do pedido
                    DataGridViewRow row5 = dgvSelecionarPedido.Rows[0];
                    lblPedidoSelecionadoDGV.Text = row5.Cells[0].Value.ToString();

                    CarregarTodasParcelas();
                    calcularTodasParcelas();

                    //joga no lblIDpedido o codigo do pedido
                    DataGridViewRow row1 = dgvSelecionarPedido.Rows[0];
                    lblPedidoSelecionadoDGV.Text = row1.Cells[0].Value.ToString();

                    //joga no lblsituacaopedido a situação do pedido
                    DataGridViewRow row2 = dgvSelecionarPedido.Rows[0];
                    lblSituacaoPedido.Text = row2.Cells[3].Value.ToString();

                    //joga no lblquantParcela a quantparcela do pedido
                    DataGridViewRow row7 = dgvSelecionarPedido.Rows[0];
                    lblQuantParcelaPedido.Text = row7.Cells[1].Value.ToString();

                    //joga no lblValorPedido o valor total pedido
                    DataGridViewRow row10 = dgvSelecionarPedido.Rows[0];
                    lblValorParcelaUnica.Text = row10.Cells[2].Value.ToString();

                    CarregaPedidoListaProdutoCliente();
                    CalculoDentroProdutosDGV();

                    CarregarPedidoListaParcela();

                    if (lblQuantParcelaPedido.Text == "0")
                    {
                        //não selecionar a parcela se tiver 0 parcelas
                    }
                    else
                    {
                        //joga no lblsituacaoparcela a situação da parcela
                        DataGridViewRow row6 = dgvPedidoParcelas.Rows[0];
                        lblSituacaoParcela.Text = row6.Cells[2].Value.ToString();
                    }

                    if (lblIdParcelaSelecionadaDGV.Text == "-ID PARCELA-")
                    {
                    }
                    else
                    {
                        //joga no lblIDparcela o codigo da parcela
                        DataGridViewRow row3 = dgvPedidoParcelas.Rows[0];
                        lblIdParcelaSelecionadaDGV.Text = row3.Cells[4].Value.ToString();

                        //joga no lblsituacaoparcela a situação da parcela
                        DataGridViewRow row4 = dgvPedidoParcelas.Rows[0];
                        lblSituacaoParcela.Text = row4.Cells[2].Value.ToString();

                        //joga o valor da parcela
                        DataGridViewRow row8 = dgvPedidoParcelas.Rows[0];
                        lblValorParcela.Text = row8.Cells[1].Value.ToString();
                    }
                    if (lblSituacaoPedido.Text == "PENDENTE")
                    {
                        //joga no lblIDparcela o codigo da parcela
                        DataGridViewRow row3 = dgvPedidoParcelas.Rows[0];
                        lblIdParcelaSelecionadaDGV.Text = row3.Cells[4].Value.ToString();

                        //joga no lblsituacaoparcela a situação da parcela
                        DataGridViewRow row4 = dgvPedidoParcelas.Rows[0];
                        lblSituacaoParcela.Text = row4.Cells[2].Value.ToString();

                        //joga o valor da parcela
                        DataGridViewRow row8 = dgvPedidoParcelas.Rows[0];
                        lblValorParcela.Text = row8.Cells[1].Value.ToString();

                        //joga a data de vencimento da parcela
                        DataGridViewRow row232 = dgvPedidoParcelas.Rows[0];
                        dtpDataVencimentoParcela.Value = Convert.ToDateTime(row232.Cells[3].Value);
                    }
                    else
                    {
                        lblIdParcelaSelecionadaDGV.Text = "-ID PARCELA-";
                    }

                    if (dgvPedidoParcelas.SelectedRows.Count == 0)
                    {
                        tbTotalDebitos.Text = "R$ 0,00";
                        tbValorPagoPedido.Text = "R$ 0,00";
                    }

                    valorPagoClientePedido();
                }
            }
        }

        private void CarregarPedidoCliente()
        {
            string id_cliente = lblClienteSelecionado.Text;

            Pedido_DAO pedido_DAO = new Pedido_DAO();

            Pedido_Colecao pedido_Colecao = new Pedido_Colecao();

            pedido_Colecao = pedido_DAO.PedidoConsultar(id_cliente);

            dgvSelecionarPedido.DataSource = null;
            dgvSelecionarPedido.DataSource = pedido_Colecao;

            dgvSelecionarPedido.Update();
            dgvSelecionarPedido.Refresh();
        }

        private void CarregarTodasParcelas()
        {
            string idcliente = lblClienteSelecionado.Text;

            Pedido_DAO pedido_DAO = new Pedido_DAO();

            Pedido_Colecao pedido_Colecao = new Pedido_Colecao();

            pedido_Colecao = pedido_DAO.consultarTotalDebitosCliente(idcliente);

            dgvConsultaTodasParcelas.DataSource = null;
            dgvConsultaTodasParcelas.DataSource = pedido_Colecao;

            dgvConsultaTodasParcelas.Update();
            dgvConsultaTodasParcelas.Refresh();
        }

        private void calcularTodasParcelas()
        {
            //calcular todas parcelas

            decimal valorTotalDebitosAtivos = 0;

            if (dgvConsultaTodasParcelas.RowCount == 0)
            {
                //MessageBox.Show("O Pedido está vazio.");
                tbValor.Text = valorTotalDebitosAtivos.ToString("C");
            }
            else
            {
                // SELECIONA APENAS AS LINHAS COM PENDENTE PARA CALCULAR TOTAL DE DEBITOS
                dgvConsultaTodasParcelas.CurrentRow.Cells[1].Value.ToString();
                for (int i = 0; i <= dgvConsultaTodasParcelas.RowCount - 1; i++)
                {
                    if (dgvConsultaTodasParcelas.Rows[i].Cells[2].Value.ToString() == "1")
                        valorTotalDebitosAtivos += Convert.ToDecimal(dgvConsultaTodasParcelas.Rows[i].Cells[1].Value);
                }
                tbTotalDebitos.Text = valorTotalDebitosAtivos.ToString("C");
            }
        }

        private void dgvSelecionarPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSelecionarPedido.Rows[e.RowIndex];
                lblPedidoSelecionadoDGV.Text = row.Cells[0].Value.ToString();
                CarregaPedidoListaProdutoCliente();
                CalculoDentroProdutosDGV();

                CarregarPedidoListaParcela();

                //joga no lblsituacaopedido a situação do pedido
                DataGridViewRow row3 = dgvSelecionarPedido.Rows[e.RowIndex];
                lblSituacaoPedido.Text = row3.Cells[3].Value.ToString();

                //joga no lblquantParcela a quantparcela do pedido
                DataGridViewRow row4 = dgvSelecionarPedido.Rows[e.RowIndex];
                lblQuantParcelaPedido.Text = row4.Cells[1].Value.ToString();

                //joga no lblValorPedido o valor total pedido
                DataGridViewRow row10 = dgvSelecionarPedido.Rows[e.RowIndex];
                lblValorParcelaUnica.Text = row10.Cells[2].Value.ToString();

                //habilita
                ibtnParcial.Enabled = true;
                ibtnQuitarParcela.Enabled = true;

                if (lblSituacaoPedido.Text == "PAGO")
                {
                    lblIdParcelaSelecionadaDGV.Text = "-ID PARCELA-";
                }
                else
                {
                    DataGridViewRow row2 = dgvPedidoParcelas.Rows[0];
                    lblIdParcelaSelecionadaDGV.Text = row2.Cells[4].Value.ToString();

                    //joga no lblsituacaoparcela a situação da parcela
                    DataGridViewRow row6 = dgvPedidoParcelas.Rows[0];
                    lblSituacaoParcela.Text = row6.Cells[2].Value.ToString();

                    //joga o valor da parcela
                    DataGridViewRow row8 = dgvPedidoParcelas.Rows[0];
                    lblValorParcela.Text = row8.Cells[1].Value.ToString();

                    //joga a data de vencimento da parcela
                    DataGridViewRow row232 = dgvPedidoParcelas.Rows[0];
                    dtpDataVencimentoParcela.Value = Convert.ToDateTime(row232.Cells[3].Value);
                }

                valorPagoClientePedido();
            }
        }

        private void CarregaPedidoListaProdutoCliente()
        {
            string id_pedido = lblPedidoSelecionadoDGV.Text;

            Pedido_Produtos_DAO pedido_Produtos_DAO = new Pedido_Produtos_DAO();

            Pedido_Produtos_Colecao pedido_Produtos_Colecao = new Pedido_Produtos_Colecao();

            pedido_Produtos_Colecao = pedido_Produtos_DAO.PedidoConsultarProdutos(id_pedido);

            dgvPedidoProdutosCliente.DataSource = null;
            dgvPedidoProdutosCliente.DataSource = pedido_Produtos_Colecao;

            dgvPedidoProdutosCliente.Update();
            dgvPedidoProdutosCliente.Refresh();
        }

        private void CarregarPedidoListaParcela()
        {
            string id_pedido = lblPedidoSelecionadoDGV.Text;

            Pedido_Parcela_Finalizar_DAO pedido_Parcela_Finalizar_DAO = new Pedido_Parcela_Finalizar_DAO();

            Pedido_Parcela_Finalizar_Colecao pedido_Parcela_Finalizar_Colecao = new Pedido_Parcela_Finalizar_Colecao();

            pedido_Parcela_Finalizar_Colecao = pedido_Parcela_Finalizar_DAO.pedidoParcelasConsultar(id_pedido);

            dgvPedidoParcelas.DataSource = null;
            dgvPedidoParcelas.DataSource = pedido_Parcela_Finalizar_Colecao;

            dgvPedidoParcelas.Update();
            dgvPedidoParcelas.Refresh();
        }

        private void CalculoDentroProdutosDGV()
        {
            //Calcula todas as linhas com o total quant * valor produto
            foreach (DataGridViewRow item in dgvPedidoProdutosCliente.Rows)
            {
                int n = item.Index;

                int quant_prod = Convert.ToInt32(dgvPedidoProdutosCliente.Rows[n].Cells[2].Value);
                decimal valor_produto = Convert.ToDecimal(dgvPedidoProdutosCliente.Rows[n].Cells[3].Value);
                dgvPedidoProdutosCliente.Rows[n].Cells[4].Value = quant_prod * valor_produto;
            }

            decimal valorTotal = 0;

            if (dgvPedidoProdutosCliente.RowCount == 0)
            {
                //MessageBox.Show("O Pedido está vazio.");
                tbValor.Text = valorTotal.ToString("C");
            }
            else
            {
                dgvPedidoProdutosCliente.CurrentRow.Cells[4].Value.ToString();
                for (int i = 0; i <= dgvPedidoProdutosCliente.RowCount - 1; i++)
                {
                    if (dgvPedidoProdutosCliente.Rows[i].Cells[4].Value != null)
                        valorTotal += Convert.ToDecimal(dgvPedidoProdutosCliente.Rows[i].Cells[4].Value);
                }
                tbValor.Text = valorTotal.ToString("C");
            }
        }

        private void lblClienteSelecionado_TextChanged(object sender, EventArgs e)
        {
            /*
            lblPedidoSelecionadoDGV.Text = "";

            CarregarPedidoListaParcela();
            CarregaPedidoListaProdutoCliente();
            */
            //limpa o datagridview
            tbTotalDebitos.Text = "R$ 0,00";
            tbValor.Text = "R$ 0,00";
            tbValorPagoPedido.Text = "R$ 0,00";
            dgvPedidoParcelas.DataSource = null;
            dgvPedidoProdutosCliente.DataSource = null;
            dgvSelecionarPedido.DataSource = null;
            ibtnParcial.Enabled = true;
            ibtnQuitarParcela.Enabled = true;

            lblIdParcelaSelecionadaDGV.Text = "-ID PARCELA-";
        }



        private void ibtnQuitarPedido_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvSelecionarPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe Nenhum pedido Selecionado.");
                return;
            }

            if (lblSituacaoPedido.Text == "PAGO")
            {
                MessageBox.Show("Este pedido já esta pago");
            }
            else
            {
                try
                {

                    if (dgvPedidoParcelas.Rows.Count == 1)
                    {

                    }
                    else
                    {
                        int quant_linhas = dgvPedidoParcelas.Rows.Count;

                        int quantidadePendente = 0;

                        dgvPedidoParcelas.ClearSelection();
                        for (int i = 0; i < dgvPedidoParcelas.Rows.Count; i++)
                        {
                            for (int c = 0; c < dgvPedidoParcelas.Columns.Count; c++)
                            {
                                if (dgvPedidoParcelas.Rows[i].Cells[c].Value.ToString() == "PENDENTE")
                                {
                                    quantidadePendente++;
                                }
                            }

                        }

                        int primeiraLinhaPendente = 0;

                        primeiraLinhaPendente = quant_linhas - quantidadePendente;

                        dgvPedidoParcelas.Rows[primeiraLinhaPendente].Selected = true;


                        //CLICK NA LINHA SELECIONADA
                        var arg = new DataGridViewCellEventArgs(primeiraLinhaPendente, primeiraLinhaPendente);
                        dgvPedidoParcelas_CellClick(dgvPedidoParcelas, arg);
                    }


                    DialogResult resultado = MessageBox.Show("Deseja mesmo Quitar o pedido ? \n" +
                        "\nTodas as parcelas do pedido serão pagas, se houver pendências. ",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        QuitarPedido();

                        ValorParcelaResetar();

                        CarregarPedidoCliente();
                        CarregarPedidoListaParcela();

                        CarregarTodasParcelas();
                        calcularTodasParcelas();

                        setarImagemPedidoDGV();

                        //joga no lblsituacaoparcela a situação da parcela
                        DataGridViewRow row6 = dgvPedidoParcelas.Rows[0];
                        lblSituacaoParcela.Text = row6.Cells[2].Value.ToString();

                        //CLICK NA LINHA SELECIONADA
                        var arg = new DataGridViewCellEventArgs(0, 0);
                        dgvSelecionarPedido_CellClick(dgvSelecionarPedido, arg);

                        valorPagoClientePedido();
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

        private void QuitarPedido()
        {
            Pedido_DTO pedido_DTO = new Pedido_DTO();

            pedido_DTO.ID_PEDIDO = Convert.ToInt32(lblPedidoSelecionadoDGV.Text);

            Pedido_DAO pedido_DAO = new Pedido_DAO();

            string retorno = pedido_DAO.QuitarPedido(pedido_DTO);

            try
            {
                int id_pedido = Convert.ToInt32(retorno);

                AutoClosingMessageBox.Show("Pedido quitado com sucesso", "Pedido: " + id_pedido.ToString(), 1500);
            }
            catch
            {
                MessageBox.Show("Não foi possivel quitar o pedido. Detalhes:"
                    + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Quitar todas as parcelas do pedido
            Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO = new Pedido_Parcela_Finalizar_DTO();

            pedido_Parcela_Finalizar_DTO.ID_PEDIDO = Convert.ToInt32(lblPedidoSelecionadoDGV.Text);

            pedido_Parcela_Finalizar_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

            Pedido_Parcela_Finalizar_DAO pedido_Parcela_Finalizar_DAO = new Pedido_Parcela_Finalizar_DAO();

            string retornoParcelas = pedido_Parcela_Finalizar_DAO.QuitarTodasParcelas(pedido_Parcela_Finalizar_DTO);

            try
            {
                int id_pedidoParcelado = Convert.ToInt32(retornoParcelas);

                //MessageBox.Show("Parcelas do pedido quitadas", id_pedidoParcelado.ToString());
            }
            catch
            {
                MessageBox.Show("Não foi possivel quitar todas as parcelas do pedido. Detalhes:"
                    + retornoParcelas, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibtQuitarParcela_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvPedidoParcelas.SelectedRows.Count == 0)
            {
                AutoClosingMessageBox.Show("Não existe Nenhuma Parcela Selecionada.", "Nenhuma Parcela Selecionada", 1200);
                return;
            }

            if (lblSituacaoParcela.Text == "PAGO")
            {
                AutoClosingMessageBox.Show("Esta parcela já esta paga", "Parcela já Paga ", 1200);
            }
            else
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja quitar a parcela ? \n" +
                        "\nA Parcela selecionada sera paga. ",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        QuitarParcela();

                        ValorParcelaResetar();

                        CarregarPedidoListaParcela();

                        CarregarTodasParcelas();
                        calcularTodasParcelas();

                        DataGridViewRow row2 = dgvPedidoParcelas.Rows[0];
                        lblIdParcelaSelecionadaDGV.Text = row2.Cells[4].Value.ToString();

                        ChecarUltimaParcela();

                        //joga no lblsituacaoparcela a situação da parcela
                        DataGridViewRow row6 = dgvPedidoParcelas.Rows[0];
                        lblSituacaoParcela.Text = row6.Cells[2].Value.ToString();

                        //joga a data de vencimento da parcela
                        DataGridViewRow row232 = dgvPedidoParcelas.Rows[0];
                        dtpDataVencimentoParcela.Value = Convert.ToDateTime(row232.Cells[3].Value);

                        valorPagoClientePedido();
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

        private void QuitarParcela()
        {
            Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO = new Pedido_Parcela_Finalizar_DTO();

            pedido_Parcela_Finalizar_DTO.ID_PARCELA = Convert.ToInt32(lblIdParcelaSelecionadaDGV.Text);

            pedido_Parcela_Finalizar_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

            Pedido_Parcela_Finalizar_DAO pedido_Parcela_Finalizar_DAO = new Pedido_Parcela_Finalizar_DAO();

            string retornoParcelas = pedido_Parcela_Finalizar_DAO.QuitarParcela(pedido_Parcela_Finalizar_DTO);

            try
            {
                int id_pedidoParcelado = Convert.ToInt32(retornoParcelas);

                AutoClosingMessageBox.Show("Parcela quitada com sucesso.", "Parcela: " + id_pedidoParcelado.ToString(), 1100);

                //MessageBox.Show("Parcela quitada com sucesso.", "Parcela: " + id_pedidoParcelado.ToString());

                //joga no lblsituacaoparcela a situação da parcela
                DataGridViewRow row6 = dgvPedidoParcelas.Rows[0];
                lblSituacaoParcela.Text = row6.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possivel quitar a parcela selecionada. Detalhes:"
                    + retornoParcelas, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValorParcelaResetar()
        {
            int quant_linhas = dgvPedidoParcelas.Rows.Count - 1;

            if (quant_linhas == 0)
            {
                Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO = new Pedido_Parcela_Finalizar_DTO();

                pedido_Parcela_Finalizar_DTO.ID_PARCELA = Convert.ToInt32(lblIdParcelaSelecionadaDGV.Text);
                pedido_Parcela_Finalizar_DTO.VALOR_PARCELA = Convert.ToDecimal(lblValorParcelaUnica.Text);

                Pedido_Parcela_Finalizar_DAO pedido_Parcela_Finalizar_DAO = new Pedido_Parcela_Finalizar_DAO();

                string retorno = pedido_Parcela_Finalizar_DAO.valorParcelaResetar(pedido_Parcela_Finalizar_DTO);

                try
                {
                    int id_parcela = Convert.ToInt32(retorno);
                }
                catch
                {
                    MessageBox.Show("Não foi possivel resetar o valor da parcela Detalhes:" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO = new Pedido_Parcela_Finalizar_DTO();

                pedido_Parcela_Finalizar_DTO.ID_PARCELA = Convert.ToInt32(lblIdParcelaSelecionadaDGV.Text);
                pedido_Parcela_Finalizar_DTO.VALOR_PARCELA = Convert.ToDecimal(lblValorParcelaAbaixo.Text);

                Pedido_Parcela_Finalizar_DAO pedido_Parcela_Finalizar_DAO = new Pedido_Parcela_Finalizar_DAO();

                string retorno = pedido_Parcela_Finalizar_DAO.valorParcelaResetar(pedido_Parcela_Finalizar_DTO);

                try
                {
                    int id_parcela = Convert.ToInt32(retorno);
                }
                catch
                {
                    MessageBox.Show("Não foi possivel resetar o valor da parcela Detalhes:" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void dgvPedidoParcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //joga no lbl id parcela
                DataGridViewRow row = dgvPedidoParcelas.Rows[e.RowIndex];
                lblIdParcelaSelecionadaDGV.Text = row.Cells[4].Value.ToString();

                //joga no lblsituacaoparcela a situação da parcela
                DataGridViewRow row2 = dgvPedidoParcelas.Rows[e.RowIndex];
                lblSituacaoParcela.Text = row2.Cells[2].Value.ToString();

                //joga o valor da parcela
                DataGridViewRow row8 = dgvPedidoParcelas.Rows[e.RowIndex];
                lblValorParcela.Text = row8.Cells[1].Value.ToString();

                //joga a data de vencimento da parcela
                DataGridViewRow row232 = dgvPedidoParcelas.Rows[e.RowIndex];
                dtpDataVencimentoParcela.Value = Convert.ToDateTime(row232.Cells[3].Value);

                int quant_linhas = dgvPedidoParcelas.Rows.Count - 1;

                if (e.RowIndex < quant_linhas)
                {
                    //joga o valor da parcela abaixo
                    DataGridViewRow row10 = dgvPedidoParcelas.Rows[e.RowIndex + 1];
                    lblValorParcelaAbaixo.Text = row10.Cells[1].Value.ToString();
                }
                else
                {
                    if (quant_linhas == 0)
                    {
                        //joga o valor da parcela
                        DataGridViewRow row10 = dgvPedidoParcelas.Rows[e.RowIndex];
                        lblValorParcelaAbaixo.Text = row10.Cells[1].Value.ToString();
                    }
                    else
                    {
                        //joga o valor da parcela acima
                        DataGridViewRow row10 = dgvPedidoParcelas.Rows[e.RowIndex - 1];
                        lblValorParcelaAbaixo.Text = row10.Cells[1].Value.ToString();
                    }
                }

                //VALIDAÇÃO PAGAR PARCELAS ---------------------------------------------------

                //obter a linha da celula selecionada
                DataGridViewRow linhaAtual = dgvPedidoParcelas.CurrentRow;

                //exibir o indice da linha atual
                int indice = linhaAtual.Index;

                //pegar quantidade de linhas
                int numeroTotalLinhas = dgvPedidoParcelas.RowCount - 1;

                if (numeroTotalLinhas == 0)
                {
                }
                else if (numeroTotalLinhas == 1)
                {
                    string linhaParcela1 = dgvPedidoParcelas.Rows[0].Cells[2].Value.ToString();

                    if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 0)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela1 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A PRIMEIRA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                }
                else if (numeroTotalLinhas == 2)
                {
                    string linhaParcela1 = dgvPedidoParcelas.Rows[0].Cells[2].Value.ToString();
                    string linhaParcela2 = dgvPedidoParcelas.Rows[1].Cells[2].Value.ToString();

                    if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 0)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela1 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A PRIMEIRA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 1)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela2 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A SEGUNDA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                }
                else if (numeroTotalLinhas == 3)
                {
                    string linhaParcela1 = dgvPedidoParcelas.Rows[0].Cells[2].Value.ToString();
                    string linhaParcela2 = dgvPedidoParcelas.Rows[1].Cells[2].Value.ToString();
                    string linhaParcela3 = dgvPedidoParcelas.Rows[2].Cells[2].Value.ToString();

                    if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 0)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela1 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A PRIMEIRA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 1)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela2 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A SEGUNDA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 2)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela3 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A TERCEIRA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                }
                else if (numeroTotalLinhas == 4)
                {
                    string linhaParcela1 = dgvPedidoParcelas.Rows[0].Cells[2].Value.ToString();
                    string linhaParcela2 = dgvPedidoParcelas.Rows[1].Cells[2].Value.ToString();
                    string linhaParcela3 = dgvPedidoParcelas.Rows[2].Cells[2].Value.ToString();
                    string linhaParcela4 = dgvPedidoParcelas.Rows[3].Cells[2].Value.ToString();

                    if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 0)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela1 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A PRIMEIRA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 1)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela2 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A SEGUNDA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 2)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela3 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A TERCEIRA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && indice == 3)
                    {
                        //MessageBox.Show("HABILITAR O BOTÃO");
                        ibtnQuitarParcela.Enabled = true;
                        ibtnParcial.Enabled = true;
                    }
                    else if (row2.Cells[2].Value.ToString() == "PENDENTE" && linhaParcela4 == "PENDENTE")
                    {
                        AutoClosingMessageBox.Show("PAGUE A QUARTA PARCELA", "Necessário: ", 1200);
                        ibtnQuitarParcela.Enabled = false;
                        ibtnParcial.Enabled = false;
                    }
                }
                else
                {
                    //se não tiver nenhum dado no datagridview não fazer nada
                }
            }
        }

        private void ChecarUltimaParcela()
        {
            /// PEGA A ULTIMA LINHA DAS PARCELAS SE ESTIVER PAGA QUITA O PEDIDO

            int numeroLinhas = dgvPedidoParcelas.RowCount - 1;

            if (dgvPedidoParcelas.Rows[numeroLinhas].Cells[2].Value.ToString() == "PAGO")
            {
                QuitarPedido();
                CarregarPedidoCliente();
                setarImagemPedidoDGV();

                //CLICK NA LINHA SELECIONADA
                var arg = new DataGridViewCellEventArgs(0, 0);
                dgvSelecionarPedido_CellClick(dgvSelecionarPedido, arg);

            }
            else
            {
                //não fazer nada
            }
        }

        private void setarImagemPedidoDGV()
        {
            foreach (DataGridViewRow item in dgvSelecionarPedido.Rows)
            {
                int n = item.Index;

                //Percorre por todas as as linhas que tem PAGO e seta um imagem na celula 5

                if (dgvSelecionarPedido.Rows[n].Cells[3].Value.ToString() == "PAGO")
                {
                    DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();

                    dgvSelecionarPedido.Rows[n].Cells[5].Value = dataGridViewImageColumn.Image = Resources.pago;
                }
                else
                {
                    DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();

                    dgvSelecionarPedido.Rows[n].Cells[5].Value = dataGridViewImageColumn.Image = Resources.pendente;
                }
            }
        }

        private void cbBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnSelecionarCliente_Click(this, new EventArgs());
            }
        }

        private void ibtnGerarCarnes_Click(object sender, EventArgs e)
        {
            if (lblQuantParcelaPedido.Text == "-QUANT PARCELA-")
            {
                MessageBox.Show("Selecione um pedido");
            }
            else if (lblQuantParcelaPedido.Text == "0")
            {
                MessageBox.Show("Esse pedido não foi Parcelado.");
            }
            else
            {
                if (Application.OpenForms.OfType<GeradorCarnes>().Count() > 0)
                {
                    //Não vai executar nada
                }
                else
                {
                    GeradorCarnes geradorCarnesForm = new GeradorCarnes(lblPedidoSelecionadoDGV.Text, cbBuscarCliente.Text);
                    geradorCarnesForm.ShowDialog();
                }
            }
        }

        private void ibtnParcial_Click(object sender, EventArgs e)
        {
            if (dgvPedidoParcelas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido que tem parcelas.");
            }
            else
            {
                if (lblSituacaoParcela.Text == "PAGO")
                {
                    MessageBox.Show("Não é possivel efetuar um pagamento parcial em um parcela Paga.");
                }
                else
                {
                    if (Application.OpenForms.OfType<PagamentoParcial>().Count() > 0)
                    {
                        //Não vai executar nada
                    }
                    else
                    {
                        PagamentoParcial pagamentoParcial =
                            new PagamentoParcial(lblIdParcelaSelecionadaDGV.Text, lblValorParcela.Text, dtpDataVencimentoParcela.Value);

                        DialogResult dialogResult = pagamentoParcial.ShowDialog();
                        if (dialogResult == DialogResult.Yes)
                        {
                            CarregarPedidoListaParcela();

                            CarregarTodasParcelas();
                            calcularTodasParcelas();

                            //joga o valor da parcela
                            DataGridViewRow row8 = dgvPedidoParcelas.Rows[0];
                            lblValorParcela.Text = row8.Cells[1].Value.ToString();

                            //joga a data de vencimento da parcela
                            DataGridViewRow row232 = dgvPedidoParcelas.Rows[0];
                            dtpDataVencimentoParcela.Value = Convert.ToDateTime(row232.Cells[3].Value);

                            valorPagoClientePedido();

                        }
                    }
                }
            }
        }

        private void dgvPedidoParcelas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvPedidoParcelas.SelectedRows.Count == -1)
            {
                MessageBox.Show("Selecione um pedido que tem parcelas.");
            }
            else
            {
                //joga o valor da parcela
                DataGridViewRow row8 = dgvPedidoParcelas.Rows[e.RowIndex];
                lblValorParcela.Text = row8.Cells[1].Value.ToString();

                //joga o valor da parcela abaixo
                DataGridViewRow row10 = dgvPedidoParcelas.Rows[e.RowIndex];
                lblValorParcelaAbaixo.Text = row10.Cells[1].Value.ToString();

                //joga no lblsituacaoparcela a situação da parcela
                DataGridViewRow row2 = dgvPedidoParcelas.Rows[e.RowIndex];
                lblSituacaoParcela.Text = row2.Cells[2].Value.ToString();
            }
        }

        private void ibtnDevolucaoDinheiro_Click(object sender, EventArgs e)
        {
            if (cbBuscarCliente.Text != "" && cbBuscarCliente.Text == lblNomeCliente.Text)
            {
                if (Application.OpenForms.OfType<ValorDevolucaoCaixa>().Count() > 0)
                {
                    //Não vai executar nada
                }
                else
                {
                    ValorDevolucaoCaixa valorDevolucaoCaixa = new ValorDevolucaoCaixa(lblNomeCliente.Text);
                    valorDevolucaoCaixa.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Cliente para realizar uma Devolução");
            }
        }

        private void RemoverPedido()
        {
            string valor_pago = tbValorPagoPedido.Text.Replace("R$ ", "");

            Pedido_DTO pedido_DTO = new Pedido_DTO();

            pedido_DTO.ID_PEDIDO = Convert.ToInt32(lblPedidoSelecionadoDGV.Text);
            pedido_DTO.VALOR_PAGO = Convert.ToDecimal(valor_pago);
            pedido_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

            Pedido_DAO pedido_DAO = new Pedido_DAO();

            string retorno = pedido_DAO.RemoverPedido(pedido_DTO);

            try
            {
                int idpedido = Convert.ToInt32(retorno);

                MessageBox.Show("Remoção concluida.");

                ibtnDevolucaoDinheiro.PerformClick();
            }
            catch
            {
                MessageBox.Show("Não foi possivel remover o pedido. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibtnRemoverPedido_Click(object sender, EventArgs e)
        {
            if (dgvSelecionarPedido.SelectedRows.Count == 0)
            {
                MessageBox.Show("Não existe nenhum pedido selecionado para se realizar uma devolução de pedido.", "Devolução de pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Deseja mesmo realizar uma Devolução ? \n" +
                        "\nTodas as parcelas do pedido serão apagadas, e todos os produtos serão adicionados de volta ao estoque. ",
                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.Yes)
                    {
                        RemoverPedido();

                        CarregarPedidoCliente();

                        if(dgvSelecionarPedido.SelectedRows.Count == 0)
                        {
                            //não fazer nada
                        }
                        else
                        {
                            //joga no lblIDpedido o codigo do pedido
                            DataGridViewRow row5 = dgvSelecionarPedido.Rows[0];
                            lblPedidoSelecionadoDGV.Text = row5.Cells[0].Value.ToString();
                        }

                        CarregaPedidoListaProdutoCliente();
                        CalculoDentroProdutosDGV();

                        CarregarPedidoListaParcela();

                        setarImagemPedidoDGV();

                        CarregarTodasParcelas();
                        calcularTodasParcelas();

                        valorPagoClientePedido();
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
            if (dgvSelecionarPedido.SelectedRows.Count == 0)
            {
                tbTotalDebitos.Text = "R$ 0,00";
                tbValor.Text = "R$ 0,00";
                tbValorPagoPedido.Text = "R$ 0,00";
                dgvPedidoParcelas.DataSource = null;
                dgvPedidoProdutosCliente.DataSource = null;
            }
        }

        private void tbTotalDebitos_TextChanged(object sender, EventArgs e)
        {
            if (tbTotalDebitos.Text == "R$ 0,00")
            {
                this.tbTotalDebitos.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                this.tbTotalDebitos.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void valorPagoClientePedido()
        {
            string ID_PEDIDO = lblPedidoSelecionadoDGV.Text;

            //criar a conexão
            SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

            con.Open();
            SqlCommand cmd = new SqlCommand("uspValorPagoClientePedido", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_PEDIDO", ID_PEDIDO);

            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());

            decimal valor_pago_pedido;

            valor_pago_pedido = Convert.ToDecimal(dt.Rows[0]["VALOR_PAGO_PEDIDO"]);

            tbValorPagoPedido.Text = valor_pago_pedido.ToString("C");

            con.Close();
        }

        private void ibtnAlterarDataVencimentoParcela_Click(object sender, EventArgs e)
        {
            if (dgvPedidoParcelas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido que tem parcelas.");
            }
            else
            {
                if (lblSituacaoParcela.Text == "PAGO")
                {
                    MessageBox.Show("Não é possivel alterar data do parcelamento de um pedido Pago.");
                }
                else
                {
                    if (Application.OpenForms.OfType<AlterarDataVencimentoParcela>().Count() > 0)
                    {
                        //Não vai executar nada
                    }
                    else
                    {
                        AlterarDataVencimentoParcela alterarDataVencimentoParcela = new AlterarDataVencimentoParcela(lblIdParcelaSelecionadaDGV.Text, dtpDataVencimentoParcela.Value);
                        DialogResult dialogResult = alterarDataVencimentoParcela.ShowDialog();

                        if (dialogResult == DialogResult.Yes)
                        {
                            CarregarPedidoListaParcela();

                            //CLICK NA LINHA SELECIONADA
                            var arg = new DataGridViewCellEventArgs(0, 0);
                            dgvSelecionarPedido_CellClick(dgvSelecionarPedido, arg);
                        }
                    }
                }
            }

        }

        private void ibtnPopupInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os Valores dos Produtos, se forem alterados no Estoque Produtos, Serão alterados aqui tbm," +
                " então não baseie o valor dos total pedido nisso!", "Informação");
        }
    }
}