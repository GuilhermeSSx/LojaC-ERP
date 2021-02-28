using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja
{
    public partial class FrmAlterarProduto : Form
    {
        public FrmAlterarProduto(Produto_DTO produto_DTO)
        {
            InitializeComponent();

            lblCodigoProduto.Text = produto_DTO.ID_PRODUTO.ToString();
            tbNomeProduto.Text = produto_DTO.NOME_PRODUTO;
            cbTamanhoProduto.Text = produto_DTO.TAMANHO;
            tbValorComprado.Text = produto_DTO.VALOR_COMPRA.ToString();
            tbValorProduto.Text = produto_DTO.VALOR_PRODUTO.ToString();
            dtpDataEntradaProduto.Value = produto_DTO.DATA_ENTRADA;
        }

        private void ibtnAlterarProduto_Click(object sender, EventArgs e)
        {
            Produto_DTO produto_DTO = new Produto_DTO();

            produto_DTO.ID_PRODUTO = Convert.ToInt32(lblCodigoProduto.Text);
            produto_DTO.NOME_PRODUTO = tbNomeProduto.Text;
            produto_DTO.TAMANHO = cbTamanhoProduto.Text;
            produto_DTO.VALOR_COMPRA = Convert.ToDecimal(tbValorComprado.Text);
            produto_DTO.VALOR_PRODUTO = Convert.ToDecimal(tbValorProduto.Text);
            produto_DTO.DATA_ENTRADA = dtpDataEntradaProduto.Value;

            Produto_DAO produto_DAO = new Produto_DAO();

            string retorno = produto_DAO.alterarProduto(produto_DTO);

            try
            {
                int id_produto = Convert.ToInt32(retorno);

                DialogResult resultado = MessageBox.Show("Produto Alterado: " + tbNomeProduto.Text);
                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel alterar produto: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }

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

        private void tbNomeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarProduto_Click(this, new EventArgs());
            }
            //Validando se o usuario aperto no teclado Ctrl + V
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbValorComprado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarProduto_Click(this, new EventArgs());
            }
        }

        private void tbValorProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarProduto_Click(this, new EventArgs());
            }
        }

        private void tbNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

    }
}