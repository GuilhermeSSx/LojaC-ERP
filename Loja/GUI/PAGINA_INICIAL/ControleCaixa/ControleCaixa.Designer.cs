
namespace Loja.GUI.PAGINA_INICIAL
{
    partial class ControleCaixa
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbSaldoCaixa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ibtnSangriaCaixa = new FontAwesome.Sharp.IconButton();
            this.ibtnReforcoCaixa = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnAtualizarSaldoInicial = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSaldoInicialAtual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1004, 34);
            this.label7.TabIndex = 98;
            this.label7.Text = "Saldo em Caixa";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSaldoCaixa
            // 
            this.tbSaldoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaldoCaixa.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldoCaixa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbSaldoCaixa.Location = new System.Drawing.Point(339, 125);
            this.tbSaldoCaixa.Name = "tbSaldoCaixa";
            this.tbSaldoCaixa.ShortcutsEnabled = false;
            this.tbSaldoCaixa.Size = new System.Drawing.Size(327, 54);
            this.tbSaldoCaixa.TabIndex = 97;
            this.tbSaldoCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSaldoCaixa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSaldoCaixa_KeyDown);
            this.tbSaldoCaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSaldoCaixa_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 37);
            this.panel1.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1004, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "CONTROLE DE CAIXA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibtnSangriaCaixa
            // 
            this.ibtnSangriaCaixa.BackColor = System.Drawing.Color.Red;
            this.ibtnSangriaCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSangriaCaixa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnSangriaCaixa.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSangriaCaixa.ForeColor = System.Drawing.Color.White;
            this.ibtnSangriaCaixa.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.ibtnSangriaCaixa.IconColor = System.Drawing.Color.White;
            this.ibtnSangriaCaixa.IconSize = 50;
            this.ibtnSangriaCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSangriaCaixa.Location = new System.Drawing.Point(33, 107);
            this.ibtnSangriaCaixa.Name = "ibtnSangriaCaixa";
            this.ibtnSangriaCaixa.Rotation = 0D;
            this.ibtnSangriaCaixa.Size = new System.Drawing.Size(273, 72);
            this.ibtnSangriaCaixa.TabIndex = 103;
            this.ibtnSangriaCaixa.Text = "Sangria de Caixa";
            this.ibtnSangriaCaixa.UseVisualStyleBackColor = false;
            this.ibtnSangriaCaixa.Click += new System.EventHandler(this.ibtnSangriaCaixa_Click);
            // 
            // ibtnReforcoCaixa
            // 
            this.ibtnReforcoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnReforcoCaixa.BackColor = System.Drawing.Color.Chartreuse;
            this.ibtnReforcoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnReforcoCaixa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnReforcoCaixa.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnReforcoCaixa.ForeColor = System.Drawing.Color.Black;
            this.ibtnReforcoCaixa.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.ibtnReforcoCaixa.IconColor = System.Drawing.Color.Black;
            this.ibtnReforcoCaixa.IconSize = 50;
            this.ibtnReforcoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnReforcoCaixa.Location = new System.Drawing.Point(699, 107);
            this.ibtnReforcoCaixa.Name = "ibtnReforcoCaixa";
            this.ibtnReforcoCaixa.Rotation = 0D;
            this.ibtnReforcoCaixa.Size = new System.Drawing.Size(273, 72);
            this.ibtnReforcoCaixa.TabIndex = 102;
            this.ibtnReforcoCaixa.Text = "Reforço de Caixa";
            this.ibtnReforcoCaixa.UseVisualStyleBackColor = false;
            this.ibtnReforcoCaixa.Click += new System.EventHandler(this.ibtnReforcoCaixa_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 34);
            this.panel2.TabIndex = 104;
            // 
            // ibtnAtualizarSaldoInicial
            // 
            this.ibtnAtualizarSaldoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAtualizarSaldoInicial.BackColor = System.Drawing.Color.DodgerBlue;
            this.ibtnAtualizarSaldoInicial.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnAtualizarSaldoInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAtualizarSaldoInicial.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAtualizarSaldoInicial.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAtualizarSaldoInicial.ForeColor = System.Drawing.Color.White;
            this.ibtnAtualizarSaldoInicial.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.ibtnAtualizarSaldoInicial.IconColor = System.Drawing.Color.Black;
            this.ibtnAtualizarSaldoInicial.IconSize = 50;
            this.ibtnAtualizarSaldoInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAtualizarSaldoInicial.Location = new System.Drawing.Point(0, 0);
            this.ibtnAtualizarSaldoInicial.Name = "ibtnAtualizarSaldoInicial";
            this.ibtnAtualizarSaldoInicial.Rotation = 0D;
            this.ibtnAtualizarSaldoInicial.Size = new System.Drawing.Size(487, 72);
            this.ibtnAtualizarSaldoInicial.TabIndex = 105;
            this.ibtnAtualizarSaldoInicial.Text = "Atualizar Saldo Inicial Atual";
            this.ibtnAtualizarSaldoInicial.UseVisualStyleBackColor = false;
            this.ibtnAtualizarSaldoInicial.Click += new System.EventHandler(this.ibtnAtualizarSaldoInicial_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 34);
            this.panel3.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 34);
            this.label1.TabIndex = 98;
            this.label1.Text = "Clique no botão abaixo para igualar o \'Saldo em Caixa\' com \'Saldo Inicial do Dia\'" +
    ".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.lblSaldoInicialAtual);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.ibtnAtualizarSaldoInicial);
            this.panel4.Location = new System.Drawing.Point(33, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 72);
            this.panel4.TabIndex = 107;
            // 
            // lblSaldoInicialAtual
            // 
            this.lblSaldoInicialAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoInicialAtual.AutoSize = true;
            this.lblSaldoInicialAtual.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInicialAtual.ForeColor = System.Drawing.Color.White;
            this.lblSaldoInicialAtual.Location = new System.Drawing.Point(788, 21);
            this.lblSaldoInicialAtual.Name = "lblSaldoInicialAtual";
            this.lblSaldoInicialAtual.Size = new System.Drawing.Size(87, 30);
            this.lblSaldoInicialAtual.TabIndex = 107;
            this.lblSaldoInicialAtual.Text = "R$ 0,00";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(508, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 30);
            this.label3.TabIndex = 106;
            this.label3.Text = "Saldo Inicial Atual:";
            // 
            // ControleCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 626);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ibtnSangriaCaixa);
            this.Controls.Add(this.ibtnReforcoCaixa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbSaldoCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControleCaixa";
            this.Text = "ControleCaixa";
            this.Load += new System.EventHandler(this.ControleCaixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSaldoCaixa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ibtnSangriaCaixa;
        private FontAwesome.Sharp.IconButton ibtnReforcoCaixa;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnAtualizarSaldoInicial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSaldoInicialAtual;
        private System.Windows.Forms.Label label3;
    }
}