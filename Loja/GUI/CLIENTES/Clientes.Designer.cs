namespace Loja.GUI.CLIENTE_CRUD
{
    partial class Clientes
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ibtnListaCompletaClientes = new FontAwesome.Sharp.IconButton();
            this.ibtnCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Loja.Properties.Resources.linha_animada;
            this.pictureBox2.Location = new System.Drawing.Point(982, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 36);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Loja.Properties.Resources.linha_animada;
            this.pictureBox1.Location = new System.Drawing.Point(2, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 36);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ibtnListaCompletaClientes
            // 
            this.ibtnListaCompletaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnListaCompletaClientes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ibtnListaCompletaClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnListaCompletaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ibtnListaCompletaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.ibtnListaCompletaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnListaCompletaClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnListaCompletaClientes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnListaCompletaClientes.ForeColor = System.Drawing.Color.White;
            this.ibtnListaCompletaClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.ibtnListaCompletaClientes.IconColor = System.Drawing.Color.White;
            this.ibtnListaCompletaClientes.IconSize = 35;
            this.ibtnListaCompletaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnListaCompletaClientes.Location = new System.Drawing.Point(743, 3);
            this.ibtnListaCompletaClientes.Name = "ibtnListaCompletaClientes";
            this.ibtnListaCompletaClientes.Rotation = 0D;
            this.ibtnListaCompletaClientes.Size = new System.Drawing.Size(227, 40);
            this.ibtnListaCompletaClientes.TabIndex = 21;
            this.ibtnListaCompletaClientes.Text = "Lista de Clientes";
            this.ibtnListaCompletaClientes.UseVisualStyleBackColor = false;
            this.ibtnListaCompletaClientes.Click += new System.EventHandler(this.ibtnListaCompletaClientes_Click);
            // 
            // ibtnCadastrarCliente
            // 
            this.ibtnCadastrarCliente.BackColor = System.Drawing.Color.Lime;
            this.ibtnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ibtnCadastrarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCadastrarCliente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCadastrarCliente.ForeColor = System.Drawing.Color.Black;
            this.ibtnCadastrarCliente.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.ibtnCadastrarCliente.IconColor = System.Drawing.Color.Black;
            this.ibtnCadastrarCliente.IconSize = 35;
            this.ibtnCadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCadastrarCliente.Location = new System.Drawing.Point(316, 3);
            this.ibtnCadastrarCliente.Name = "ibtnCadastrarCliente";
            this.ibtnCadastrarCliente.Rotation = 0D;
            this.ibtnCadastrarCliente.Size = new System.Drawing.Size(227, 40);
            this.ibtnCadastrarCliente.TabIndex = 20;
            this.ibtnCadastrarCliente.Text = "Cadastro de Clientes";
            this.ibtnCadastrarCliente.UseVisualStyleBackColor = false;
            this.ibtnCadastrarCliente.Click += new System.EventHandler(this.ibtnCadastrarCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ibtnCadastrarCliente);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ibtnListaCompletaClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 51);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 805);
            this.panel2.TabIndex = 25;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 856);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnCadastrarCliente;
        private FontAwesome.Sharp.IconButton ibtnListaCompletaClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}