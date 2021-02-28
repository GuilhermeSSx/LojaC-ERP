namespace Loja.GUI.PAGINA_INICIAL
{
    partial class FluxoCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFluxoCaixa = new System.Windows.Forms.DataGridView();
            this.colOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdutoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.tbTotalCompra = new System.Windows.Forms.TextBox();
            this.tbTotalVenda = new System.Windows.Forms.TextBox();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.ibtnFiltrarBusca = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLucroDeficit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnPopupInfo = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoCaixa)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFluxoCaixa
            // 
            this.dgvFluxoCaixa.AllowUserToAddRows = false;
            this.dgvFluxoCaixa.AllowUserToResizeColumns = false;
            this.dgvFluxoCaixa.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvFluxoCaixa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFluxoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFluxoCaixa.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvFluxoCaixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFluxoCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFluxoCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFluxoCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOperacao,
            this.colProdutoPedido,
            this.colValor,
            this.DataParcela,
            this.colUsuario});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFluxoCaixa.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFluxoCaixa.Location = new System.Drawing.Point(7, 73);
            this.dgvFluxoCaixa.MultiSelect = false;
            this.dgvFluxoCaixa.Name = "dgvFluxoCaixa";
            this.dgvFluxoCaixa.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFluxoCaixa.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvFluxoCaixa.RowHeadersWidth = 5;
            this.dgvFluxoCaixa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFluxoCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFluxoCaixa.Size = new System.Drawing.Size(753, 531);
            this.dgvFluxoCaixa.TabIndex = 59;
            // 
            // colOperacao
            // 
            this.colOperacao.DataPropertyName = "OPERACAO";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colOperacao.DefaultCellStyle = dataGridViewCellStyle11;
            this.colOperacao.HeaderText = "Operação";
            this.colOperacao.Name = "colOperacao";
            this.colOperacao.ReadOnly = true;
            this.colOperacao.Width = 92;
            // 
            // colProdutoPedido
            // 
            this.colProdutoPedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProdutoPedido.DataPropertyName = "PRODUTO_PEDIDO";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Nirmala UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.colProdutoPedido.DefaultCellStyle = dataGridViewCellStyle12;
            this.colProdutoPedido.HeaderText = "Movimento ( Pedido / Produto / Descrição )";
            this.colProdutoPedido.Name = "colProdutoPedido";
            this.colProdutoPedido.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.DataPropertyName = "VALOR";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.colValor.DefaultCellStyle = dataGridViewCellStyle13;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // DataParcela
            // 
            this.DataParcela.DataPropertyName = "DATA_HORA";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.Format = "g";
            dataGridViewCellStyle14.NullValue = null;
            this.DataParcela.DefaultCellStyle = dataGridViewCellStyle14;
            this.DataParcela.HeaderText = "Data/Hora";
            this.DataParcela.Name = "DataParcela";
            this.DataParcela.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.DataPropertyName = "USUARIO";
            this.colUsuario.HeaderText = "USUARIO";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "Relatório Fluxo de Caixa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.BackColor = System.Drawing.SystemColors.Control;
            this.pieChart1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChart1.ForeColor = System.Drawing.Color.Black;
            this.pieChart1.Location = new System.Drawing.Point(3, 298);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(234, 233);
            this.pieChart1.TabIndex = 63;
            this.pieChart1.Text = "pieChart1";
            // 
            // tbTotalCompra
            // 
            this.tbTotalCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalCompra.BackColor = System.Drawing.Color.White;
            this.tbTotalCompra.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalCompra.Location = new System.Drawing.Point(908, 40);
            this.tbTotalCompra.Name = "tbTotalCompra";
            this.tbTotalCompra.ReadOnly = true;
            this.tbTotalCompra.Size = new System.Drawing.Size(71, 25);
            this.tbTotalCompra.TabIndex = 65;
            this.tbTotalCompra.Visible = false;
            this.tbTotalCompra.WordWrap = false;
            // 
            // tbTotalVenda
            // 
            this.tbTotalVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalVenda.BackColor = System.Drawing.Color.White;
            this.tbTotalVenda.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalVenda.Location = new System.Drawing.Point(787, 40);
            this.tbTotalVenda.Name = "tbTotalVenda";
            this.tbTotalVenda.ReadOnly = true;
            this.tbTotalVenda.Size = new System.Drawing.Size(80, 25);
            this.tbTotalVenda.TabIndex = 66;
            this.tbTotalVenda.Visible = false;
            this.tbTotalVenda.WordWrap = false;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInicial.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(58, 33);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(125, 29);
            this.dtpInicial.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Filtrar por Data:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 71;
            this.label2.Text = "a";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(58, 89);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(125, 29);
            this.dtpFinal.TabIndex = 72;
            // 
            // ibtnFiltrarBusca
            // 
            this.ibtnFiltrarBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnFiltrarBusca.BackColor = System.Drawing.SystemColors.Desktop;
            this.ibtnFiltrarBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFiltrarBusca.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnFiltrarBusca.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnFiltrarBusca.ForeColor = System.Drawing.Color.White;
            this.ibtnFiltrarBusca.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnFiltrarBusca.IconColor = System.Drawing.Color.White;
            this.ibtnFiltrarBusca.IconSize = 30;
            this.ibtnFiltrarBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnFiltrarBusca.Location = new System.Drawing.Point(58, 138);
            this.ibtnFiltrarBusca.Name = "ibtnFiltrarBusca";
            this.ibtnFiltrarBusca.Rotation = 0D;
            this.ibtnFiltrarBusca.Size = new System.Drawing.Size(125, 42);
            this.ibtnFiltrarBusca.TabIndex = 73;
            this.ibtnFiltrarBusca.Text = "Filtrar";
            this.ibtnFiltrarBusca.UseVisualStyleBackColor = false;
            this.ibtnFiltrarBusca.Click += new System.EventHandler(this.ibtnFiltrarBusca_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 74;
            this.label3.Text = "Lucro | ou | Déficit ";
            // 
            // tbLucroDeficit
            // 
            this.tbLucroDeficit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLucroDeficit.BackColor = System.Drawing.Color.White;
            this.tbLucroDeficit.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLucroDeficit.Location = new System.Drawing.Point(49, 238);
            this.tbLucroDeficit.Name = "tbLucroDeficit";
            this.tbLucroDeficit.ReadOnly = true;
            this.tbLucroDeficit.Size = new System.Drawing.Size(143, 27);
            this.tbLucroDeficit.TabIndex = 75;
            this.tbLucroDeficit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 37);
            this.panel1.TabIndex = 76;
            // 
            // ibtnPopupInfo
            // 
            this.ibtnPopupInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnPopupInfo.FlatAppearance.BorderSize = 0;
            this.ibtnPopupInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ibtnPopupInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ibtnPopupInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPopupInfo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnPopupInfo.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.ibtnPopupInfo.IconColor = System.Drawing.Color.ForestGreen;
            this.ibtnPopupInfo.IconSize = 30;
            this.ibtnPopupInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnPopupInfo.Location = new System.Drawing.Point(184, 200);
            this.ibtnPopupInfo.Name = "ibtnPopupInfo";
            this.ibtnPopupInfo.Rotation = 0D;
            this.ibtnPopupInfo.Size = new System.Drawing.Size(31, 32);
            this.ibtnPopupInfo.TabIndex = 83;
            this.ibtnPopupInfo.UseVisualStyleBackColor = true;
            this.ibtnPopupInfo.Click += new System.EventHandler(this.ibtnPopupInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ibtnPopupInfo);
            this.panel2.Controls.Add(this.tbLucroDeficit);
            this.panel2.Controls.Add(this.dtpInicial);
            this.panel2.Controls.Add(this.pieChart1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpFinal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ibtnFiltrarBusca);
            this.panel2.Location = new System.Drawing.Point(763, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 531);
            this.panel2.TabIndex = 84;
            // 
            // FluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbTotalVenda);
            this.Controls.Add(this.tbTotalCompra);
            this.Controls.Add(this.dgvFluxoCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FluxoCaixa";
            this.Text = "FluxoCaixa";
            this.Load += new System.EventHandler(this.FluxoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxoCaixa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFluxoCaixa;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.TextBox tbTotalCompra;
        private System.Windows.Forms.TextBox tbTotalVenda;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private FontAwesome.Sharp.IconButton ibtnFiltrarBusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLucroDeficit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private FontAwesome.Sharp.IconButton ibtnPopupInfo;
        private System.Windows.Forms.Panel panel2;
    }
}