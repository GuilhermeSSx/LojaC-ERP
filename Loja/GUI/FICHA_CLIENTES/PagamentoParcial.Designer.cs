namespace Loja.GUI.FICHA_CLIENTES
{
    partial class PagamentoParcial
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
            this.lblIdParcela = new System.Windows.Forms.Label();
            this.tbValorDescontado = new System.Windows.Forms.TextBox();
            this.tbValorRestante = new System.Windows.Forms.TextBox();
            this.tbValorParcela = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ibtnEfetuarPagamentoParcial = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataVencimentoParcela = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblIdParcela
            // 
            this.lblIdParcela.AutoSize = true;
            this.lblIdParcela.Location = new System.Drawing.Point(100, 57);
            this.lblIdParcela.Name = "lblIdParcela";
            this.lblIdParcela.Size = new System.Drawing.Size(53, 13);
            this.lblIdParcela.TabIndex = 0;
            this.lblIdParcela.Text = "id parcela";
            this.lblIdParcela.Visible = false;
            // 
            // tbValorDescontado
            // 
            this.tbValorDescontado.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorDescontado.Location = new System.Drawing.Point(159, 47);
            this.tbValorDescontado.MaxLength = 7;
            this.tbValorDescontado.Name = "tbValorDescontado";
            this.tbValorDescontado.ShortcutsEnabled = false;
            this.tbValorDescontado.Size = new System.Drawing.Size(100, 29);
            this.tbValorDescontado.TabIndex = 2;
            this.tbValorDescontado.TextChanged += new System.EventHandler(this.tbValorDescontado_TextChanged);
            this.tbValorDescontado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorDescontado_KeyPress);
            // 
            // tbValorRestante
            // 
            this.tbValorRestante.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorRestante.Location = new System.Drawing.Point(159, 85);
            this.tbValorRestante.Name = "tbValorRestante";
            this.tbValorRestante.ReadOnly = true;
            this.tbValorRestante.Size = new System.Drawing.Size(100, 29);
            this.tbValorRestante.TabIndex = 3;
            this.tbValorRestante.TextChanged += new System.EventHandler(this.tbValorRestante_TextChanged);
            // 
            // tbValorParcela
            // 
            this.tbValorParcela.Enabled = false;
            this.tbValorParcela.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorParcela.Location = new System.Drawing.Point(159, 7);
            this.tbValorParcela.Name = "tbValorParcela";
            this.tbValorParcela.ReadOnly = true;
            this.tbValorParcela.Size = new System.Drawing.Size(100, 29);
            this.tbValorParcela.TabIndex = 1;
            this.tbValorParcela.TextChanged += new System.EventHandler(this.tbValorParcela_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Valor Restante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Desconto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Valor Parcela";
            // 
            // ibtnEfetuarPagamentoParcial
            // 
            this.ibtnEfetuarPagamentoParcial.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtnEfetuarPagamentoParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEfetuarPagamentoParcial.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnEfetuarPagamentoParcial.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEfetuarPagamentoParcial.ForeColor = System.Drawing.Color.Black;
            this.ibtnEfetuarPagamentoParcial.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.ibtnEfetuarPagamentoParcial.IconColor = System.Drawing.Color.Firebrick;
            this.ibtnEfetuarPagamentoParcial.IconSize = 25;
            this.ibtnEfetuarPagamentoParcial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnEfetuarPagamentoParcial.Location = new System.Drawing.Point(12, 175);
            this.ibtnEfetuarPagamentoParcial.Name = "ibtnEfetuarPagamentoParcial";
            this.ibtnEfetuarPagamentoParcial.Rotation = 0D;
            this.ibtnEfetuarPagamentoParcial.Size = new System.Drawing.Size(247, 45);
            this.ibtnEfetuarPagamentoParcial.TabIndex = 53;
            this.ibtnEfetuarPagamentoParcial.Text = "Efetuar";
            this.ibtnEfetuarPagamentoParcial.UseVisualStyleBackColor = false;
            this.ibtnEfetuarPagamentoParcial.Click += new System.EventHandler(this.ibtnEfetuarPagamentoParcial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Novo Vencimento";
            // 
            // dtpDataVencimentoParcela
            // 
            this.dtpDataVencimentoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataVencimentoParcela.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoParcela.Location = new System.Drawing.Point(159, 129);
            this.dtpDataVencimentoParcela.Name = "dtpDataVencimentoParcela";
            this.dtpDataVencimentoParcela.Size = new System.Drawing.Size(100, 27);
            this.dtpDataVencimentoParcela.TabIndex = 55;
            // 
            // PagamentoParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 230);
            this.Controls.Add(this.dtpDataVencimentoParcela);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ibtnEfetuarPagamentoParcial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbValorDescontado);
            this.Controls.Add(this.tbValorRestante);
            this.Controls.Add(this.tbValorParcela);
            this.Controls.Add(this.lblIdParcela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PagamentoParcial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento Parcial de Parcela";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PagamentoParcial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdParcela;
        private System.Windows.Forms.TextBox tbValorDescontado;
        private System.Windows.Forms.TextBox tbValorRestante;
        private System.Windows.Forms.TextBox tbValorParcela;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton ibtnEfetuarPagamentoParcial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataVencimentoParcela;
    }
}