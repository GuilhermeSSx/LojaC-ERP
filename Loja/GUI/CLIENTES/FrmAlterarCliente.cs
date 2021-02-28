using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja
{
    public partial class FrmAlterarCliente : Form
    {
        public FrmAlterarCliente(Cliente_DTO cliente_DTO)
        {
            InitializeComponent();

            lblCodigoCliente.Text = cliente_DTO.ID_CLIENTE.ToString();
            tbNomeCliente.Text = cliente_DTO.NOME_CLIENTE;
            tbEndereco.Text = cliente_DTO.ENDERECO;
            tbBairro.Text = cliente_DTO.BAIRRO;
            tbNumero.Text = cliente_DTO.NUMERO.ToString();
            mtbCpf.Text = cliente_DTO.CPF.ToString();
            mtbCelular.Text = cliente_DTO.CELULAR.ToString();
            mtbRg.Text = cliente_DTO.RG.ToString();
        }

        private void FrmAlterarCliente_Load(object sender, EventArgs e)
        {
        }

        private void ibtnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (tbNomeCliente.Text == "")
            {
                MessageBox.Show("Nome do Cliente é obrigatório.");
            }
            else
            {
                mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mtbCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mtbRg.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                Cliente_DTO cliente_DTO = new Cliente_DTO();

                cliente_DTO.ID_CLIENTE = Convert.ToInt32(lblCodigoCliente.Text);
                cliente_DTO.NOME_CLIENTE = tbNomeCliente.Text;
                cliente_DTO.ENDERECO = tbEndereco.Text;
                cliente_DTO.BAIRRO = tbBairro.Text;
                cliente_DTO.NUMERO = Convert.ToInt32(tbNumero.Text);
                cliente_DTO.CPF = mtbCpf.Text;
                cliente_DTO.CELULAR = Convert.ToInt64(mtbCelular.Text);
                cliente_DTO.RG = Convert.ToInt32(mtbRg.Text);

                Cliente_DAO cliente_DAO = new Cliente_DAO();

                string retorno = cliente_DAO.AlterarCliente(cliente_DTO);

                try
                {
                    int id_cliente = Convert.ToInt32(retorno);

                    DialogResult resultado = MessageBox.Show("Cliente alterado: " + tbNomeCliente.Text);
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar. Detalhes:" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void tbNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            //Validando se o usuario aperto no teclado Ctrl + V
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarCliente_Click(this, new EventArgs());
            }
        }

        private void tbEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarCliente_Click(this, new EventArgs());
            }
        }

        private void tbBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarCliente_Click(this, new EventArgs());
            }
        }

        private void tbNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarCliente_Click(this, new EventArgs());
            }
        }

        private void mtbCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarCliente_Click(this, new EventArgs());
            }
        }

        private void mtbRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarCliente_Click(this, new EventArgs());
            }
        }

        private void mtbCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnAlterarCliente_Click(this, new EventArgs());
            }
        }

        private void tbNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

    }
}