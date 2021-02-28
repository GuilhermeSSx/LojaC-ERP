using Loja.DAO;
using Loja.DTO;
using Loja.GUI.ESTOQUE_PRODUTOS;
using Loja.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Loja
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            //não gerar colunas automatico
            dgvEstoque.AutoGenerateColumns = false;
            dgvBuscarTipoProduto.AutoGenerateColumns = false;
            dgvBuscarMarca.AutoGenerateColumns = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            cbQuantidadeProduto.SelectedIndex = 0;
            cbTamanhoProduto.SelectedIndex = 0;

            CarregaListaProduto();

            //selecionar a primeira linha do dgv e colocar id no lbl
            if (dgvEstoque.SelectedRows.Count == 0)
            {
            }
            else
            {
                DataGridViewRow row1 = dgvEstoque.Rows[0];
                lblIdProduto.Text = row1.Cells[6].Value.ToString();
            }

            tbValorProduto.Text = "0";
            tbValorComprado.Text = "0";


            nome_inteiro_produto[0] = "";
            nome_inteiro_produto[1] = "";
            nome_inteiro_produto[2] = "";
            nome_inteiro_produto[3] = "";

            cbQuantidadeProduto.ContextMenu = new ContextMenu();
        }

        public void CarregaListaProduto()
        {
            Produto_DAO produto_DAO = new Produto_DAO();

            Produto_Colecao produto_Colecao = new Produto_Colecao();

            produto_Colecao = produto_DAO.ConsultarPorNome(tbNomeProduto.Text);

            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = produto_Colecao;

            dgvEstoque.Update();
            dgvEstoque.Refresh();

            int quant_total_prod = 0;
            

            if(dgvEstoque.SelectedRows.Count == 0)
            {
                lblQuantTipoProdutos.Text = "0";
                lblQuantTotalProd.Text = "0";
                lblPatrimonioTotal.Text = "R$ 0.00";
            }
            else
            {
                lblQuantTipoProdutos.Text = dgvEstoque.RowCount.ToString();

                //Valor total quantidade de produtos em estoque de cada tipo produto
                dgvEstoque.CurrentRow.Cells[2].Value.ToString();
                for (int i = 0; i <= dgvEstoque.RowCount - 1; i++)
                {
                    if (dgvEstoque.Rows[i].Cells[2].Value != null)
                        quant_total_prod += Convert.ToInt32(dgvEstoque.Rows[i].Cells[2].Value);
                }
                lblQuantTotalProd.Text = quant_total_prod.ToString();

                //criar a conexão
                SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(QUANT_PROD * VALOR_PRODUTO) AS PATRIMONIO_ATUAL FROM ESTOQUE_PRODUTOS", con);
                cmd.CommandType = CommandType.Text;

                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());

                lblPatrimonioTotal.Text = dt.Rows[0]["PATRIMONIO_ATUAL"].ToString();

                decimal valor_total_prod = Convert.ToDecimal(lblPatrimonioTotal.Text);

                lblPatrimonioTotal.Text = valor_total_prod.ToString("C");

                con.Close();
            }


        }

        private void limpar_campos()
        {
            
            cbQuantidadeProduto.SelectedIndex = 0;
            cbTamanhoProduto.SelectedIndex = 0;
            tbValorComprado.Text = "";
            tbValorProduto.Text = "";

            cbBuscarTipoProduto.Text = "";
            cbBuscarMarca.Text = "";
            tbDescricaoNomeProduto.Text = "";
            tbRefProduto.Text = "";

            nome_inteiro_produto[0] = "";
            nome_inteiro_produto[1] = "";
            nome_inteiro_produto[2] = "";
            nome_inteiro_produto[3] = "";

            SetarNomeProduto();
        }

        private void ibtnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            if (tbNomeProduto.Text == "")
            {
                MessageBox.Show("Digite um nome de produto");
            }
            else
            {
                if (tbValorComprado.Text == "0,00")
                {
                    MessageBox.Show("Digite o valor comprado do produto");
                }
                else
                {
                    if (tbValorProduto.Text == "0,00")
                    {
                        MessageBox.Show("Digite o valor do produto");
                    }
                    else
                    {
                        Produto_DTO produto_DTO = new Produto_DTO();

                        produto_DTO.NOME_PRODUTO = tbNomeProduto.Text;
                        produto_DTO.TAMANHO = cbTamanhoProduto.Text;
                        produto_DTO.QUANT_PROD = Convert.ToInt32(cbQuantidadeProduto.Text);
                        produto_DTO.VALOR_COMPRA = Convert.ToDecimal(tbValorComprado.Text);
                        produto_DTO.VALOR_PRODUTO = Convert.ToDecimal(tbValorProduto.Text);
                        produto_DTO.DATA_ENTRADA = dtpDataEntradaProduto.Value = DateTime.Now;

                        produto_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

                        Produto_DAO produto_DAO = new Produto_DAO();
                        string retorno = produto_DAO.CadastrarProduto(produto_DTO);

                        try
                        {
                            int id_produto = Convert.ToInt32(retorno);

                            MessageBox.Show("Produto adicionado com sucesso ", "Novo produto adicionado" + retorno, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            limpar_campos();
                            cbBuscarTipoProduto.Focus();
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possivel adicionar novo Produto. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if(retorno != "Produto com o mesmo nome já existe no estoque, escolha outro nome")
                        {
                            CarregaListaProduto();
                        }
                        
                    }
                }
            }
        }

        private void ibtnAlterarProduto_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            //Pegar o produto selecionado no grid
            Produto_DTO produtoSelecionado = (dgvEstoque.SelectedRows[0].DataBoundItem as Produto_DTO);

            if (Application.OpenForms.OfType<FrmAlterarProduto>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                FrmAlterarProduto frmAlterarProduto = new FrmAlterarProduto(produtoSelecionado);
                DialogResult dialogResult = frmAlterarProduto.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    CarregaListaProduto();
                }
            }
        }

        private void ibtnRemoverCliente_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            //perguntar se realmente quer excluir
            DialogResult resultado = MessageBox.Show("Deseja mesmo remover produto ?\n \nTodas as movimentações desse " +
                "produto serão removidas, porem permaneceram no fluxo de caixa.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar o produto selecionado no grid
            Produto_DTO produtoSelecionado = (dgvEstoque.SelectedRows[0].DataBoundItem as Produto_DTO);

            //Instanciar a regra Produto
            Produto_DAO produto_DAO = new Produto_DAO();

            //chama o metodo excluir
            string retorno = produto_DAO.ExcluirProduto(produtoSelecionado, TelaLogin.nomeUsuario);

            //verifica se excluiu, se o retorno for numero é porque deu certo, senão é a mensagem de erro
            try
            {
                int id_produto = Convert.ToInt32(retorno);

                CarregaListaProduto();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEstoque.Rows[e.RowIndex];
                lblIdProduto.Text = row.Cells[6].Value.ToString();
            }
        }

        private void ibtnGerarCodigoBarras_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            ///GERA O CODIGO DE BARRAS E IMPRIMI

            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(lblIdProduto.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pbBarcodeProduto.Image = code.GetGraphic(50);

            pbBarcodeProduto.Visible = true;
            PrintBarcode();
        }

        private void PrintBarcode()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                //pega o form atual e deixa atras do print save
                Sistema.ActiveForm.TopMost = false;
                doc.Print();
            }
            else
            {
                pbBarcodeProduto.Visible = false;
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pbBarcodeProduto.Width, pbBarcodeProduto.Height);
            pbBarcodeProduto.DrawToBitmap(bm, new Rectangle(0, 0, pbBarcodeProduto.Width, pbBarcodeProduto.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();

            pbBarcodeProduto.Visible = false;
        }

        private void tbValorComprado_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tbValorComprado);
        }

        private void tbValorProduto_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tbValorProduto);
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

        private void ibtnBuscarProduto_Click(object sender, EventArgs e)
        {

            BuscarDgvEstoque buscarDgvEstoque = new BuscarDgvEstoque();
            DialogResult dialogResult = buscarDgvEstoque.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                string pesquisarProduto = buscarDgvEstoque.ParametroNomeProduto;

                //dgvEstoque.ClearSelection();

                foreach (DataGridViewRow row in dgvEstoque.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        int rowIndex = 0;

                        if (row.Cells[0].Value.ToString().Equals(pesquisarProduto))
                        {
                            rowIndex = row.Index;
                            dgvEstoque.ClearSelection();
                            dgvEstoque.Rows[rowIndex].Selected = true;
                            dgvEstoque.FirstDisplayedScrollingRowIndex = rowIndex;
                            dgvEstoque.Focus();
                            break;
                        }
                    }
                }
            }

        }



        private void cbQuantidadeProduto_TextChanged(object sender, EventArgs e)
        {
            if (cbQuantidadeProduto.Text == "")
            {
                cbQuantidadeProduto.Text = "0";
                cbQuantidadeProduto.SelectAll();
            }
        }

        private void ibtnAumentarDiminuir_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            //Pegar o produto selecionado no grid
            Produto_DTO produtoSelecionado = (dgvEstoque.SelectedRows[0].DataBoundItem as Produto_DTO);


            if (Application.OpenForms.OfType<AumentarDiminuirEstoque>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AumentarDiminuirEstoque aumentarDiminuirEstoque = new AumentarDiminuirEstoque(produtoSelecionado);
                DialogResult dialogResult = aumentarDiminuirEstoque.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    CarregaListaProduto();
                }
            }
        }

        private bool isCollapsed;

        private void ibtnAddNovoProduto_Click(object sender, EventArgs e)
        {
            timerBtn.Start();
        }

        private void timerBtn_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelAdicionarProduto.Height += 20;
                if (panelAdicionarProduto.Size == panelAdicionarProduto.MaximumSize)
                {
                    timerBtn.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelAdicionarProduto.Height -= 20;
                if (panelAdicionarProduto.Size == panelAdicionarProduto.MinimumSize)
                {
                    timerBtn.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void cbBuscarTipoProduto_TextChanged(object sender, EventArgs e)
        {
            if(cbBuscarTipoProduto.Text == "")
            {
                dgvBuscarTipoProduto.Visible = false;
                dgvBuscarTipoProduto.DataSource = null;
            }
            else
            {
                dgvBuscarTipoProduto.Visible = true;

                //criar a conexão
                SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                string sqlquery = "SELECT NOME_TIPO FROM [dbo].[TIPO_PRODUTOS] WHERE NOME_TIPO LIKE '%" + cbBuscarTipoProduto.Text + "%'";

                con.Open();

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dgvBuscarTipoProduto.DataSource = dt;
                con.Close();

                if (dgvBuscarTipoProduto.Rows.Count == 0)
                {
                    dgvBuscarTipoProduto.Visible = false;
                    dgvBuscarTipoProduto.DataSource = null;
                }
                else
                {
                    dgvBuscarTipoProduto.Visible = true;
                }
            }

            nome_inteiro_produto[0] = "";

            SetarNomeProduto();

        }

        private void cbBuscarMarca_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscarMarca.Text == "")
            {
                dgvBuscarMarca.Visible = false;
                dgvBuscarMarca.DataSource = null;
            }
            else
            {
                dgvBuscarMarca.Visible = true;

                //criar a conexão
                SqlConnection con = new SqlConnection(Settings.Default.stringConexao);

                string sqlquery = "SELECT NOME_MARCA FROM [dbo].[MARCA_PRODUTO] WHERE NOME_MARCA LIKE '%" + cbBuscarMarca.Text + "%'";

                con.Open();

                SqlCommand cmd = new SqlCommand(sqlquery, con);
                SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdr.Fill(dt);
                dgvBuscarMarca.DataSource = dt;
                con.Close();

                if (dgvBuscarMarca.Rows.Count == 0)
                {
                    dgvBuscarMarca.Visible = false;
                    dgvBuscarMarca.DataSource = null;
                }
                else
                {
                    dgvBuscarMarca.Visible = true;
                }

                nome_inteiro_produto[2] = "";

                SetarNomeProduto();
            }
        }

        private string[] nome_inteiro_produto = new string[4];


        private void SetarNomeProduto()
        {
            string tipo = nome_inteiro_produto[0];
            string descricao = nome_inteiro_produto[1];
            string marca = nome_inteiro_produto[2];
            string ref_prod = nome_inteiro_produto[3];


            //tbNomeProduto.Text = tipo + " " + descricao + " " + marca + " " + ref_prod;

            if(tipo == "" && descricao == "" && marca == "" && ref_prod == "") // nenhum campo
            {
                tbNomeProduto.Text = "";
            }
            else if(tipo != "" && descricao == "" && marca == "" && ref_prod == "") // somente tipo
            {
                tbNomeProduto.Text = tipo;
            }
            else if (tipo == "" && descricao != "" && marca == "" && ref_prod == "") // somente descricao
            {
                tbNomeProduto.Text = descricao;
            }
            else if (tipo == "" && descricao == "" && marca != "" && ref_prod == "") // somente marca
            {
                tbNomeProduto.Text = marca;
            }
            else if (tipo == "" && descricao == "" && marca == "" && ref_prod != "") // somente ref_prod
            {
                tbNomeProduto.Text = ref_prod;
            }
            else if (tipo != "" && descricao != "" && marca == "" && ref_prod == "") // tipo e descricao
            {
                tbNomeProduto.Text = tipo + " " + descricao;
            }
            else if (tipo != "" && descricao == "" && marca != "" && ref_prod == "") // tipo e marca
            {
                tbNomeProduto.Text = tipo + " " + marca;
            }
            else if (tipo != "" && descricao == "" && marca == "" && ref_prod != "") // tipo e ref_prod
            {
                tbNomeProduto.Text = tipo + " " + ref_prod;
            }
            else if (tipo == "" && descricao != "" && marca != "" && ref_prod == "") // descricao e marca
            {
                tbNomeProduto.Text = descricao + " " + marca;
            }
            else if (tipo == "" && descricao != "" && marca == "" && ref_prod != "") // descricao e ref_prod
            {
                tbNomeProduto.Text = descricao + " " + ref_prod;
            }
            else if (tipo == "" && descricao != "" && marca != "" && ref_prod == "") // marca e descricao
            {
                tbNomeProduto.Text = descricao + " " + marca;
            }
            else if (tipo == "" && descricao == "" && marca != "" && ref_prod != "") // marca e ref_prod
            {
                tbNomeProduto.Text = marca + " " + ref_prod;
            }
            else if (tipo != "" && descricao != "" && marca != "" && ref_prod == "") // tipo descricao marca
            {
                tbNomeProduto.Text = tipo + " " + descricao + " " + marca;
            }
            else if (tipo != "" && descricao == "" && marca != "" && ref_prod != "") // tipo marca ref_prod
            {
                tbNomeProduto.Text = tipo + " " + marca + " " + ref_prod;
            }
            else if (tipo != "" && descricao != "" && marca == "" && ref_prod != "") // tipo descricao ref_prod
            {
                tbNomeProduto.Text = tipo + " " + descricao + " " + ref_prod;
            }
            else if (tipo == "" && descricao != "" && marca != "" && ref_prod != "") // descricao marca ref_prod
            {
                tbNomeProduto.Text = descricao + " " + marca + " " + ref_prod;
            }
            else // tipo descricao marca ref_prod
            {
                tbNomeProduto.Text = tipo + " " + descricao + " " + marca + " " + ref_prod;
            }


            //string[] texto_nome_inteiro = nome_inteiro_produto.ToArray();

            //tbNomeProduto.Text = String.Join(" ", texto_nome_inteiro);

        }

        private void cbBuscarTipoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(dgvBuscarTipoProduto.Rows.Count != 0)
                {
                    DataGridViewRow row1 = dgvBuscarTipoProduto.Rows[0];
                    cbBuscarTipoProduto.Text = row1.Cells[0].Value.ToString();

                    nome_inteiro_produto[0] = cbBuscarTipoProduto.Text;

                    SetarNomeProduto();

                    dgvBuscarTipoProduto.DataSource = null;

                    dgvBuscarTipoProduto.Visible = false;

                    this.ActiveControl = tbDescricaoNomeProduto;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (dgvBuscarTipoProduto.Rows.Count != 0)
                {
                    dgvBuscarTipoProduto.Focus();

                    int linha = dgvBuscarTipoProduto.CurrentRow.Index;

                    linha += 1;

                    dgvBuscarTipoProduto.CurrentCell = dgvBuscarTipoProduto.Rows[linha].Cells[0];

                }
            }

        }

        private void cbBuscarMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvBuscarMarca.Rows.Count != 0)
                {
                    DataGridViewRow row1 = dgvBuscarMarca.Rows[0];
                    cbBuscarMarca.Text = row1.Cells[0].Value.ToString();

                    nome_inteiro_produto[2] = cbBuscarMarca.Text;

                    SetarNomeProduto();

                    dgvBuscarMarca.DataSource = null;

                    dgvBuscarMarca.Visible = false;

                    this.ActiveControl = tbRefProduto;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (dgvBuscarMarca.Rows.Count != 0)
                {
                    dgvBuscarMarca.Focus();

                    int linha = dgvBuscarMarca.CurrentRow.Index;

                    linha += 1;

                    dgvBuscarMarca.CurrentCell = dgvBuscarMarca.Rows[linha].Cells[0];

                }
            }

        }

        private void dgvBuscarTipoProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = dgvBuscarTipoProduto.Rows[e.RowIndex];
            cbBuscarTipoProduto.Text = row1.Cells[0].Value.ToString();

            nome_inteiro_produto[0] = cbBuscarTipoProduto.Text;

            SetarNomeProduto();

            dgvBuscarTipoProduto.DataSource = null;

            dgvBuscarTipoProduto.Visible = false;

            this.ActiveControl = tbDescricaoNomeProduto;
        }

        private void dgvBuscarMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = dgvBuscarMarca.Rows[e.RowIndex];
            cbBuscarMarca.Text = row1.Cells[0].Value.ToString();

            nome_inteiro_produto[2] = cbBuscarMarca.Text;

            SetarNomeProduto();

            dgvBuscarMarca.DataSource = null;

            dgvBuscarMarca.Visible = false;

            this.ActiveControl = tbRefProduto;
        }

        private void tbDescricaoNomeProduto_TextChanged(object sender, EventArgs e)
        {
            nome_inteiro_produto[1] = tbDescricaoNomeProduto.Text;

            SetarNomeProduto();
        }

        private void tbRefProduto_TextChanged(object sender, EventArgs e)
        {
            nome_inteiro_produto[3] = tbRefProduto.Text;

            SetarNomeProduto();
        }

        private void tbDescricaoNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }


        private void dgvEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ibtnRemoverCliente_Click(this, new EventArgs());
            }
        }

        private void tbValorProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAdicionarEstoque_Click(this, new EventArgs());
            }
        }

        private void tbNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void cbQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void tbValorComprado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void tbValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void cbQuantidadeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            //Validando se o usuario aperto no teclado Ctrl + V
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbRefProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void linkTipoProduto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms.OfType<TipoProduto>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                TipoProduto tipoProduto = new TipoProduto();
                tipoProduto.ShowDialog();
            }
        }

        private void dgvBuscarTipoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int linha = dgvBuscarTipoProduto.CurrentRow.Index;

                //CLICK NA LINHA SELECIONADA
                var arg = new DataGridViewCellEventArgs(linha, linha);
                dgvBuscarTipoProduto_CellClick(dgvBuscarTipoProduto, arg);

                this.ActiveControl = tbDescricaoNomeProduto;
            }
        }

        private void dgvBuscarMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int linha = dgvBuscarMarca.CurrentRow.Index;

                //CLICK NA LINHA SELECIONADA
                var arg = new DataGridViewCellEventArgs(linha, linha);
                dgvBuscarMarca_CellClick(dgvBuscarMarca, arg);

                this.ActiveControl = tbRefProduto;
            }
        }

        private void linkMarca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms.OfType<MarcaProduto>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                MarcaProduto marcaProduto = new MarcaProduto();
                marcaProduto.ShowDialog();
            }
        }
    }
}