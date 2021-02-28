
namespace Loja.GUI.CAIXA
{
    partial class BuscarProdutoPedido
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
            this.cbBuscarProduto = new System.Windows.Forms.ComboBox();
            this.dgvBuscarProdutosPedido = new System.Windows.Forms.DataGridView();
            this.colIdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeProd__ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnSelecionarProduto = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProdutosPedido)).BeginInit();
            this.SuspendLayout();
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
            this.cbBuscarProduto.Size = new System.Drawing.Size(514, 28);
            this.cbBuscarProduto.TabIndex = 64;
            this.cbBuscarProduto.TextChanged += new System.EventHandler(this.cbBuscarProduto_TextChanged);
            this.cbBuscarProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBuscarProduto_KeyDown);
            // 
            // dgvBuscarProdutosPedido
            // 
            this.dgvBuscarProdutosPedido.AllowUserToAddRows = false;
            this.dgvBuscarProdutosPedido.AllowUserToDeleteRows = false;
            this.dgvBuscarProdutosPedido.AllowUserToResizeColumns = false;
            this.dgvBuscarProdutosPedido.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBuscarProdutosPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscarProdutosPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscarProdutosPedido.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvBuscarProdutosPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuscarProdutosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuscarProdutosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuscarProdutosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProd,
            this.colNomeProd__,
            this.colValorProd,
            this.colQuantProd});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscarProdutosPedido.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBuscarProdutosPedido.Location = new System.Drawing.Point(9, 52);
            this.dgvBuscarProdutosPedido.MultiSelect = false;
            this.dgvBuscarProdutosPedido.Name = "dgvBuscarProdutosPedido";
            this.dgvBuscarProdutosPedido.ReadOnly = true;
            this.dgvBuscarProdutosPedido.RowHeadersVisible = false;
            this.dgvBuscarProdutosPedido.RowHeadersWidth = 5;
            this.dgvBuscarProdutosPedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuscarProdutosPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarProdutosPedido.Size = new System.Drawing.Size(715, 183);
            this.dgvBuscarProdutosPedido.TabIndex = 62;
            this.dgvBuscarProdutosPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarProdutosPedido_CellClick);
            // 
            // colIdProd
            // 
            this.colIdProd.DataPropertyName = "ID_PRODUTO";
            this.colIdProd.HeaderText = "ID";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.ReadOnly = true;
            this.colIdProd.Width = 55;
            // 
            // colNomeProd__
            // 
            this.colNomeProd__.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeProd__.DataPropertyName = "NOME_PRODUTO";
            this.colNomeProd__.HeaderText = "Nome do Produto";
            this.colNomeProd__.Name = "colNomeProd__";
            this.colNomeProd__.ReadOnly = true;
            // 
            // colValorProd
            // 
            this.colValorProd.DataPropertyName = "VALOR_PRODUTO";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.colValorProd.DefaultCellStyle = dataGridViewCellStyle3;
            this.colValorProd.HeaderText = "Valor";
            this.colValorProd.Name = "colValorProd";
            this.colValorProd.ReadOnly = true;
            this.colValorProd.Width = 70;
            // 
            // colQuantProd
            // 
            this.colQuantProd.DataPropertyName = "QUANT_PROD";
            this.colQuantProd.HeaderText = "Qtd";
            this.colQuantProd.Name = "colQuantProd";
            this.colQuantProd.ReadOnly = true;
            this.colQuantProd.Width = 35;
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
            this.ibtnSelecionarProduto.Location = new System.Drawing.Point(529, 6);
            this.ibtnSelecionarProduto.Name = "ibtnSelecionarProduto";
            this.ibtnSelecionarProduto.Rotation = 0D;
            this.ibtnSelecionarProduto.Size = new System.Drawing.Size(195, 42);
            this.ibtnSelecionarProduto.TabIndex = 63;
            this.ibtnSelecionarProduto.Text = "Selecionar";
            this.ibtnSelecionarProduto.UseVisualStyleBackColor = false;
            this.ibtnSelecionarProduto.Click += new System.EventHandler(this.ibtnSelecionarProduto_Click);
            // 
            // BuscarProdutoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 241);
            this.Controls.Add(this.cbBuscarProduto);
            this.Controls.Add(this.ibtnSelecionarProduto);
            this.Controls.Add(this.dgvBuscarProdutosPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarProdutoPedido";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Produto - Em Estoque";
            this.Load += new System.EventHandler(this.BuscarProdutoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProdutosPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBuscarProduto;
        private FontAwesome.Sharp.IconButton ibtnSelecionarProduto;
        private System.Windows.Forms.DataGridView dgvBuscarProdutosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProd__;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantProd;
    }
}