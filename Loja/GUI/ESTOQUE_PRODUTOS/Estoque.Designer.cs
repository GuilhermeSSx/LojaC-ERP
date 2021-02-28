namespace Loja
{
    partial class Estoque
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTamanhoProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbQuantidadeProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataEntradaProduto = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbValorComprado = new System.Windows.Forms.TextBox();
            this.tbValorProduto = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuanProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdProdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPatrimonioTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblQuantTotalProd = new System.Windows.Forms.Label();
            this.lblQuantTipoProdutos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBuscarTipoProduto = new System.Windows.Forms.ComboBox();
            this.cbBuscarMarca = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDescricaoNomeProduto = new System.Windows.Forms.TextBox();
            this.painelGeral = new System.Windows.Forms.Panel();
            this.panelAdicionarProduto = new System.Windows.Forms.Panel();
            this.dgvBuscarMarca = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBuscarTipoProduto = new System.Windows.Forms.DataGridView();
            this.colTipoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkMarca = new System.Windows.Forms.LinkLabel();
            this.linkTipoProduto = new System.Windows.Forms.LinkLabel();
            this.tbRefProduto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ibtnAddNovoProduto = new FontAwesome.Sharp.IconButton();
            this.pbBarcodeProduto = new System.Windows.Forms.PictureBox();
            this.ibtnAdicionarEstoque = new FontAwesome.Sharp.IconButton();
            this.timerBtn = new System.Windows.Forms.Timer(this.components);
            this.ibtnAumentarDiminuir = new FontAwesome.Sharp.IconButton();
            this.ibtnBuscarProduto = new FontAwesome.Sharp.IconButton();
            this.ibtnGerarCodigoBarras = new FontAwesome.Sharp.IconButton();
            this.ibtnRemoverCliente = new FontAwesome.Sharp.IconButton();
            this.ibtnAlterarProduto = new FontAwesome.Sharp.IconButton();
            this.bdLojaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.panel1.SuspendLayout();
            this.painelGeral.SuspendLayout();
            this.panelAdicionarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarTipoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcodeProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLojaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome do Produto";
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.BackColor = System.Drawing.Color.DarkViolet;
            this.tbNomeProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeProduto.ForeColor = System.Drawing.Color.White;
            this.tbNomeProduto.Location = new System.Drawing.Point(426, 151);
            this.tbNomeProduto.MaxLength = 79;
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.ShortcutsEnabled = false;
            this.tbNomeProduto.Size = new System.Drawing.Size(561, 29);
            this.tbNomeProduto.TabIndex = 21;
            this.tbNomeProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomeProduto_KeyDown);
            this.tbNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomeProduto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(771, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tamanho";
            // 
            // cbTamanhoProduto
            // 
            this.cbTamanhoProduto.DropDownHeight = 450;
            this.cbTamanhoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTamanhoProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamanhoProduto.FormattingEnabled = true;
            this.cbTamanhoProduto.IntegralHeight = false;
            this.cbTamanhoProduto.ItemHeight = 21;
            this.cbTamanhoProduto.Items.AddRange(new object[] {
            "PP",
            "P",
            "M",
            "G",
            "GG",
            "G1",
            "G2",
            "G3",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50",
            "52",
            "54",
            "",
            "unico"});
            this.cbTamanhoProduto.Location = new System.Drawing.Point(870, 42);
            this.cbTamanhoProduto.Name = "cbTamanhoProduto";
            this.cbTamanhoProduto.Size = new System.Drawing.Size(121, 29);
            this.cbTamanhoProduto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1040, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quantidade";
            // 
            // cbQuantidadeProduto
            // 
            this.cbQuantidadeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuantidadeProduto.DropDownHeight = 320;
            this.cbQuantidadeProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantidadeProduto.FormattingEnabled = true;
            this.cbQuantidadeProduto.IntegralHeight = false;
            this.cbQuantidadeProduto.Items.AddRange(new object[] {
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
            this.cbQuantidadeProduto.Location = new System.Drawing.Point(1161, 43);
            this.cbQuantidadeProduto.MaxLength = 5;
            this.cbQuantidadeProduto.Name = "cbQuantidadeProduto";
            this.cbQuantidadeProduto.Size = new System.Drawing.Size(79, 29);
            this.cbQuantidadeProduto.TabIndex = 5;
            this.cbQuantidadeProduto.TextChanged += new System.EventHandler(this.cbQuantidadeProduto_TextChanged);
            this.cbQuantidadeProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbQuantidadeProduto_KeyDown);
            this.cbQuantidadeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbQuantidadeProduto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor Custo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Valor Produto";
            // 
            // dtpDataEntradaProduto
            // 
            this.dtpDataEntradaProduto.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dtpDataEntradaProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEntradaProduto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntradaProduto.Location = new System.Drawing.Point(870, 80);
            this.dtpDataEntradaProduto.Name = "dtpDataEntradaProduto";
            this.dtpDataEntradaProduto.Size = new System.Drawing.Size(121, 29);
            this.dtpDataEntradaProduto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(719, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data de Entrada";
            // 
            // tbValorComprado
            // 
            this.tbValorComprado.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorComprado.Location = new System.Drawing.Point(162, 115);
            this.tbValorComprado.MaxLength = 12;
            this.tbValorComprado.Name = "tbValorComprado";
            this.tbValorComprado.ShortcutsEnabled = false;
            this.tbValorComprado.Size = new System.Drawing.Size(92, 29);
            this.tbValorComprado.TabIndex = 8;
            this.tbValorComprado.TextChanged += new System.EventHandler(this.tbValorComprado_TextChanged);
            this.tbValorComprado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorComprado_KeyPress);
            // 
            // tbValorProduto
            // 
            this.tbValorProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorProduto.Location = new System.Drawing.Point(162, 151);
            this.tbValorProduto.MaxLength = 12;
            this.tbValorProduto.Name = "tbValorProduto";
            this.tbValorProduto.ShortcutsEnabled = false;
            this.tbValorProduto.Size = new System.Drawing.Size(92, 29);
            this.tbValorProduto.TabIndex = 9;
            this.tbValorProduto.TextChanged += new System.EventHandler(this.tbValorProduto_TextChanged);
            this.tbValorProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValorProduto_KeyDown);
            this.tbValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValorProduto_KeyPress);
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduto.Location = new System.Drawing.Point(297, -4);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(131, 20);
            this.lblIdProduto.TabIndex = 56;
            this.lblIdProduto.Text = "-ID PRODUTO-";
            this.lblIdProduto.Visible = false;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToResizeColumns = false;
            this.dgvEstoque.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeProduto,
            this.Tamanho,
            this.QuanProd,
            this.ValorCompra,
            this.ValorProduto,
            this.DataEntrada,
            this.colIdProdd});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstoque.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstoque.Location = new System.Drawing.Point(0, 40);
            this.dgvEstoque.MultiSelect = false;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.RowHeadersWidth = 20;
            this.dgvEstoque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(1260, 438);
            this.dgvEstoque.TabIndex = 19;
            this.dgvEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellClick);
            this.dgvEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEstoque_KeyDown);
            // 
            // NomeProduto
            // 
            this.NomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeProduto.DataPropertyName = "NOME_PRODUTO";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.NomeProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomeProduto.HeaderText = "Nome do Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "TAMANHO";
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.ReadOnly = true;
            this.Tamanho.Width = 80;
            // 
            // QuanProd
            // 
            this.QuanProd.DataPropertyName = "QUANT_PROD";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.OrangeRed;
            this.QuanProd.DefaultCellStyle = dataGridViewCellStyle4;
            this.QuanProd.HeaderText = "Quant";
            this.QuanProd.Name = "QuanProd";
            this.QuanProd.ReadOnly = true;
            this.QuanProd.Width = 80;
            // 
            // ValorCompra
            // 
            this.ValorCompra.DataPropertyName = "VALOR_COMPRA";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ValorCompra.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValorCompra.HeaderText = "Valor de Custo";
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.ReadOnly = true;
            this.ValorCompra.Width = 130;
            // 
            // ValorProduto
            // 
            this.ValorProduto.DataPropertyName = "VALOR_PRODUTO";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.ValorProduto.DefaultCellStyle = dataGridViewCellStyle6;
            this.ValorProduto.HeaderText = "Valor do Produto";
            this.ValorProduto.Name = "ValorProduto";
            this.ValorProduto.ReadOnly = true;
            this.ValorProduto.Width = 130;
            // 
            // DataEntrada
            // 
            this.DataEntrada.DataPropertyName = "DATA_ENTRADA";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.DataEntrada.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataEntrada.HeaderText = "Ultima Data de Entrada";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.ReadOnly = true;
            this.DataEntrada.Width = 150;
            // 
            // colIdProdd
            // 
            this.colIdProdd.DataPropertyName = "ID_PRODUTO";
            this.colIdProdd.HeaderText = "ID";
            this.colIdProdd.Name = "colIdProdd";
            this.colIdProdd.ReadOnly = true;
            this.colIdProdd.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPatrimonioTotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblQuantTotalProd);
            this.panel1.Controls.Add(this.lblQuantTipoProdutos);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 33);
            this.panel1.TabIndex = 61;
            // 
            // lblPatrimonioTotal
            // 
            this.lblPatrimonioTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatrimonioTotal.AutoSize = true;
            this.lblPatrimonioTotal.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatrimonioTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblPatrimonioTotal.Location = new System.Drawing.Point(1099, 5);
            this.lblPatrimonioTotal.Name = "lblPatrimonioTotal";
            this.lblPatrimonioTotal.Size = new System.Drawing.Size(20, 20);
            this.lblPatrimonioTotal.TabIndex = 33;
            this.lblPatrimonioTotal.Text = "=";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(911, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Patrimônio Total:";
            // 
            // lblQuantTotalProd
            // 
            this.lblQuantTotalProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantTotalProd.AutoSize = true;
            this.lblQuantTotalProd.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantTotalProd.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblQuantTotalProd.Location = new System.Drawing.Point(801, 5);
            this.lblQuantTotalProd.Name = "lblQuantTotalProd";
            this.lblQuantTotalProd.Size = new System.Drawing.Size(20, 20);
            this.lblQuantTotalProd.TabIndex = 31;
            this.lblQuantTotalProd.Text = "=";
            // 
            // lblQuantTipoProdutos
            // 
            this.lblQuantTipoProdutos.AutoSize = true;
            this.lblQuantTipoProdutos.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantTipoProdutos.Location = new System.Drawing.Point(153, 5);
            this.lblQuantTipoProdutos.Name = "lblQuantTipoProdutos";
            this.lblQuantTipoProdutos.Size = new System.Drawing.Size(20, 20);
            this.lblQuantTipoProdutos.TabIndex = 30;
            this.lblQuantTipoProdutos.Text = "=";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(644, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Quant. Total Prod:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Quant. Tipos Prod:";
            // 
            // cbBuscarTipoProduto
            // 
            this.cbBuscarTipoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscarTipoProduto.DropDownHeight = 320;
            this.cbBuscarTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbBuscarTipoProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarTipoProduto.FormattingEnabled = true;
            this.cbBuscarTipoProduto.IntegralHeight = false;
            this.cbBuscarTipoProduto.Location = new System.Drawing.Point(162, 42);
            this.cbBuscarTipoProduto.MaxLength = 25;
            this.cbBuscarTipoProduto.Name = "cbBuscarTipoProduto";
            this.cbBuscarTipoProduto.Size = new System.Drawing.Size(211, 29);
            this.cbBuscarTipoProduto.TabIndex = 2;
            this.cbBuscarTipoProduto.TextChanged += new System.EventHandler(this.cbBuscarTipoProduto_TextChanged);
            this.cbBuscarTipoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBuscarTipoProduto_KeyDown);
            // 
            // cbBuscarMarca
            // 
            this.cbBuscarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscarMarca.DropDownHeight = 320;
            this.cbBuscarMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbBuscarMarca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarMarca.FormattingEnabled = true;
            this.cbBuscarMarca.IntegralHeight = false;
            this.cbBuscarMarca.Location = new System.Drawing.Point(162, 79);
            this.cbBuscarMarca.MaxLength = 25;
            this.cbBuscarMarca.Name = "cbBuscarMarca";
            this.cbBuscarMarca.Size = new System.Drawing.Size(146, 29);
            this.cbBuscarMarca.TabIndex = 6;
            this.cbBuscarMarca.TextChanged += new System.EventHandler(this.cbBuscarMarca_TextChanged);
            this.cbBuscarMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbBuscarMarca_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(388, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 21);
            this.label12.TabIndex = 66;
            this.label12.Text = "Descrição";
            // 
            // tbDescricaoNomeProduto
            // 
            this.tbDescricaoNomeProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescricaoNomeProduto.Location = new System.Drawing.Point(494, 42);
            this.tbDescricaoNomeProduto.MaxLength = 30;
            this.tbDescricaoNomeProduto.Name = "tbDescricaoNomeProduto";
            this.tbDescricaoNomeProduto.ShortcutsEnabled = false;
            this.tbDescricaoNomeProduto.Size = new System.Drawing.Size(271, 29);
            this.tbDescricaoNomeProduto.TabIndex = 3;
            this.tbDescricaoNomeProduto.TextChanged += new System.EventHandler(this.tbDescricaoNomeProduto_TextChanged);
            this.tbDescricaoNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescricaoNomeProduto_KeyPress);
            // 
            // painelGeral
            // 
            this.painelGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelGeral.Controls.Add(this.dgvEstoque);
            this.painelGeral.Controls.Add(this.panelAdicionarProduto);
            this.painelGeral.Location = new System.Drawing.Point(12, 12);
            this.painelGeral.Name = "painelGeral";
            this.painelGeral.Size = new System.Drawing.Size(1260, 478);
            this.painelGeral.TabIndex = 68;
            // 
            // panelAdicionarProduto
            // 
            this.panelAdicionarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.panelAdicionarProduto.Controls.Add(this.dgvBuscarMarca);
            this.panelAdicionarProduto.Controls.Add(this.dgvBuscarTipoProduto);
            this.panelAdicionarProduto.Controls.Add(this.linkMarca);
            this.panelAdicionarProduto.Controls.Add(this.linkTipoProduto);
            this.panelAdicionarProduto.Controls.Add(this.tbRefProduto);
            this.panelAdicionarProduto.Controls.Add(this.label13);
            this.panelAdicionarProduto.Controls.Add(this.ibtnAddNovoProduto);
            this.panelAdicionarProduto.Controls.Add(this.cbBuscarTipoProduto);
            this.panelAdicionarProduto.Controls.Add(this.cbBuscarMarca);
            this.panelAdicionarProduto.Controls.Add(this.tbDescricaoNomeProduto);
            this.panelAdicionarProduto.Controls.Add(this.label4);
            this.panelAdicionarProduto.Controls.Add(this.pbBarcodeProduto);
            this.panelAdicionarProduto.Controls.Add(this.cbQuantidadeProduto);
            this.panelAdicionarProduto.Controls.Add(this.dtpDataEntradaProduto);
            this.panelAdicionarProduto.Controls.Add(this.label3);
            this.panelAdicionarProduto.Controls.Add(this.label6);
            this.panelAdicionarProduto.Controls.Add(this.ibtnAdicionarEstoque);
            this.panelAdicionarProduto.Controls.Add(this.label12);
            this.panelAdicionarProduto.Controls.Add(this.tbValorComprado);
            this.panelAdicionarProduto.Controls.Add(this.label5);
            this.panelAdicionarProduto.Controls.Add(this.tbValorProduto);
            this.panelAdicionarProduto.Controls.Add(this.label1);
            this.panelAdicionarProduto.Controls.Add(this.tbNomeProduto);
            this.panelAdicionarProduto.Controls.Add(this.label2);
            this.panelAdicionarProduto.Controls.Add(this.cbTamanhoProduto);
            this.panelAdicionarProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdicionarProduto.Location = new System.Drawing.Point(0, 0);
            this.panelAdicionarProduto.MaximumSize = new System.Drawing.Size(1260, 190);
            this.panelAdicionarProduto.MinimumSize = new System.Drawing.Size(1260, 40);
            this.panelAdicionarProduto.Name = "panelAdicionarProduto";
            this.panelAdicionarProduto.Size = new System.Drawing.Size(1260, 40);
            this.panelAdicionarProduto.TabIndex = 1;
            // 
            // dgvBuscarMarca
            // 
            this.dgvBuscarMarca.AllowUserToAddRows = false;
            this.dgvBuscarMarca.AllowUserToDeleteRows = false;
            this.dgvBuscarMarca.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.dgvBuscarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMarca.ColumnHeadersVisible = false;
            this.dgvBuscarMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscarMarca.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBuscarMarca.Location = new System.Drawing.Point(162, 108);
            this.dgvBuscarMarca.Name = "dgvBuscarMarca";
            this.dgvBuscarMarca.ReadOnly = true;
            this.dgvBuscarMarca.RowHeadersVisible = false;
            this.dgvBuscarMarca.RowHeadersWidth = 5;
            this.dgvBuscarMarca.Size = new System.Drawing.Size(189, 73);
            this.dgvBuscarMarca.TabIndex = 74;
            this.dgvBuscarMarca.Visible = false;
            this.dgvBuscarMarca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarMarca_CellClick);
            this.dgvBuscarMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBuscarMarca_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NOME_MARCA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome Marca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvBuscarTipoProduto
            // 
            this.dgvBuscarTipoProduto.AllowUserToAddRows = false;
            this.dgvBuscarTipoProduto.AllowUserToDeleteRows = false;
            this.dgvBuscarTipoProduto.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.dgvBuscarTipoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarTipoProduto.ColumnHeadersVisible = false;
            this.dgvBuscarTipoProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipoProd});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuscarTipoProduto.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBuscarTipoProduto.Location = new System.Drawing.Point(162, 71);
            this.dgvBuscarTipoProduto.Name = "dgvBuscarTipoProduto";
            this.dgvBuscarTipoProduto.ReadOnly = true;
            this.dgvBuscarTipoProduto.RowHeadersVisible = false;
            this.dgvBuscarTipoProduto.RowHeadersWidth = 5;
            this.dgvBuscarTipoProduto.Size = new System.Drawing.Size(211, 109);
            this.dgvBuscarTipoProduto.TabIndex = 73;
            this.dgvBuscarTipoProduto.Visible = false;
            this.dgvBuscarTipoProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarTipoProduto_CellClick);
            this.dgvBuscarTipoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBuscarTipoProduto_KeyDown);
            // 
            // colTipoProd
            // 
            this.colTipoProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipoProd.DataPropertyName = "NOME_TIPO";
            this.colTipoProd.HeaderText = "Tipo Produto";
            this.colTipoProd.Name = "colTipoProd";
            this.colTipoProd.ReadOnly = true;
            // 
            // linkMarca
            // 
            this.linkMarca.AutoSize = true;
            this.linkMarca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.linkMarca.LinkColor = System.Drawing.Color.Black;
            this.linkMarca.Location = new System.Drawing.Point(15, 83);
            this.linkMarca.Name = "linkMarca";
            this.linkMarca.Size = new System.Drawing.Size(57, 21);
            this.linkMarca.TabIndex = 72;
            this.linkMarca.TabStop = true;
            this.linkMarca.Text = "Marca";
            this.linkMarca.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMarca_LinkClicked);
            // 
            // linkTipoProduto
            // 
            this.linkTipoProduto.AutoSize = true;
            this.linkTipoProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.linkTipoProduto.LinkColor = System.Drawing.Color.Black;
            this.linkTipoProduto.Location = new System.Drawing.Point(15, 45);
            this.linkTipoProduto.Name = "linkTipoProduto";
            this.linkTipoProduto.Size = new System.Drawing.Size(133, 21);
            this.linkTipoProduto.TabIndex = 71;
            this.linkTipoProduto.TabStop = true;
            this.linkTipoProduto.Text = "Tipo de Produto";
            this.linkTipoProduto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTipoProduto_LinkClicked);
            // 
            // tbRefProduto
            // 
            this.tbRefProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRefProduto.Location = new System.Drawing.Point(494, 80);
            this.tbRefProduto.MaxLength = 4;
            this.tbRefProduto.Name = "tbRefProduto";
            this.tbRefProduto.ShortcutsEnabled = false;
            this.tbRefProduto.Size = new System.Drawing.Size(62, 29);
            this.tbRefProduto.TabIndex = 7;
            this.tbRefProduto.TextChanged += new System.EventHandler(this.tbRefProduto_TextChanged);
            this.tbRefProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRefProduto_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(388, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 21);
            this.label13.TabIndex = 69;
            this.label13.Text = "Ref:";
            // 
            // ibtnAddNovoProduto
            // 
            this.ibtnAddNovoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAddNovoProduto.BackColor = System.Drawing.Color.White;
            this.ibtnAddNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAddNovoProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAddNovoProduto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAddNovoProduto.ForeColor = System.Drawing.Color.Black;
            this.ibtnAddNovoProduto.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.ibtnAddNovoProduto.IconColor = System.Drawing.Color.Black;
            this.ibtnAddNovoProduto.IconSize = 30;
            this.ibtnAddNovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAddNovoProduto.Location = new System.Drawing.Point(0, 0);
            this.ibtnAddNovoProduto.Name = "ibtnAddNovoProduto";
            this.ibtnAddNovoProduto.Rotation = 0D;
            this.ibtnAddNovoProduto.Size = new System.Drawing.Size(251, 36);
            this.ibtnAddNovoProduto.TabIndex = 1;
            this.ibtnAddNovoProduto.Text = "Adicionar Novo Produto";
            this.ibtnAddNovoProduto.UseVisualStyleBackColor = false;
            this.ibtnAddNovoProduto.Click += new System.EventHandler(this.ibtnAddNovoProduto_Click);
            // 
            // pbBarcodeProduto
            // 
            this.pbBarcodeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBarcodeProduto.Location = new System.Drawing.Point(1190, 76);
            this.pbBarcodeProduto.Name = "pbBarcodeProduto";
            this.pbBarcodeProduto.Size = new System.Drawing.Size(50, 50);
            this.pbBarcodeProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBarcodeProduto.TabIndex = 55;
            this.pbBarcodeProduto.TabStop = false;
            // 
            // ibtnAdicionarEstoque
            // 
            this.ibtnAdicionarEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAdicionarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnAdicionarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAdicionarEstoque.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAdicionarEstoque.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAdicionarEstoque.ForeColor = System.Drawing.Color.Black;
            this.ibtnAdicionarEstoque.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAdicionarEstoque.IconColor = System.Drawing.Color.Black;
            this.ibtnAdicionarEstoque.IconSize = 30;
            this.ibtnAdicionarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAdicionarEstoque.Location = new System.Drawing.Point(997, 132);
            this.ibtnAdicionarEstoque.Name = "ibtnAdicionarEstoque";
            this.ibtnAdicionarEstoque.Rotation = 0D;
            this.ibtnAdicionarEstoque.Size = new System.Drawing.Size(263, 49);
            this.ibtnAdicionarEstoque.TabIndex = 11;
            this.ibtnAdicionarEstoque.Text = "Adicionar ao Estoque";
            this.ibtnAdicionarEstoque.UseVisualStyleBackColor = false;
            this.ibtnAdicionarEstoque.Click += new System.EventHandler(this.ibtnAdicionarEstoque_Click);
            // 
            // timerBtn
            // 
            this.timerBtn.Enabled = true;
            this.timerBtn.Interval = 15;
            this.timerBtn.Tick += new System.EventHandler(this.timerBtn_Tick);
            // 
            // ibtnAumentarDiminuir
            // 
            this.ibtnAumentarDiminuir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAumentarDiminuir.BackColor = System.Drawing.Color.DarkOrchid;
            this.ibtnAumentarDiminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAumentarDiminuir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAumentarDiminuir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAumentarDiminuir.ForeColor = System.Drawing.Color.White;
            this.ibtnAumentarDiminuir.IconChar = FontAwesome.Sharp.IconChar.Sort;
            this.ibtnAumentarDiminuir.IconColor = System.Drawing.Color.White;
            this.ibtnAumentarDiminuir.IconSize = 30;
            this.ibtnAumentarDiminuir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAumentarDiminuir.Location = new System.Drawing.Point(800, 527);
            this.ibtnAumentarDiminuir.Name = "ibtnAumentarDiminuir";
            this.ibtnAumentarDiminuir.Rotation = 0D;
            this.ibtnAumentarDiminuir.Size = new System.Drawing.Size(472, 43);
            this.ibtnAumentarDiminuir.TabIndex = 60;
            this.ibtnAumentarDiminuir.Text = "Aumentar | Diminuir";
            this.ibtnAumentarDiminuir.UseVisualStyleBackColor = false;
            this.ibtnAumentarDiminuir.Click += new System.EventHandler(this.ibtnAumentarDiminuir_Click);
            // 
            // ibtnBuscarProduto
            // 
            this.ibtnBuscarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnBuscarProduto.BackColor = System.Drawing.SystemColors.Desktop;
            this.ibtnBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBuscarProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnBuscarProduto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnBuscarProduto.ForeColor = System.Drawing.Color.White;
            this.ibtnBuscarProduto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnBuscarProduto.IconColor = System.Drawing.Color.White;
            this.ibtnBuscarProduto.IconSize = 30;
            this.ibtnBuscarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnBuscarProduto.Location = new System.Drawing.Point(490, 527);
            this.ibtnBuscarProduto.Name = "ibtnBuscarProduto";
            this.ibtnBuscarProduto.Rotation = 0D;
            this.ibtnBuscarProduto.Size = new System.Drawing.Size(304, 92);
            this.ibtnBuscarProduto.TabIndex = 58;
            this.ibtnBuscarProduto.Text = "Buscar Produto";
            this.ibtnBuscarProduto.UseVisualStyleBackColor = false;
            this.ibtnBuscarProduto.Click += new System.EventHandler(this.ibtnBuscarProduto_Click);
            // 
            // ibtnGerarCodigoBarras
            // 
            this.ibtnGerarCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnGerarCodigoBarras.BackColor = System.Drawing.Color.DodgerBlue;
            this.ibtnGerarCodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnGerarCodigoBarras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnGerarCodigoBarras.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnGerarCodigoBarras.ForeColor = System.Drawing.Color.White;
            this.ibtnGerarCodigoBarras.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.ibtnGerarCodigoBarras.IconColor = System.Drawing.Color.White;
            this.ibtnGerarCodigoBarras.IconSize = 40;
            this.ibtnGerarCodigoBarras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnGerarCodigoBarras.Location = new System.Drawing.Point(12, 576);
            this.ibtnGerarCodigoBarras.Name = "ibtnGerarCodigoBarras";
            this.ibtnGerarCodigoBarras.Rotation = 0D;
            this.ibtnGerarCodigoBarras.Size = new System.Drawing.Size(472, 43);
            this.ibtnGerarCodigoBarras.TabIndex = 54;
            this.ibtnGerarCodigoBarras.Text = "Codigo Barras";
            this.ibtnGerarCodigoBarras.UseVisualStyleBackColor = false;
            this.ibtnGerarCodigoBarras.Click += new System.EventHandler(this.ibtnGerarCodigoBarras_Click);
            // 
            // ibtnRemoverCliente
            // 
            this.ibtnRemoverCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnRemoverCliente.BackColor = System.Drawing.Color.Red;
            this.ibtnRemoverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRemoverCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnRemoverCliente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRemoverCliente.ForeColor = System.Drawing.Color.White;
            this.ibtnRemoverCliente.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ibtnRemoverCliente.IconColor = System.Drawing.Color.White;
            this.ibtnRemoverCliente.IconSize = 30;
            this.ibtnRemoverCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnRemoverCliente.Location = new System.Drawing.Point(12, 527);
            this.ibtnRemoverCliente.Name = "ibtnRemoverCliente";
            this.ibtnRemoverCliente.Rotation = 0D;
            this.ibtnRemoverCliente.Size = new System.Drawing.Size(472, 43);
            this.ibtnRemoverCliente.TabIndex = 53;
            this.ibtnRemoverCliente.Text = "Remover Produto";
            this.ibtnRemoverCliente.UseVisualStyleBackColor = false;
            this.ibtnRemoverCliente.Click += new System.EventHandler(this.ibtnRemoverCliente_Click);
            // 
            // ibtnAlterarProduto
            // 
            this.ibtnAlterarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAlterarProduto.BackColor = System.Drawing.Color.DarkOrange;
            this.ibtnAlterarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAlterarProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAlterarProduto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAlterarProduto.ForeColor = System.Drawing.Color.White;
            this.ibtnAlterarProduto.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnAlterarProduto.IconColor = System.Drawing.Color.White;
            this.ibtnAlterarProduto.IconSize = 30;
            this.ibtnAlterarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAlterarProduto.Location = new System.Drawing.Point(800, 576);
            this.ibtnAlterarProduto.Name = "ibtnAlterarProduto";
            this.ibtnAlterarProduto.Rotation = 0D;
            this.ibtnAlterarProduto.Size = new System.Drawing.Size(472, 43);
            this.ibtnAlterarProduto.TabIndex = 52;
            this.ibtnAlterarProduto.Text = "Alterar Produto";
            this.ibtnAlterarProduto.UseVisualStyleBackColor = false;
            this.ibtnAlterarProduto.Click += new System.EventHandler(this.ibtnAlterarProduto_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1284, 627);
            this.Controls.Add(this.painelGeral);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ibtnAumentarDiminuir);
            this.Controls.Add(this.ibtnBuscarProduto);
            this.Controls.Add(this.ibtnGerarCodigoBarras);
            this.Controls.Add(this.ibtnRemoverCliente);
            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.ibtnAlterarProduto);
            this.Name = "Estoque";
            this.ShowIcon = false;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painelGeral.ResumeLayout(false);
            this.panelAdicionarProduto.ResumeLayout(false);
            this.panelAdicionarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarTipoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcodeProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLojaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTamanhoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbQuantidadeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataEntradaProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbValorComprado;
        private System.Windows.Forms.TextBox tbValorProduto;
        private System.Windows.Forms.BindingSource bdLojaDataSetBindingSource;
        private FontAwesome.Sharp.IconButton ibtnAdicionarEstoque;
        private FontAwesome.Sharp.IconButton ibtnAlterarProduto;
        private FontAwesome.Sharp.IconButton ibtnRemoverCliente;
        private FontAwesome.Sharp.IconButton ibtnGerarCodigoBarras;
        private System.Windows.Forms.PictureBox pbBarcodeProduto;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private FontAwesome.Sharp.IconButton ibtnBuscarProduto;
        private FontAwesome.Sharp.IconButton ibtnAumentarDiminuir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPatrimonioTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblQuantTotalProd;
        private System.Windows.Forms.Label lblQuantTipoProdutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBuscarTipoProduto;
        private System.Windows.Forms.ComboBox cbBuscarMarca;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDescricaoNomeProduto;
        private System.Windows.Forms.Panel painelGeral;
        private System.Windows.Forms.Panel panelAdicionarProduto;
        private FontAwesome.Sharp.IconButton ibtnAddNovoProduto;
        private System.Windows.Forms.TextBox tbRefProduto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timerBtn;
        private System.Windows.Forms.LinkLabel linkTipoProduto;
        private System.Windows.Forms.LinkLabel linkMarca;
        private System.Windows.Forms.DataGridView dgvBuscarTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoProd;
        private System.Windows.Forms.DataGridView dgvBuscarMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuanProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProdd;
    }
}