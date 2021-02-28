using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void limpar_campos()
        {
            tbNomeCliente.Text = "";
            tbEndereco.Text = "";
            tbBairro.Text = "";
            tbNumero.Text = "";
            mtbCpf.Text = "";
            mtbCelular.Text = "";
            mtbRg.Text = "";
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 1300, WinAPI.BLEND);
        }

        private void ibtnCadastrarCliente_Click(object sender, EventArgs e)
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

                cliente_DTO.NOME_CLIENTE = tbNomeCliente.Text;
                cliente_DTO.ENDERECO = tbEndereco.Text;
                cliente_DTO.BAIRRO = tbBairro.Text;
                cliente_DTO.NUMERO = Convert.ToInt32(tbNumero.Text.Trim() == "" ? 0 : Convert.ToDecimal(tbNumero.Text.Trim()));
                cliente_DTO.CPF = mtbCpf.Text;
                cliente_DTO.CELULAR = Convert.ToInt64(mtbCelular.Text.Trim() == "" ? 0 : Convert.ToDecimal(mtbCelular.Text.Trim()));
                cliente_DTO.RG = Convert.ToInt32(mtbRg.Text.Trim() == "" ? 0 : Convert.ToDecimal(mtbRg.Text.Trim()));

                Cliente_DAO cliente_DAO = new Cliente_DAO();
                string retorno = cliente_DAO.CadastrarCliente(cliente_DTO);

                try
                {
                    int id_cliente = Convert.ToInt32(retorno);

                    MessageBox.Show("Cliente criado com sucesso ", "Novo Cliente criado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar_campos();
                    tbNomeCliente.Focus();
                }
                catch
                {
                    MessageBox.Show("Não foi possivel criar novo Cliente. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mtbCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnCadastrarCliente_Click(this, new EventArgs());
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
                ibtnCadastrarCliente_Click(this, new EventArgs());
            }
        }

        private void mtbCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnCadastrarCliente_Click(this, new EventArgs());
            }
        }

        private void mtbRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnCadastrarCliente_Click(this, new EventArgs());
            }
        }

        private void tbNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ibtnCadastrarCliente_Click(this, new EventArgs());
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