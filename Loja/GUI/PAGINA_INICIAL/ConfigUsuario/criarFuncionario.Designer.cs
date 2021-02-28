namespace Loja.GUI.PAGINA_INICIAL.Configuracoes
{
    partial class crudFuncionario
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
            this.tbSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ibtnSalvarUsuario = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // tbSenhaFuncionario
            // 
            this.tbSenhaFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSenhaFuncionario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenhaFuncionario.Location = new System.Drawing.Point(190, 50);
            this.tbSenhaFuncionario.MaxLength = 16;
            this.tbSenhaFuncionario.Name = "tbSenhaFuncionario";
            this.tbSenhaFuncionario.PasswordChar = '*';
            this.tbSenhaFuncionario.Size = new System.Drawing.Size(184, 29);
            this.tbSenhaFuncionario.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "Senha Funcionário";
            // 
            // tbNomeFuncionario
            // 
            this.tbNomeFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeFuncionario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeFuncionario.Location = new System.Drawing.Point(190, 10);
            this.tbNomeFuncionario.MaxLength = 20;
            this.tbNomeFuncionario.Name = "tbNomeFuncionario";
            this.tbNomeFuncionario.Size = new System.Drawing.Size(184, 29);
            this.tbNomeFuncionario.TabIndex = 76;
            this.tbNomeFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomeFuncionario_KeyDown);
            this.tbNomeFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomeFuncionario_KeyPress);
            this.tbNomeFuncionario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbNomeFuncionario_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nome Funcionário";
            // 
            // ibtnSalvarUsuario
            // 
            this.ibtnSalvarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnSalvarUsuario.BackColor = System.Drawing.Color.Chartreuse;
            this.ibtnSalvarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSalvarUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnSalvarUsuario.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ibtnSalvarUsuario.ForeColor = System.Drawing.Color.Black;
            this.ibtnSalvarUsuario.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtnSalvarUsuario.IconColor = System.Drawing.Color.Black;
            this.ibtnSalvarUsuario.IconSize = 30;
            this.ibtnSalvarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSalvarUsuario.Location = new System.Drawing.Point(16, 98);
            this.ibtnSalvarUsuario.Name = "ibtnSalvarUsuario";
            this.ibtnSalvarUsuario.Rotation = 0D;
            this.ibtnSalvarUsuario.Size = new System.Drawing.Size(358, 65);
            this.ibtnSalvarUsuario.TabIndex = 74;
            this.ibtnSalvarUsuario.Text = "Criar Novo";
            this.ibtnSalvarUsuario.UseVisualStyleBackColor = false;
            this.ibtnSalvarUsuario.Click += new System.EventHandler(this.ibtnSalvarUsuario_Click);
            // 
            // crudFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 173);
            this.Controls.Add(this.tbSenhaFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ibtnSalvarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "crudFuncionario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Novo Funcionario";
            this.Load += new System.EventHandler(this.crudFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSenhaFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomeFuncionario;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ibtnSalvarUsuario;
    }
}