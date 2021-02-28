
namespace Loja.GUI.ESTOQUE_PRODUTOS
{
    partial class TipoProduto
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
            this.dgvTipoProduto = new System.Windows.Forms.DataGridView();
            this.colIdTipoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnNovoTipoProd = new FontAwesome.Sharp.IconButton();
            this.ibtnRemoverTipoProd = new FontAwesome.Sharp.IconButton();
            this.tbTipoProduto = new System.Windows.Forms.TextBox();
            this.lblIdTipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoProduto
            // 
            this.dgvTipoProduto.AllowUserToAddRows = false;
            this.dgvTipoProduto.AllowUserToDeleteRows = false;
            this.dgvTipoProduto.AllowUserToResizeColumns = false;
            this.dgvTipoProduto.AllowUserToResizeRows = false;
            this.dgvTipoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoProduto.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.dgvTipoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTipoProd,
            this.colTipoProd});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoProduto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoProduto.Location = new System.Drawing.Point(12, 96);
            this.dgvTipoProduto.MultiSelect = false;
            this.dgvTipoProduto.Name = "dgvTipoProduto";
            this.dgvTipoProduto.ReadOnly = true;
            this.dgvTipoProduto.RowHeadersVisible = false;
            this.dgvTipoProduto.RowHeadersWidth = 25;
            this.dgvTipoProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTipoProduto.Size = new System.Drawing.Size(198, 377);
            this.dgvTipoProduto.TabIndex = 74;
            this.dgvTipoProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoProduto_CellClick);
            // 
            // colIdTipoProd
            // 
            this.colIdTipoProd.DataPropertyName = "ID_TIPO_PRODUTO";
            this.colIdTipoProd.HeaderText = "ID";
            this.colIdTipoProd.Name = "colIdTipoProd";
            this.colIdTipoProd.ReadOnly = true;
            this.colIdTipoProd.Visible = false;
            // 
            // colTipoProd
            // 
            this.colTipoProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoProd.DataPropertyName = "NOME_TIPO";
            this.colTipoProd.HeaderText = "Tipo Produto";
            this.colTipoProd.Name = "colTipoProd";
            this.colTipoProd.ReadOnly = true;
            // 
            // ibtnNovoTipoProd
            // 
            this.ibtnNovoTipoProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnNovoTipoProd.BackColor = System.Drawing.Color.SeaGreen;
            this.ibtnNovoTipoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNovoTipoProd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnNovoTipoProd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnNovoTipoProd.ForeColor = System.Drawing.Color.White;
            this.ibtnNovoTipoProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnNovoTipoProd.IconColor = System.Drawing.Color.White;
            this.ibtnNovoTipoProd.IconSize = 30;
            this.ibtnNovoTipoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnNovoTipoProd.Location = new System.Drawing.Point(12, 47);
            this.ibtnNovoTipoProd.Name = "ibtnNovoTipoProd";
            this.ibtnNovoTipoProd.Rotation = 0D;
            this.ibtnNovoTipoProd.Size = new System.Drawing.Size(198, 43);
            this.ibtnNovoTipoProd.TabIndex = 76;
            this.ibtnNovoTipoProd.Text = "Novo Tipo Prod";
            this.ibtnNovoTipoProd.UseVisualStyleBackColor = false;
            this.ibtnNovoTipoProd.Click += new System.EventHandler(this.ibtnNovoTipoProd_Click);
            // 
            // ibtnRemoverTipoProd
            // 
            this.ibtnRemoverTipoProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnRemoverTipoProd.BackColor = System.Drawing.Color.Red;
            this.ibtnRemoverTipoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRemoverTipoProd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnRemoverTipoProd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRemoverTipoProd.ForeColor = System.Drawing.Color.White;
            this.ibtnRemoverTipoProd.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ibtnRemoverTipoProd.IconColor = System.Drawing.Color.White;
            this.ibtnRemoverTipoProd.IconSize = 30;
            this.ibtnRemoverTipoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnRemoverTipoProd.Location = new System.Drawing.Point(12, 479);
            this.ibtnRemoverTipoProd.Name = "ibtnRemoverTipoProd";
            this.ibtnRemoverTipoProd.Rotation = 0D;
            this.ibtnRemoverTipoProd.Size = new System.Drawing.Size(198, 43);
            this.ibtnRemoverTipoProd.TabIndex = 77;
            this.ibtnRemoverTipoProd.Text = "Remover Tipo";
            this.ibtnRemoverTipoProd.UseVisualStyleBackColor = false;
            this.ibtnRemoverTipoProd.Click += new System.EventHandler(this.ibtnRemoverTipoProd_Click);
            // 
            // tbTipoProduto
            // 
            this.tbTipoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTipoProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTipoProduto.Location = new System.Drawing.Point(12, 12);
            this.tbTipoProduto.MaxLength = 20;
            this.tbTipoProduto.Name = "tbTipoProduto";
            this.tbTipoProduto.ShortcutsEnabled = false;
            this.tbTipoProduto.Size = new System.Drawing.Size(198, 29);
            this.tbTipoProduto.TabIndex = 79;
            this.tbTipoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTipoProduto_KeyPress);
            // 
            // lblIdTipo
            // 
            this.lblIdTipo.AutoSize = true;
            this.lblIdTipo.Location = new System.Drawing.Point(96, 525);
            this.lblIdTipo.Name = "lblIdTipo";
            this.lblIdTipo.Size = new System.Drawing.Size(13, 13);
            this.lblIdTipo.TabIndex = 80;
            this.lblIdTipo.Text = "=";
            this.lblIdTipo.Visible = false;
            // 
            // TipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 534);
            this.Controls.Add(this.lblIdTipo);
            this.Controls.Add(this.tbTipoProduto);
            this.Controls.Add(this.ibtnRemoverTipoProd);
            this.Controls.Add(this.ibtnNovoTipoProd);
            this.Controls.Add(this.dgvTipoProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Produto";
            this.Load += new System.EventHandler(this.TipoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoProduto;
        private FontAwesome.Sharp.IconButton ibtnNovoTipoProd;
        private FontAwesome.Sharp.IconButton ibtnRemoverTipoProd;
        private System.Windows.Forms.TextBox tbTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTipoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoProd;
        private System.Windows.Forms.Label lblIdTipo;
    }
}