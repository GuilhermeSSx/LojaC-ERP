namespace Loja.GUI.ESTOQUE_PRODUTOS
{
    partial class AumentarDiminuirEstoque
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
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ibtnAumentarDiminuir = new FontAwesome.Sharp.IconButton();
            this.cbQuantidadeProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.Location = new System.Drawing.Point(0, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(607, 35);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "-NOME PRODUTO-";
            this.lblNomeProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNomeProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 35);
            this.panel1.TabIndex = 1;
            // 
            // ibtnAumentarDiminuir
            // 
            this.ibtnAumentarDiminuir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAumentarDiminuir.BackColor = System.Drawing.Color.DarkOrchid;
            this.ibtnAumentarDiminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAumentarDiminuir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAumentarDiminuir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAumentarDiminuir.ForeColor = System.Drawing.Color.White;
            this.ibtnAumentarDiminuir.IconChar = FontAwesome.Sharp.IconChar.Sort;
            this.ibtnAumentarDiminuir.IconColor = System.Drawing.Color.White;
            this.ibtnAumentarDiminuir.IconSize = 30;
            this.ibtnAumentarDiminuir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAumentarDiminuir.Location = new System.Drawing.Point(345, 39);
            this.ibtnAumentarDiminuir.Name = "ibtnAumentarDiminuir";
            this.ibtnAumentarDiminuir.Rotation = 0D;
            this.ibtnAumentarDiminuir.Size = new System.Drawing.Size(246, 43);
            this.ibtnAumentarDiminuir.TabIndex = 61;
            this.ibtnAumentarDiminuir.Text = "Aumentar | Diminuir";
            this.ibtnAumentarDiminuir.UseVisualStyleBackColor = false;
            this.ibtnAumentarDiminuir.Click += new System.EventHandler(this.ibtnAumentarDiminuir_Click);
            // 
            // cbQuantidadeProduto
            // 
            this.cbQuantidadeProduto.DropDownHeight = 242;
            this.cbQuantidadeProduto.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantidadeProduto.FormattingEnabled = true;
            this.cbQuantidadeProduto.IntegralHeight = false;
            this.cbQuantidadeProduto.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cbQuantidadeProduto.Location = new System.Drawing.Point(152, 45);
            this.cbQuantidadeProduto.MaxLength = 5;
            this.cbQuantidadeProduto.Name = "cbQuantidadeProduto";
            this.cbQuantidadeProduto.Size = new System.Drawing.Size(170, 33);
            this.cbQuantidadeProduto.TabIndex = 63;
            this.cbQuantidadeProduto.TextChanged += new System.EventHandler(this.cbQuantidadeProduto_TextChanged);
            this.cbQuantidadeProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbQuantidadeProduto_KeyDown);
            this.cbQuantidadeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbQuantidadeProduto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Quantidade";
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduto.Location = new System.Drawing.Point(1, 38);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(12, 15);
            this.lblIdProduto.TabIndex = 64;
            this.lblIdProduto.Text = "-";
            this.lblIdProduto.Visible = false;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.Location = new System.Drawing.Point(19, 37);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(12, 15);
            this.lblValorCompra.TabIndex = 65;
            this.lblValorCompra.Text = "-";
            this.lblValorCompra.Visible = false;
            // 
            // AumentarDiminuirEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 88);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.cbQuantidadeProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ibtnAumentarDiminuir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AumentarDiminuirEstoque";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aumentar | Diminuir Produto";
            this.Load += new System.EventHandler(this.AumentarDiminuirEstoque_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton ibtnAumentarDiminuir;
        private System.Windows.Forms.ComboBox cbQuantidadeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.Label lblValorCompra;
    }
}