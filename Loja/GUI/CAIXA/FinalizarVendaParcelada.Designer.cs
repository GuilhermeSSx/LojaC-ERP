namespace Loja.GUI.CAIXA
{
    partial class FinalizarVendaParcelada
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
            this.ibtnFinalizarVendaParcelada = new FontAwesome.Sharp.IconButton();
            this.lblCodigoPedido = new System.Windows.Forms.Label();
            this.tbValorDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuantidadeParcelas = new System.Windows.Forms.TextBox();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.colIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDparcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantParcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarParcelas = new System.Windows.Forms.Button();
            this.cbQuantidadeParcelas = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // ibtnFinalizarVendaParcelada
            // 
            this.ibtnFinalizarVendaParcelada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnFinalizarVendaParcelada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFinalizarVendaParcelada.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnFinalizarVendaParcelada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnFinalizarVendaParcelada.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.ibtnFinalizarVendaParcelada.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ibtnFinalizarVendaParcelada.IconColor = System.Drawing.Color.Black;
            this.ibtnFinalizarVendaParcelada.IconSize = 30;
            this.ibtnFinalizarVendaParcelada.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnFinalizarVendaParcelada.Location = new System.Drawing.Point(282, 119);
            this.ibtnFinalizarVendaParcelada.Name = "ibtnFinalizarVendaParcelada";
            this.ibtnFinalizarVendaParcelada.Rotation = 0D;
            this.ibtnFinalizarVendaParcelada.Size = new System.Drawing.Size(164, 47);
            this.ibtnFinalizarVendaParcelada.TabIndex = 64;
            this.ibtnFinalizarVendaParcelada.Text = "Finalizar Venda Parcelada";
            this.ibtnFinalizarVendaParcelada.UseVisualStyleBackColor = false;
            this.ibtnFinalizarVendaParcelada.Click += new System.EventHandler(this.ibtnFinalizarVendaParcelada_Click);
            // 
            // lblCodigoPedido
            // 
            this.lblCodigoPedido.AutoSize = true;
            this.lblCodigoPedido.Location = new System.Drawing.Point(393, 47);
            this.lblCodigoPedido.Name = "lblCodigoPedido";
            this.lblCodigoPedido.Size = new System.Drawing.Size(13, 13);
            this.lblCodigoPedido.TabIndex = 63;
            this.lblCodigoPedido.Text = "=";
            this.lblCodigoPedido.Visible = false;
            // 
            // tbValorDesconto
            // 
            this.tbValorDesconto.Enabled = false;
            this.tbValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorDesconto.Location = new System.Drawing.Point(167, 47);
            this.tbValorDesconto.Name = "tbValorDesconto";
            this.tbValorDesconto.Size = new System.Drawing.Size(103, 21);
            this.tbValorDesconto.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Valor Desconto:";
            // 
            // tbQuantidadeParcelas
            // 
            this.tbQuantidadeParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantidadeParcelas.Location = new System.Drawing.Point(352, 83);
            this.tbQuantidadeParcelas.Name = "tbQuantidadeParcelas";
            this.tbQuantidadeParcelas.Size = new System.Drawing.Size(54, 21);
            this.tbQuantidadeParcelas.TabIndex = 60;
            this.tbQuantidadeParcelas.Visible = false;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToResizeColumns = false;
            this.dgvParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParcelas.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPedido,
            this.colIDparcela,
            this.colQuantParcelas,
            this.colValorParcela,
            this.colVencimento});
            this.dgvParcelas.Location = new System.Drawing.Point(22, 172);
            this.dgvParcelas.MultiSelect = false;
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.RowHeadersWidth = 30;
            this.dgvParcelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvParcelas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelas.Size = new System.Drawing.Size(424, 134);
            this.dgvParcelas.TabIndex = 59;
            // 
            // colIdPedido
            // 
            this.colIdPedido.DataPropertyName = "ID_PEDIDO";
            this.colIdPedido.HeaderText = "ID PEDIDO";
            this.colIdPedido.Name = "colIdPedido";
            this.colIdPedido.ReadOnly = true;
            this.colIdPedido.Visible = false;
            this.colIdPedido.Width = 90;
            // 
            // colIDparcela
            // 
            this.colIDparcela.DataPropertyName = "ID_PARCELA";
            this.colIDparcela.HeaderText = "ID PARCELA";
            this.colIDparcela.Name = "colIDparcela";
            this.colIDparcela.ReadOnly = true;
            this.colIDparcela.Visible = false;
            this.colIDparcela.Width = 80;
            // 
            // colQuantParcelas
            // 
            this.colQuantParcelas.DataPropertyName = "QUANT_PARCELAS";
            this.colQuantParcelas.HeaderText = "Num. Parcelas";
            this.colQuantParcelas.Name = "colQuantParcelas";
            this.colQuantParcelas.ReadOnly = true;
            this.colQuantParcelas.Width = 110;
            // 
            // colValorParcela
            // 
            this.colValorParcela.DataPropertyName = "VALOR_PARCELA";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colValorParcela.DefaultCellStyle = dataGridViewCellStyle2;
            this.colValorParcela.HeaderText = "Valor Parcela";
            this.colValorParcela.Name = "colValorParcela";
            this.colValorParcela.ReadOnly = true;
            this.colValorParcela.Width = 125;
            // 
            // colVencimento
            // 
            this.colVencimento.DataPropertyName = "DATA_PARCELAS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colVencimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.colVencimento.HeaderText = "Vencimento";
            this.colVencimento.Name = "colVencimento";
            this.colVencimento.ReadOnly = true;
            this.colVencimento.Width = 155;
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.Enabled = false;
            this.dtpDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimento.Location = new System.Drawing.Point(167, 86);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(103, 21);
            this.dtpDataVencimento.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Data Vencimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Quantidade:";
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Enabled = false;
            this.tbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorTotal.Location = new System.Drawing.Point(167, 8);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(103, 21);
            this.tbValorTotal.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Valor Total:";
            // 
            // btnGerarParcelas
            // 
            this.btnGerarParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarParcelas.Location = new System.Drawing.Point(331, 7);
            this.btnGerarParcelas.Name = "btnGerarParcelas";
            this.btnGerarParcelas.Size = new System.Drawing.Size(115, 24);
            this.btnGerarParcelas.TabIndex = 53;
            this.btnGerarParcelas.Text = "Gerar Parcelas";
            this.btnGerarParcelas.UseVisualStyleBackColor = true;
            this.btnGerarParcelas.Visible = false;
            this.btnGerarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click_1);
            // 
            // cbQuantidadeParcelas
            // 
            this.cbQuantidadeParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantidadeParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantidadeParcelas.FormattingEnabled = true;
            this.cbQuantidadeParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbQuantidadeParcelas.Location = new System.Drawing.Point(167, 123);
            this.cbQuantidadeParcelas.Name = "cbQuantidadeParcelas";
            this.cbQuantidadeParcelas.Size = new System.Drawing.Size(63, 23);
            this.cbQuantidadeParcelas.TabIndex = 65;
            this.cbQuantidadeParcelas.SelectedIndexChanged += new System.EventHandler(this.cbQuantidadeParcelas_SelectedIndexChanged);
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(361, 67);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(13, 13);
            this.lblFormaPagamento.TabIndex = 66;
            this.lblFormaPagamento.Text = "=";
            this.lblFormaPagamento.Visible = false;
            // 
            // FinalizarVendaParcelada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 317);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.cbQuantidadeParcelas);
            this.Controls.Add(this.ibtnFinalizarVendaParcelada);
            this.Controls.Add(this.lblCodigoPedido);
            this.Controls.Add(this.tbValorDesconto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQuantidadeParcelas);
            this.Controls.Add(this.dgvParcelas);
            this.Controls.Add(this.dtpDataVencimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarParcelas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FinalizarVendaParcelada";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Venda Parcelada";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FinalizarVendaParcelada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnFinalizarVendaParcelada;
        private System.Windows.Forms.Label lblCodigoPedido;
        private System.Windows.Forms.TextBox tbValorDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQuantidadeParcelas;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarParcelas;
        private System.Windows.Forms.ComboBox cbQuantidadeParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDparcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantParcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencimento;
        private System.Windows.Forms.Label lblFormaPagamento;
    }
}