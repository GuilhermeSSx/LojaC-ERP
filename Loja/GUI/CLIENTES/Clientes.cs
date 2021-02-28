using System;
using System.Linq;
using System.Windows.Forms;

namespace Loja.GUI.CLIENTE_CRUD
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            AbrirFormFechar(new CadastroClientes());
        }

        private Form formAtivo = null;

        private void AbrirFormFechar(Form childForm)
        {
            if (formAtivo != null) formAtivo.Close();
            formAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            TopMost = true;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ibtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadastroClientes>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar(new CadastroClientes());
            }
        }

        private void ibtnListaCompletaClientes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ListaCompletaClientes>().Count() > 0)
            {
                //Não vai executar nada
            }
            else
            {
                AbrirFormFechar(new ListaCompletaClientes());
            }
        }
    }
}