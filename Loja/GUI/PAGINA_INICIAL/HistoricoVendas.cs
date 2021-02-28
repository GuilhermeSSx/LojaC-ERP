using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.GUI.PAGINA_INICIAL
{
    public partial class HistoricoVendas : Form
    {
        public HistoricoVendas()
        {
            InitializeComponent();
            dgvHistoricoVendas.AutoGenerateColumns = false;
        }

        private void HistoricoVendas_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now; // get the current DateTime

            var firstDay = new DateTime(now.Year, now.Month, 1);

            dtpInicial.Value = firstDay;

            dtpFinal.Value = DateTime.Now;

            carregarHistoricoVendas();
        }


        private void carregarHistoricoVendas()
        {
            Pedido_DAO pedido_DAO = new Pedido_DAO();

            Pedido_Colecao pedido_Colecao = new Pedido_Colecao();

            pedido_Colecao = pedido_DAO.carregarHistoricoVendas(dtpInicial.Value, dtpFinal.Value);

            dgvHistoricoVendas.DataSource = null;
            dgvHistoricoVendas.DataSource = pedido_Colecao;
        }

        private void ibtnFiltrarBusca_Click(object sender, EventArgs e)
        {
            carregarHistoricoVendas();
        }
    }
}
