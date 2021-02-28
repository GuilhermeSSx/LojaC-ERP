namespace Loja.GUI.SISTEMA
{
    partial class PaginaInicial
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
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnConfiguracoes = new FontAwesome.Sharp.IconButton();
            this.ibtnControleCaixa = new FontAwesome.Sharp.IconButton();
            this.panelRelatorioButton = new System.Windows.Forms.Panel();
            this.ibtnRelatoriosGerais = new FontAwesome.Sharp.IconButton();
            this.ibtnHistoricoVendas = new FontAwesome.Sharp.IconButton();
            this.ibtnVendasCompras = new FontAwesome.Sharp.IconButton();
            this.ibtnFluxoCaixa = new FontAwesome.Sharp.IconButton();
            this.ibtnMovimentoEstoque = new FontAwesome.Sharp.IconButton();
            this.ibtnContasVencidas = new FontAwesome.Sharp.IconButton();
            this.ibtnContasReceber = new FontAwesome.Sharp.IconButton();
            this.ibtnHome = new FontAwesome.Sharp.IconButton();
            this.lblNivel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerBtn = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenuLateral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRelatorioButton.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.Gold;
            this.panelMenuLateral.Controls.Add(this.panel2);
            this.panelMenuLateral.Controls.Add(this.lblNivel);
            this.panelMenuLateral.Controls.Add(this.panel1);
            this.panelMenuLateral.Controls.Add(this.label1);
            this.panelMenuLateral.Controls.Add(this.label2);
            this.panelMenuLateral.Controls.Add(this.pictureBox2);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenuLateral.Location = new System.Drawing.Point(1004, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelMenuLateral.Size = new System.Drawing.Size(280, 703);
            this.panelMenuLateral.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ibtnConfiguracoes);
            this.panel2.Controls.Add(this.ibtnControleCaixa);
            this.panel2.Controls.Add(this.panelRelatorioButton);
            this.panel2.Controls.Add(this.ibtnContasVencidas);
            this.panel2.Controls.Add(this.ibtnContasReceber);
            this.panel2.Controls.Add(this.ibtnHome);
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 465);
            this.panel2.TabIndex = 66;
            // 
            // ibtnConfiguracoes
            // 
            this.ibtnConfiguracoes.BackColor = System.Drawing.Color.Yellow;
            this.ibtnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnConfiguracoes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnConfiguracoes.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnConfiguracoes.ForeColor = System.Drawing.Color.Black;
            this.ibtnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.ibtnConfiguracoes.IconColor = System.Drawing.Color.Black;
            this.ibtnConfiguracoes.IconSize = 30;
            this.ibtnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnConfiguracoes.Location = new System.Drawing.Point(0, 410);
            this.ibtnConfiguracoes.Name = "ibtnConfiguracoes";
            this.ibtnConfiguracoes.Rotation = 0D;
            this.ibtnConfiguracoes.Size = new System.Drawing.Size(280, 45);
            this.ibtnConfiguracoes.TabIndex = 77;
            this.ibtnConfiguracoes.Text = "Configurações";
            this.ibtnConfiguracoes.UseVisualStyleBackColor = false;
            this.ibtnConfiguracoes.Click += new System.EventHandler(this.ibtnConfiguracoes_Click);
            // 
            // ibtnControleCaixa
            // 
            this.ibtnControleCaixa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ibtnControleCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnControleCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnControleCaixa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnControleCaixa.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnControleCaixa.ForeColor = System.Drawing.Color.White;
            this.ibtnControleCaixa.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.ibtnControleCaixa.IconColor = System.Drawing.Color.Black;
            this.ibtnControleCaixa.IconSize = 30;
            this.ibtnControleCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnControleCaixa.Location = new System.Drawing.Point(0, 365);
            this.ibtnControleCaixa.Name = "ibtnControleCaixa";
            this.ibtnControleCaixa.Rotation = 0D;
            this.ibtnControleCaixa.Size = new System.Drawing.Size(280, 45);
            this.ibtnControleCaixa.TabIndex = 76;
            this.ibtnControleCaixa.Text = "Controle de Caixa";
            this.ibtnControleCaixa.UseVisualStyleBackColor = false;
            this.ibtnControleCaixa.Click += new System.EventHandler(this.ibtnControleCaixa_Click_1);
            // 
            // panelRelatorioButton
            // 
            this.panelRelatorioButton.Controls.Add(this.ibtnRelatoriosGerais);
            this.panelRelatorioButton.Controls.Add(this.ibtnHistoricoVendas);
            this.panelRelatorioButton.Controls.Add(this.ibtnVendasCompras);
            this.panelRelatorioButton.Controls.Add(this.ibtnFluxoCaixa);
            this.panelRelatorioButton.Controls.Add(this.ibtnMovimentoEstoque);
            this.panelRelatorioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRelatorioButton.Location = new System.Drawing.Point(0, 135);
            this.panelRelatorioButton.MaximumSize = new System.Drawing.Size(280, 230);
            this.panelRelatorioButton.MinimumSize = new System.Drawing.Size(280, 46);
            this.panelRelatorioButton.Name = "panelRelatorioButton";
            this.panelRelatorioButton.Size = new System.Drawing.Size(280, 230);
            this.panelRelatorioButton.TabIndex = 75;
            // 
            // ibtnRelatoriosGerais
            // 
            this.ibtnRelatoriosGerais.BackColor = System.Drawing.Color.Snow;
            this.ibtnRelatoriosGerais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.ibtnRelatoriosGerais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnRelatoriosGerais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRelatoriosGerais.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnRelatoriosGerais.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRelatoriosGerais.ForeColor = System.Drawing.Color.Black;
            this.ibtnRelatoriosGerais.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.ibtnRelatoriosGerais.IconColor = System.Drawing.Color.Black;
            this.ibtnRelatoriosGerais.IconSize = 30;
            this.ibtnRelatoriosGerais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnRelatoriosGerais.Location = new System.Drawing.Point(1, 0);
            this.ibtnRelatoriosGerais.Name = "ibtnRelatoriosGerais";
            this.ibtnRelatoriosGerais.Rotation = 0D;
            this.ibtnRelatoriosGerais.Size = new System.Drawing.Size(278, 45);
            this.ibtnRelatoriosGerais.TabIndex = 60;
            this.ibtnRelatoriosGerais.Text = "Relatórios Gerais";
            this.ibtnRelatoriosGerais.UseVisualStyleBackColor = false;
            this.ibtnRelatoriosGerais.Click += new System.EventHandler(this.ibtnRelatoriosGerais_Click);
            // 
            // ibtnHistoricoVendas
            // 
            this.ibtnHistoricoVendas.BackColor = System.Drawing.Color.Gainsboro;
            this.ibtnHistoricoVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHistoricoVendas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnHistoricoVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnHistoricoVendas.ForeColor = System.Drawing.Color.Black;
            this.ibtnHistoricoVendas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnHistoricoVendas.IconColor = System.Drawing.Color.Black;
            this.ibtnHistoricoVendas.IconSize = 30;
            this.ibtnHistoricoVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnHistoricoVendas.Location = new System.Drawing.Point(1, 184);
            this.ibtnHistoricoVendas.Name = "ibtnHistoricoVendas";
            this.ibtnHistoricoVendas.Rotation = 0D;
            this.ibtnHistoricoVendas.Size = new System.Drawing.Size(278, 45);
            this.ibtnHistoricoVendas.TabIndex = 62;
            this.ibtnHistoricoVendas.Text = "Histórico de Vendas";
            this.ibtnHistoricoVendas.UseVisualStyleBackColor = false;
            this.ibtnHistoricoVendas.Click += new System.EventHandler(this.ibtnHistoricoVendas_Click_1);
            // 
            // ibtnVendasCompras
            // 
            this.ibtnVendasCompras.BackColor = System.Drawing.Color.Gainsboro;
            this.ibtnVendasCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnVendasCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnVendasCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnVendasCompras.ForeColor = System.Drawing.Color.Black;
            this.ibtnVendasCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnVendasCompras.IconColor = System.Drawing.Color.Black;
            this.ibtnVendasCompras.IconSize = 30;
            this.ibtnVendasCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnVendasCompras.Location = new System.Drawing.Point(1, 138);
            this.ibtnVendasCompras.Name = "ibtnVendasCompras";
            this.ibtnVendasCompras.Rotation = 0D;
            this.ibtnVendasCompras.Size = new System.Drawing.Size(278, 45);
            this.ibtnVendasCompras.TabIndex = 61;
            this.ibtnVendasCompras.Text = "Gráficos | BI";
            this.ibtnVendasCompras.UseVisualStyleBackColor = false;
            this.ibtnVendasCompras.Click += new System.EventHandler(this.ibtnVendasCompras_Click);
            // 
            // ibtnFluxoCaixa
            // 
            this.ibtnFluxoCaixa.BackColor = System.Drawing.Color.Gainsboro;
            this.ibtnFluxoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFluxoCaixa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnFluxoCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnFluxoCaixa.ForeColor = System.Drawing.Color.Black;
            this.ibtnFluxoCaixa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnFluxoCaixa.IconColor = System.Drawing.Color.Black;
            this.ibtnFluxoCaixa.IconSize = 30;
            this.ibtnFluxoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnFluxoCaixa.Location = new System.Drawing.Point(1, 92);
            this.ibtnFluxoCaixa.Name = "ibtnFluxoCaixa";
            this.ibtnFluxoCaixa.Rotation = 0D;
            this.ibtnFluxoCaixa.Size = new System.Drawing.Size(278, 45);
            this.ibtnFluxoCaixa.TabIndex = 60;
            this.ibtnFluxoCaixa.Text = "Fluxo de Caixa";
            this.ibtnFluxoCaixa.UseVisualStyleBackColor = false;
            this.ibtnFluxoCaixa.Click += new System.EventHandler(this.ibtnFluxoCaixa_Click);
            // 
            // ibtnMovimentoEstoque
            // 
            this.ibtnMovimentoEstoque.BackColor = System.Drawing.Color.Gainsboro;
            this.ibtnMovimentoEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMovimentoEstoque.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnMovimentoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMovimentoEstoque.ForeColor = System.Drawing.Color.Black;
            this.ibtnMovimentoEstoque.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnMovimentoEstoque.IconColor = System.Drawing.Color.Black;
            this.ibtnMovimentoEstoque.IconSize = 30;
            this.ibtnMovimentoEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnMovimentoEstoque.Location = new System.Drawing.Point(1, 46);
            this.ibtnMovimentoEstoque.Name = "ibtnMovimentoEstoque";
            this.ibtnMovimentoEstoque.Rotation = 0D;
            this.ibtnMovimentoEstoque.Size = new System.Drawing.Size(278, 45);
            this.ibtnMovimentoEstoque.TabIndex = 59;
            this.ibtnMovimentoEstoque.Text = "Movimento de Estoque";
            this.ibtnMovimentoEstoque.UseVisualStyleBackColor = false;
            this.ibtnMovimentoEstoque.Click += new System.EventHandler(this.ibtnMovimentoEstoque_Click);
            // 
            // ibtnContasVencidas
            // 
            this.ibtnContasVencidas.BackColor = System.Drawing.Color.OrangeRed;
            this.ibtnContasVencidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnContasVencidas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnContasVencidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnContasVencidas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnContasVencidas.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnContasVencidas.ForeColor = System.Drawing.Color.White;
            this.ibtnContasVencidas.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.ibtnContasVencidas.IconColor = System.Drawing.Color.Black;
            this.ibtnContasVencidas.IconSize = 30;
            this.ibtnContasVencidas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnContasVencidas.Location = new System.Drawing.Point(0, 90);
            this.ibtnContasVencidas.Name = "ibtnContasVencidas";
            this.ibtnContasVencidas.Rotation = 0D;
            this.ibtnContasVencidas.Size = new System.Drawing.Size(280, 45);
            this.ibtnContasVencidas.TabIndex = 74;
            this.ibtnContasVencidas.Text = "Contas Vencidas";
            this.ibtnContasVencidas.UseVisualStyleBackColor = false;
            this.ibtnContasVencidas.Click += new System.EventHandler(this.ibtnContasVencidas_Click);
            // 
            // ibtnContasReceber
            // 
            this.ibtnContasReceber.BackColor = System.Drawing.Color.Lime;
            this.ibtnContasReceber.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnContasReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnContasReceber.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnContasReceber.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnContasReceber.ForeColor = System.Drawing.Color.Black;
            this.ibtnContasReceber.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.ibtnContasReceber.IconColor = System.Drawing.Color.Black;
            this.ibtnContasReceber.IconSize = 30;
            this.ibtnContasReceber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnContasReceber.Location = new System.Drawing.Point(0, 45);
            this.ibtnContasReceber.Name = "ibtnContasReceber";
            this.ibtnContasReceber.Rotation = 0D;
            this.ibtnContasReceber.Size = new System.Drawing.Size(280, 45);
            this.ibtnContasReceber.TabIndex = 73;
            this.ibtnContasReceber.Text = "Contas Receber";
            this.ibtnContasReceber.UseVisualStyleBackColor = false;
            this.ibtnContasReceber.Click += new System.EventHandler(this.ibtnContasReceber_Click);
            // 
            // ibtnHome
            // 
            this.ibtnHome.BackColor = System.Drawing.Color.ForestGreen;
            this.ibtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnHome.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnHome.ForeColor = System.Drawing.Color.White;
            this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnHome.IconColor = System.Drawing.Color.White;
            this.ibtnHome.IconSize = 30;
            this.ibtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnHome.Location = new System.Drawing.Point(0, 0);
            this.ibtnHome.Name = "ibtnHome";
            this.ibtnHome.Rotation = 0D;
            this.ibtnHome.Size = new System.Drawing.Size(280, 45);
            this.ibtnHome.TabIndex = 72;
            this.ibtnHome.Text = "Home";
            this.ibtnHome.UseVisualStyleBackColor = false;
            this.ibtnHome.Click += new System.EventHandler(this.ibtnHome_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.Black;
            this.lblNivel.Location = new System.Drawing.Point(130, 598);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(20, 25);
            this.lblNivel.TabIndex = 70;
            this.lblNivel.Text = "-";
            this.lblNivel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.lblNomeUsuario);
            this.panel1.Location = new System.Drawing.Point(1, 652);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 26);
            this.panel1.TabIndex = 68;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblNomeUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(279, 26);
            this.lblNomeUsuario.TabIndex = 67;
            this.lblNomeUsuario.Text = "-NOME USUARIO-";
            this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "Bem vinda(o)";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(54, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Menu Lateral";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Loja.Properties.Resources.linha_animada;
            this.pictureBox2.Location = new System.Drawing.Point(0, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 30);
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // timerBtn
            // 
            this.timerBtn.Enabled = true;
            this.timerBtn.Interval = 15;
            this.timerBtn.Tick += new System.EventHandler(this.timerBtn_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1004, 703);
            this.panelContainer.TabIndex = 23;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 703);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenuLateral);
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Inicial";
            this.Load += new System.EventHandler(this.PaginaInicial_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelMenuLateral.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelRelatorioButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnConfiguracoes;
        private FontAwesome.Sharp.IconButton ibtnControleCaixa;
        private System.Windows.Forms.Panel panelRelatorioButton;
        private FontAwesome.Sharp.IconButton ibtnRelatoriosGerais;
        private FontAwesome.Sharp.IconButton ibtnHistoricoVendas;
        private FontAwesome.Sharp.IconButton ibtnVendasCompras;
        private FontAwesome.Sharp.IconButton ibtnFluxoCaixa;
        private FontAwesome.Sharp.IconButton ibtnMovimentoEstoque;
        private FontAwesome.Sharp.IconButton ibtnContasVencidas;
        private FontAwesome.Sharp.IconButton ibtnContasReceber;
        private FontAwesome.Sharp.IconButton ibtnHome;
    }
}