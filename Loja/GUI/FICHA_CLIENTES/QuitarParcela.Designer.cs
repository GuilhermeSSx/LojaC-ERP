
namespace Loja.GUI.FICHA_CLIENTES
{
    partial class QuitarParcela
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbValorReceber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValorParcela = new System.Windows.Forms.TextBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ibtnQuitarParcela = new FontAwesome.Sharp.IconButton();
            this.lblIdParcela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "Valor a Receber";
            // 
            // tbValorReceber
            // 
            this.tbValorReceber.Enabled = false;
            this.tbValorReceber.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorReceber.Location = new System.Drawing.Point(195, 45);
            this.tbValorReceber.Name = "tbValorReceber";
            this.tbValorReceber.ReadOnly = true;
            this.tbValorReceber.Size = new System.Drawing.Size(119, 29);
            this.tbValorReceber.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Valor Parcela";
            // 
            // tbValorParcela
            // 
            this.tbValorParcela.Enabled = false;
            this.tbValorParcela.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorParcela.Location = new System.Drawing.Point(195, 10);
            this.tbValorParcela.Name = "tbValorParcela";
            this.tbValorParcela.ReadOnly = true;
            this.tbValorParcela.Size = new System.Drawing.Size(119, 29);
            this.tbValorParcela.TabIndex = 92;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito 1x"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(195, 80);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(119, 28);
            this.cbFormaPagamento.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Forma de Pagamento";
            // 
            // ibtnQuitarParcela
            // 
            this.ibtnQuitarParcela.BackColor = System.Drawing.Color.Gold;
            this.ibtnQuitarParcela.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnQuitarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnQuitarParcela.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnQuitarParcela.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnQuitarParcela.ForeColor = System.Drawing.Color.Black;
            this.ibtnQuitarParcela.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ibtnQuitarParcela.IconColor = System.Drawing.Color.LimeGreen;
            this.ibtnQuitarParcela.IconSize = 25;
            this.ibtnQuitarParcela.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnQuitarParcela.Location = new System.Drawing.Point(15, 120);
            this.ibtnQuitarParcela.Name = "ibtnQuitarParcela";
            this.ibtnQuitarParcela.Rotation = 0D;
            this.ibtnQuitarParcela.Size = new System.Drawing.Size(299, 45);
            this.ibtnQuitarParcela.TabIndex = 89;
            this.ibtnQuitarParcela.Text = "Quitar Parcela";
            this.ibtnQuitarParcela.UseVisualStyleBackColor = false;
            this.ibtnQuitarParcela.Click += new System.EventHandler(this.ibtnQuitarParcela_Click);
            // 
            // lblIdParcela
            // 
            this.lblIdParcela.AutoSize = true;
            this.lblIdParcela.Location = new System.Drawing.Point(33, 2);
            this.lblIdParcela.Name = "lblIdParcela";
            this.lblIdParcela.Size = new System.Drawing.Size(53, 13);
            this.lblIdParcela.TabIndex = 96;
            this.lblIdParcela.Text = "id parcela";
            this.lblIdParcela.Visible = false;
            // 
            // QuitarParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 175);
            this.Controls.Add(this.lblIdParcela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbValorReceber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbValorParcela);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ibtnQuitarParcela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuitarParcela";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quitar a Parcela";
            this.Load += new System.EventHandler(this.QuitarParcela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValorReceber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbValorParcela;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ibtnQuitarParcela;
        private System.Windows.Forms.Label lblIdParcela;
    }
}