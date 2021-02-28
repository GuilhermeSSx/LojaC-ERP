using FontAwesome.Sharp;
using Loja.DAO;
using Loja.DTO;
using Loja.GUI.CLIENTE_CRUD;
using Loja.GUI.SISTEMA;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Loja
{
    public partial class Sistema : Form
    {
        private IconButton currentBtn;
        private Panel bordaSuperiorBtn;
        private Panel bordaSuperiorPaginaInicialBtn;

        //cria uma variavel estatica na memoria para não perder o valor passado
        public static string codigoPedido = "0";

        public Sistema()
        {
            InitializeComponent();
            bordaSuperiorBtn = new Panel();
            bordaSuperiorBtn.Size = new Size(217, 4);
            panelMenu.Controls.Add(bordaSuperiorBtn);
            //--
            bordaSuperiorPaginaInicialBtn = new Panel();
            bordaSuperiorPaginaInicialBtn.Size = new Size(280, 4);
            panelMenu.Controls.Add(bordaSuperiorPaginaInicialBtn);

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        // Construtor para pegar o codigo do pedido do form Caixa
        public Sistema(string codigoPedidoRetornado) : this()
        {
            InitializeComponent();
            codigoPedido = codigoPedidoRetornado;

            //MessageBox.Show(codigoPedido);
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            AbrirFormFechar(new PaginaInicial());

            botaoDesativadoIniciar(ibtnCadastroClientes);
            botaoDesativadoIniciar(ibtnCaixa);
            botaoDesativadoIniciar(ibtnFichaClientes);
            botaoDesativadoIniciar(ibtnEstoque);

            botaoAtivado(ibtnPaginaInicial, Color.FromArgb(192, 0, 192));
            btnPaginaInicialClick = true;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(0, 0, 192);
            public static Color color2 = Color.FromArgb(0, 192, 0);
            public static Color color3 = Color.FromArgb(30, 144, 255);
            public static Color color4 = Color.FromArgb(192, 0, 0);
            public static Color color5 = Color.FromArgb(192, 0, 192);
        }

        private void botaoAtivado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                botaoDesativado();

                if (senderBtn == ibtnPaginaInicial)
                {
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    //borda esquerda do botão
                    bordaSuperiorPaginaInicialBtn.BackColor = color;
                    bordaSuperiorPaginaInicialBtn.Location = new Point(currentBtn.Location.X, 0);
                    bordaSuperiorPaginaInicialBtn.Visible = true;
                    bordaSuperiorPaginaInicialBtn.BringToFront();

                    bordaSuperiorBtn.Visible = false;
                }
                else
                {
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    //borda esquerda do botão
                    bordaSuperiorBtn.BackColor = color;
                    bordaSuperiorBtn.Location = new Point(currentBtn.Location.X, 0);
                    bordaSuperiorBtn.Visible = true;
                    bordaSuperiorBtn.BringToFront();

                    bordaSuperiorPaginaInicialBtn.Visible = false;
                }
            }
        }

        private void botaoDesativado()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(245, 245, 245);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void botaoDesativadoIniciar(object senderBtn)
        {
            botaoDesativado();

            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = Color.FromArgb(245, 245, 245);
            currentBtn.ForeColor = Color.Black;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = Color.Black;
            currentBtn.TextImageRelation = TextImageRelation.Overlay;
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void ibtnCadastroClientes_Click(object sender, EventArgs e)
        {
            botaoAtivado(sender, RGBColors.color1);

            if (Application.OpenForms.OfType<Clientes>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar(new Clientes());
                btnPaginaInicialClick = false;
            }
        }

        private void ibtnCaixa_Click(object sender, EventArgs e)
        {
            botaoAtivado(sender, RGBColors.color2);

            if (Application.OpenForms.OfType<Caixa>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar(new Caixa());
                btnPaginaInicialClick = false;
            }
        }

        private void ibtnFichaClientes_Click(object sender, EventArgs e)
        {
            botaoAtivado(sender, RGBColors.color3);

            if (Application.OpenForms.OfType<FichasClientes>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar(new FichasClientes());
                btnPaginaInicialClick = false;
            }
        }

        private void ibtnEstoque_Click(object sender, EventArgs e)
        {
            botaoAtivado(sender, RGBColors.color4);

            if (Application.OpenForms.OfType<Estoque>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar(new Estoque());
                btnPaginaInicialClick = false;
            }
        }

        private Form formAtivo = null;

        private void AbrirFormFechar(Form childForm)
        {
            if (formAtivo != null) formAtivo.Close();
            formAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            TopMost = false;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ResetarPedido()
        {
            Pedido_DTO pedido_DTO = new Pedido_DTO();

            pedido_DTO.ID_PEDIDO = Convert.ToInt32(codigoPedido);

            Pedido_DAO pedido_DAO = new Pedido_DAO();

            string retorno = pedido_DAO.ResetarPedido(pedido_DTO);

            try
            {
                int idpedido = Convert.ToInt32(retorno);
            }
            catch
            {
                MessageBox.Show("Não foi resetar o pedido. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool btnPaginaInicialClick = false;

        private void ibtnPaginaInicial_Click(object sender, EventArgs e)
        {
            botaoAtivado(sender, RGBColors.color5);

            if (Application.OpenForms.OfType<PaginaInicial>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar(new PaginaInicial());
                btnPaginaInicialClick = true;
            }
        }

        private void Sistema_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                if (btnPaginaInicialClick == true)
                {
                    bordaPaginaIncialReload();
                }
            }
            else
            {
                bordaPaginaIncialReload();
            }
        }

        private void bordaPaginaIncialReload()
        {
            if (btnPaginaInicialClick == true)
            {
                Color color = Color.FromArgb(192, 0, 192);

                //borda superior botão
                bordaSuperiorPaginaInicialBtn.BackColor = color;
                bordaSuperiorPaginaInicialBtn.Location = new Point(ibtnPaginaInicial.Location.X, 0);
                bordaSuperiorPaginaInicialBtn.Visible = true;
                bordaSuperiorPaginaInicialBtn.BringToFront();

                bordaSuperiorBtn.Visible = false;
            }
        }

        public void Sistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(codigoPedido);

            if (codigoPedido == "0")
            {
            }
            else
            {
                ResetarPedido();
            }

        }

        private void Sistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }
    }
}