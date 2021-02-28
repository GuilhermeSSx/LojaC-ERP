namespace Loja
{
    partial class CadastroClientes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.bdLojaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbRg = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnCadastrarCliente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdLojaDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "RG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero:";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeCliente.Location = new System.Drawing.Point(146, 27);
            this.tbNomeCliente.MaxLength = 50;
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.ShortcutsEnabled = false;
            this.tbNomeCliente.Size = new System.Drawing.Size(454, 27);
            this.tbNomeCliente.TabIndex = 1;
            this.tbNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomeCliente_KeyDown);
            this.tbNomeCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomeCliente_KeyPress);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(146, 133);
            this.tbEndereco.MaxLength = 40;
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(285, 27);
            this.tbEndereco.TabIndex = 3;
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBairro.Location = new System.Drawing.Point(146, 186);
            this.tbBairro.MaxLength = 30;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(285, 27);
            this.tbBairro.TabIndex = 4;
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(534, 186);
            this.tbNumero.MaxLength = 6;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ShortcutsEnabled = false;
            this.tbNumero.Size = new System.Drawing.Size(66, 27);
            this.tbNumero.TabIndex = 5;
            this.tbNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumero_KeyDown);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(146, 238);
            this.mtbCpf.Mask = "999,999,999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.ShortcutsEnabled = false;
            this.mtbCpf.Size = new System.Drawing.Size(197, 29);
            this.mtbCpf.TabIndex = 7;
            this.mtbCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCpf_KeyDown);
            // 
            // mtbRg
            // 
            this.mtbRg.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRg.Location = new System.Drawing.Point(146, 290);
            this.mtbRg.Mask = "99,999,999-9";
            this.mtbRg.Name = "mtbRg";
            this.mtbRg.ShortcutsEnabled = false;
            this.mtbRg.Size = new System.Drawing.Size(197, 29);
            this.mtbRg.TabIndex = 8;
            this.mtbRg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbRg_KeyDown);
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(146, 80);
            this.mtbCelular.Mask = "(99) 9 9999-9999";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.ShortcutsEnabled = false;
            this.mtbCelular.Size = new System.Drawing.Size(163, 29);
            this.mtbCelular.TabIndex = 2;
            this.mtbCelular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCelular_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.ibtnCadastrarCliente);
            this.panel1.Controls.Add(this.tbNomeCliente);
            this.panel1.Controls.Add(this.mtbCelular);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbNumero);
            this.panel1.Controls.Add(this.tbBairro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mtbCpf);
            this.panel1.Controls.Add(this.mtbRg);
            this.panel1.Controls.Add(this.tbEndereco);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(323, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 349);
            this.panel1.TabIndex = 17;
            // 
            // ibtnCadastrarCliente
            // 
            this.ibtnCadastrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCadastrarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCadastrarCliente.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCadastrarCliente.ForeColor = System.Drawing.Color.Black;
            this.ibtnCadastrarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ibtnCadastrarCliente.IconColor = System.Drawing.Color.Black;
            this.ibtnCadastrarCliente.IconSize = 30;
            this.ibtnCadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCadastrarCliente.Location = new System.Drawing.Point(379, 239);
            this.ibtnCadastrarCliente.Name = "ibtnCadastrarCliente";
            this.ibtnCadastrarCliente.Rotation = 0D;
            this.ibtnCadastrarCliente.Size = new System.Drawing.Size(221, 80);
            this.ibtnCadastrarCliente.TabIndex = 10;
            this.ibtnCadastrarCliente.Text = "Cadastrar";
            this.ibtnCadastrarCliente.UseVisualStyleBackColor = false;
            this.ibtnCadastrarCliente.Click += new System.EventHandler(this.ibtnCadastrarCliente_Click);
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1284, 616);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroClientes";
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdLojaDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.BindingSource bdLojaDataSetBindingSource;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.MaskedTextBox mtbRg;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnCadastrarCliente;
    }
}