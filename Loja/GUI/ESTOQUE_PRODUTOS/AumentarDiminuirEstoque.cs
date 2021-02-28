using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.GUI.ESTOQUE_PRODUTOS
{
    public partial class AumentarDiminuirEstoque : Form
    {
        public AumentarDiminuirEstoque(Produto_DTO produto_DTO)
        {
            InitializeComponent();

            lblIdProduto.Text = produto_DTO.ID_PRODUTO.ToString();
            lblNomeProduto.Text = produto_DTO.NOME_PRODUTO;
            cbQuantidadeProduto.Text = produto_DTO.QUANT_PROD.ToString();
            lblValorCompra.Text = produto_DTO.VALOR_COMPRA.ToString();
        }

        private void ibtnAumentarDiminuir_Click(object sender, EventArgs e)
        {
            Produto_DTO produto_DTO = new Produto_DTO();

            produto_DTO.ID_PRODUTO = Convert.ToInt32(lblIdProduto.Text);
            produto_DTO.NOME_PRODUTO = Convert.ToString(lblNomeProduto.Text);
            produto_DTO.QUANT_PROD = Convert.ToInt32(cbQuantidadeProduto.Text);
            produto_DTO.VALOR_COMPRA = Convert.ToDecimal(lblValorCompra.Text);
            produto_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

            Produto_DAO produto_DAO = new Produto_DAO();

            string retorno = produto_DAO.AumentarDiminuirEstoque(produto_DTO);

            try
            {
                int id_produto = Convert.ToInt32(retorno);

                DialogResult resultado = MessageBox.Show("Produtos adicionados ou diminuidos: " + lblNomeProduto.Text);
                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                if(retorno == "Quantidade Inalterada")
                {
                    this.DialogResult = DialogResult.No;
                }
                else
                {
                    MessageBox.Show("Não foi possivel adicionar ou diminuir: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
        }

        private void cbQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
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

        private void cbQuantidadeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            //Validando se o usuario aperto no teclado Ctrl + V
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void AumentarDiminuirEstoque_Load(object sender, EventArgs e)
        {
            cbQuantidadeProduto.ContextMenu = new ContextMenu();
        }
    }
}