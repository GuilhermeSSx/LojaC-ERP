namespace Loja.GUI.PAGINA_INICIAL
{
    partial class ContasReceber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ibtnMesAnterior = new FontAwesome.Sharp.IconButton();
            this.lblMes = new System.Windows.Forms.Label();
            this.ibtnProximoMes = new FontAwesome.Sharp.IconButton();
            this.dtpMesAno = new System.Windows.Forms.DateTimePicker();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvContasReceberCliente = new System.Windows.Forms.DataGridView();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuantidadeAtiva = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalDebitos = new System.Windows.Forms.TextBox();
            this.dtpVencido = new System.Windows.Forms.DateTimePicker();
            this.lblDataSemHoras = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceberCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibtnMesAnterior
            // 
            this.ibtnMesAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnMesAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMesAnterior.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnMesAnterior.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMesAnterior.ForeColor = System.Drawing.Color.Black;
            this.ibtnMesAnterior.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ibtnMesAnterior.IconColor = System.Drawing.Color.Black;
            this.ibtnMesAnterior.IconSize = 30;
            this.ibtnMesAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMesAnterior.Location = new System.Drawing.Point(8, 73);
            this.ibtnMesAnterior.Name = "ibtnMesAnterior";
            this.ibtnMesAnterior.Rotation = 0D;
            this.ibtnMesAnterior.Size = new System.Drawing.Size(208, 45);
            this.ibtnMesAnterior.TabIndex = 61;
            this.ibtnMesAnterior.Text = "Mês Anterior";
            this.ibtnMesAnterior.UseVisualStyleBackColor = false;
            this.ibtnMesAnterior.Click += new System.EventHandler(this.ibtnMesAnterior_Click);
            // 
            // lblMes
            // 
            this.lblMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMes.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(0, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(225, 37);
            this.lblMes.TabIndex = 59;
            this.lblMes.Text = "=";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ibtnProximoMes
            // 
            this.ibtnProximoMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnProximoMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnProximoMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProximoMes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnProximoMes.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnProximoMes.ForeColor = System.Drawing.Color.Black;
            this.ibtnProximoMes.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.ibtnProximoMes.IconColor = System.Drawing.Color.Black;
            this.ibtnProximoMes.IconSize = 30;
            this.ibtnProximoMes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnProximoMes.Location = new System.Drawing.Point(795, 73);
            this.ibtnProximoMes.Name = "ibtnProximoMes";
            this.ibtnProximoMes.Rotation = 0D;
            this.ibtnProximoMes.Size = new System.Drawing.Size(208, 45);
            this.ibtnProximoMes.TabIndex = 60;
            this.ibtnProximoMes.Text = "Próximo Mês";
            this.ibtnProximoMes.UseVisualStyleBackColor = false;
            this.ibtnProximoMes.Click += new System.EventHandler(this.ibtnProximoMes_Click);
            // 
            // dtpMesAno
            // 
            this.dtpMesAno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMesAno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMesAno.Location = new System.Drawing.Point(16, 453);
            this.dtpMesAno.Name = "dtpMesAno";
            this.dtpMesAno.Size = new System.Drawing.Size(200, 27);
            this.dtpMesAno.TabIndex = 63;
            this.dtpMesAno.Visible = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(90, 493);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(30, 32);
            this.lblNumero.TabIndex = 62;
            this.lblNumero.Text = "0";
            this.lblNumero.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 58;
            this.label1.Text = "Contas a Receber Mês :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvContasReceberCliente
            // 
            this.dgvContasReceberCliente.AllowUserToAddRows = false;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvContasReceberCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvContasReceberCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContasReceberCliente.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvContasReceberCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContasReceberCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvContasReceberCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasReceberCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCliente,
            this.ValorParcela,
            this.DataParcela});
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContasReceberCliente.DefaultCellStyle = dataGridViewCellStyle41;
            this.dgvContasReceberCliente.Location = new System.Drawing.Point(222, 73);
            this.dgvContasReceberCliente.MultiSelect = false;
            this.dgvContasReceberCliente.Name = "dgvContasReceberCliente";
            this.dgvContasReceberCliente.ReadOnly = true;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContasReceberCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvContasReceberCliente.RowHeadersWidth = 25;
            this.dgvContasReceberCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvContasReceberCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContasReceberCliente.Size = new System.Drawing.Size(567, 531);
            this.dgvContasReceberCliente.TabIndex = 57;
            this.dgvContasReceberCliente.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvContasReceberCliente_RowPrePaint);
            this.dgvContasReceberCliente.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvContasReceberCliente_RowsAdded);
            // 
            // NomeCliente
            // 
            this.NomeCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeCliente.DataPropertyName = "NOME_CLIENTE";
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeCliente.DefaultCellStyle = dataGridViewCellStyle38;
            this.NomeCliente.HeaderText = "Nome Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            // 
            // ValorParcela
            // 
            this.ValorParcela.DataPropertyName = "VALOR_PARCELA";
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.Format = "C2";
            dataGridViewCellStyle39.NullValue = null;
            this.ValorParcela.DefaultCellStyle = dataGridViewCellStyle39;
            this.ValorParcela.HeaderText = "Valor Parcela";
            this.ValorParcela.Name = "ValorParcela";
            this.ValorParcela.ReadOnly = true;
            this.ValorParcela.Width = 110;
            // 
            // DataParcela
            // 
            this.DataParcela.DataPropertyName = "DATA_PARCELAS";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.Format = "d";
            dataGridViewCellStyle40.NullValue = null;
            this.DataParcela.DefaultCellStyle = dataGridViewCellStyle40;
            this.DataParcela.HeaderText = "Data Parcela";
            this.DataParcela.Name = "DataParcela";
            this.DataParcela.ReadOnly = true;
            this.DataParcela.Width = 130;
            // 
            // lblQuantidadeAtiva
            // 
            this.lblQuantidadeAtiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantidadeAtiva.AutoSize = true;
            this.lblQuantidadeAtiva.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeAtiva.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblQuantidadeAtiva.Location = new System.Drawing.Point(893, 471);
            this.lblQuantidadeAtiva.Name = "lblQuantidadeAtiva";
            this.lblQuantidadeAtiva.Size = new System.Drawing.Size(19, 21);
            this.lblQuantidadeAtiva.TabIndex = 67;
            this.lblQuantidadeAtiva.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(828, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 66;
            this.label4.Text = "Quantidade Ativa";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(857, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 65;
            this.label3.Text = "A Receber";
            // 
            // tbTotalDebitos
            // 
            this.tbTotalDebitos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalDebitos.BackColor = System.Drawing.Color.White;
            this.tbTotalDebitos.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalDebitos.Location = new System.Drawing.Point(843, 571);
            this.tbTotalDebitos.Name = "tbTotalDebitos";
            this.tbTotalDebitos.ReadOnly = true;
            this.tbTotalDebitos.Size = new System.Drawing.Size(121, 33);
            this.tbTotalDebitos.TabIndex = 64;
            // 
            // dtpVencido
            // 
            this.dtpVencido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencido.Location = new System.Drawing.Point(16, 362);
            this.dtpVencido.Name = "dtpVencido";
            this.dtpVencido.Size = new System.Drawing.Size(200, 27);
            this.dtpVencido.TabIndex = 68;
            this.dtpVencido.Visible = false;
            // 
            // lblDataSemHoras
            // 
            this.lblDataSemHoras.AutoSize = true;
            this.lblDataSemHoras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSemHoras.Location = new System.Drawing.Point(93, 264);
            this.lblDataSemHoras.Name = "lblDataSemHoras";
            this.lblDataSemHoras.Size = new System.Drawing.Size(15, 16);
            this.lblDataSemHoras.TabIndex = 69;
            this.lblDataSemHoras.Text = "0";
            this.lblDataSemHoras.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(222, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 37);
            this.panel1.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblMes);
            this.panel2.Location = new System.Drawing.Point(564, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 37);
            this.panel2.TabIndex = 71;
            // 
            // ContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDataSemHoras);
            this.Controls.Add(this.dtpVencido);
            this.Controls.Add(this.lblQuantidadeAtiva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTotalDebitos);
            this.Controls.Add(this.ibtnMesAnterior);
            this.Controls.Add(this.ibtnProximoMes);
            this.Controls.Add(this.dtpMesAno);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.dgvContasReceberCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContasReceber";
            this.Load += new System.EventHandler(this.ContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceberCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnMesAnterior;
        private System.Windows.Forms.Label lblMes;
        private FontAwesome.Sharp.IconButton ibtnProximoMes;
        private System.Windows.Forms.DateTimePicker dtpMesAno;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContasReceberCliente;
        private System.Windows.Forms.Label lblQuantidadeAtiva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalDebitos;
        private System.Windows.Forms.DateTimePicker dtpVencido;
        private System.Windows.Forms.Label lblDataSemHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataParcela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}