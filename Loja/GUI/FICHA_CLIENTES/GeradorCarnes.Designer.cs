namespace Loja.GUI.FICHA_CLIENTES
{
    partial class GeradorCarnes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbCarne = new System.Windows.Forms.PictureBox();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.dgvPedidoParcelasCarne = new System.Windows.Forms.DataGridView();
            this.colNumeroParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacaoParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.panelScrollPB = new System.Windows.Forms.Panel();
            this.ibtnImprimirCarne = new FontAwesome.Sharp.IconButton();
            this.lblValorDocumento = new System.Windows.Forms.Label();
            this.btnVoltar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoParcelasCarne)).BeginInit();
            this.panelScrollPB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCarne
            // 
            this.pbCarne.BackColor = System.Drawing.Color.White;
            this.pbCarne.Location = new System.Drawing.Point(0, 3);
            this.pbCarne.Name = "pbCarne";
            this.pbCarne.Size = new System.Drawing.Size(600, 1120);
            this.pbCarne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCarne.TabIndex = 1;
            this.pbCarne.TabStop = false;
            this.pbCarne.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCarne_Paint);
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPedido.Location = new System.Drawing.Point(263, 501);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(114, 13);
            this.lblCodigoPedido.TabIndex = 2;
            this.lblCodigoPedido.Text = "-CODIGO PEDIDO-";
            this.lblCodigoPedido.Visible = false;
            // 
            // dgvPedidoParcelasCarne
            // 
            this.dgvPedidoParcelasCarne.AllowUserToAddRows = false;
            this.dgvPedidoParcelasCarne.AllowUserToDeleteRows = false;
            this.dgvPedidoParcelasCarne.AllowUserToResizeColumns = false;
            this.dgvPedidoParcelasCarne.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedidoParcelasCarne.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidoParcelasCarne.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvPedidoParcelasCarne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoParcelasCarne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumeroParcela,
            this.ValorParcela,
            this.colSituacaoParcela,
            this.DataPagamento,
            this.colIdParcelas});
            this.dgvPedidoParcelasCarne.Location = new System.Drawing.Point(203, 498);
            this.dgvPedidoParcelasCarne.MultiSelect = false;
            this.dgvPedidoParcelasCarne.Name = "dgvPedidoParcelasCarne";
            this.dgvPedidoParcelasCarne.ReadOnly = true;
            this.dgvPedidoParcelasCarne.RowHeadersWidth = 30;
            this.dgvPedidoParcelasCarne.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPedidoParcelasCarne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoParcelasCarne.Size = new System.Drawing.Size(41, 31);
            this.dgvPedidoParcelasCarne.TabIndex = 26;
            this.dgvPedidoParcelasCarne.Visible = false;
            // 
            // colNumeroParcela
            // 
            this.colNumeroParcela.DataPropertyName = "QUANT_PARCELAS";
            this.colNumeroParcela.HeaderText = "Numero";
            this.colNumeroParcela.Name = "colNumeroParcela";
            this.colNumeroParcela.ReadOnly = true;
            this.colNumeroParcela.Width = 60;
            // 
            // ValorParcela
            // 
            this.ValorParcela.DataPropertyName = "VALOR_PARCELA";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ValorParcela.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorParcela.HeaderText = "Valor Parcela";
            this.ValorParcela.Name = "ValorParcela";
            this.ValorParcela.ReadOnly = true;
            // 
            // colSituacaoParcela
            // 
            this.colSituacaoParcela.DataPropertyName = "DESCRICAO";
            this.colSituacaoParcela.HeaderText = "Situação";
            this.colSituacaoParcela.Name = "colSituacaoParcela";
            this.colSituacaoParcela.ReadOnly = true;
            this.colSituacaoParcela.Visible = false;
            this.colSituacaoParcela.Width = 90;
            // 
            // DataPagamento
            // 
            this.DataPagamento.DataPropertyName = "DATA_PARCELAS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.DataPagamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataPagamento.HeaderText = "Vencimento";
            this.DataPagamento.Name = "DataPagamento";
            this.DataPagamento.ReadOnly = true;
            this.DataPagamento.Width = 120;
            // 
            // colIdParcelas
            // 
            this.colIdParcelas.DataPropertyName = "ID_PARCELA";
            this.colIdParcelas.HeaderText = "ID";
            this.colIdParcelas.Name = "colIdParcelas";
            this.colIdParcelas.ReadOnly = true;
            this.colIdParcelas.Visible = false;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(270, 486);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(107, 13);
            this.lblNomeCliente.TabIndex = 27;
            this.lblNomeCliente.Text = "-NOME CLIENTE-";
            this.lblNomeCliente.Visible = false;
            // 
            // panelScrollPB
            // 
            this.panelScrollPB.BackColor = System.Drawing.Color.Gold;
            this.panelScrollPB.Controls.Add(this.pbCarne);
            this.panelScrollPB.Location = new System.Drawing.Point(11, 7);
            this.panelScrollPB.Name = "panelScrollPB";
            this.panelScrollPB.Size = new System.Drawing.Size(620, 455);
            this.panelScrollPB.TabIndex = 28;
            // 
            // ibtnImprimirCarne
            // 
            this.ibtnImprimirCarne.BackColor = System.Drawing.Color.Blue;
            this.ibtnImprimirCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnImprimirCarne.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnImprimirCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnImprimirCarne.ForeColor = System.Drawing.Color.White;
            this.ibtnImprimirCarne.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ibtnImprimirCarne.IconColor = System.Drawing.Color.White;
            this.ibtnImprimirCarne.IconSize = 40;
            this.ibtnImprimirCarne.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnImprimirCarne.Location = new System.Drawing.Point(409, 476);
            this.ibtnImprimirCarne.Name = "ibtnImprimirCarne";
            this.ibtnImprimirCarne.Rotation = 0D;
            this.ibtnImprimirCarne.Size = new System.Drawing.Size(202, 53);
            this.ibtnImprimirCarne.TabIndex = 57;
            this.ibtnImprimirCarne.Text = "Imprimir Carnê";
            this.ibtnImprimirCarne.UseVisualStyleBackColor = false;
            this.ibtnImprimirCarne.Click += new System.EventHandler(this.ibtnImprimirCarne_Click);
            // 
            // lblValorDocumento
            // 
            this.lblValorDocumento.AutoSize = true;
            this.lblValorDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDocumento.Location = new System.Drawing.Point(261, 516);
            this.lblValorDocumento.Name = "lblValorDocumento";
            this.lblValorDocumento.Size = new System.Drawing.Size(116, 13);
            this.lblValorDocumento.TabIndex = 58;
            this.lblValorDocumento.Text = "-VALOR PARCELA-";
            this.lblValorDocumento.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnVoltar.IconColor = System.Drawing.Color.Red;
            this.btnVoltar.IconSize = 35;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(11, 476);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Rotation = 0D;
            this.btnVoltar.Size = new System.Drawing.Size(159, 53);
            this.btnVoltar.TabIndex = 59;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // GeradorCarnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(638, 532);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblValorDocumento);
            this.Controls.Add(this.ibtnImprimirCarne);
            this.Controls.Add(this.panelScrollPB);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.dgvPedidoParcelasCarne);
            this.Controls.Add(this.lblCodigoPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeradorCarnes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Carnês";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GeradorCarnes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoParcelasCarne)).EndInit();
            this.panelScrollPB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCarne;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.DataGridView dgvPedidoParcelasCarne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacaoParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdParcelas;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Panel panelScrollPB;
        private FontAwesome.Sharp.IconButton ibtnImprimirCarne;
        private System.Windows.Forms.Label lblValorDocumento;
        private FontAwesome.Sharp.IconButton btnVoltar;
    }
}