using Loja.DAO;
using Loja.DTO;
using Loja.GUI.CAIXA;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Caixa : Form
    {
        private Font boldEmpresa = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
        private Font bold = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
        private Font regular = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        private Font regularItens = new Font(FontFamily.GenericSansSerif, 6, FontStyle.Regular);

        public Caixa()
        {
            InitializeComponent();
            //não gerar colunas automatico
            dgvListaPedidoProdutos.AutoGenerateColumns = false;
        }

        public string lblPedidoCriadoRetorno
        {
            get { return lblIdPedidoCriado.Text; }
            set { lblIdPedidoCriado.Text = lblIdPedidoCriado.Text; }
        }

        public Caixa(string parametro) : this()
        {
            lblIdPedidoCriado.Text = parametro;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            cbFormaPagamento.SelectedIndex = 0;
            cbQuantidadeParcelas.SelectedIndex = 0;
            cbQuantidadeProduto.Enabled = false;

            BuscarClienteComboBox();
            BuscarProdutoComboBox();

            lblIdPedidoCriado.Text = "";

            cbSelecionarCliente.Focus();

            //Desabilitar campo para adicionar produto
            cbAdicionarProduto.Enabled = false;
            cbQuantidadeProduto.Enabled = false;
            ibtnAdicionarProduto.Enabled = false;
            ibtnRemoveProduto.Enabled = false;

            ibtnFinalizarPedido.Enabled = false;

            cbQuantidadeEstoque.Text = "0";

            //Setar o campos com um valor 0 quando inicia

            decimal valor = 0;
            tbValor.Text = valor.ToString("C");
            tbDinheiro.Text = "0";
            tbValorTotal.Text = valor.ToString("C");

            //iniciar date timer com 30 dias a frente
            dtpDataPagamento.Value = DateTime.Now.AddMonths(1);

            listarIdsProdutos();
            listarNomesProdutos();
        }

        private void BuscarClienteComboBox()
        {
            Cliente_DAO cliente_DAO = new Cliente_DAO();

            Cliente_Colecao cliente_Colecao = new Cliente_Colecao();

            cliente_Colecao = cliente_DAO.ConsultarPorNome(cbSelecionarCliente.Text);

            //combobox
            cbSelecionarCliente.DataSource = cliente_Colecao;
            cbSelecionarCliente.ValueMember = "ID_CLIENTE";
            cbSelecionarCliente.DisplayMember = "NOME_CLIENTE";

            cbSelecionarCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSelecionarCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbSelecionarCliente.Text = "";
            lblClienteSelecionado.Text = "";
        }

        private void listarIdsProdutos()
        {
            Produto_DAO produto_DAO = new Produto_DAO();

            Produto_Colecao produto_Colecao = new Produto_Colecao();

            produto_Colecao = produto_DAO.listarIdsProdutos();

            //combobox
            listBoxIdEstoque.DataSource = produto_Colecao;
            listBoxIdEstoque.ValueMember = "ID_PRODUTO";
            listBoxIdEstoque.DisplayMember = "ID_PRODUTO";
        }

        private void listarNomesProdutos()
        {
            Produto_DAO produto_DAO = new Produto_DAO();

            Produto_Colecao produto_Colecao = new Produto_Colecao();

            produto_Colecao = produto_DAO.listarNomesProdutos();

            //combobox
            listBoxNomeProduto.DataSource = produto_Colecao;
            listBoxNomeProduto.ValueMember = "NOME_PRODUTO";
            listBoxNomeProduto.DisplayMember = "NOME_PRODUTO";
        }

        private void BuscarProdutoComboBox()
        {
            Produto_DAO produto_DAO = new Produto_DAO();

            Produto_Colecao produto_Colecao = new Produto_Colecao();

            produto_Colecao = produto_DAO.ConsultarPorNome(cbAdicionarProduto.Text);

            //combobox
            cbAdicionarProduto.DataSource = produto_Colecao;
            cbAdicionarProduto.ValueMember = "ID_PRODUTO";
            cbAdicionarProduto.DisplayMember = "NOME_PRODUTO";

            cbAdicionarProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAdicionarProduto.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbAdicionarProduto.Text = "";
            lblProdutoSelecionado.Text = "";
        }

        private void CalcularJurosDebitoCredito()
        {
            double valor_total_produtos = valor_total_pedido;

            if (cbFormaPagamento.Text == "Débito")
            {
                double valor_juros_debito = valor_total_produtos;

                valor_juros_debito = 0.0239 * valor_total_produtos;

                valor_total_produtos = valor_total_produtos - valor_juros_debito;

                tbValor.Text = valor_total_produtos.ToString("C");
            }
            else if(cbFormaPagamento.Text == "Crédito 1x")
            {
                double valor_juros_creditox1 = valor_total_produtos;

                valor_juros_creditox1 = 0.0499 * valor_total_produtos;

                valor_total_produtos = valor_total_produtos - valor_juros_creditox1;

                tbValor.Text = valor_total_produtos.ToString("C");
            }
            else if (cbFormaPagamento.Text == "Crédito 2x")
            {
                double valor_juros_creditox2 = valor_total_produtos;

                valor_juros_creditox2 = 0.0559 * valor_total_produtos;

                valor_total_produtos = valor_total_produtos - valor_juros_creditox2;

                tbValor.Text = valor_total_produtos.ToString("C");
            }
            else if (cbFormaPagamento.Text == "Crédito 3x")
            {
                double valor_juros_creditox3 = valor_total_produtos;

                valor_juros_creditox3 = 0.0559 * valor_total_produtos;

                valor_total_produtos = valor_total_produtos - valor_juros_creditox3;

                tbValor.Text = valor_total_produtos.ToString("C");
            }
            else if (cbFormaPagamento.Text == "Crédito 4x")
            {
                double valor_juros_creditox4 = valor_total_produtos;

                valor_juros_creditox4 = 0.0559 * valor_total_produtos;

                valor_total_produtos = valor_total_produtos - valor_juros_creditox4;

                tbValor.Text = valor_total_produtos.ToString("C");
            }
            else if (cbFormaPagamento.Text == "Crédito 5x")
            {
                double valor_juros_creditox5 = valor_total_produtos;

                valor_juros_creditox5 = 0.0559 * valor_total_produtos;

                valor_total_produtos = valor_total_produtos - valor_juros_creditox5;

                tbValor.Text = valor_total_produtos.ToString("C");
            }
            else
            {
                tbValor.Text = valor_total_pedido.ToString("C");
            }

        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFormaPagamento.SelectedIndex == 0)
            {
                lblDinheiroEntrada.Text = "Dinheiro";
                cbQuantidadeParcelas.Visible = false;
                dtpDataPagamento.Visible = false;
                textQuantidadeParcelas.Visible = false;
                textDataPagamento.Visible = false;
                ibtnVerParcelas.Visible = false;
                ibtnFinalizarPedido.Visible = true;

                lblJuros.Visible = false;
            }
            else if (cbFormaPagamento.SelectedIndex == 1)
            {
                lblDinheiroEntrada.Text = "Entrada";
                cbQuantidadeParcelas.Visible = true;
                dtpDataPagamento.Visible = true;
                textQuantidadeParcelas.Visible = true;
                textDataPagamento.Visible = true;
                ibtnVerParcelas.Visible = true;
                ibtnFinalizarPedido.Visible = false;

                lblJuros.Visible = false;
            }
            else if (cbFormaPagamento.SelectedIndex == 2)
            {
                lblDinheiroEntrada.Text = "Débito";
                cbQuantidadeParcelas.Visible = false;
                dtpDataPagamento.Visible = false;
                textQuantidadeParcelas.Visible = false;
                textDataPagamento.Visible = false;
                ibtnVerParcelas.Visible = false;
                ibtnFinalizarPedido.Visible = true;

                lblJuros.Visible = false;

                lblJuros.Text = "Os Juros são sobre o valor total 2,39%";
                lblJuros.Visible = true;

            }
            else if (cbFormaPagamento.SelectedIndex == 3)
            {
                lblDinheiroEntrada.Text = "Crédito 1x";
                cbQuantidadeParcelas.Visible = false;
                dtpDataPagamento.Visible = false;
                textQuantidadeParcelas.Visible = false;
                textDataPagamento.Visible = false;
                ibtnVerParcelas.Visible = false;
                ibtnFinalizarPedido.Visible = true;

                lblJuros.Text = "Os Juros são sobre o valor total 4,99%";
                lblJuros.Visible = true;
            }
            else if (cbFormaPagamento.SelectedIndex == 4)
            {
                lblDinheiroEntrada.Text = "Crédito 2x";
                cbQuantidadeParcelas.Visible = false;
                dtpDataPagamento.Visible = false;
                textQuantidadeParcelas.Visible = false;
                textDataPagamento.Visible = false;
                ibtnVerParcelas.Visible = false;
                ibtnFinalizarPedido.Visible = true;

                lblJuros.Text = "Os Juros são sobre o valor total 5,59%";
                lblJuros.Visible = true;
            }
            else if (cbFormaPagamento.SelectedIndex == 5)
            {
                lblDinheiroEntrada.Text = "Crédito 3x";
                cbQuantidadeParcelas.Visible = false;
                dtpDataPagamento.Visible = false;
                textQuantidadeParcelas.Visible = false;
                textDataPagamento.Visible = false;
                ibtnVerParcelas.Visible = false;
                ibtnFinalizarPedido.Visible = true;

                lblJuros.Text = "Os Juros são sobre o valor total 5,59%";
                lblJuros.Visible = true;
            }
            else if (cbFormaPagamento.SelectedIndex == 6)
            {
                lblDinheiroEntrada.Text = "Crédito 4x";
                cbQuantidadeParcelas.Visible = false;
                dtpDataPagamento.Visible = false;
                textQuantidadeParcelas.Visible = false;
                textDataPagamento.Visible = false;
                ibtnVerParcelas.Visible = false;
                ibtnFinalizarPedido.Visible = true;

                lblJuros.Text = "Os Juros são sobre o valor total 5,59%";
                lblJuros.Visible = true;
            }
            else
            {
                lblDinheiroEntrada.Text = "Crédito 5x";
                cbQuantidadeParcelas.Visible = false;
                dtpDataPagamento.Visible = false;
                textQuantidadeParcelas.Visible = false;
                textDataPagamento.Visible = false;
                ibtnVerParcelas.Visible = false;
                ibtnFinalizarPedido.Visible = true;

                lblJuros.Text = "Os Juros são sobre o valor total 5,59%";
                lblJuros.Visible = true;
            }

        }

        private void cbSelecionarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cbSelecionarCliente.SelectedValue;
            lblClienteSelecionado.Text = selected.ToString();
        }

        private void cbAdicionarProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cbAdicionarProduto.SelectedValue;
            lblProdutoSelecionado.Text = selected.ToString();
        }

        private void ibtnCriarPedido_Click(object sender, EventArgs e)
        {
            //////// CRIAR PEDIDO AO SELECIONAR UM CLIENTE /////////

            if (cbSelecionarCliente.Text == "")
            {
                MessageBox.Show("Você precisa Selecionar um Cliente", "Selecione um Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Pedido_DTO pedido_DTO = new Pedido_DTO();

                string id_cliente = lblClienteSelecionado.Text;

                pedido_DTO.ID_CLIENTE = Convert.ToInt32(id_cliente);

                pedido_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

                Pedido_DAO pedido_DAO = new Pedido_DAO();

                string retorno = pedido_DAO.CriarPedido(pedido_DTO);

                try
                {
                    int id_pedido = Convert.ToInt32(retorno);

                    lblIdPedidoCriado.Text = id_pedido.ToString();

                    ibtnCriarPedido.Enabled = false;

                    cbSelecionarCliente.Enabled = false;

                    //Manda o lblpedidocriado do form caixa para o form sistema
                    Sistema sistema = new Sistema(lblPedidoCriadoRetorno);

                    //Habilitar campo para adicionar produto
                    cbAdicionarProduto.Enabled = true;
                    cbQuantidadeProduto.Enabled = false;
                    ibtnAdicionarProduto.Enabled = true;
                    ibtnRemoveProduto.Enabled = true;

                    cbAdicionarProduto.Focus();
                }
                catch
                {
                    MessageBox.Show("Não foi possivel criar pedido. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetarPedido()
        {
            if (ibtnCriarPedido.Enabled == true)
            {
                MessageBox.Show("Para Resetar Você precisa Criar um Pedido",
                    "Você não criou um pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Pedido_DTO pedido_DTO = new Pedido_DTO();

                string id_pedido = lblIdPedidoCriado.Text;

                pedido_DTO.ID_PEDIDO = Convert.ToInt32(id_pedido);

                Pedido_DAO pedido_DAO = new Pedido_DAO();

                string retorno = pedido_DAO.ResetarPedido(pedido_DTO);

                try
                {
                    int idpedido = Convert.ToInt32(retorno);

                    ibtnCriarPedido.Enabled = true;

                    cbSelecionarCliente.Enabled = true;

                    lblIdPedidoCriado.Text = "";

                    cbSelecionarCliente.Focus();

                    cbQuantidadeEstoque.Text = "";

                    lblProdutoSelecionado.Text = "";

                    cbAdicionarProduto.Text = "";

                    cbSelecionarCliente.Text = "";

                    lblClienteSelecionado.Text = "";

                    cbFormaPagamento.SelectedIndex = 0;

                    //Desabilitar campo ao Resetar Pedido
                    ibtnRemoveProduto.Enabled = false;
                    ibtnAdicionarProduto.Enabled = false;
                    cbQuantidadeProduto.Enabled = false;
                    cbAdicionarProduto.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Não foi resetar o pedido. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Caixa_Leave(object sender, EventArgs e)
        {
            if (lblIdPedidoCriado.Text == "")
            {
            }
            else
            {
                ResetarPedido();
            }
        }

        private void quantidadeEstoqueProduto()
        {
            string idproduto = cbAdicionarProduto.Text;

            // MOSTRAR A QUANTIDADE EM ESTOQUE DO PRODUTO NO CB

            cbQuantidadeProduto.Enabled = true;

            Produto_DTO produto_DTO = new Produto_DTO();

            Produto_DAO produto_DAO = new Produto_DAO();

            Produto_Colecao produto_Colecao = new Produto_Colecao();

            produto_Colecao = produto_DAO.CarregarQuantidadeProduto(idproduto);

            cbQuantidadeEstoque.Enabled = false;

            cbQuantidadeEstoque.DataSource = produto_Colecao;
            cbQuantidadeEstoque.DisplayMember = "QUANT_PROD";

            //DEIXA SELECIONAR NO CBQUANT_PROD SÓ O VALOR QUE ESTA EM ESTOQUE
            int quant_prod = Convert.ToInt32(cbQuantidadeEstoque.Text);

            cbQuantidadeProduto.DataSource = Enumerable.Range(1, quant_prod).ToList();
        }

        private void ibtnAdicionarProduto_Click(object sender, EventArgs e)
        {
            //////// ADICIONAR PRODUTO AO SELECIONAR UM PRODUTO /////////

            string textoCombobox = cbAdicionarProduto.Text;

            int num;

            bool isNum = Int32.TryParse(textoCombobox, out num);

            if (cbAdicionarProduto.Text == "")
            {
                MessageBox.Show("Você precisa Escolher um Produto", "Escolha um Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (isNum == true)
            {
                Pedido_Produtos_DTO pedido_Produtos_DTO = new Pedido_Produtos_DTO();

                string id_pedido = lblIdPedidoCriado.Text;
                string id_produto = cbAdicionarProduto.Text;

                quantidadeEstoqueProduto();

                if (cbQuantidadeProduto.SelectedIndex == -1)
                {
                    MessageBox.Show("Não tem esse produto em estoque");
                    cbQuantidadeProduto.Enabled = false;
                    return;
                }
                else
                {
                    string textID = listBoxIdEstoque.GetItemText(listBoxIdEstoque.SelectedItem);

                    if (cbAdicionarProduto.Text == textID)
                    {
                        pedido_Produtos_DTO.ID_PEDIDO = Convert.ToInt32(id_pedido);
                        pedido_Produtos_DTO.ID_PRODUTO = Convert.ToInt32(id_produto);
                        pedido_Produtos_DTO.QUANT_PROD = Convert.ToInt32(cbQuantidadeProduto.Text);
                        pedido_Produtos_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

                        Pedido_Produtos_DAO pedido_Produtos_DAO = new Pedido_Produtos_DAO();

                        string retorno = pedido_Produtos_DAO.InserirProdutos(pedido_Produtos_DTO);

                        try
                        {
                            int idproduto = Convert.ToInt32(retorno);

                            cbAdicionarProduto.Text = "";

                            cbAdicionarProduto.Focus();

                            lblProdutoSelecionado.Text = "";

                            cbQuantidadeProduto.SelectedIndex = 0;

                            cbQuantidadeEstoque.Text = "0";

                            //ADICIONAR NO DATAGRIDVIEW LISTA PRODUTOS

                            CarregaPedidoListaProduto();

                            CalcularJurosDebitoCredito();

                            cbQuantidadeProduto.Enabled = false;
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possivel adicionar o produto \n" +
                                "Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um codigo produto valido.");
                    }
                }
            }
            else
            {
                Pedido_Produtos_DTO pedido_Produtos_DTO = new Pedido_Produtos_DTO();

                string id_pedido = lblIdPedidoCriado.Text;
                string id_produto = lblProdutoSelecionado.Text;

                if (cbQuantidadeProduto.SelectedIndex == -1)
                {
                    cbQuantidadeProduto.Enabled = false;
                    //MessageBox.Show("Não tem esse produto em estoque");
                }
                else
                {
                    if (isNum == true)
                    {
                        if (listBoxIdEstoque.SelectedValue.ToString() == cbAdicionarProduto.Text)
                        {
                            pedido_Produtos_DTO.ID_PEDIDO = Convert.ToInt32(id_pedido);
                            pedido_Produtos_DTO.ID_PRODUTO = Convert.ToInt32(id_produto);
                            pedido_Produtos_DTO.QUANT_PROD = Convert.ToInt32(cbQuantidadeProduto.Text);
                            pedido_Produtos_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

                            Pedido_Produtos_DAO pedido_Produtos_DAO = new Pedido_Produtos_DAO();

                            string retorno = pedido_Produtos_DAO.InserirProdutos(pedido_Produtos_DTO);

                            try
                            {
                                int idproduto = Convert.ToInt32(retorno);

                                cbAdicionarProduto.Text = "";

                                cbAdicionarProduto.Focus();

                                lblProdutoSelecionado.Text = "";

                                cbQuantidadeProduto.SelectedIndex = 0;

                                cbQuantidadeEstoque.Text = "0";

                                //ADICIONAR NO DATAGRIDVIEW LISTA PRODUTOS

                                CarregaPedidoListaProduto();

                                CalcularJurosDebitoCredito();

                                cbQuantidadeProduto.Enabled = false;
                            }
                            catch
                            {
                                MessageBox.Show("Não foi possivel adicionar o produto \n" +
                                    "Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("esse codigo de produto não existe");
                        }
                    }
                    else
                    {
                    }
                }

                if (cbQuantidadeProduto.SelectedIndex == -1)
                {
                    cbQuantidadeProduto.Enabled = false;
                    //MessageBox.Show("Não tem esse produto em estoque");
                }
                else
                {
                    bool isValid = char.IsLetter(textoCombobox.FirstOrDefault());

                    if (isValid == true)
                    {
                        string textNome = listBoxNomeProduto.GetItemText(listBoxNomeProduto.SelectedItem);

                        if (cbAdicionarProduto.Text == textNome)
                        {
                            pedido_Produtos_DTO.ID_PEDIDO = Convert.ToInt32(id_pedido);
                            pedido_Produtos_DTO.ID_PRODUTO = Convert.ToInt32(id_produto);
                            pedido_Produtos_DTO.QUANT_PROD = Convert.ToInt32(cbQuantidadeProduto.Text);
                            pedido_Produtos_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

                            Pedido_Produtos_DAO pedido_Produtos_DAO = new Pedido_Produtos_DAO();

                            string retorno = pedido_Produtos_DAO.InserirProdutos(pedido_Produtos_DTO);

                            try
                            {
                                int idproduto = Convert.ToInt32(retorno);

                                cbAdicionarProduto.Text = "";

                                cbAdicionarProduto.Focus();

                                lblProdutoSelecionado.Text = "";

                                cbQuantidadeProduto.SelectedIndex = 0;

                                cbQuantidadeEstoque.Text = "0";

                                //ADICIONAR NO DATAGRIDVIEW LISTA PRODUTOS

                                CarregaPedidoListaProduto();

                                CalcularJurosDebitoCredito();

                                cbQuantidadeProduto.Enabled = false;
                            }
                            catch
                            {
                                MessageBox.Show("Não foi possivel adicionar o produto \n" +
                                    "Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não existe esse nome de produto, digite um nome válido.");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("NÃO É UM TEXTO");
                    }
                }
            }
        }

        private async void cbQuantidadeEstoque_TextChanged(object sender, EventArgs e)
        {
            //Verifica se tem quantidade em estoque do produto para poder adicionar o produto

            await Task.Delay(10);
            if (lblProdutoSelecionado.Text == "")
            {
            }
            else
            {
                if (cbQuantidadeEstoque.Text == "0")
                {
                    MessageBox.Show("Não tem nenhum desse produto no estoque.\nAdicione mais ao estoque ou selecione outro produto.",
                        "Não tem nenhum desse produto no estoque.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ibtnAdicionarProduto.Enabled = false;
                    cbQuantidadeProduto.Enabled = false;
                }
                else
                {
                    ibtnAdicionarProduto.Enabled = true;
                    cbQuantidadeProduto.Enabled = true;
                }
            }
        }

        private void CarregaPedidoListaProduto()
        {
            string id_pedido = lblIdPedidoCriado.Text;

            Pedido_Produtos_DAO pedido_Produtos_DAO = new Pedido_Produtos_DAO();

            Pedido_Produtos_Colecao pedido_Produtos_Colecao = new Pedido_Produtos_Colecao();

            pedido_Produtos_Colecao = pedido_Produtos_DAO.PedidoConsultarProdutos(id_pedido);

            dgvListaPedidoProdutos.DataSource = null;
            dgvListaPedidoProdutos.DataSource = pedido_Produtos_Colecao;

            CalculoDentroDGV();

            dgvListaPedidoProdutos.Update();
            dgvListaPedidoProdutos.Refresh();
        }

        private void ibtnRemoveProduto_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvListaPedidoProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            //Pegar o produto selecionado no grid
            Pedido_Produtos_DTO produtoSelecionado = (dgvListaPedidoProdutos.SelectedRows[0].DataBoundItem as Pedido_Produtos_DTO);

            //Instanciar a regra Produto
            Pedido_Produtos_DAO pedido_Produtos_DAO = new Pedido_Produtos_DAO();

            //chama o metodo excluir
            string retorno = pedido_Produtos_DAO.RemoverProduto(produtoSelecionado);

            //verifica se excluiu, se o retorno for numero é porque deu certo, senão é a mensagem de erro
            try
            {
                int id_produto = Convert.ToInt32(retorno);

                cbAdicionarProduto.Focus();

                cbAdicionarProduto.Text = "";

                cbAdicionarProduto.Focus();

                lblProdutoSelecionado.Text = "";

                cbQuantidadeProduto.SelectedIndex = 0;

                cbQuantidadeEstoque.Text = "";

                CarregaPedidoListaProduto();

                if(dgvListaPedidoProdutos.SelectedRows.Count > 0)
                {
                    CalcularJurosDebitoCredito();
                }
                else
                {
                    valor_total_pedido = 0;
                }
     
            }
            catch
            {
                //MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAdicionarProduto.Focus();
                CarregaPedidoListaProduto();
            }
        }

        public static double valor_total_pedido = 0;

        private void CalculoDentroDGV()
        {
            //Calcula todas as linhas com o total quant * valor produto
            foreach (DataGridViewRow item in dgvListaPedidoProdutos.Rows)
            {
                int n = item.Index;

                int quant_prod = Convert.ToInt32(dgvListaPedidoProdutos.Rows[n].Cells[2].Value);
                decimal valor_produto = Convert.ToDecimal(dgvListaPedidoProdutos.Rows[n].Cells[3].Value);
                dgvListaPedidoProdutos.Rows[n].Cells[4].Value = quant_prod * valor_produto;
            }

            decimal valorTotal = 0;

            if (dgvListaPedidoProdutos.RowCount == 0)
            {
                //MessageBox.Show("O Pedido está vazio.");
                tbValor.Text = valorTotal.ToString("C");
                tbDinheiro.Text = "0";
            }
            else
            {
                dgvListaPedidoProdutos.CurrentRow.Cells[4].Value.ToString();
                for (int i = 0; i <= dgvListaPedidoProdutos.RowCount - 1; i++)
                {
                    if (dgvListaPedidoProdutos.Rows[i].Cells[4].Value != null)
                        valorTotal += Convert.ToDecimal(dgvListaPedidoProdutos.Rows[i].Cells[4].Value);
                }
                tbValor.Text = valorTotal.ToString("C");

                valor_total_pedido = Convert.ToDouble(valorTotal);
            }
        }

        private void tbDesconto_TextChanged_1(object sender, EventArgs e)
        {
            Moeda(ref tbDinheiro);

            decimal ResultadoValorTotal;

            ResultadoValorTotal = Convert.ToDecimal(tbValor.Text.Replace("R$", "").Trim()) - Convert.ToDecimal
                (tbDinheiro.Text.Trim() == "" ? 0 : Convert.ToDecimal(tbDinheiro.Text.Trim()));

            tbValorTotal.Text = ResultadoValorTotal.ToString("C");
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {
            decimal ResultadoValorTotal;

            ResultadoValorTotal = Convert.ToDecimal(tbValor.Text.Replace("R$", "").Trim()) - Convert.ToDecimal
                (tbDinheiro.Text.Trim() == "" ? 0 : Convert.ToDecimal(tbDinheiro.Text.Trim()));

            tbValorTotal.Text = ResultadoValorTotal.ToString("C");

            decimal vtotal = Convert.ToDecimal(tbValorTotal.Text.Replace("R$", ""));

            // VERIFICAR SE TEM UM NUMERO DIFERENTE DE 0 PARA HABILITAR O FINALIZAR PEDIDO
            string textboxValor = tbValor.Text;

            if (textboxValor == "R$ 0,00")
            {
                ibtnFinalizarPedido.Enabled = false;
                cbFormaPagamento.Enabled = false;
                ibtnVerParcelas.Enabled = false;
            }
            else
            {
                ibtnFinalizarPedido.Enabled = true;
                cbFormaPagamento.Enabled = true;
                ibtnVerParcelas.Enabled = true;
            }
        }

        private void tbValorTotal_TextChanged(object sender, EventArgs e)
        {
            if (tbValorTotal.Text.Contains("-"))
            {
                tbValorTotal.Text = "R$ 0,00";
            }
            else
            {
                //decimal vtotal_pedido = Convert.ToDecimal(tbValorTotal.Text.Replace("R$", ""));
            }
        }

        private void ibtnFinalizarPedido_Click(object sender, EventArgs e)
        {
            // SELECIONAR PAGAMENTO A PRAZO SE TIVER VALOR NO VALOR TOTAL PEDIDO

            decimal vtotal_pedido = Convert.ToDecimal(tbValorTotal.Text.Replace("R$", ""));

            if (vtotal_pedido != 0)
            {
                if (cbFormaPagamento.Text == "A Prazo")
                {
                    FinalizarPedidoDinheiroPrazo();
                }
                else
                {
                    MessageBox.Show("Selecione pagamento a prazo para pagar o valor restante");
                    //cbFormaPagamento.SelectedIndex = 1;
                }
            }
            else
            {
                FinalizarPedidoDinheiroPrazo();
            }
        }

        private void FinalizarPedidoDinheiroPrazo()
        {
            Pedido_Finalizar_DTO pedido_Finalizar_DTO = new Pedido_Finalizar_DTO();

            string id_pedido = lblIdPedidoCriado.Text;
            string desconto = tbDinheiro.Text.Trim() == "" ? "0" : tbDinheiro.Text.Trim();
            string quant_parcelas = cbQuantidadeParcelas.Text;
            var data_pagamento = Convert.ToDateTime(dtpDataPagamento.Value);
            string valor_total = tbValorTotal.Text.Replace("R$", "");


            string valorPedido = tbValor.Text.Replace("R$", "");

            if (cbFormaPagamento.Text == "A Prazo")
            {
                //quant_parcelas = cbQuantidadeParcelas.Text;
                //data_pagamento = Convert.ToDateTime(dtpDataPagamento.Value);
                pedido_Finalizar_DTO.QUANT_PARCELAS = Convert.ToByte(quant_parcelas);
                pedido_Finalizar_DTO.DATA_PARCELAS = data_pagamento;
            }
            else
            {
                quant_parcelas = null; // não consegui passar valor null = 0
                string dtpDataPagamento = "31-12-9999"; // não consegui passar valor null
                pedido_Finalizar_DTO.QUANT_PARCELAS = Convert.ToByte(quant_parcelas);
                pedido_Finalizar_DTO.DATA_PARCELAS = Convert.ToDateTime(dtpDataPagamento);
            }

            pedido_Finalizar_DTO.ID_PEDIDO = Convert.ToInt32(id_pedido);
            pedido_Finalizar_DTO.VALOR_DESCONTO = Convert.ToDecimal(desconto);

            //Caso o pagamento for no dinheiro a vista = pegar o valor do pedido e não o valor total
            if (tbValorTotal.Text == "R$ 0,00")
            {
                pedido_Finalizar_DTO.VALOR_TOTAL = Convert.ToDecimal(valorPedido);
            }
            else
            {
                pedido_Finalizar_DTO.VALOR_TOTAL = Convert.ToDecimal(valor_total);
            }

            //forma de pagamento
            pedido_Finalizar_DTO.FORMA_PAGAMENTO = cbFormaPagamento.Text;

            //nome do usuario
            pedido_Finalizar_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

            Pedido_Finalizar_DAO pedido_Finalizar_DAO = new Pedido_Finalizar_DAO();

            string retorno = pedido_Finalizar_DAO.PedidoFinalizar(pedido_Finalizar_DTO);

            try
            {
                ImprimirCupom();

                int idpedido = Convert.ToInt32(retorno);

                //Calcula o troco -> mostra no msgbox abaixo
                decimal vtotal_produtos = Convert.ToDecimal(tbValor.Text.Replace("R$", ""));
                decimal descontoTroco = Convert.ToDecimal(tbDinheiro.Text);
                decimal total_troco = vtotal_produtos - descontoTroco;

                //Limpar campos para uma nova Venda
                tbDinheiro.Text = "0";
                cbAdicionarProduto.Text = "";
                lblProdutoSelecionado.Text = "";
                cbQuantidadeEstoque.Text = "";
                cbSelecionarCliente.Text = "";
                lblClienteSelecionado.Text = "";
                ibtnAdicionarProduto.Enabled = false;
                cbQuantidadeProduto.Enabled = false;
                cbAdicionarProduto.Enabled = false;
                cbSelecionarCliente.Enabled = true;
                ibtnCriarPedido.Enabled = true;
                ibtnRemoveProduto.Enabled = false;

                lblIdPedidoCriado.Text = "0";
                //Manda o lblpedidocriado do form caixa para o form sistema
                Sistema sistema = new Sistema(lblPedidoCriadoRetorno);

                lblIdPedidoCriado.Text = "";

                CarregaPedidoListaProduto();

                valor_total_pedido = 0;

                string troco = Convert.ToString(total_troco);

                if (cbFormaPagamento.Text == "Dinheiro")
                {
                    MessageBox.Show("O Pedido foi finalizado\n \nTotal troco: R$ " + troco.Replace("-", ""), "Pedido Concluido. ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O Pedido foi finalizado", "Pedido Concluido. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cbFormaPagamento.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Não foi possivel criar finalizar o Pedido. Detalhes: "
                    + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblProdutoSelecionado_TextChanged(object sender, EventArgs e)
        {
            //Espera para executar a tarefa
            //await Task.Delay(2000);

            string idproduto = lblProdutoSelecionado.Text;

            int num;

            bool isNum = Int32.TryParse(idproduto, out num);

            if (isNum != true)
            {
                return;
            }
            else
            {
                // MOSTRAR A QUANTIDADE EM ESTOQUE DO PRODUTO NO CB

                cbQuantidadeProduto.Enabled = true;

                Produto_DTO produto_DTO = new Produto_DTO();

                Produto_DAO produto_DAO = new Produto_DAO();

                Produto_Colecao produto_Colecao = new Produto_Colecao();

                produto_Colecao = produto_DAO.CarregarQuantidadeProduto(idproduto);

                cbQuantidadeEstoque.Enabled = false;

                cbQuantidadeEstoque.DataSource = produto_Colecao;
                cbQuantidadeEstoque.DisplayMember = "QUANT_PROD";

                //DEIXA SELECIONAR NO CBQUANT_PROD SÓ O VALOR QUE ESTA EM ESTOQUE
                int quant_prod = Convert.ToInt32(cbQuantidadeEstoque.Text);

                cbQuantidadeProduto.DataSource = Enumerable.Range(1, quant_prod).ToList();

                //funcaoAddRemoverProdutos();
            }
        }

        private void tbDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Só deixa Digitar numeros no TextBox Desconto
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void ibtnVerParcelas_Click(object sender, EventArgs e)
        {
            if (tbValorTotal.Text == "R$ 0,00")
            {
                MessageBox.Show("Não é possivel parcelar um Valor R$ 0.00");
            }
            else
            {
                if (Application.OpenForms.OfType<FinalizarVendaParcelada>().Count() > 0)
                {
                    //Não vai executar nada
                }
                else
                {
                    FinalizarVendaParcelada finalizarVendaParcelada =
                        new FinalizarVendaParcelada(lblIdPedidoCriado.Text
                        , cbQuantidadeParcelas.Text,
                        tbValorTotal.Text, tbDinheiro.Text, dtpDataPagamento.Value, cbFormaPagamento.Text);

                    DialogResult dialogResult = finalizarVendaParcelada.ShowDialog();
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Limpar campos para uma nova Venda
                        tbDinheiro.Text = "0";
                        cbAdicionarProduto.Text = "";
                        lblProdutoSelecionado.Text = "";
                        cbQuantidadeEstoque.Text = "";
                        cbSelecionarCliente.Text = "";
                        lblClienteSelecionado.Text = "";
                        ibtnAdicionarProduto.Enabled = false;
                        cbQuantidadeProduto.Enabled = false;
                        cbAdicionarProduto.Enabled = false;
                        cbSelecionarCliente.Enabled = true;
                        ibtnCriarPedido.Enabled = true;
                        ibtnRemoveProduto.Enabled = false;

                        lblIdPedidoCriado.Text = "";

                        CarregaPedidoListaProduto();

                        cbFormaPagamento.SelectedIndex = 0;
                    }
                }
            }
        }

        private void ibtnResetarPedido_Click(object sender, EventArgs e)
        {
            ResetarPedido();
            CarregaPedidoListaProduto();
            //zera o campo tbValor
            decimal valorTotal = 0;
            tbValor.Text = valorTotal.ToString("C");

            valor_total_pedido = 0;

            cbQuantidadeEstoque.Text = "";
        }

        private void cbAdicionarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAdicionarProduto_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.F1)
            {
                BuscarProdutoPedido buscarProdutoPedido = new BuscarProdutoPedido();
                DialogResult dialogResult = buscarProdutoPedido.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    cbAdicionarProduto.Text = buscarProdutoPedido.ParametroNomeProduto;
                    lblProdutoSelecionado.Text = buscarProdutoPedido.ParametreIDProduto;
                }
            }
        }

        private void cbAdicionarProduto_TextChanged(object sender, EventArgs e)
        {
            string idproduto = cbAdicionarProduto.Text;

            int num;

            bool isNum = Int32.TryParse(idproduto, out num);

            if (isNum != true)
            {
                //seleciona o valor digitado nome produto no listbox com todos os nomes no estoque
                listBoxNomeProduto.SelectedValue = Convert.ToString(cbAdicionarProduto.Text);
                return;
            }
            else
            {
                //seleciona o valor digitado id produto no listbox com todos os ids no estoque
                listBoxIdEstoque.SelectedValue = Convert.ToInt32(cbAdicionarProduto.Text);

                if (listBoxIdEstoque.Items.ToString() == cbAdicionarProduto.Text)
                {
                    // MOSTRAR A QUANTIDADE EM ESTOQUE DO PRODUTO NO CB

                    cbQuantidadeProduto.Enabled = true;

                    Produto_DTO produto_DTO = new Produto_DTO();

                    Produto_DAO produto_DAO = new Produto_DAO();

                    Produto_Colecao produto_Colecao = new Produto_Colecao();

                    produto_Colecao = produto_DAO.CarregarQuantidadeProduto(idproduto);

                    cbQuantidadeEstoque.Enabled = false;

                    cbQuantidadeEstoque.DataSource = produto_Colecao;
                    cbQuantidadeEstoque.DisplayMember = "QUANT_PROD";

                    //DEIXA SELECIONAR NO CBQUANT_PROD SÓ O VALOR QUE ESTA EM ESTOQUE
                    int quant_prod = Convert.ToInt32(cbQuantidadeEstoque.Text);

                    cbQuantidadeProduto.DataSource = Enumerable.Range(1, quant_prod).ToList();
                }
                else
                {
                }
            }
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

        private void pbCupom_Paint(object sender, PaintEventArgs e)
        {
            /*
            Graphics graphics = e.Graphics;
            int offset = 190;

            //Linha Tracejada
            float[] dashValues = { 5, 2, 5, 2 };
            Pen linhaTracejadaPreta = new Pen(Color.Black, 1);
            linhaTracejadaPreta.DashPattern = dashValues;

            //print header
            graphics.DrawString("ELÊGANCIA MODAS", boldEmpresa, Brushes.Black, 65, 6);
            graphics.DrawString("AVENIDA VISCONDE DE NOVA GRANADA" + " - " + "1342", regular, Brushes.Black, 37, 35);
            graphics.DrawString("CEP: 13617-400" + " - JARDIM SÃO FRANCISCO -" + " LEME " + "SP", regular, Brushes.Black, 22, 50);

            graphics.DrawLine(linhaTracejadaPreta, 20, 65, 310, 65);

            graphics.DrawString("CNPJ: 11.060.453/0001-20", regular, Brushes.Black, 18, 68);
            graphics.DrawString("IE: 415.149.480.116", regular, Brushes.Black, 210, 68);

            graphics.DrawLine(linhaTracejadaPreta, 20, 83, 310, 83);

            graphics.DrawString("DATA: " + DateTime.Now.ToString("dd/MM/yyyy"), regular, Brushes.Black, 18, 86);
            graphics.DrawString(DateTime.Now.ToString("HH:mm:ss"), regular, Brushes.Black, 110, 86);

            graphics.DrawLine(linhaTracejadaPreta, 20, 101, 310, 101);
            graphics.DrawString("NÃO É DOCUMENTO FISCAL", regularItens, Brushes.Black, 100, 105);
            graphics.DrawString("COMPROVANTE NÃO FISCAL", bold, Brushes.Black, 62, 118);
            graphics.DrawLine(linhaTracejadaPreta, 20, 138, 310, 138);
            graphics.DrawString("PEDIDO: " + lblIdPedidoCriado.Text, regular, Brushes.Black, 20, 143);
            graphics.DrawLine(linhaTracejadaPreta, 20, 160, 310, 160);

            //itens header
            graphics.DrawString("PRODUTO", regular, Brushes.Black, 20, 165);
            graphics.DrawString("UNIT.", regular, Brushes.Black, 150, 165);
            graphics.DrawString("QTD.", regular, Brushes.Black, 200, 165);
            graphics.DrawString("TOTAL", regular, Brushes.Black, 250, 165);
            graphics.DrawLine(linhaTracejadaPreta, 20, 181, 310, 181);

            //Joga os valores no cupom fiscal do dgv
            foreach (DataGridViewRow iv in dgvListaPedidoProdutos.Rows)
            {
                int n = iv.Index;

                string nome_produto = Convert.ToString(dgvListaPedidoProdutos.Rows[n].Cells[0].Value);
                string valor_unit = Convert.ToString(dgvListaPedidoProdutos.Rows[n].Cells[3].Value);
                int quant_prod = Convert.ToInt32(dgvListaPedidoProdutos.Rows[n].Cells[2].Value);
                string valor_total_prod = Convert.ToString(dgvListaPedidoProdutos.Rows[n].Cells[4].Value);

                graphics.DrawString(nome_produto.Length > 20 ? nome_produto.Substring(0, 20) + "..." : nome_produto, regularItens, Brushes.Black, 20, offset);
                graphics.DrawString(valor_unit, regularItens, Brushes.Black, 155, offset);
                graphics.DrawString(Convert.ToString(quant_prod), regularItens, Brushes.Black, 215, offset);
                graphics.DrawString(valor_total_prod, regularItens, Brushes.Black, 255, offset);
                offset += 20;
            }

            //total
            graphics.DrawLine(linhaTracejadaPreta, 20, offset, 310, offset);
            offset += 5;

            graphics.DrawString("TOTAL: ", bold, Brushes.Black, 20, offset);
            graphics.DrawString(tbValor.Text, bold, Brushes.Black, 230, offset);
            offset += 14;

            decimal dinheiro = Convert.ToDecimal(tbDesconto.Text);

            graphics.DrawString("Dinheiro: ", regular10, Brushes.Black, 20, offset);
            graphics.DrawString(Convert.ToString(dinheiro.ToString("C")), regular10, Brushes.Black, 233, offset);
            offset += 14;

            //Calcula o troco -> mostra no msgbox abaixo
            decimal vtotal_produtos = Convert.ToDecimal(tbValor.Text.Replace("R$", ""));
            decimal descontoTroco = Convert.ToDecimal(tbDesconto.Text);
            decimal total_troco = vtotal_produtos - descontoTroco;

            if(total_troco == 0)
            {
                offset += 4;
            }
            else
            {
                graphics.DrawString("Troco: ", regular10, Brushes.Black, 20, offset);
                graphics.DrawString(Convert.ToString(total_troco.ToString("C")), regular10, Brushes.Black, 233, offset);
                offset += 18;
            }

            graphics.DrawLine(linhaTracejadaPreta, 20, offset, 310, offset);
            offset += 3;

            graphics.DrawString("Operador: ", regular, Brushes.Black, 18, offset);
            graphics.DrawString("Guilherme", regular, Brushes.Black, 85, offset);
            offset += 15;

            graphics.DrawLine(linhaTracejadaPreta, 20, offset, 310, offset);
            offset += 5;

            //bottom
            graphics.DrawString("Obrigado pela preferência, volte sempre", regular, Brushes.Black, 60, offset);
            */
        }

        public void ImprimirCupom()
        {
            DialogResult resultado = MessageBox.Show("Deseja imprimir o Cupom Não fiscal Para o Cliente ? \n",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                PrintDocument doc = new PrintDocument();

                doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                doc.OriginAtMargins = false;
                doc.PrintPage += Doc_PrintPage;

                doc.DocumentName = "Comprovante";

                PrintDialog pd = new PrintDialog();
                if (pd.AllowPrintToFile == true)
                {
                    Sistema.ActiveForm.TopMost = false;
                }

                doc.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int offset = 183;

            //Linha Tracejada
            float[] dashValues = { 5, 2, 5, 2 };
            Pen linhaTracejadaPreta = new Pen(Color.Black, 1);
            linhaTracejadaPreta.DashPattern = dashValues;

            //print header
            graphics.DrawString("ELÊGANCIA MODAS", boldEmpresa, Brushes.Black, 65, 6);
            graphics.DrawString("AVENIDA VISCONDE DE NOVA GRANADA" + " - " + "1334", regular, Brushes.Black, 37, 35);
            graphics.DrawString("CEP: 13617-400" + " - JARDIM SÃO FRANCISCO -" + " LEME " + "SP", regular, Brushes.Black, 22, 50);

            graphics.DrawLine(linhaTracejadaPreta, 20, 65, 310, 65);

            graphics.DrawString("CNPJ: 11.060.453/0001-20", regular, Brushes.Black, 18, 68);
            graphics.DrawString("IE: 415.149.480.116", regular, Brushes.Black, 210, 68);

            graphics.DrawLine(linhaTracejadaPreta, 20, 83, 310, 83);

            graphics.DrawString("DATA: " + DateTime.Now.ToString("dd/MM/yyyy"), regular, Brushes.Black, 18, 86);
            graphics.DrawString(DateTime.Now.ToString("HH:mm:ss"), regular, Brushes.Black, 120, 86);

            graphics.DrawLine(linhaTracejadaPreta, 20, 101, 310, 101);
            graphics.DrawString("NÃO É DOCUMENTO FISCAL", regularItens, Brushes.Black, 100, 105);
            graphics.DrawString("COMPROVANTE NÃO FISCAL", bold, Brushes.Black, 62, 118);
            graphics.DrawLine(linhaTracejadaPreta, 20, 138, 310, 138);
            graphics.DrawString("PEDIDO: " + lblIdPedidoCriado.Text, regular, Brushes.Black, 20, 143);
            graphics.DrawLine(linhaTracejadaPreta, 20, 160, 310, 160);

            //itens header
            graphics.DrawString("DESCRIÇÃO", regular, Brushes.Black, 20, 165);
            graphics.DrawString("UNIT.", regular, Brushes.Black, 200, 165);
            graphics.DrawString("QTD.", regular, Brushes.Black, 239, 165);
            graphics.DrawString("TOTAL", regular, Brushes.Black, 270, 165);
            graphics.DrawLine(linhaTracejadaPreta, 20, 181, 310, 181);

            var format = new StringFormat() { Alignment = StringAlignment.Far };

            //Joga os valores no cupom fiscal do dgv
            foreach (DataGridViewRow iv in dgvListaPedidoProdutos.Rows)
            {
                int n = iv.Index;

                string nome_produto = Convert.ToString(dgvListaPedidoProdutos.Rows[n].Cells[0].Value);
                string valor_unit = Convert.ToString(dgvListaPedidoProdutos.Rows[n].Cells[3].Value);
                int quant_prod = Convert.ToInt32(dgvListaPedidoProdutos.Rows[n].Cells[2].Value);
                string valor_total_prod = Convert.ToString(dgvListaPedidoProdutos.Rows[n].Cells[4].Value);

                graphics.DrawString(nome_produto.Length > 35 ? nome_produto.Substring(0, 20) + "..." : nome_produto, regularItens, Brushes.Black, 20, offset);
                graphics.DrawString(valor_unit, regularItens, Brushes.Black, 226, offset, format);
                graphics.DrawString(Convert.ToString(quant_prod), regularItens, Brushes.Black, 259, offset, format);
                graphics.DrawString(valor_total_prod, regularItens, Brushes.Black, 310, offset, format);
                offset += 12;
            }

            //total
            graphics.DrawLine(linhaTracejadaPreta, 20, offset, 310, offset);
            offset += 5;

            graphics.DrawString("Total: ", bold, Brushes.Black, 20, offset);
            graphics.DrawString(tbValor.Text, bold, Brushes.Black, 310, offset, format);
            offset += 14;

            decimal dinheiro = Convert.ToDecimal(tbDinheiro.Text);

            graphics.DrawString("Dinheiro: ", bold, Brushes.Black, 20, offset);
            graphics.DrawString(Convert.ToString(dinheiro.ToString("C")), bold, Brushes.Black, 310, offset, format);
            offset += 14;

            //Calcula o troco -> mostra no msgbox abaixo
            decimal vtotal_produtos = Convert.ToDecimal(tbValor.Text.Replace("R$", ""));
            decimal descontoTroco = Convert.ToDecimal(tbDinheiro.Text);
            decimal total_troco = vtotal_produtos - descontoTroco;

            if (total_troco == 0)
            {
                offset += 4;
            }
            else
            {
                graphics.DrawString("Troco: ", bold, Brushes.Black, 20, offset);
                graphics.DrawString(Convert.ToString(total_troco.ToString("C").Replace("-", "")), bold, Brushes.Black, 310, offset, format);
                offset += 18;
            }

            graphics.DrawLine(linhaTracejadaPreta, 20, offset, 310, offset);
            offset += 3;

            graphics.DrawString("Operador: ", regular, Brushes.Black, 18, offset);
            graphics.DrawString(TelaLogin.nomeUsuario, regular, Brushes.Black, 85, offset);
            offset += 15;

            graphics.DrawLine(linhaTracejadaPreta, 20, offset, 310, offset);
            offset += 5;

            //bottom
            graphics.DrawString("Obrigado pela preferência, volte sempre", regular, Brushes.Black, 60, offset);

            e.HasMorePages = false;

            /*
            Bitmap bm = new Bitmap(pbCupom.Width, pbCupom.Height);
            pbCupom.DrawToBitmap(bm, new Rectangle(0, 0, pbCupom.Width, pbCupom.Height));
            e.Graphics.DrawImage(bm, 0, 0); //margem na folha
            bm.Dispose();
            */
        }
    }
}