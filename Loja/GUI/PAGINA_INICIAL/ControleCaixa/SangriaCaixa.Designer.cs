
namespace Loja.GUI.CAIXA
{
    partial class SangriaCaixa
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
            this.tbValorSangria = new System.Windows.Forms.TextBox();
            this.ibtnSangriaCaixa = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // tbValorSangria
            // 
            this.tbValorSangria.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorSangria.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbValorSangria.Location = new System.Drawing.Point(12, 12);
            this.tbValorSangria.MaxLength = 12;
            this.tbValorSangria.Name = "tbValorSangria";
            this.tbValorSangria.ShortcutsEnabled = false;
            this.tbValorSangria.Size = new System.Drawing.Size(216, 46);
            this.tbValorSangria.TabIndex = 99;
            this.tbValorSangria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbValorSangria.TextChanged += new System.EventHandler(this.tbValorSangria_TextChanged);
            this.tbValorSangria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorSangria_KeyPress);
            // 
            // ibtnSangriaCaixa
            // 
            this.ibtnSangriaCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnSangriaCaixa.BackColor = System.Drawing.Color.Red;
            this.ibtnSangriaCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSangriaCaixa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnSangriaCaixa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSangriaCaixa.ForeColor = System.Drawing.Color.White;
            this.ibtnSangriaCaixa.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleDown;
            this.ibtnSangriaCaixa.IconColor = System.Drawing.Color.White;
            this.ibtnSangriaCaixa.IconSize = 30;
            this.ibtnSangriaCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSangriaCaixa.Location = new System.Drawing.Point(12, 64);
            this.ibtnSangriaCaixa.Name = "ibtnSangriaCaixa";
            this.ibtnSangriaCaixa.Rotation = 0D;
            this.ibtnSangriaCaixa.Size = new System.Drawing.Size(216, 50);
            this.ibtnSangriaCaixa.TabIndex = 100;
            this.ibtnSangriaCaixa.Text = "Efetuar";
            this.ibtnSangriaCaixa.UseVisualStyleBackColor = false;
            this.ibtnSangriaCaixa.Click += new System.EventHandler(this.ibtnSangriaCaixa_Click);
            // 
            // SangriaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 126);
            this.Controls.Add(this.ibtnSangriaCaixa);
            this.Controls.Add(this.tbValorSangria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SangriaCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangria de Caixa";
            this.Load += new System.EventHandler(this.SangriaCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnSangriaCaixa;
        private System.Windows.Forms.TextBox tbValorSangria;
    }
}