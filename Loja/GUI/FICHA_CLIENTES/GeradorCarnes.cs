using Loja.DAO;
using Loja.DTO;
using Loja.Properties;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Loja.GUI.FICHA_CLIENTES
{
    public partial class GeradorCarnes : Form
    {
        public GeradorCarnes(string codigoPedido, string nomeCliente)
        {
            InitializeComponent();

            lblCodigoPedido.Text = codigoPedido;

            lblNomeCliente.Text = nomeCliente;

            dgvPedidoParcelasCarne.AutoGenerateColumns = false;
        }

        private void pbCarne_Paint(object sender, PaintEventArgs e)
        {
            string nomeCliente = lblNomeCliente.Text;

            Int32 index = dgvPedidoParcelasCarne.Rows.Count - 1;

            //numero da parcela
            string numeroParcela1 = dgvPedidoParcelasCarne.Rows[0].Cells[0].Value.ToString();

            string numeroUltimaParcela = dgvPedidoParcelasCarne.Rows[index].Cells[0].Value.ToString();
            //Valor documento
            string valorParcela1 = dgvPedidoParcelasCarne.Rows[0].Cells[1].Value.ToString();
            decimal valorFormatado = Convert.ToDecimal(valorParcela1);
            lblValorDocumento.Text = valorFormatado.ToString("C");

            //data da parcela
            String dataParcela1 = dgvPedidoParcelasCarne.Rows[0].Cells[3].Value.ToString();

            ///DESENHAR LINHAS - caneta
            Pen myPen = new Pen(Color.FromArgb(35, 31, 32), 2);
            Pen myPenSmall = new Pen(Color.FromArgb(35, 31, 32), 1);

            Graphics g = e.Graphics;
            //DESENHAR UMA STRING

            Font drawFont = new Font("Arial", 16);
            Font drawFontMedium = new Font("Arial", 14);
            Font drawFontSmall = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            //pegar quantidade de linhas
            int numeroTotalLinhas = dgvPedidoParcelasCarne.RowCount - 1;

            if (numeroTotalLinhas == 0)
            {
                //CORDENADAS
                PointF drawPointEmpresa = new PointF(255.0F, 15.0F);

                PointF drawPointParcela = new PointF(43.0F, 132.0F);

                PointF drawPointParcelaNumero = new PointF(45.0F, 150.0F);

                PointF drawPointParcelaNumeroUltimo = new PointF(65.0F, 150.0F);

                PointF drawPointVencimento = new PointF(29.0F, 175.0F);

                PointF drawPointVencimentoValor = new PointF(7.0F, 194.0F);

                PointF drawPointLocalPagamento = new PointF(135.0F, 48.0F);

                PointF drawPointLocalPagamentoTexto = new PointF(135.0F, 68.0F);

                PointF drawPointCedente = new PointF(135.0F, 94.0F);

                PointF drawPointCedenteTexto = new PointF(135.0F, 109.0F);

                PointF drawPointInfo = new PointF(135.0F, 155.0F);

                PointF drawPointValorDocumentoTexto = new PointF(440.0F, 157.0F);

                PointF drawPointValorDocumento = new PointF(470.0F, 177.0F);

                PointF drawPointImage = new PointF(5.0F, 7.0F);

                //linha horizontal
                g.DrawLine(myPen, 5, 3, 595, 3);

                g.DrawLine(myPenSmall, 137, 8, 594, 8);

                g.DrawLine(myPenSmall, 137, 42, 594, 42);

                g.DrawLine(myPenSmall, 137, 88, 594, 88);

                g.DrawLine(myPenSmall, 137, 130, 594, 130);

                g.DrawLine(myPen, 5, 221, 595, 221);

                //-------------

                g.DrawLine(myPenSmall, 5, 130, 121, 130);

                g.DrawLine(myPenSmall, 5, 173, 121, 173);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 8, 129, 216);

                g.DrawLine(myPenSmall, 428, 135, 428, 216);

                //DESENHAR IMAGEM

                g.DrawImage(Resources.logo_em, drawPointImage);

                //mostrar na tela TEXTO parcela 1
                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, drawPointEmpresa);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, drawPointParcela);

                e.Graphics.DrawString(numeroParcela1, drawFont, drawBrush, drawPointParcelaNumero);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 150.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, drawPointParcelaNumeroUltimo);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, drawPointVencimento);

                e.Graphics.DrawString(dataParcela1.Replace("00:00:00", ""), drawFont, drawBrush, drawPointVencimentoValor);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, drawPointLocalPagamento);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, drawPointLocalPagamentoTexto);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, drawPointCedente);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, drawPointCedenteTexto);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, drawPointInfo);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, drawPointValorDocumentoTexto);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, drawPointValorDocumento);

                this.pbCarne.Size = new System.Drawing.Size(600, 226);
            }
            else if (numeroTotalLinhas == 1)
            {
                //CORDENADAS
                PointF drawPointEmpresa = new PointF(255.0F, 15.0F);

                PointF drawPointParcela = new PointF(43.0F, 132.0F);

                PointF drawPointParcelaNumero = new PointF(45.0F, 150.0F);

                PointF drawPointParcelaNumeroUltimo = new PointF(65.0F, 150.0F);

                PointF drawPointVencimento = new PointF(29.0F, 175.0F);

                PointF drawPointVencimentoValor = new PointF(7.0F, 194.0F);

                PointF drawPointLocalPagamento = new PointF(135.0F, 48.0F);

                PointF drawPointLocalPagamentoTexto = new PointF(135.0F, 68.0F);

                PointF drawPointCedente = new PointF(135.0F, 94.0F);

                PointF drawPointCedenteTexto = new PointF(135.0F, 109.0F);

                PointF drawPointInfo = new PointF(135.0F, 155.0F);

                PointF drawPointValorDocumentoTexto = new PointF(440.0F, 157.0F);

                PointF drawPointValorDocumento = new PointF(470.0F, 177.0F);

                PointF drawPointImage = new PointF(5.0F, 7.0F);

                //linha horizontal
                g.DrawLine(myPen, 5, 3, 595, 3);

                g.DrawLine(myPenSmall, 137, 8, 594, 8);

                g.DrawLine(myPenSmall, 137, 42, 594, 42);

                g.DrawLine(myPenSmall, 137, 88, 594, 88);

                g.DrawLine(myPenSmall, 137, 130, 594, 130);

                g.DrawLine(myPen, 5, 221, 595, 221);

                //-------------

                g.DrawLine(myPenSmall, 5, 130, 121, 130);

                g.DrawLine(myPenSmall, 5, 173, 121, 173);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 8, 129, 216);

                g.DrawLine(myPenSmall, 428, 135, 428, 216);

                //DESENHAR IMAGEM

                g.DrawImage(Resources.logo_em, drawPointImage);

                //mostrar na tela TEXTO parcela 1
                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, drawPointEmpresa);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, drawPointParcela);

                e.Graphics.DrawString(numeroParcela1, drawFont, drawBrush, drawPointParcelaNumero);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 150.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, drawPointParcelaNumeroUltimo);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, drawPointVencimento);

                e.Graphics.DrawString(dataParcela1.Replace("00:00:00", ""), drawFont, drawBrush, drawPointVencimentoValor);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, drawPointLocalPagamento);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, drawPointLocalPagamentoTexto);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, drawPointCedente);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, drawPointCedenteTexto);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, drawPointInfo);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, drawPointValorDocumentoTexto);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, drawPointValorDocumento);

                // SEGUNDA PARCELA ------------------------------------------------------------------------

                string numeroParcela2 = dgvPedidoParcelasCarne.Rows[1].Cells[0].Value.ToString();
                String dataParcela2 = dgvPedidoParcelasCarne.Rows[1].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 227, 595, 227);

                g.DrawLine(myPenSmall, 137, 232, 594, 232);

                g.DrawLine(myPenSmall, 137, 266, 594, 266);

                g.DrawLine(myPenSmall, 137, 312, 594, 312);

                g.DrawLine(myPenSmall, 137, 354, 594, 354);

                g.DrawLine(myPen, 5, 445, 595, 445);

                //-------------

                g.DrawLine(myPenSmall, 5, 354, 121, 354);

                g.DrawLine(myPenSmall, 5, 397, 121, 397);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 232, 129, 440);

                g.DrawLine(myPenSmall, 428, 359, 428, 440);

                // -----------texto parcela 2

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 239.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 356.0F);

                e.Graphics.DrawString(numeroParcela2.Replace("00:00:00", ""), drawFont, drawBrush, 45.0F, 374.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 374.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 374.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 399.0F);

                e.Graphics.DrawString(dataParcela2.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 418.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 272.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 292.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 318.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 333.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 379.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 381.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 401.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 231.0F);

                this.pbCarne.Size = new System.Drawing.Size(600, 452);
            }
            else if (numeroTotalLinhas == 2)
            {
                //CORDENADAS
                PointF drawPointEmpresa = new PointF(255.0F, 15.0F);

                PointF drawPointParcela = new PointF(43.0F, 132.0F);

                PointF drawPointParcelaNumero = new PointF(45.0F, 150.0F);

                PointF drawPointParcelaNumeroUltimo = new PointF(65.0F, 150.0F);

                PointF drawPointVencimento = new PointF(29.0F, 175.0F);

                PointF drawPointVencimentoValor = new PointF(7.0F, 194.0F);

                PointF drawPointLocalPagamento = new PointF(135.0F, 48.0F);

                PointF drawPointLocalPagamentoTexto = new PointF(135.0F, 68.0F);

                PointF drawPointCedente = new PointF(135.0F, 94.0F);

                PointF drawPointCedenteTexto = new PointF(135.0F, 109.0F);

                PointF drawPointInfo = new PointF(135.0F, 155.0F);

                PointF drawPointValorDocumentoTexto = new PointF(440.0F, 157.0F);

                PointF drawPointValorDocumento = new PointF(470.0F, 177.0F);

                PointF drawPointImage = new PointF(5.0F, 7.0F);

                //linha horizontal
                g.DrawLine(myPen, 5, 3, 595, 3);

                g.DrawLine(myPenSmall, 137, 8, 594, 8);

                g.DrawLine(myPenSmall, 137, 42, 594, 42);

                g.DrawLine(myPenSmall, 137, 88, 594, 88);

                g.DrawLine(myPenSmall, 137, 130, 594, 130);

                g.DrawLine(myPen, 5, 221, 595, 221);

                //-------------

                g.DrawLine(myPenSmall, 5, 130, 121, 130);

                g.DrawLine(myPenSmall, 5, 173, 121, 173);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 8, 129, 216);

                g.DrawLine(myPenSmall, 428, 135, 428, 216);

                //DESENHAR IMAGEM

                g.DrawImage(Resources.logo_em, drawPointImage);

                //mostrar na tela TEXTO parcela 1
                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, drawPointEmpresa);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, drawPointParcela);

                e.Graphics.DrawString(numeroParcela1, drawFont, drawBrush, drawPointParcelaNumero);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 150.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, drawPointParcelaNumeroUltimo);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, drawPointVencimento);

                e.Graphics.DrawString(dataParcela1.Replace("00:00:00", ""), drawFont, drawBrush, drawPointVencimentoValor);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, drawPointLocalPagamento);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, drawPointLocalPagamentoTexto);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, drawPointCedente);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, drawPointCedenteTexto);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, drawPointInfo);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, drawPointValorDocumentoTexto);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, drawPointValorDocumento);

                // SEGUNDA PARCELA ------------------------------------------------------------------------

                string numeroParcela2 = dgvPedidoParcelasCarne.Rows[1].Cells[0].Value.ToString();
                String dataParcela2 = dgvPedidoParcelasCarne.Rows[1].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 227, 595, 227);

                g.DrawLine(myPenSmall, 137, 232, 594, 232);

                g.DrawLine(myPenSmall, 137, 266, 594, 266);

                g.DrawLine(myPenSmall, 137, 312, 594, 312);

                g.DrawLine(myPenSmall, 137, 354, 594, 354);

                g.DrawLine(myPen, 5, 445, 595, 445);

                //-------------

                g.DrawLine(myPenSmall, 5, 354, 121, 354);

                g.DrawLine(myPenSmall, 5, 397, 121, 397);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 232, 129, 440);

                g.DrawLine(myPenSmall, 428, 359, 428, 440);

                // -----------texto parcela 2

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 239.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 356.0F);

                e.Graphics.DrawString(numeroParcela2.Replace("00:00:00", ""), drawFont, drawBrush, 45.0F, 374.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 374.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 374.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 399.0F);

                e.Graphics.DrawString(dataParcela2.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 418.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 272.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 292.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 318.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 333.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 379.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 381.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 401.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 231.0F);

                // TERCEIRA PARCELA ------------------------------------------------------------------------

                string numeroParcela3 = dgvPedidoParcelasCarne.Rows[2].Cells[0].Value.ToString();
                String dataParcela3 = dgvPedidoParcelasCarne.Rows[2].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 451, 595, 451);

                g.DrawLine(myPenSmall, 137, 456, 594, 456);

                g.DrawLine(myPenSmall, 137, 490, 594, 490);

                g.DrawLine(myPenSmall, 137, 536, 594, 536);

                g.DrawLine(myPenSmall, 137, 578, 594, 578);

                g.DrawLine(myPen, 5, 669, 595, 669);

                //-------------

                g.DrawLine(myPenSmall, 5, 578, 121, 578);

                g.DrawLine(myPenSmall, 5, 621, 121, 621);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 456, 129, 664);

                g.DrawLine(myPenSmall, 428, 583, 428, 664);

                // -----------texto parcela 3

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 463.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 580.0F);

                e.Graphics.DrawString(numeroParcela3, drawFont, drawBrush, 45.0F, 598.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 598.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 598.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 623.0F);

                e.Graphics.DrawString(dataParcela3.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 642.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 496.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 516.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 542.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 557.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 603.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 605.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 625.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 455.0F);

                this.pbCarne.Size = new System.Drawing.Size(600, 676);
            }
            else if (numeroTotalLinhas == 3)
            {
                //CORDENADAS
                PointF drawPointEmpresa = new PointF(255.0F, 15.0F);

                PointF drawPointParcela = new PointF(43.0F, 132.0F);

                PointF drawPointParcelaNumero = new PointF(45.0F, 150.0F);

                PointF drawPointParcelaNumeroUltimo = new PointF(65.0F, 150.0F);

                PointF drawPointVencimento = new PointF(29.0F, 175.0F);

                PointF drawPointVencimentoValor = new PointF(7.0F, 194.0F);

                PointF drawPointLocalPagamento = new PointF(135.0F, 48.0F);

                PointF drawPointLocalPagamentoTexto = new PointF(135.0F, 68.0F);

                PointF drawPointCedente = new PointF(135.0F, 94.0F);

                PointF drawPointCedenteTexto = new PointF(135.0F, 109.0F);

                PointF drawPointInfo = new PointF(135.0F, 155.0F);

                PointF drawPointValorDocumentoTexto = new PointF(440.0F, 157.0F);

                PointF drawPointValorDocumento = new PointF(470.0F, 177.0F);

                PointF drawPointImage = new PointF(5.0F, 7.0F);

                //linha horizontal
                g.DrawLine(myPen, 5, 3, 595, 3);

                g.DrawLine(myPenSmall, 137, 8, 594, 8);

                g.DrawLine(myPenSmall, 137, 42, 594, 42);

                g.DrawLine(myPenSmall, 137, 88, 594, 88);

                g.DrawLine(myPenSmall, 137, 130, 594, 130);

                g.DrawLine(myPen, 5, 221, 595, 221);

                //-------------

                g.DrawLine(myPenSmall, 5, 130, 121, 130);

                g.DrawLine(myPenSmall, 5, 173, 121, 173);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 8, 129, 216);

                g.DrawLine(myPenSmall, 428, 135, 428, 216);

                //DESENHAR IMAGEM

                g.DrawImage(Resources.logo_em, drawPointImage);

                //mostrar na tela TEXTO parcela 1
                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, drawPointEmpresa);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, drawPointParcela);

                e.Graphics.DrawString(numeroParcela1, drawFont, drawBrush, drawPointParcelaNumero);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 150.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, drawPointParcelaNumeroUltimo);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, drawPointVencimento);

                e.Graphics.DrawString(dataParcela1.Replace("00:00:00", ""), drawFont, drawBrush, drawPointVencimentoValor);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, drawPointLocalPagamento);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, drawPointLocalPagamentoTexto);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, drawPointCedente);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, drawPointCedenteTexto);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, drawPointInfo);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, drawPointValorDocumentoTexto);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, drawPointValorDocumento);

                // SEGUNDA PARCELA ------------------------------------------------------------------------

                string numeroParcela2 = dgvPedidoParcelasCarne.Rows[1].Cells[0].Value.ToString();
                String dataParcela2 = dgvPedidoParcelasCarne.Rows[1].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 227, 595, 227);

                g.DrawLine(myPenSmall, 137, 232, 594, 232);

                g.DrawLine(myPenSmall, 137, 266, 594, 266);

                g.DrawLine(myPenSmall, 137, 312, 594, 312);

                g.DrawLine(myPenSmall, 137, 354, 594, 354);

                g.DrawLine(myPen, 5, 445, 595, 445);

                //-------------

                g.DrawLine(myPenSmall, 5, 354, 121, 354);

                g.DrawLine(myPenSmall, 5, 397, 121, 397);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 232, 129, 440);

                g.DrawLine(myPenSmall, 428, 359, 428, 440);

                // -----------texto parcela 2

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 239.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 356.0F);

                e.Graphics.DrawString(numeroParcela2.Replace("00:00:00", ""), drawFont, drawBrush, 45.0F, 374.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 374.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 374.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 399.0F);

                e.Graphics.DrawString(dataParcela2.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 418.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 272.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 292.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 318.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 333.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 379.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 381.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 401.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 231.0F);

                // TERCEIRA PARCELA ------------------------------------------------------------------------

                string numeroParcela3 = dgvPedidoParcelasCarne.Rows[2].Cells[0].Value.ToString();
                String dataParcela3 = dgvPedidoParcelasCarne.Rows[2].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 451, 595, 451);

                g.DrawLine(myPenSmall, 137, 456, 594, 456);

                g.DrawLine(myPenSmall, 137, 490, 594, 490);

                g.DrawLine(myPenSmall, 137, 536, 594, 536);

                g.DrawLine(myPenSmall, 137, 578, 594, 578);

                g.DrawLine(myPen, 5, 669, 595, 669);

                //-------------

                g.DrawLine(myPenSmall, 5, 578, 121, 578);

                g.DrawLine(myPenSmall, 5, 621, 121, 621);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 456, 129, 664);

                g.DrawLine(myPenSmall, 428, 583, 428, 664);

                // -----------texto parcela 3

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 463.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 580.0F);

                e.Graphics.DrawString(numeroParcela3, drawFont, drawBrush, 45.0F, 598.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 598.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 598.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 623.0F);

                e.Graphics.DrawString(dataParcela3.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 642.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 496.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 516.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 542.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 557.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 603.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 605.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 625.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 455.0F);

                // QUARTA PARCELA ------------------------------------------------------------------------

                string numeroParcela4 = dgvPedidoParcelasCarne.Rows[3].Cells[0].Value.ToString();
                String dataParcela4 = dgvPedidoParcelasCarne.Rows[3].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 675, 595, 675);

                g.DrawLine(myPenSmall, 137, 680, 594, 680);

                g.DrawLine(myPenSmall, 137, 714, 594, 714);

                g.DrawLine(myPenSmall, 137, 760, 594, 760);

                g.DrawLine(myPenSmall, 137, 802, 594, 802);

                g.DrawLine(myPen, 5, 893, 595, 893);

                //-------------

                g.DrawLine(myPenSmall, 5, 802, 121, 802);

                g.DrawLine(myPenSmall, 5, 845, 121, 845);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 680, 129, 888);

                g.DrawLine(myPenSmall, 428, 807, 428, 888);

                // -----------texto parcela 4

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 687.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 804.0F);

                e.Graphics.DrawString(numeroParcela4, drawFont, drawBrush, 45.0F, 822.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 822.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 822.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 847.0F);

                e.Graphics.DrawString(dataParcela4.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 866.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 720.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 740.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 766.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 781.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 827.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 829.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 849.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 679.0F);

                this.pbCarne.Size = new System.Drawing.Size(600, 900);
            }
            else if (numeroTotalLinhas == 4)
            {
                //CORDENADAS
                PointF drawPointEmpresa = new PointF(255.0F, 15.0F);

                PointF drawPointParcela = new PointF(43.0F, 132.0F);

                PointF drawPointParcelaNumero = new PointF(45.0F, 150.0F);

                PointF drawPointParcelaNumeroUltimo = new PointF(65.0F, 150.0F);

                PointF drawPointVencimento = new PointF(29.0F, 175.0F);

                PointF drawPointVencimentoValor = new PointF(7.0F, 194.0F);

                PointF drawPointLocalPagamento = new PointF(135.0F, 48.0F);

                PointF drawPointLocalPagamentoTexto = new PointF(135.0F, 68.0F);

                PointF drawPointCedente = new PointF(135.0F, 94.0F);

                PointF drawPointCedenteTexto = new PointF(135.0F, 109.0F);

                PointF drawPointInfo = new PointF(135.0F, 155.0F);

                PointF drawPointValorDocumentoTexto = new PointF(440.0F, 157.0F);

                PointF drawPointValorDocumento = new PointF(470.0F, 177.0F);

                PointF drawPointImage = new PointF(5.0F, 7.0F);

                //linha horizontal
                g.DrawLine(myPen, 5, 3, 595, 3);

                g.DrawLine(myPenSmall, 137, 8, 594, 8);

                g.DrawLine(myPenSmall, 137, 42, 594, 42);

                g.DrawLine(myPenSmall, 137, 88, 594, 88);

                g.DrawLine(myPenSmall, 137, 130, 594, 130);

                g.DrawLine(myPen, 5, 221, 595, 221);

                //-------------

                g.DrawLine(myPenSmall, 5, 130, 121, 130);

                g.DrawLine(myPenSmall, 5, 173, 121, 173);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 8, 129, 216);

                g.DrawLine(myPenSmall, 428, 135, 428, 216);

                //DESENHAR IMAGEM

                g.DrawImage(Resources.logo_em, drawPointImage);

                //mostrar na tela TEXTO parcela 1
                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, drawPointEmpresa);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, drawPointParcela);

                e.Graphics.DrawString(numeroParcela1, drawFont, drawBrush, drawPointParcelaNumero);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 150.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, drawPointParcelaNumeroUltimo);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, drawPointVencimento);

                e.Graphics.DrawString(dataParcela1.Replace("00:00:00", ""), drawFont, drawBrush, drawPointVencimentoValor);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, drawPointLocalPagamento);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, drawPointLocalPagamentoTexto);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, drawPointCedente);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, drawPointCedenteTexto);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, drawPointInfo);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, drawPointValorDocumentoTexto);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, drawPointValorDocumento);

                // SEGUNDA PARCELA ------------------------------------------------------------------------

                string numeroParcela2 = dgvPedidoParcelasCarne.Rows[1].Cells[0].Value.ToString();
                String dataParcela2 = dgvPedidoParcelasCarne.Rows[1].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 227, 595, 227);

                g.DrawLine(myPenSmall, 137, 232, 594, 232);

                g.DrawLine(myPenSmall, 137, 266, 594, 266);

                g.DrawLine(myPenSmall, 137, 312, 594, 312);

                g.DrawLine(myPenSmall, 137, 354, 594, 354);

                g.DrawLine(myPen, 5, 445, 595, 445);

                //-------------

                g.DrawLine(myPenSmall, 5, 354, 121, 354);

                g.DrawLine(myPenSmall, 5, 397, 121, 397);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 232, 129, 440);

                g.DrawLine(myPenSmall, 428, 359, 428, 440);

                // -----------texto parcela 2

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 239.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 356.0F);

                e.Graphics.DrawString(numeroParcela2.Replace("00:00:00", ""), drawFont, drawBrush, 45.0F, 374.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 374.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 374.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 399.0F);

                e.Graphics.DrawString(dataParcela2.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 418.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 272.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 292.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 318.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 333.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 379.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 381.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 401.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 231.0F);

                // TERCEIRA PARCELA ------------------------------------------------------------------------

                string numeroParcela3 = dgvPedidoParcelasCarne.Rows[2].Cells[0].Value.ToString();
                String dataParcela3 = dgvPedidoParcelasCarne.Rows[2].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 451, 595, 451);

                g.DrawLine(myPenSmall, 137, 456, 594, 456);

                g.DrawLine(myPenSmall, 137, 490, 594, 490);

                g.DrawLine(myPenSmall, 137, 536, 594, 536);

                g.DrawLine(myPenSmall, 137, 578, 594, 578);

                g.DrawLine(myPen, 5, 669, 595, 669);

                //-------------

                g.DrawLine(myPenSmall, 5, 578, 121, 578);

                g.DrawLine(myPenSmall, 5, 621, 121, 621);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 456, 129, 664);

                g.DrawLine(myPenSmall, 428, 583, 428, 664);

                // -----------texto parcela 3

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 463.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 580.0F);

                e.Graphics.DrawString(numeroParcela3, drawFont, drawBrush, 45.0F, 598.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 598.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 598.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 623.0F);

                e.Graphics.DrawString(dataParcela3.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 642.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 496.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 516.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 542.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 557.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 603.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 605.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 625.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 455.0F);

                // QUARTA PARCELA ------------------------------------------------------------------------

                string numeroParcela4 = dgvPedidoParcelasCarne.Rows[3].Cells[0].Value.ToString();
                String dataParcela4 = dgvPedidoParcelasCarne.Rows[3].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 675, 595, 675);

                g.DrawLine(myPenSmall, 137, 680, 594, 680);

                g.DrawLine(myPenSmall, 137, 714, 594, 714);

                g.DrawLine(myPenSmall, 137, 760, 594, 760);

                g.DrawLine(myPenSmall, 137, 802, 594, 802);

                g.DrawLine(myPen, 5, 893, 595, 893);

                //-------------

                g.DrawLine(myPenSmall, 5, 802, 121, 802);

                g.DrawLine(myPenSmall, 5, 845, 121, 845);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 680, 129, 888);

                g.DrawLine(myPenSmall, 428, 807, 428, 888);

                // -----------texto parcela 4

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 687.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 804.0F);

                e.Graphics.DrawString(numeroParcela4, drawFont, drawBrush, 45.0F, 822.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 822.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 822.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 847.0F);

                e.Graphics.DrawString(dataParcela4.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 866.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 720.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 740.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 766.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 781.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 827.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 829.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 849.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 679.0F);

                // QUINTA PARCELA ------------------------------------------------------------------------

                string numeroParcela5 = dgvPedidoParcelasCarne.Rows[4].Cells[0].Value.ToString();
                String dataParcela5 = dgvPedidoParcelasCarne.Rows[4].Cells[3].Value.ToString();

                //linha horizontal
                g.DrawLine(myPen, 5, 899, 595, 899);

                g.DrawLine(myPenSmall, 137, 904, 594, 904);

                g.DrawLine(myPenSmall, 137, 938, 594, 938);

                g.DrawLine(myPenSmall, 137, 984, 594, 984);

                g.DrawLine(myPenSmall, 137, 1026, 594, 1026);

                g.DrawLine(myPen, 5, 1117, 595, 1117);

                //-------------

                g.DrawLine(myPenSmall, 5, 1026, 121, 1026);

                g.DrawLine(myPenSmall, 5, 1069, 121, 1069);

                //linha vertical
                g.DrawLine(myPenSmall, 129, 904, 129, 1112);

                g.DrawLine(myPenSmall, 428, 1031, 428, 1112);

                // -----------texto parcela 5

                e.Graphics.DrawString("ELEGÂNCIA MODAS", drawFont, drawBrush, 255.0F, 911.0F);

                e.Graphics.DrawString("Parcela", drawFontSmall, drawBrush, 43.0F, 1028.0F);

                e.Graphics.DrawString(numeroParcela5, drawFont, drawBrush, 45.0F, 1046.0F);

                e.Graphics.DrawString("/", drawFont, drawBrush, 57.0F, 1046.0F);

                e.Graphics.DrawString(numeroUltimaParcela, drawFont, drawBrush, 65.0F, 1046.0F);

                e.Graphics.DrawString("Vencimento", drawFontSmall, drawBrush, 29.0F, 1071.0F);

                e.Graphics.DrawString(dataParcela5.Replace("00:00:00", ""), drawFont, drawBrush, 7.0F, 1090.0F);

                e.Graphics.DrawString("Local de Pagamento", drawFontSmall, drawBrush, 135.0F, 944.0F);

                e.Graphics.DrawString("REALIZAR O PAGAMENTO APENAS NO ESTABELECIMENTO EMISSOR.",
                    drawFontSmall, drawBrush, 135.0F, 964.0F);

                e.Graphics.DrawString("Cedente", drawFontSmall, drawBrush, 135.0F, 990.0F);

                e.Graphics.DrawString(nomeCliente, drawFontSmall, drawBrush, 135.0F, 1005.0F);

                e.Graphics.DrawString("Após o vencimento cobrar 0,30% de juros\n" +
                    "ao dia e 9,00% de juros ao mês.\nObrigado pela Preferência.", drawFontSmall, drawBrush, 135.0F, 1051.0F);

                e.Graphics.DrawString("(=) Valor do Documento", drawFontSmall, drawBrush, 440.0F, 1053.0F);

                e.Graphics.DrawString(lblValorDocumento.Text, drawFontMedium, drawBrush, 470.0F, 1073.0F);

                //DESENHAR IMAGEM
                g.DrawImage(Resources.logo_em, 5.0F, 903.0F);

                this.pbCarne.Size = new System.Drawing.Size(600, 1124);
            }
        }

        private void GeradorCarnes_Load(object sender, EventArgs e)
        {
            if (lblCodigoPedido.Text == "")
            {
                MessageBox.Show("esse cliente não tem parcelas");
            }
            else
            {
                CarregarPedidoListaParcela();
            }

            panelScrollPB.AutoScroll = true;
            pbCarne.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void CarregarPedidoListaParcela()
        {
            string id_pedido = lblCodigoPedido.Text;

            Pedido_Parcela_Finalizar_DAO pedido_Parcela_Finalizar_DAO = new Pedido_Parcela_Finalizar_DAO();

            Pedido_Parcela_Finalizar_Colecao pedido_Parcela_Finalizar_Colecao = new Pedido_Parcela_Finalizar_Colecao();

            pedido_Parcela_Finalizar_Colecao = pedido_Parcela_Finalizar_DAO.pedidoParcelasConsultar(id_pedido);

            dgvPedidoParcelasCarne.DataSource = null;
            dgvPedidoParcelasCarne.DataSource = pedido_Parcela_Finalizar_Colecao;

            dgvPedidoParcelasCarne.Update();
            dgvPedidoParcelasCarne.Refresh();
        }

        private void ibtnImprimirCarne_Click(object sender, EventArgs e)
        {
            PrintCarne();
        }

        private void PrintCarne()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                //tela atual fica atras do print save
                this.TopMost = false;
                doc.Print();
            }
            else
            {
                this.Close();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pbCarne.Width, pbCarne.Height);
            pbCarne.DrawToBitmap(bm, new Rectangle(0, 0, pbCarne.Width, pbCarne.Height));
            e.Graphics.DrawImage(bm, 93, 2); //margem na folha
            bm.Dispose();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}