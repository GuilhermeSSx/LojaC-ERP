
namespace Loja.GUI.CAIXA
{
    partial class ReforcoCaixa
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
            this.tbValorReforco = new System.Windows.Forms.TextBox();
            this.ibtnReforcoCaixa = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // tbValorReforco
            // 
            this.tbValorReforco.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorReforco.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbValorReforco.Location = new System.Drawing.Point(12, 12);
            this.tbValorReforco.MaxLength = 12;
            this.tbValorReforco.Name = "tbValorReforco";
            this.tbValorReforco.ShortcutsEnabled = false;
            this.tbValorReforco.Size = new System.Drawing.Size(216, 46);
            this.tbValorReforco.TabIndex = 101;
            this.tbValorReforco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbValorReforco.TextChanged += new System.EventHandler(this.tbValorReforco_TextChanged);
            this.tbValorReforco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorReforco_KeyPress);
            // 
            // ibtnReforcoCaixa
            // 
            this.ibtnReforcoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnReforcoCaixa.BackColor = System.Drawing.Color.ForestGreen;
            this.ibtnReforcoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnReforcoCaixa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnReforcoCaixa.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnReforcoCaixa.ForeColor = System.Drawing.Color.White;
            this.ibtnReforcoCaixa.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp;
            this.ibtnReforcoCaixa.IconColor = System.Drawing.Color.White;
            this.ibtnReforcoCaixa.IconSize = 30;
            this.ibtnReforcoCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnReforcoCaixa.Location = new System.Drawing.Point(12, 64);
            this.ibtnReforcoCaixa.Name = "ibtnReforcoCaixa";
            this.ibtnReforcoCaixa.Rotation = 0D;
            this.ibtnReforcoCaixa.Size = new System.Drawing.Size(216, 50);
            this.ibtnReforcoCaixa.TabIndex = 102;
            this.ibtnReforcoCaixa.Text = "Efetuar";
            this.ibtnReforcoCaixa.UseVisualStyleBackColor = false;
            this.ibtnReforcoCaixa.Click += new System.EventHandler(this.ibtnReforcoCaixa_Click);
            // 
            // ReforcoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 126);
            this.Controls.Add(this.ibtnReforcoCaixa);
            this.Controls.Add(this.tbValorReforco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReforcoCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reforço de Caixa";
            this.Load += new System.EventHandler(this.ReforcoCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnReforcoCaixa;
        private System.Windows.Forms.TextBox tbValorReforco;
    }
}