using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.GUI.FICHA_CLIENTES
{
    public partial class PagamentoParcial : Form
    {
        public PagamentoParcial(string id_parcela, string valor_parcela, DateTime dataVencimentoParcela)
        {
            InitializeComponent();
            lblIdParcela.Text = id_parcela;
            tbValorParcela.Text = valor_parcela;
            dtpDataVencimentoParcela.Value = dataVencimentoParcela;
        }

        private void PagamentoParcial_Load(object sender, EventArgs e)
        {
            tbValorDescontado.Text = "0";

            tbValorDescontado.Focus();
        }

        private void tbValorParcela_TextChanged(object sender, EventArgs e)
        {
            decimal ResultadoValorParcelaFinal;

            ResultadoValorParcelaFinal = Convert.ToDecimal(tbValorParcela.Text.Replace("R$", "").Trim()) - Convert.ToDecimal
                (tbValorDescontado.Text.Trim() == "" ? 0 : Convert.ToDecimal(tbValorDescontado.Text.Trim()));

            tbValorRestante.Text = ResultadoValorParcelaFinal.ToString("C");
        }

        private void tbValorDescontado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Só deixa Digitar numeros no TextBox Desconto
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbValorDescontado_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tbValorDescontado);

            decimal valorParcelaAtual = Convert.ToDecimal(tbValorParcela.Text);

            decimal valorDescontado = Convert.ToDecimal(tbValorDescontado.Text);

            if (valorDescontado > valorParcelaAtual)
            {
                tbValorDescontado.Text = Convert.ToString(valorParcelaAtual);
            }

            if (tbValorDescontado.Text == "0,00")
            {
                ibtnEfetuarPagamentoParcial.Enabled = false;
            }
            else
            {
                ibtnEfetuarPagamentoParcial.Enabled = true;
            }

            decimal ResultadoValorFinalParcela;

            ResultadoValorFinalParcela = Convert.ToDecimal(tbValorParcela.Text.Replace("R$", "").Trim()) - Convert.ToDecimal
                (tbValorDescontado.Text.Trim() == "" ? 0 : Convert.ToDecimal(tbValorDescontado.Text.Trim()));

            tbValorRestante.Text = ResultadoValorFinalParcela.ToString("C");
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

        private void tbValorRestante_TextChanged(object sender, EventArgs e)
        {
            if (tbValorRestante.Text.Contains("-"))
            {
                tbValorRestante.Text = "R$ 0,00";
            }
            else
            {
                //não fazer nada
            }
        }

        private void ibtnEfetuarPagamentoParcial_Click(object sender, EventArgs e)
        {
            if(tbValorDescontado.Text == "0,00")
            {
                MessageBox.Show("Selecione um valor maior que 0 Zero.");
            }
            else
            {
                string valor_restante = tbValorRestante.Text.Replace("R$ ", "");

                Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO = new Pedido_Parcela_Finalizar_DTO();

                pedido_Parcela_Finalizar_DTO.ID_PARCELA = Convert.ToInt32(lblIdParcela.Text);
                pedido_Parcela_Finalizar_DTO.VALOR_PARCELA = Convert.ToDecimal(valor_restante);
                pedido_Parcela_Finalizar_DTO.VALOR_DESCONTADO = Convert.ToDecimal(tbValorDescontado.Text);
                pedido_Parcela_Finalizar_DTO.NOVA_DATA_VENCIMENTO = dtpDataVencimentoParcela.Value;
                pedido_Parcela_Finalizar_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

                Pedido_Parcela_Finalizar_DAO pedido_Parcela_Finalizar_DAO = new Pedido_Parcela_Finalizar_DAO();

                string retorno = pedido_Parcela_Finalizar_DAO.PagamentoParcial(pedido_Parcela_Finalizar_DTO);

                try
                {
                    int id_parcela = Convert.ToInt32(retorno);

                    DialogResult resultado = MessageBox.Show("Pagamento Efetuado.\nValor Restante: " + tbValorRestante.Text);
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel realizar pagamento. Detalhes:" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }


        }




    }
}