using Loja.DAO;
using Loja.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Loja
{
    public partial class ListaCompletaClientes : Form
    {
        public ListaCompletaClientes()
        {
            InitializeComponent();
            //não gerar colunas automatico
            dgvListaCompletaClientes.AutoGenerateColumns = false;

        }

        private void CarregarListaCliente()
        {
            Cliente_DAO cliente_DAO = new Cliente_DAO();

            Cliente_Colecao cliente_Colecao = new Cliente_Colecao();

            cliente_Colecao = cliente_DAO.ConsultarPorNome(cbBuscarCliente.Text);

            dgvListaCompletaClientes.DataSource = null;
            dgvListaCompletaClientes.DataSource = cliente_Colecao;

            //combobox
            cbBuscarCliente.DataSource = cliente_Colecao;
            cbBuscarCliente.ValueMember = "ID_CLIENTE";
            cbBuscarCliente.DisplayMember = "NOME_CLIENTE";

            cbBuscarCliente.Text = "";

            dgvListaCompletaClientes.Update();
            dgvListaCompletaClientes.Refresh();
        }

        private void ListaCompletaClientes_Load(object sender, EventArgs e)
        {
            CarregarListaCliente();
        }

        private void ibtnAlterarCliente_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvListaCompletaClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid
            Cliente_DTO clienteSelecionado = (dgvListaCompletaClientes.SelectedRows[0].DataBoundItem as Cliente_DTO);

            if (Application.OpenForms.OfType<FrmAlterarCliente>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                FrmAlterarCliente frmAlterarCliente = new FrmAlterarCliente(clienteSelecionado);
                DialogResult dialogResult = frmAlterarCliente.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    cbBuscarCliente.Text = "";
                    CarregarListaCliente();
                }
            }
        }

        private void ibtnRemoverCliente_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvListaCompletaClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado.");
                return;
            }

            //perguntar se realmente quer excluir
            DialogResult resultado = MessageBox.Show("Deseja mesmo remover o Cliente ?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar o cliente selecionado no grid
            Cliente_DTO clienteSelecionado = (dgvListaCompletaClientes.SelectedRows[0].DataBoundItem as Cliente_DTO);

            //Instanciar a regra Produto
            Cliente_DAO cliente_DAO = new Cliente_DAO();

            //chama o metodo excluir
            string retorno = cliente_DAO.ExcluirCliente(clienteSelecionado);

            //verifica se excluiu, se o retorno for numero é porque deu certo, senão é a mensagem de erro
            try
            {
                int id_cliente = Convert.ToInt32(retorno);
                cbBuscarCliente.Text = "";
                CarregarListaCliente();
            }
            catch
            {
                MessageBox.Show("Detalhes: \n"
                    + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ibtnBuscarClienteCC_Click(object sender, EventArgs e)
        {
            pesquisarNoDataGrid();
        }

        private void cbBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisarNoDataGrid();
            }
        }

        private void pesquisarNoDataGrid()
        {
            string pesquisar = cbBuscarCliente.Text.ToLower();

            dgvListaCompletaClientes.ClearSelection();

            foreach (DataGridViewRow row in dgvListaCompletaClientes.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString().ToLower().Equals(pesquisar))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        private void dgvListaCompletaClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ibtnRemoverCliente_Click(this, new EventArgs());
            }
        }
    }
}