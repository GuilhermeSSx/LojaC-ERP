
namespace Loja.GUI.ESTOQUE_PRODUTOS
{
    partial class MarcaProduto
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
            this.tbMarcaProduto = new System.Windows.Forms.TextBox();
            this.dgvMarcaProduto = new System.Windows.Forms.DataGridView();
            this.colIdTipoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnRemoverMarcaProd = new FontAwesome.Sharp.IconButton();
            this.ibtnNovaMarcaProd = new FontAwesome.Sharp.IconButton();
            this.lblIdMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMarcaProduto
            // 
            this.tbMarcaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMarcaProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarcaProduto.Location = new System.Drawing.Point(12, 12);
            this.tbMarcaProduto.MaxLength = 20;
            this.tbMarcaProduto.Name = "tbMarcaProduto";
            this.tbMarcaProduto.ShortcutsEnabled = false;
            this.tbMarcaProduto.Size = new System.Drawing.Size(198, 29);
            this.tbMarcaProduto.TabIndex = 83;
            this.tbMarcaProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMarcaProduto_KeyPress);
            // 
            // dgvMarcaProduto
            // 
            this.dgvMarcaProduto.AllowUserToAddRows = false;
            this.dgvMarcaProduto.AllowUserToDeleteRows = false;
            this.dgvMarcaProduto.AllowUserToResizeColumns = false;
            this.dgvMarcaProduto.AllowUserToResizeRows = false;
            this.dgvMarcaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarcaProduto.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.dgvMarcaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTipoProd,
            this.colTipoProd});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarcaProduto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarcaProduto.Location = new System.Drawing.Point(12, 96);
            this.dgvMarcaProduto.MultiSelect = false;
            this.dgvMarcaProduto.Name = "dgvMarcaProduto";
            this.dgvMarcaProduto.ReadOnly = true;
            this.dgvMarcaProduto.RowHeadersVisible = false;
            this.dgvMarcaProduto.RowHeadersWidth = 25;
            this.dgvMarcaProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMarcaProduto.Size = new System.Drawing.Size(198, 377);
            this.dgvMarcaProduto.TabIndex = 80;
            this.dgvMarcaProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarcaProduto_CellClick);
            // 
            // colIdTipoProd
            // 
            this.colIdTipoProd.DataPropertyName = "ID_MARCA_PRODUTO";
            this.colIdTipoProd.HeaderText = "ID";
            this.colIdTipoProd.Name = "colIdTipoProd";
            this.colIdTipoProd.ReadOnly = true;
            this.colIdTipoProd.Visible = false;
            // 
            // colTipoProd
            // 
            this.colTipoProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoProd.DataPropertyName = "NOME_MARCA";
            this.colTipoProd.HeaderText = "Nome Marca";
            this.colTipoProd.Name = "colTipoProd";
            this.colTipoProd.ReadOnly = true;
            // 
            // ibtnRemoverMarcaProd
            // 
            this.ibtnRemoverMarcaProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnRemoverMarcaProd.BackColor = System.Drawing.Color.Red;
            this.ibtnRemoverMarcaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRemoverMarcaProd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnRemoverMarcaProd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRemoverMarcaProd.ForeColor = System.Drawing.Color.White;
            this.ibtnRemoverMarcaProd.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ibtnRemoverMarcaProd.IconColor = System.Drawing.Color.White;
            this.ibtnRemoverMarcaProd.IconSize = 30;
            this.ibtnRemoverMarcaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnRemoverMarcaProd.Location = new System.Drawing.Point(12, 479);
            this.ibtnRemoverMarcaProd.Name = "ibtnRemoverMarcaProd";
            this.ibtnRemoverMarcaProd.Rotation = 0D;
            this.ibtnRemoverMarcaProd.Size = new System.Drawing.Size(198, 43);
            this.ibtnRemoverMarcaProd.TabIndex = 82;
            this.ibtnRemoverMarcaProd.Text = "Remover Marca";
            this.ibtnRemoverMarcaProd.UseVisualStyleBackColor = false;
            this.ibtnRemoverMarcaProd.Click += new System.EventHandler(this.ibtnRemoverMarcaProd_Click);
            // 
            // ibtnNovaMarcaProd
            // 
            this.ibtnNovaMarcaProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnNovaMarcaProd.BackColor = System.Drawing.Color.SeaGreen;
            this.ibtnNovaMarcaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNovaMarcaProd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnNovaMarcaProd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnNovaMarcaProd.ForeColor = System.Drawing.Color.White;
            this.ibtnNovaMarcaProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnNovaMarcaProd.IconColor = System.Drawing.Color.White;
            this.ibtnNovaMarcaProd.IconSize = 30;
            this.ibtnNovaMarcaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnNovaMarcaProd.Location = new System.Drawing.Point(12, 47);
            this.ibtnNovaMarcaProd.Name = "ibtnNovaMarcaProd";
            this.ibtnNovaMarcaProd.Rotation = 0D;
            this.ibtnNovaMarcaProd.Size = new System.Drawing.Size(198, 43);
            this.ibtnNovaMarcaProd.TabIndex = 81;
            this.ibtnNovaMarcaProd.Text = "Nova Marca Prod";
            this.ibtnNovaMarcaProd.UseVisualStyleBackColor = false;
            this.ibtnNovaMarcaProd.Click += new System.EventHandler(this.ibtnNovaMarcaProd_Click);
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(106, 525);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(13, 13);
            this.lblIdMarca.TabIndex = 84;
            this.lblIdMarca.Text = "=";
            this.lblIdMarca.Visible = false;
            // 
            // MarcaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 534);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.tbMarcaProduto);
            this.Controls.Add(this.ibtnRemoverMarcaProd);
            this.Controls.Add(this.ibtnNovaMarcaProd);
            this.Controls.Add(this.dgvMarcaProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarcaProduto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarcaProduto";
            this.Load += new System.EventHandler(this.MarcaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarcaProduto;
        private FontAwesome.Sharp.IconButton ibtnRemoverMarcaProd;
        private FontAwesome.Sharp.IconButton ibtnNovaMarcaProd;
        private System.Windows.Forms.DataGridView dgvMarcaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTipoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoProd;
        private System.Windows.Forms.Label lblIdMarca;
    }
}