namespace Loja
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnPaginaInicial = new FontAwesome.Sharp.IconButton();
            this.ibtnEstoque = new FontAwesome.Sharp.IconButton();
            this.ibtnFichaClientes = new FontAwesome.Sharp.IconButton();
            this.ibtnCaixa = new FontAwesome.Sharp.IconButton();
            this.ibtnCadastroClientes = new FontAwesome.Sharp.IconButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.ibtnPaginaInicial);
            this.panelMenu.Controls.Add(this.ibtnEstoque);
            this.panelMenu.Controls.Add(this.ibtnFichaClientes);
            this.panelMenu.Controls.Add(this.ibtnCaixa);
            this.panelMenu.Controls.Add(this.ibtnCadastroClientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 626);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panelMenu.Size = new System.Drawing.Size(1284, 70);
            this.panelMenu.TabIndex = 30;
            // 
            // ibtnPaginaInicial
            // 
            this.ibtnPaginaInicial.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnPaginaInicial.FlatAppearance.BorderSize = 0;
            this.ibtnPaginaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPaginaInicial.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnPaginaInicial.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnPaginaInicial.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnPaginaInicial.IconColor = System.Drawing.Color.DarkOrchid;
            this.ibtnPaginaInicial.IconSize = 35;
            this.ibtnPaginaInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPaginaInicial.Location = new System.Drawing.Point(1001, 0);
            this.ibtnPaginaInicial.Name = "ibtnPaginaInicial";
            this.ibtnPaginaInicial.Rotation = 0D;
            this.ibtnPaginaInicial.Size = new System.Drawing.Size(280, 68);
            this.ibtnPaginaInicial.TabIndex = 4;
            this.ibtnPaginaInicial.Text = "Pagina Inicial";
            this.ibtnPaginaInicial.UseVisualStyleBackColor = true;
            this.ibtnPaginaInicial.Click += new System.EventHandler(this.ibtnPaginaInicial_Click);
            // 
            // ibtnEstoque
            // 
            this.ibtnEstoque.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibtnEstoque.FlatAppearance.BorderSize = 0;
            this.ibtnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEstoque.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnEstoque.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEstoque.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.ibtnEstoque.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ibtnEstoque.IconSize = 35;
            this.ibtnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEstoque.Location = new System.Drawing.Point(652, 0);
            this.ibtnEstoque.Name = "ibtnEstoque";
            this.ibtnEstoque.Rotation = 0D;
            this.ibtnEstoque.Size = new System.Drawing.Size(217, 68);
            this.ibtnEstoque.TabIndex = 3;
            this.ibtnEstoque.Text = "Estoque";
            this.ibtnEstoque.UseVisualStyleBackColor = true;
            this.ibtnEstoque.Click += new System.EventHandler(this.ibtnEstoque_Click);
            // 
            // ibtnFichaClientes
            // 
            this.ibtnFichaClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibtnFichaClientes.FlatAppearance.BorderSize = 0;
            this.ibtnFichaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFichaClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnFichaClientes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnFichaClientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ibtnFichaClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ibtnFichaClientes.IconSize = 35;
            this.ibtnFichaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFichaClientes.Location = new System.Drawing.Point(435, 0);
            this.ibtnFichaClientes.Name = "ibtnFichaClientes";
            this.ibtnFichaClientes.Rotation = 0D;
            this.ibtnFichaClientes.Size = new System.Drawing.Size(217, 68);
            this.ibtnFichaClientes.TabIndex = 2;
            this.ibtnFichaClientes.Text = "Ficha dos Clientes";
            this.ibtnFichaClientes.UseVisualStyleBackColor = true;
            this.ibtnFichaClientes.Click += new System.EventHandler(this.ibtnFichaClientes_Click);
            // 
            // ibtnCaixa
            // 
            this.ibtnCaixa.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibtnCaixa.FlatAppearance.BorderSize = 0;
            this.ibtnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCaixa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCaixa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCaixa.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.ibtnCaixa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ibtnCaixa.IconSize = 35;
            this.ibtnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCaixa.Location = new System.Drawing.Point(218, 0);
            this.ibtnCaixa.Name = "ibtnCaixa";
            this.ibtnCaixa.Rotation = 0D;
            this.ibtnCaixa.Size = new System.Drawing.Size(217, 68);
            this.ibtnCaixa.TabIndex = 1;
            this.ibtnCaixa.Text = "Caixa | PDV";
            this.ibtnCaixa.UseVisualStyleBackColor = true;
            this.ibtnCaixa.Click += new System.EventHandler(this.ibtnCaixa_Click);
            // 
            // ibtnCadastroClientes
            // 
            this.ibtnCadastroClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibtnCadastroClientes.FlatAppearance.BorderSize = 0;
            this.ibtnCadastroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCadastroClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCadastroClientes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCadastroClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.ibtnCadastroClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ibtnCadastroClientes.IconSize = 35;
            this.ibtnCadastroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCadastroClientes.Location = new System.Drawing.Point(1, 0);
            this.ibtnCadastroClientes.Name = "ibtnCadastroClientes";
            this.ibtnCadastroClientes.Rotation = 0D;
            this.ibtnCadastroClientes.Size = new System.Drawing.Size(217, 68);
            this.ibtnCadastroClientes.TabIndex = 0;
            this.ibtnCadastroClientes.Text = "Clientes";
            this.ibtnCadastroClientes.UseVisualStyleBackColor = true;
            this.ibtnCadastroClientes.Click += new System.EventHandler(this.ibtnCadastroClientes_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1284, 626);
            this.panelContainer.TabIndex = 31;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 696);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 735);
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Elegância Modas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sistema_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sistema_FormClosed);
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.Resize += new System.EventHandler(this.Sistema_Resize);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibtnEstoque;
        private FontAwesome.Sharp.IconButton ibtnFichaClientes;
        private FontAwesome.Sharp.IconButton ibtnCaixa;
        private FontAwesome.Sharp.IconButton ibtnCadastroClientes;
        private FontAwesome.Sharp.IconButton ibtnPaginaInicial;
        private System.Windows.Forms.Panel panelContainer;
    }
}