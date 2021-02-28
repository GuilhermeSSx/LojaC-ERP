using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.GUI.CAIXA
{
    public partial class ReforcoCaixa : Form
    {
        public ReforcoCaixa()
        {
            InitializeComponent();
        }

        private void ReforcoCaixa_Load(object sender, EventArgs e)
        {
            tbValorReforco.Text = "0";
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

        private void tbValorReforco_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref tbValorReforco);
            if (tbValorReforco.Text == "0,00")
            {
                ibtnReforcoCaixa.Enabled = false;
            }
            else
            {
                ibtnReforcoCaixa.Enabled = true;
            }
        }

        private void ibtnReforcoCaixa_Click(object sender, EventArgs e)
        {
            if (tbValorReforco.Text == "0,00")
            {
                MessageBox.Show("Adicione um valor acima de zero para Realizar um Reforço de Caixa.");
                return;
            }
            else
            {
                Caixa_DTO caixa_DTO = new Caixa_DTO();

                caixa_DTO.SALDO_REFORCO = Convert.ToDecimal(tbValorReforco.Text);
                caixa_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

                Caixa_DAO caixa_DAO = new Caixa_DAO();

                string retorno = caixa_DAO.reforcoCaixa(caixa_DTO);

                try
                {
                    decimal SALDO_REFORCO = Convert.ToDecimal(retorno);

                    DialogResult resultado = MessageBox.Show("Reforço de caixa Realizado em: " + retorno);
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel realizar o Reforço: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.No;
                }
            }

        }

        private void tbValorReforco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
