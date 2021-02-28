namespace Loja
{
    partial class FrmAlterarCliente
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
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.ibtnAlterarCliente = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(395, 200);
            this.mtbCelular.Mask = "(99) 9 9999-9999";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.ShortcutsEnabled = false;
            this.mtbCelular.Size = new System.Drawing.Size(163, 29);
            this.mtbCelular.TabIndex = 29;
            this.mtbCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCelular_KeyDown);
            // 
            // mtbRg
            // 
            this.mtbRg.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRg.Location = new System.Drawing.Point(114, 200);
            this.mtbRg.Mask = "99,999,999-9";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.ShortcutsEnabled = false;
            this.mtbRg.Size = new System.Drawing.Size(197, 29);
            this.mtbRg.TabIndex = 28;
            this.mtbRg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbRg_KeyDown);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(114, 151);
            this.mtbCpf.Mask = "999,999,999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.ShortcutsEnabled = false;
            this.mtbCpf.Size = new System.Drawing.Size(197, 29);
            this.mtbCpf.TabIndex = 27;
            this.mtbCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCpf_KeyDown);
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(476, 104);
            this.tbNumero.MaxLength = 6;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ShortcutsEnabled = false;
            this.tbNumero.Size = new System.Drawing.Size(79, 29);
            this.tbNumero.TabIndex = 26;
            this.tbNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumero_KeyDown);
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBairro.Location = new System.Drawing.Point(114, 104);
            this.tbBairro.MaxLength = 30;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(273, 29);
            this.tbBairro.TabIndex = 25;
            this.tbBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBairro_KeyDown);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(114, 57);
            this.tbEndereco.MaxLength = 40;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(442, 29);
            this.tbEndereco.TabIndex = 24;
            this.tbEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEndereco_KeyDown);
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCliente.Location = new System.Drawing.Point(114, 11);
            this.tbNomeCliente.MaxLength = 50;
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ShortcutsEnabled = false;
            this.tbNomeCliente.Size = new System.Drawing.Size(442, 29);
            this.tbNomeCliente.TabIndex = 23;
            this.tbNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomeCliente_KeyDown);
            this.tbNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomeCliente_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(393, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome:";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(453, 162);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(17, 18);
            this.lblCodigoCliente.TabIndex = 30;
            this.lblCodigoCliente.Text = "=";
            this.lblCodigoCliente.Visible = false;
            // 
            // ibtnAlterarCliente
            // 
            this.ibtnAlterarCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.ibtnAlterarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAlterarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAlterarCliente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAlterarCliente.ForeColor = System.Drawing.Color.White;
            this.ibtnAlterarCliente.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnAlterarCliente.IconColor = System.Drawing.Color.White;
            this.ibtnAlterarCliente.IconSize = 30;
            this.ibtnAlterarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAlterarCliente.Location = new System.Drawing.Point(16, 248);
            this.ibtnAlterarCliente.Name = "ibtnAlterarCliente";
            this.ibtnAlterarCliente.Rotation = 0D;
            this.ibtnAlterarCliente.Size = new System.Drawing.Size(543, 61);
            this.ibtnAlterarCliente.TabIndex = 52;
            this.ibtnAlterarCliente.Text = "Alterar Cliente";
            this.ibtnAlterarCliente.UseVisualStyleBackColor = false;
            this.ibtnAlterarCliente.Click += new System.EventHandler(this.ibtnAlterarCliente_Click);
            // 
            // FrmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 318);
            this.Controls.Add(this.ibtnAlterarCliente);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbRg);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlterarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Cliente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAlterarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigoCliente;
        private FontAwesome.Sharp.IconButton ibtnAlterarCliente;
    }
}