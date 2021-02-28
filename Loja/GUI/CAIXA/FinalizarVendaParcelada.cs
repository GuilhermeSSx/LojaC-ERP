using Loja.DAO;
using Loja.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Loja.GUI.CAIXA
{
    public partial class FinalizarVendaParcelada : Form
    {
        public FinalizarVendaParcelada(string codigoPedido, string quantidadeParcelas,
            string valorTotal, string valorDesconto, DateTime dataVencimento, string FormaPagamento)
        {
            InitializeComponent();

            lblCodigoPedido.Text = codigoPedido;
            tbQuantidadeParcelas.Text = quantidadeParcelas;
            tbValorTotal.Text = valorTotal;
            tbValorDesconto.Text = valorDesconto;
            dtpDataVencimento.Value = dataVencimento;
            lblFormaPagamento.Text = FormaPagamento;

            int quant_parcelas = Convert.ToInt32(tbQuantidadeParcelas.Text);

            cbQuantidadeParcelas.DataSource = Enumerable.Range(1, 5).ToList();

            cbQuantidadeParcelas.SelectedItem = quant_parcelas;
        }

        public string lblCodigoPedidoRetorno
        {
            get { return lblCodigoPedido.Text; }
            set { lblCodigoPedido.Text = lblCodigoPedido.Text; }
        }

        public FinalizarVendaParcelada(string parametro)
        {
            lblCodigoPedido.Text = parametro;
        }

        private void CalcularParcela(int qtdeParcela)
        {
            DateTime dataVencimento = dtpDataVencimento.Value;
            decimal valorTotal = Convert.ToDecimal(tbValorTotal.Text.Replace("R$", ""));
            int totalParcelas = qtdeParcela;
            int contador = 0;

            List<Pedido_Parcela_Finalizar_DTO> lista = new List<Pedido_Parcela_Finalizar_DTO>();

            for (int i = 0; i < totalParcelas; i++)
            {
                contador++;

                var parcela = new Pedido_Parcela_Finalizar_DTO();

                parcela.VALOR_PARCELA = valorTotal / qtdeParcela;

                parcela.QUANT_PARCELAS = contador;

                parcela.ID_PARCELA = contador;

                parcela.ID_PEDIDO = Convert.ToInt32(lblCodigoPedido.Text);

                parcela.DATA_PARCELAS = dataVencimento.AddMonths(contador - 1);

                lista.Add(parcela);
            }

            dgvParcelas.AutoGenerateColumns = false;

            dgvParcelas.DataSource = null;

            dgvParcelas.DataSource = lista;
        }

        private void GeradorParcelas_Load(object sender, EventArgs e)
        {
            //cbQuantidadeParcelas.SelectedIndex = 0;

            int quantParcela = Convert.ToInt32(tbQuantidadeParcelas.Text);
            CalcularParcela(quantParcela);
        }

        private void ibtnFinalizarVendaParcelada_Click(object sender, EventArgs e)
        {
            Pedido_Finalizar_DTO pedido_Finalizar_DTO = new Pedido_Finalizar_DTO();

            string id_pedido = lblCodigoPedido.Text;
            string desconto = tbValorDesconto.Text.Trim() == "" ? "0" : tbValorDesconto.Text.Trim();
            string quant_parcelas = tbQuantidadeParcelas.Text;
            var data_pagamento = Convert.ToDateTime(dtpDataVencimento.Value);
            string valor_total = tbValorTotal.Text.Replace("R$", "");

            pedido_Finalizar_DTO.ID_PEDIDO = Convert.ToInt32(id_pedido);
            pedido_Finalizar_DTO.QUANT_PARCELAS = Convert.ToByte(quant_parcelas);
            pedido_Finalizar_DTO.DATA_PARCELAS = data_pagamento;
            pedido_Finalizar_DTO.VALOR_TOTAL = Convert.ToDecimal(valor_total);
            pedido_Finalizar_DTO.VALOR_DESCONTO = Convert.ToDecimal(desconto);

            pedido_Finalizar_DTO.FORMA_PAGAMENTO = lblFormaPagamento.Text;

            pedido_Finalizar_DTO.USUARIO = Convert.ToString(TelaLogin.nomeUsuario);

            Pedido_Finalizar_DAO pedido_Finalizar_DAO = new Pedido_Finalizar_DAO();

            string retorno = pedido_Finalizar_DAO.PedidoFinalizar(pedido_Finalizar_DTO);

            try
            {
                int idpedido = Convert.ToInt32(retorno);
                //MessageBox.Show("Pedido Parcelado feito");

                lblCodigoPedido.Text = "0";
                //Manda o lblcodigoPedido do form FinalizarVendaParcelada para o form sistema
                Sistema sistema = new Sistema(lblCodigoPedidoRetorno);
            }
            catch
            {
                MessageBox.Show("Não foi possivel criar finalizar o Pedido. Detalhes: "
                    + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SalvarGridParcela();
        }

        public void SalvarGridParcela()
        {
            try
            {
                // SALVAR EM MASSA PARCELAS
                if (dgvParcelas.Rows.Count > 0)
                {
                    for (int i = 0; i <= dgvParcelas.Rows.Count - 1; i++)
                    {
                        int col0 = Convert.ToInt32(dgvParcelas.Rows[i].Cells[0].Value); //id pedido
                        string col2 = dgvParcelas.Rows[i].Cells[2].Value.ToString(); //numero parcela
                        string col4 = dgvParcelas.Rows[i].Cells[3].Value.ToString(); //valor parcela
                        string col5 = dgvParcelas.Rows[i].Cells[4].Value.ToString(); //data vencimento

                        Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO = new Pedido_Parcela_Finalizar_DTO();

                        pedido_Parcela_Finalizar_DTO.ID_PEDIDO = Convert.ToInt32(col0);
                        pedido_Parcela_Finalizar_DTO.QUANT_PARCELAS = Convert.ToInt32(col2);
                        pedido_Parcela_Finalizar_DTO.VALOR_PARCELA = Convert.ToDecimal(col4);
                        pedido_Parcela_Finalizar_DTO.DATA_PARCELAS = Convert.ToDateTime(col5);

                        Pedido_Parcela_Finalizar_DAO pedido_Parcela_Finalizar_DAO = new Pedido_Parcela_Finalizar_DAO();

                        string retorno = pedido_Parcela_Finalizar_DAO.PedidoParcelaCriar(pedido_Parcela_Finalizar_DTO);
                    }
                }

                DialogResult resultado = MessageBox.Show("Venda Parcelada Efetuada ", "Sucesso.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnGerarParcelas_Click_1(object sender, EventArgs e)
        {
            /*
            string escolha = cbQuantidadeParcelas.SelectedItem.ToString();

            switch (escolha)
            {
                case "1":
                    CalcularParcela(1);
                    break;

                case "2":
                    CalcularParcela(2);
                    break;

                case "3":
                    CalcularParcela(3);
                    break;

                case "4":
                    CalcularParcela(4);
                    break;

                case "5":
                    CalcularParcela(5);
                    break;
            }
            */

            int quantParcela = Convert.ToInt32(tbQuantidadeParcelas.Text);
            CalcularParcela(quantParcela);
        }

        private void FinalizarVendaParcelada_Load(object sender, EventArgs e)
        {
            int quantParcela = Convert.ToInt32(tbQuantidadeParcelas.Text);
            CalcularParcela(quantParcela);
        }

        private void cbQuantidadeParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //colocar o valor do combobox no textbox para salvar no banco
            tbQuantidadeParcelas.Text = cbQuantidadeParcelas.SelectedItem.ToString();

            //realizar o calculo da quantidade ao clicar em em uma opção do combobox
            int quantParcela = Convert.ToInt32(tbQuantidadeParcelas.Text);
            CalcularParcela(quantParcela);
        }
    }
}