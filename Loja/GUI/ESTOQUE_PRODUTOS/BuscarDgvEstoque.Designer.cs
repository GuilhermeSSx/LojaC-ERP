
namespace Loja.GUI.ESTOQUE_PRODUTOS
{
    partial class BuscarDgvEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBuscarProdutos = new System.Windows.Forms.DataGridView();
            this.colNomePRODdgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantProdDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBuscarProduto = new System.Windows.Forms.ComboBox();
            this.ibtnSelecionarProduto = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarProdutos
            // 
            this.dgvBuscarProdutos.AllowUserToAddRows = false;
            this.dgvBuscarProdutos.AllowUserToDeleteRows = false;
            this.dgvBuscarProdutos.AllowUserToResizeColumns = false;
            this.dgvBuscarProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBuscarProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscarProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscarProdutos.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvBuscarProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscarProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuscarProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuscarProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomePRODdgv,
            this.colQuantProdDGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscarProdutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBuscarProdutos.Location = new System.Drawing.Point(9, 52);
            this.dgvBuscarProdutos.MultiSelect = false;
            this.dgvBuscarProdutos.Name = "dgvBuscarProdutos";
            this.dgvBuscarProdutos.ReadOnly = true;
            this.dgvBuscarProdutos.RowHeadersVisible = false;
            this.dgvBuscarProdutos.RowHeadersWidth = 10;
            this.dgvBuscarProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuscarProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarProdutos.Size = new System.Drawing.Size(662, 135);
            this.dgvBuscarProdutos.TabIndex = 20;
            this.dgvBuscarProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarProdutos_CellClick);
            // 
            // colNomePRODdgv
            // 
            this.colNomePRODdgv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomePRODdgv.DataPropertyName = "NOME_PRODUTO";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.colNomePRODdgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNomePRODdgv.HeaderText = "Nome do Produto";
            this.colNomePRODdgv.Name = "colNomePRODdgv";
            this.colNomePRODdgv.ReadOnly = true;
            // 
            // colQuantProdDGV
            // 
            this.colQuantProdDGV.DataPropertyName = "QUANT_PROD";
            this.colQuantProdDGV.HeaderText = "Qtd";
            this.colQuantProdDGV.Name = "colQuantProdDGV";
            this.colQuantProdDGV.ReadOnly = true;
            this.colQuantProdDGV.Width = 33;
            // 
            // cbBuscarProduto
            // 
            this.cbBuscarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscarProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBuscarProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBuscarProduto.DropDownHeight = 143;
            this.cbBuscarProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbBuscarProduto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarProduto.FormattingEnabled = true;
            this.cbBuscarProduto.IntegralHeight = false;
            this.cbBuscarProduto.Location = new System.Drawing.Point(9, 13);
            this.cbBuscarProduto.Name = "cbBuscarProduto";
            this.cbBuscarProduto.Size = new System.Drawing.Size(491, 28);
            this.cbBuscarProduto.TabIndex = 61;
            this.cbBuscarProduto.TextChanged += new System.EventHandler(this.cbBuscarProduto_TextChanged);
            this.cbBuscarProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBuscarProduto_KeyDown);
            // 
            // ibtnSelecionarProduto
            // 
            this.ibtnSelecionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnSelecionarProduto.BackColor = System.Drawing.SystemColors.Desktop;
            this.ibtnSelecionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSelecionarProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnSelecionarProduto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSelecionarProduto.ForeColor = System.Drawing.Color.White;
            this.ibtnSelecionarProduto.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.ibtnSelecionarProduto.IconColor = System.Drawing.Color.White;
            this.ibtnSelecionarProduto.IconSize = 30;
            this.ibtnSelecionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSelecionarProduto.Location = new System.Drawing.Point(506, 6);
            this.ibtnSelecionarProduto.Name = "ibtnSelecionarProduto";
            this.ibtnSelecionarProduto.Rotation = 0D;
            this.ibtnSelecionarProduto.Size = new System.Drawing.Size(165, 42);
            this.ibtnSelecionarProduto.TabIndex = 60;
            this.ibtnSelecionarProduto.Text = "Selecionar";
            this.ibtnSelecionarProduto.UseVisualStyleBackColor = false;
            this.ibtnSelecionarProduto.Click += new System.EventHandler(this.ibtnSelecionarProduto_Click);
            // 
            // BuscarDgvEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 193);
            this.Controls.Add(this.cbBuscarProduto);
            this.Controls.Add(this.ibtnSelecionarProduto);
            this.Controls.Add(this.dgvBuscarProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarDgvEstoque";
            this.Opacity = 0.94D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar no Estoque Produtos";
            this.Load += new System.EventHandler(this.BuscarDgvEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarProdutos;
        private System.Windows.Forms.ComboBox cbBuscarProduto;
        private FontAwesome.Sharp.IconButton ibtnSelecionarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomePRODdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantProdDGV;
    }
}