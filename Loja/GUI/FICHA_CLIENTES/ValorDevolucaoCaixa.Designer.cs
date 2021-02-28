
namespace Loja.GUI.FICHA_CLIENTES
{
    partial class ValorDevolucaoCaixa
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSaldoCaixa = new System.Windows.Forms.TextBox();
            this.ibtnDevolucaoDinheiroCliente = new FontAwesome.Sharp.IconButton();
            this.tbValorDevolucao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::Loja.Properties.Resources.linha_animada;
            this.pictureBox5.Location = new System.Drawing.Point(42, 145);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(296, 33);
            this.pictureBox5.TabIndex = 102;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(46, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 37);
            this.label7.TabIndex = 101;
            this.label7.Text = "Saldo Atual em Caixa";
            // 
            // tbSaldoCaixa
            // 
            this.tbSaldoCaixa.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldoCaixa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbSaldoCaixa.Location = new System.Drawing.Point(92, 75);
            this.tbSaldoCaixa.Name = "tbSaldoCaixa";
            this.tbSaldoCaixa.Size = new System.Drawing.Size(197, 46);
            this.tbSaldoCaixa.TabIndex = 100;
            this.tbSaldoCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSaldoCaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSaldoCaixa_KeyPress);
            // 
            // ibtnDevolucaoDinheiroCliente
            // 
            this.ibtnDevolucaoDinheiroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ibtnDevolucaoDinheiroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDevolucaoDinheiroCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnDevolucaoDinheiroCliente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDevolucaoDinheiroCliente.ForeColor = System.Drawing.Color.White;
            this.ibtnDevolucaoDinheiroCliente.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.ibtnDevolucaoDinheiroCliente.IconColor = System.Drawing.Color.White;
            this.ibtnDevolucaoDinheiroCliente.IconSize = 30;
            this.ibtnDevolucaoDinheiroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnDevolucaoDinheiroCliente.Location = new System.Drawing.Point(82, 304);
            this.ibtnDevolucaoDinheiroCliente.Name = "ibtnDevolucaoDinheiroCliente";
            this.ibtnDevolucaoDinheiroCliente.Rotation = 0D;
            this.ibtnDevolucaoDinheiroCliente.Size = new System.Drawing.Size(216, 50);
            this.ibtnDevolucaoDinheiroCliente.TabIndex = 104;
            this.ibtnDevolucaoDinheiroCliente.Text = "Efetuar";
            this.ibtnDevolucaoDinheiroCliente.UseVisualStyleBackColor = false;
            this.ibtnDevolucaoDinheiroCliente.Click += new System.EventHandler(this.ibtnDevolucaoDinheiroCliente_Click);
            // 
            // tbValorDevolucao
            // 
            this.tbValorDevolucao.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorDevolucao.ForeColor = System.Drawing.Color.Red;
            this.tbValorDevolucao.Location = new System.Drawing.Point(82, 245);
            this.tbValorDevolucao.MaxLength = 12;
            this.tbValorDevolucao.Name = "tbValorDevolucao";
            this.tbValorDevolucao.ShortcutsEnabled = false;
            this.tbValorDevolucao.Size = new System.Drawing.Size(216, 46);
            this.tbValorDevolucao.TabIndex = 103;
            this.tbValorDevolucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbValorDevolucao.TextChanged += new System.EventHandler(this.tbValorDevolucao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 105;
            this.label1.Text = "Valor a Devolver";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNomeCliente.Location = new System.Drawing.Point(70, 7);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCliente.TabIndex = 106;
            this.lblNomeCliente.Text = "-Nome Cliente-";
            this.lblNomeCliente.Visible = false;
            // 
            // ValorDevolucaoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 371);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ibtnDevolucaoDinheiroCliente);
            this.Controls.Add(this.tbValorDevolucao);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSaldoCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValorDevolucaoCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor da Devolucao ao Cliente";
            this.Load += new System.EventHandler(this.ValorDevolucaoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSaldoCaixa;
        private FontAwesome.Sharp.IconButton ibtnDevolucaoDinheiroCliente;
        private System.Windows.Forms.TextBox tbValorDevolucao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCliente;
    }
}