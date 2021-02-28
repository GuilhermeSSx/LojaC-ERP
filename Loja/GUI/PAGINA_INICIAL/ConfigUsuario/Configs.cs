using Loja.DAO;
using Loja.DTO;
using Loja.GUI.PAGINA_INICIAL.Configuracoes;
using Loja.GUI.PAGINA_INICIAL.ConfigUsuario;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Loja.GUI.PAGINA_INICIAL
{
    public partial class Configs : Form
    {
        public Configs()
        {
            InitializeComponent();
            dgvListaFuncionarios.AutoGenerateColumns = false;

            lblNomeUsuario.Text = TelaLogin.nomeUsuario;
            lblNivelAcesso.Text = TelaLogin.nivelAcessoUsuario.ToString();

            if (lblNivelAcesso.Text == "1")
            {
                iconButton2.Visible = true;
            }
        }

        private void ibtnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<crudFuncionario>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                crudFuncionario crudFuncionario = new crudFuncionario();
                DialogResult dialogResult = crudFuncionario.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    CarregarFuncionarios();
                }
            }
        }

        private void Configs_Load(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }

        private void CarregarFuncionarios()
        {
            Funcionario_DAO funcionario_DAO = new Funcionario_DAO();

            Funcionario_Colecao funcionario_Colecao = new Funcionario_Colecao();

            funcionario_Colecao = funcionario_DAO.carregarFuncionarios();

            dgvListaFuncionarios.DataSource = null;
            dgvListaFuncionarios.DataSource = funcionario_Colecao;

            dgvListaFuncionarios.Update();
            dgvListaFuncionarios.Refresh();
        }

        private void ibtnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvListaFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum funcionario selecionado.");
                return;
            }

            //Pegar o produto selecionado no grid
            Funcionario_DTO funcionarioSelecionado = (dgvListaFuncionarios.SelectedRows[0].DataBoundItem as Funcionario_DTO);

            if (Application.OpenForms.OfType<alterarFuncionario>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                alterarFuncionario alterarFuncionario = new alterarFuncionario(funcionarioSelecionado);
                DialogResult dialogResult = alterarFuncionario.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    CarregarFuncionarios();
                }
            }
        }

        private void ibtnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dgvListaFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum funcionario selecionado.");
                return;
            }

            //perguntar se realmente quer excluir
            DialogResult resultado = MessageBox.Show("Deseja mesmo remover o Funcionário ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }


            Funcionario_DTO funcionarioSelecionado = (dgvListaFuncionarios.SelectedRows[0].DataBoundItem as Funcionario_DTO);

            Funcionario_DAO funcionario_DAO = new Funcionario_DAO();

            //chama o metodo excluir
            string retorno = funcionario_DAO.ExcluirFuncionario(funcionarioSelecionado);

            //verifica se excluiu, se o retorno for numero é porque deu certo, senão é a mensagem de erro
            try
            {
                int id_usuario = Convert.ToInt32(retorno);

                CarregarFuncionarios();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
