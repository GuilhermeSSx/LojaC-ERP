using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.GUI.CAIXA
{
    public partial class SangriaCaixa : Form
    {
        string valor_caixa = "0,00";

        public SangriaCaixa(string saldo_caixa)
        {
            InitializeComponent();
            valor_caixa = saldo_caixa;
        }

        private void SangriaCaixa_Load(object sender, EventArgs e)
        {
            tbValorSangria.Text = "0";
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

        private void tbValorSangria_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tbValorSangria);

            decimal saldo_caixa = Convert.ToDecimal(valor_caixa.Replace("R$ ", ""));
            decimal valor_sangria = Convert.ToDecimal(tbValorSangria.Text);

            if(valor_sangria > saldo_caixa)
            {
                tbValorSangria.Text = Convert.ToString(saldo_caixa);
            }
 
            if (tbValorSangria.Text == "0,00")
            {
                ibtnSangriaCaixa.Enabled = false;
            }
            else
            {
                ibtnSangriaCaixa.Enabled = true;
            }
        }

        private void ibtnSangriaCaixa_Click(object sender, EventArgs e)
        {
            if (tbValorSangria.Text == "0,00")
            {
                MessageBox.Show("Adicione um valor acima de zero para Realizar uma Sangria de Caixa.");
                return;
            }
            else
            {
                Caixa_DTO caixa_DTO = new Caixa_DTO();

                caixa_DTO.SALDO_SANGRIA = Convert.ToDecimal(tbValorSangria.Text);
                caixa_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

                Caixa_DAO caixa_DAO = new Caixa_DAO();

                string retorno = caixa_DAO.sangriaCaixa(caixa_DTO);

                try
                {
                    decimal SALDO_SANGRIA = Convert.ToDecimal(retorno);

                    DialogResult resultado = MessageBox.Show("Sangria de caixa Realizada em: " + retorno);
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel realizar a Sangria: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.No;
                }
            }

        }

        private void tbValorSangria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
