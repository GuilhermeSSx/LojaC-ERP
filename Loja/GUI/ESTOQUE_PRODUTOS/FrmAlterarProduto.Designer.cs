namespace Loja
{
    partial class FrmAlterarProduto
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
            this.tbValorProduto = new System.Windows.Forms.TextBox();
            this.tbValorComprado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataEntradaProduto = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTamanhoProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.ibtnAlterarProduto = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // tbValorProduto
            // 
            this.tbValorProduto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorProduto.Location = new System.Drawing.Point(179, 103);
            this.tbValorProduto.MaxLength = 12;
            this.tbValorProduto.Name = "tbValorProduto";
            this.tbValorProduto.ShortcutsEnabled = false;
            this.tbValorProduto.Size = new System.Drawing.Size(92, 25);
            this.tbValorProduto.TabIndex = 44;
            this.tbValorProduto.TextChanged += new System.EventHandler(this.tbValorProduto_TextChanged);
            this.tbValorProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValorProduto_KeyDown);
            // 
            // tbValorComprado
            // 
            this.tbValorComprado.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorComprado.Location = new System.Drawing.Point(179, 60);
            this.tbValorComprado.MaxLength = 12;
            this.tbValorComprado.Name = "tbValorComprado";
            this.tbValorComprado.ShortcutsEnabled = false;
            this.tbValorComprado.Size = new System.Drawing.Size(92, 25);
            this.tbValorComprado.TabIndex = 43;
            this.tbValorComprado.TextChanged += new System.EventHandler(this.tbValorComprado_TextChanged);
            this.tbValorComprado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValorComprado_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Data de Entrada";
            // 
            // dtpDataEntradaProduto
            // 
            this.dtpDataEntradaProduto.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dtpDataEntradaProduto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntradaProduto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntradaProduto.Location = new System.Drawing.Point(179, 144);
            this.dtpDataEntradaProduto.Name = "dtpDataEntradaProduto";
            this.dtpDataEntradaProduto.Size = new System.Drawing.Size(92, 25);
            this.dtpDataEntradaProduto.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Valor Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Valor Comprado";
            // 
            // cbTamanhoProduto
            // 
            this.cbTamanhoProduto.DropDownHeight = 242;
            this.cbTamanhoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTamanhoProduto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamanhoProduto.FormattingEnabled = true;
            this.cbTamanhoProduto.IntegralHeight = false;
            this.cbTamanhoProduto.Items.AddRange(new object[] {
            "PP",
            "P",
            "M",
            "G",
            "GG",
            "G1",
            "G2",
            "G3",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50",
            "52",
            "54",
            "-",
            "único"});
            this.cbTamanhoProduto.Location = new System.Drawing.Point(425, 61);
            this.cbTamanhoProduto.Name = "cbTamanhoProduto";
            this.cbTamanhoProduto.Size = new System.Drawing.Size(121, 25);
            this.cbTamanhoProduto.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tamanho";
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeProduto.Location = new System.Drawing.Point(179, 18);
            this.tbNomeProduto.MaxLength = 58;
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.ShortcutsEnabled = false;
            this.tbNomeProduto.Size = new System.Drawing.Size(368, 25);
            this.tbNomeProduto.TabIndex = 34;
            this.tbNomeProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomeProduto_KeyDown);
            this.tbNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomeProduto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nome do Produto";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(84, -1);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(13, 13);
            this.lblCodigoProduto.TabIndex = 46;
            this.lblCodigoProduto.Text = "=";
            this.lblCodigoProduto.Visible = false;
            // 
            // ibtnAlterarProduto
            // 
            this.ibtnAlterarProduto.BackColor = System.Drawing.Color.DarkOrange;
            this.ibtnAlterarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAlterarProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAlterarProduto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAlterarProduto.ForeColor = System.Drawing.Color.White;
            this.ibtnAlterarProduto.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnAlterarProduto.IconColor = System.Drawing.Color.White;
            this.ibtnAlterarProduto.IconSize = 30;
            this.ibtnAlterarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAlterarProduto.Location = new System.Drawing.Point(348, 118);
            this.ibtnAlterarProduto.Name = "ibtnAlterarProduto";
            this.ibtnAlterarProduto.Rotation = 0D;
            this.ibtnAlterarProduto.Size = new System.Drawing.Size(198, 51);
            this.ibtnAlterarProduto.TabIndex = 53;
            this.ibtnAlterarProduto.Text = "Alterar Produto";
            this.ibtnAlterarProduto.UseVisualStyleBackColor = false;
            this.ibtnAlterarProduto.Click += new System.EventHandler(this.ibtnAlterarProduto_Click);
            // 
            // FrmAlterarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 185);
            this.Controls.Add(this.ibtnAlterarProduto);
            this.Controls.Add(this.lblCodigoProduto);
            this.Controls.Add(this.tbValorProduto);
            this.Controls.Add(this.tbValorComprado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataEntradaProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTamanhoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeProduto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlterarProduto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbValorProduto;
        private System.Windows.Forms.TextBox tbValorComprado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataEntradaProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTamanhoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigoProduto;
        private FontAwesome.Sharp.IconButton ibtnAlterarProduto;
    }
}