
namespace Loja.GUI.FICHA_CLIENTES
{
    partial class AlterarDataVencimentoParcela
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
            this.dtpDataVencimentoParcela = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnAlterarData = new FontAwesome.Sharp.IconButton();
            this.lblIdParcela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDataVencimentoParcela
            // 
            this.dtpDataVencimentoParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataVencimentoParcela.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoParcela.Location = new System.Drawing.Point(160, 16);
            this.dtpDataVencimentoParcela.Name = "dtpDataVencimentoParcela";
            this.dtpDataVencimentoParcela.Size = new System.Drawing.Size(100, 27);
            this.dtpDataVencimentoParcela.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Novo Vencimento";
            // 
            // ibtnAlterarData
            // 
            this.ibtnAlterarData.BackColor = System.Drawing.Color.DodgerBlue;
            this.ibtnAlterarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAlterarData.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAlterarData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAlterarData.ForeColor = System.Drawing.Color.White;
            this.ibtnAlterarData.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.ibtnAlterarData.IconColor = System.Drawing.Color.White;
            this.ibtnAlterarData.IconSize = 35;
            this.ibtnAlterarData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAlterarData.Location = new System.Drawing.Point(13, 61);
            this.ibtnAlterarData.Name = "ibtnAlterarData";
            this.ibtnAlterarData.Rotation = 0D;
            this.ibtnAlterarData.Size = new System.Drawing.Size(247, 49);
            this.ibtnAlterarData.TabIndex = 59;
            this.ibtnAlterarData.Text = "Alterar Data";
            this.ibtnAlterarData.UseVisualStyleBackColor = false;
            this.ibtnAlterarData.Click += new System.EventHandler(this.ibtnAlterarData_Click);
            // 
            // lblIdParcela
            // 
            this.lblIdParcela.AutoSize = true;
            this.lblIdParcela.Location = new System.Drawing.Point(39, 7);
            this.lblIdParcela.Name = "lblIdParcela";
            this.lblIdParcela.Size = new System.Drawing.Size(53, 13);
            this.lblIdParcela.TabIndex = 60;
            this.lblIdParcela.Text = "id parcela";
            this.lblIdParcela.Visible = false;
            // 
            // AlterarDataVencimentoParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 122);
            this.Controls.Add(this.lblIdParcela);
            this.Controls.Add(this.ibtnAlterarData);
            this.Controls.Add(this.dtpDataVencimentoParcela);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterarDataVencimentoParcela";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Data";
            this.Load += new System.EventHandler(this.AlterarDataVencimentoParcela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataVencimentoParcela;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibtnAlterarData;
        private System.Windows.Forms.Label lblIdParcela;
    }
}