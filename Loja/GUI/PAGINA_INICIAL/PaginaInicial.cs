using Loja.GUI.PAGINA_INICIAL;
using Loja.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Loja.GUI.SISTEMA
{
    public partial class PaginaInicial : Form
    {
        private bool isCollapsed;

        //criar a conexão
        SqlConnection conexao = new SqlConnection(Settings.Default.stringConexao);

        public PaginaInicial()
        {
            InitializeComponent();
            lblNomeUsuario.Text = TelaLogin.nomeUsuario;

            conexao.Open();
            string query2 = "SELECT NIVEL_ACESSO FROM USUARIO WHERE NOME_USUARIO = '" + lblNomeUsuario.Text + "'";
            SqlDataAdapter dp2 = new SqlDataAdapter(query2, conexao);
            DataTable dt2 = new DataTable();
            dp2.Fill(dt2);

            if (dt2.Rows.Count == 1)
            {
                lblNivel.Text = (dt2.Rows[0]["NIVEL_ACESSO"].ToString());
                conexao.Close();
            }
            else
            {
                MessageBox.Show("erro de nivel de acesso");
                conexao.Close();
            }

            if(lblNivel.Text == "3")
            {
                ibtnControleCaixa.Visible = false;
                ibtnConfiguracoes.Visible = false;
                panelRelatorioButton.Visible = false;
            }

        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            AbrirFormFechar2(new Home());
        }

        private Form formAtivo2 = null;

        private void AbrirFormFechar2(Form childForm)
        {
            if (formAtivo2 != null) formAtivo2.Close();
            formAtivo2 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            TopMost = true;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timerBtn_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelRelatorioButton.Height += 20;
                if (panelRelatorioButton.Size == panelRelatorioButton.MaximumSize)
                {
                    timerBtn.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelRelatorioButton.Height -= 20;
                if (panelRelatorioButton.Size == panelRelatorioButton.MinimumSize)
                {
                    timerBtn.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void ibtnHome_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Home>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar2(new Home());
            }
        }

        private void ibtnContasReceber_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ContasReceber>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar2(new ContasReceber());
            }
        }

        private void ibtnContasVencidas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ContasVencidas>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar2(new ContasVencidas());
            }
        }

        private void ibtnRelatoriosGerais_Click(object sender, EventArgs e)
        {
            timerBtn.Start();
        }

        private void ibtnMovimentoEstoque_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MovimentoEstoque>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar2(new MovimentoEstoque());
            }
        }

        private void ibtnFluxoCaixa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FluxoCaixa>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar2(new FluxoCaixa());
            }
        }

        private void ibtnVendasCompras_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<RelatorioVendasCompras>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar2(new RelatorioVendasCompras());
            }
        }

        private void ibtnHistoricoVendas_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<HistoricoVendas>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar2(new HistoricoVendas());
            }
        }

        private void ibtnControleCaixa_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ControleCaixa>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar2(new ControleCaixa());
            }
        }

        private void ibtnConfiguracoes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Configs>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar2(new Configs());
            }
        }


    }
}