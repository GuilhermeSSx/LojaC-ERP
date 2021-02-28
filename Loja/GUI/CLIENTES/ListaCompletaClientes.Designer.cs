namespace Loja
{
    partial class ListaCompletaClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaCompletaClientes = new System.Windows.Forms.DataGridView();
            this.colNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ibtnAlterarCliente = new FontAwesome.Sharp.IconButton();
            this.ibtnRemoverCliente = new FontAwesome.Sharp.IconButton();
            this.ibtnBuscarClienteCC = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompletaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCompletaClientes
            // 
            this.dgvListaCompletaClientes.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListaCompletaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListaCompletaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCompletaClientes.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvListaCompletaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCompletaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeCliente,
            this.colEndereco,
            this.colBairro,
            this.colNumero,
            this.colCpf,
            this.colCelular,
            this.colRg});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCompletaClientes.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListaCompletaClientes.Location = new System.Drawing.Point(17, 64);
            this.dgvListaCompletaClientes.MultiSelect = false;
            this.dgvListaCompletaClientes.Name = "dgvListaCompletaClientes";
            this.dgvListaCompletaClientes.ReadOnly = true;
            this.dgvListaCompletaClientes.RowHeadersWidth = 22;
            this.dgvListaCompletaClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaCompletaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCompletaClientes.Size = new System.Drawing.Size(1247, 499);
            this.dgvListaCompletaClientes.TabIndex = 21;
            this.dgvListaCompletaClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListaCompletaClientes_KeyDown);
            // 
            // colNomeCliente
            // 
            this.colNomeCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeCliente.DataPropertyName = "NOME_CLIENTE";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNomeCliente.DefaultCellStyle = dataGridViewCellStyle8;
            this.colNomeCliente.HeaderText = "Nome do Cliente";
            this.colNomeCliente.Name = "colNomeCliente";
            this.colNomeCliente.ReadOnly = true;
            // 
            // colEndereco
            // 
            this.colEndereco.DataPropertyName = "ENDERECO";
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            this.colEndereco.Width = 260;
            // 
            // colBairro
            // 
            this.colBairro.DataPropertyName = "BAIRRO";
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            this.colBairro.Width = 230;
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "NUMERO";
            this.colNumero.HeaderText = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 80;
            // 
            // colCpf
            // 
            this.colCpf.DataPropertyName = "CPF";
            dataGridViewCellStyle9.Format = "000\\.000\\.000-00";
            this.colCpf.DefaultCellStyle = dataGridViewCellStyle9;
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colCelular
            // 
            this.colCelular.DataPropertyName = "CELULAR";
            dataGridViewCellStyle10.Format = "(00)\\ 0\\ 0000-0000";
            dataGridViewCellStyle10.NullValue = null;
            this.colCelular.DefaultCellStyle = dataGridViewCellStyle10;
            this.colCelular.HeaderText = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            // 
            // colRg
            // 
            this.colRg.DataPropertyName = "RG";
            dataGridViewCellStyle11.Format = "00\\.000\\.000\\-0";
            this.colRg.DefaultCellStyle = dataGridViewCellStyle11;
            this.colRg.HeaderText = "RG";
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            this.colRg.Width = 80;
            // 
            // cbBuscarCliente
            // 
            this.cbBuscarCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBuscarCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBuscarCliente.DropDownHeight = 353;
            this.cbBuscarCliente.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarCliente.FormattingEnabled = true;
            this.cbBuscarCliente.IntegralHeight = false;
            this.cbBuscarCliente.Location = new System.Drawing.Point(173, 5);
            this.cbBuscarCliente.Name = "cbBuscarCliente";
            this.cbBuscarCliente.Size = new System.Drawing.Size(405, 33);
            this.cbBuscarCliente.TabIndex = 23;
            this.cbBuscarCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBuscarCliente_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Buscar Cliente:";
            // 
            // ibtnAlterarCliente
            // 
            this.ibtnAlterarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAlterarCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.ibtnAlterarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAlterarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAlterarCliente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAlterarCliente.ForeColor = System.Drawing.Color.White;
            this.ibtnAlterarCliente.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.ibtnAlterarCliente.IconColor = System.Drawing.Color.White;
            this.ibtnAlterarCliente.IconSize = 30;
            this.ibtnAlterarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAlterarCliente.Location = new System.Drawing.Point(877, 2);
            this.ibtnAlterarCliente.Name = "ibtnAlterarCliente";
            this.ibtnAlterarCliente.Rotation = 0D;
            this.ibtnAlterarCliente.Size = new System.Drawing.Size(184, 53);
            this.ibtnAlterarCliente.TabIndex = 51;
            this.ibtnAlterarCliente.Text = "Alterar Cliente";
            this.ibtnAlterarCliente.UseVisualStyleBackColor = false;
            this.ibtnAlterarCliente.Click += new System.EventHandler(this.ibtnAlterarCliente_Click);
            // 
            // ibtnRemoverCliente
            // 
            this.ibtnRemoverCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnRemoverCliente.BackColor = System.Drawing.Color.Red;
            this.ibtnRemoverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRemoverCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnRemoverCliente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRemoverCliente.ForeColor = System.Drawing.Color.White;
            this.ibtnRemoverCliente.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.ibtnRemoverCliente.IconColor = System.Drawing.Color.White;
            this.ibtnRemoverCliente.IconSize = 30;
            this.ibtnRemoverCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnRemoverCliente.Location = new System.Drawing.Point(1080, 2);
            this.ibtnRemoverCliente.Name = "ibtnRemoverCliente";
            this.ibtnRemoverCliente.Rotation = 0D;
            this.ibtnRemoverCliente.Size = new System.Drawing.Size(184, 52);
            this.ibtnRemoverCliente.TabIndex = 52;
            this.ibtnRemoverCliente.Text = "Remover Cliente";
            this.ibtnRemoverCliente.UseVisualStyleBackColor = false;
            this.ibtnRemoverCliente.Click += new System.EventHandler(this.ibtnRemoverCliente_Click);
            // 
            // ibtnBuscarClienteCC
            // 
            this.ibtnBuscarClienteCC.BackColor = System.Drawing.SystemColors.Desktop;
            this.ibtnBuscarClienteCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBuscarClienteCC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnBuscarClienteCC.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnBuscarClienteCC.ForeColor = System.Drawing.Color.White;
            this.ibtnBuscarClienteCC.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnBuscarClienteCC.IconColor = System.Drawing.Color.White;
            this.ibtnBuscarClienteCC.IconSize = 30;
            this.ibtnBuscarClienteCC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnBuscarClienteCC.Location = new System.Drawing.Point(594, 3);
            this.ibtnBuscarClienteCC.Name = "ibtnBuscarClienteCC";
            this.ibtnBuscarClienteCC.Rotation = 0D;
            this.ibtnBuscarClienteCC.Size = new System.Drawing.Size(213, 45);
            this.ibtnBuscarClienteCC.TabIndex = 53;
            this.ibtnBuscarClienteCC.Text = "Buscar";
            this.ibtnBuscarClienteCC.UseVisualStyleBackColor = false;
            this.ibtnBuscarClienteCC.Click += new System.EventHandler(this.ibtnBuscarClienteCC_Click);
            // 
            // ListaCompletaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 573);
            this.Controls.Add(this.ibtnBuscarClienteCC);
            this.Controls.Add(this.ibtnRemoverCliente);
            this.Controls.Add(this.ibtnAlterarCliente);
            this.Controls.Add(this.cbBuscarCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListaCompletaClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaCompletaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaCompletaClientes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ListaCompletaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCompletaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCompletaClientes;
        private System.Windows.Forms.ComboBox cbBuscarCliente;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton ibtnAlterarCliente;
        private FontAwesome.Sharp.IconButton ibtnRemoverCliente;
        private FontAwesome.Sharp.IconButton ibtnBuscarClienteCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg;
    }
}