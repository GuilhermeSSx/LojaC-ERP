namespace Loja.GUI.PAGINA_INICIAL
{
    partial class Configs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListaFuncionarios = new System.Windows.Forms.DataGridView();
            this.colNomeFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnCadastrarFuncionario = new FontAwesome.Sharp.IconButton();
            this.ibtnRemoverFuncionario = new FontAwesome.Sharp.IconButton();
            this.ibtnAlterarFuncionario = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(1004, 41);
            this.lblNomeUsuario.TabIndex = 60;
            this.lblNomeUsuario.Text = "-NOME USUARIO-";
            this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblNomeUsuario);
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 41);
            this.panel3.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 42);
            this.panel2.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 42);
            this.label1.TabIndex = 59;
            this.label1.Text = "Configurações | Funcionários";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1004, 14);
            this.label3.TabIndex = 70;
            this.label3.Text = "Todos os Direitos Reservados  © - Gui Sistemas - v1.35";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 611);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 14);
            this.panel1.TabIndex = 90;
            // 
            // dgvListaFuncionarios
            // 
            this.dgvListaFuncionarios.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListaFuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaFuncionarios.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvListaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeFunc});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaFuncionarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaFuncionarios.Location = new System.Drawing.Point(211, 156);
            this.dgvListaFuncionarios.MultiSelect = false;
            this.dgvListaFuncionarios.Name = "dgvListaFuncionarios";
            this.dgvListaFuncionarios.ReadOnly = true;
            this.dgvListaFuncionarios.RowHeadersWidth = 40;
            this.dgvListaFuncionarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaFuncionarios.Size = new System.Drawing.Size(358, 199);
            this.dgvListaFuncionarios.TabIndex = 84;
            // 
            // colNomeFunc
            // 
            this.colNomeFunc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeFunc.DataPropertyName = "NOME_USUARIO";
            this.colNomeFunc.HeaderText = "Nomes Funcionários";
            this.colNomeFunc.Name = "colNomeFunc";
            this.colNomeFunc.ReadOnly = true;
            // 
            // ibtnCadastrarFuncionario
            // 
            this.ibtnCadastrarFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCadastrarFuncionario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCadastrarFuncionario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCadastrarFuncionario.ForeColor = System.Drawing.Color.Black;
            this.ibtnCadastrarFuncionario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ibtnCadastrarFuncionario.IconColor = System.Drawing.Color.Black;
            this.ibtnCadastrarFuncionario.IconSize = 30;
            this.ibtnCadastrarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCadastrarFuncionario.Location = new System.Drawing.Point(575, 156);
            this.ibtnCadastrarFuncionario.Name = "ibtnCadastrarFuncionario";
            this.ibtnCadastrarFuncionario.Rotation = 0D;
            this.ibtnCadastrarFuncionario.Size = new System.Drawing.Size(219, 82);
            this.ibtnCadastrarFuncionario.TabIndex = 87;
            this.ibtnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.ibtnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.ibtnCadastrarFuncionario.Click += new System.EventHandler(this.ibtnCadastrarFuncionario_Click);
            // 
            // ibtnRemoverFuncionario
            // 
            this.ibtnRemoverFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnRemoverFuncionario.BackColor = System.Drawing.Color.Red;
            this.ibtnRemoverFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRemoverFuncionario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnRemoverFuncionario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRemoverFuncionario.ForeColor = System.Drawing.Color.White;
            this.ibtnRemoverFuncionario.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.ibtnRemoverFuncionario.IconColor = System.Drawing.Color.White;
            this.ibtnRemoverFuncionario.IconSize = 30;
            this.ibtnRemoverFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnRemoverFuncionario.Location = new System.Drawing.Point(575, 303);
            this.ibtnRemoverFuncionario.Name = "ibtnRemoverFuncionario";
            this.ibtnRemoverFuncionario.Rotation = 0D;
            this.ibtnRemoverFuncionario.Size = new System.Drawing.Size(219, 52);
            this.ibtnRemoverFuncionario.TabIndex = 86;
            this.ibtnRemoverFuncionario.Text = "Remover Funcionário";
            this.ibtnRemoverFuncionario.UseVisualStyleBackColor = false;
            this.ibtnRemoverFuncionario.Click += new System.EventHandler(this.ibtnRemoverFuncionario_Click);
            // 
            // ibtnAlterarFuncionario
            // 
            this.ibtnAlterarFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAlterarFuncionario.BackColor = System.Drawing.Color.DarkOrange;
            this.ibtnAlterarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAlterarFuncionario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAlterarFuncionario.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAlterarFuncionario.ForeColor = System.Drawing.Color.White;
            this.ibtnAlterarFuncionario.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnAlterarFuncionario.IconColor = System.Drawing.Color.White;
            this.ibtnAlterarFuncionario.IconSize = 30;
            this.ibtnAlterarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAlterarFuncionario.Location = new System.Drawing.Point(575, 245);
            this.ibtnAlterarFuncionario.Name = "ibtnAlterarFuncionario";
            this.ibtnAlterarFuncionario.Rotation = 0D;
            this.ibtnAlterarFuncionario.Size = new System.Drawing.Size(219, 53);
            this.ibtnAlterarFuncionario.TabIndex = 85;
            this.ibtnAlterarFuncionario.Text = "Alterar Funcionário";
            this.ibtnAlterarFuncionario.UseVisualStyleBackColor = false;
            this.ibtnAlterarFuncionario.Click += new System.EventHandler(this.ibtnAlterarFuncionario_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Gold;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(385, 460);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(235, 52);
            this.iconButton2.TabIndex = 89;
            this.iconButton2.Text = "Backup";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Visible = false;
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Location = new System.Drawing.Point(877, 121);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(16, 13);
            this.lblNivelAcesso.TabIndex = 93;
            this.lblNivelAcesso.Text = "---";
            this.lblNivelAcesso.Visible = false;
            // 
            // Configs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 625);
            this.Controls.Add(this.lblNivelAcesso);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ibtnCadastrarFuncionario);
            this.Controls.Add(this.ibtnRemoverFuncionario);
            this.Controls.Add(this.ibtnAlterarFuncionario);
            this.Controls.Add(this.dgvListaFuncionarios);
            this.Controls.Add(this.iconButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configs";
            this.Text = "                                                              ";
            this.Load += new System.EventHandler(this.Configs_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnCadastrarFuncionario;
        private FontAwesome.Sharp.IconButton ibtnRemoverFuncionario;
        private FontAwesome.Sharp.IconButton ibtnAlterarFuncionario;
        private System.Windows.Forms.DataGridView dgvListaFuncionarios;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lblNivelAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeFunc;
    }
}