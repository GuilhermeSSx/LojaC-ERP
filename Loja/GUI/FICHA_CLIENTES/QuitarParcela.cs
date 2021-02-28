using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.GUI.FICHA_CLIENTES
{
    public partial class QuitarParcela : Form
    {
        public QuitarParcela(string id_parcela, string valor_parcela)
        {
            InitializeComponent();
            lblIdParcela.Text = id_parcela;
            tbValorParcela.Text = valor_parcela;
            
        }

        private void ibtnQuitarParcela_Click(object sender, EventArgs e)
        {

        }

        private void QuitarParcela_Load(object sender, EventArgs e)
        {

        }
    }
}
