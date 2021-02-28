namespace Loja
{
    partial class Caixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbQuantidadeEstoque = new System.Windows.Forms.ComboBox();
            this.listBoxIdEstoque = new System.Windows.Forms.ListBox();
            this.listBoxNomeProduto = new System.Windows.Forms.ListBox();
            this.dgvListaPedidoProdutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelecionarCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClienteSelecionado = new System.Windows.Forms.Label();
            this.cbAdicionarProduto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbQuantidadeProduto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDinheiro = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lblIdPedidoCriado = new System.Windows.Forms.Label();
            this.lblDinheiroEntrada = new System.Windows.Forms.Label();
            this.lblProdutoSelecionado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.textDataPagamento = new System.Windows.Forms.Label();
            this.textQuantidadeParcelas = new System.Windows.Forms.Label();
            this.cbQuantidadeParcelas = new System.Windows.Forms.ComboBox();
            this.panelEsconderControles = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ibtnResetarPedido = new FontAwesome.Sharp.IconButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbCupom = new System.Windows.Forms.PictureBox();
            this.ibtnRemoveProduto = new FontAwesome.Sharp.IconButton();
            this.ibtnFinalizarPedido = new FontAwesome.Sharp.IconButton();
            this.ibtnAdicionarProduto = new FontAwesome.Sharp.IconButton();
            this.ibtnCriarPedido = new FontAwesome.Sharp.IconButton();
            this.ibtnVerParcelas = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.colNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidoProdutos)).BeginInit();
            this.panelEsconderControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCupom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbQuantidadeEstoque
            // 
            this.cbQuantidadeEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.cbQuantidadeEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbQuantidadeEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantidadeEstoque.ForeColor = System.Drawing.Color.Chartreuse;
            this.cbQuantidadeEstoque.FormattingEnabled = true;
            this.cbQuantidadeEstoque.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbQuantidadeEstoque.IntegralHeight = false;
            this.cbQuantidadeEstoque.ItemHeight = 20;
            this.cbQuantidadeEstoque.Location = new System.Drawing.Point(3, 54);
            this.cbQuantidadeEstoque.MaxDropDownItems = 1;
            this.cbQuantidadeEstoque.Name = "cbQuantidadeEstoque";
            this.cbQuantidadeEstoque.Size = new System.Drawing.Size(66, 28);
            this.cbQuantidadeEstoque.TabIndex = 48;
            this.cbQuantidadeEstoque.TextChanged += new System.EventHandler(this.cbQuantidadeEstoque_TextChanged);
            // 
            // listBoxIdEstoque
            // 
            this.listBoxIdEstoque.FormattingEnabled = true;
            this.listBoxIdEstoque.Location = new System.Drawing.Point(99, 52);
            this.listBoxIdEstoque.Name = "listBoxIdEstoque";
            this.listBoxIdEstoque.Size = new System.Drawing.Size(22, 30);
            this.listBoxIdEstoque.TabIndex = 66;
            this.listBoxIdEstoque.Visible = false;
            // 
            // listBoxNomeProduto
            // 
            this.listBoxNomeProduto.FormattingEnabled = true;
            this.listBoxNomeProduto.Location = new System.Drawing.Point(75, 53);
            this.listBoxNomeProduto.Name = "listBoxNomeProduto";
            this.listBoxNomeProduto.Size = new System.Drawing.Size(18, 30);
            this.listBoxNomeProduto.TabIndex = 67;
            this.listBoxNomeProduto.Visible = false;
            // 
            // dgvListaPedidoProdutos
            // 
            this.dgvListaPedidoProdutos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListaPedidoProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPedidoProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaPedidoProdutos.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvListaPedidoProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidoProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeProduto,
            this.colTamanho,
            this.colQuantProd,
            this.colValorProduto,
            this.colValorTotal,
            this.colIdProd});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPedidoProdutos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaPedidoProdutos.Location = new System.Drawing.Point(12, 193);
            this.dgvListaPedidoProdutos.MultiSelect = false;
            this.dgvListaPedidoProdutos.Name = "dgvListaPedidoProdutos";
            this.dgvListaPedidoProdutos.ReadOnly = true;
            this.dgvListaPedidoProdutos.RowHeadersVisible = false;
            this.dgvListaPedidoProdutos.RowHeadersWidth = 31;
            this.dgvListaPedidoProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaPedidoProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaPedidoProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPedidoProdutos.Size = new System.Drawing.Size(794, 416);
            this.dgvListaPedidoProdutos.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar Cliente:";
            // 
            // cbSelecionarCliente
            // 
            this.cbSelecionarCliente.DropDownHeight = 232;
            this.cbSelecionarCliente.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelecionarCliente.FormattingEnabled = true;
            this.cbSelecionarCliente.IntegralHeight = false;
            this.cbSelecionarCliente.ItemHeight = 25;
            this.cbSelecionarCliente.Location = new System.Drawing.Point(219, 40);
            this.cbSelecionarCliente.Name = "cbSelecionarCliente";
            this.cbSelecionarCliente.Size = new System.Drawing.Size(411, 33);
            this.cbSelecionarCliente.TabIndex = 1;
            this.cbSelecionarCliente.SelectedIndexChanged += new System.EventHandler(this.cbSelecionarCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Adicionar produto";
            // 
            // lblClienteSelecionado
            // 
            this.lblClienteSelecionado.AutoSize = true;
            this.lblClienteSelecionado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteSelecionado.Location = new System.Drawing.Point(321, 16);
            this.lblClienteSelecionado.Name = "lblClienteSelecionado";
            this.lblClienteSelecionado.Size = new System.Drawing.Size(196, 18);
            this.lblClienteSelecionado.TabIndex = 18;
            this.lblClienteSelecionado.Text = "-CLIENTE SELECIONADO-";
            this.lblClienteSelecionado.Visible = false;
            // 
            // cbAdicionarProduto
            // 
            this.cbAdicionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAdicionarProduto.DropDownHeight = 254;
            this.cbAdicionarProduto.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdicionarProduto.FormattingEnabled = true;
            this.cbAdicionarProduto.IntegralHeight = false;
            this.cbAdicionarProduto.Location = new System.Drawing.Point(197, 148);
            this.cbAdicionarProduto.Name = "cbAdicionarProduto";
            this.cbAdicionarProduto.Size = new System.Drawing.Size(396, 31);
            this.cbAdicionarProduto.TabIndex = 19;
            this.cbAdicionarProduto.SelectedIndexChanged += new System.EventHandler(this.cbAdicionarProduto_SelectedIndexChanged);
            this.cbAdicionarProduto.TextChanged += new System.EventHandler(this.cbAdicionarProduto_TextChanged);
            this.cbAdicionarProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbAdicionarProduto_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(865, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Forma de Pagamento";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "A Prazo",
            "Débito",
            "Crédito 1x",
            "Crédito 2x",
            "Crédito 3x",
            "Crédito 4x",
            "Crédito 5x"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(1074, 318);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(159, 33);
            this.cbFormaPagamento.TabIndex = 29;
            this.cbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbFormaPagamento_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantidade";
            // 
            // cbQuantidadeProduto
            // 
            this.cbQuantidadeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuantidadeProduto.DropDownHeight = 220;
            this.cbQuantidadeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantidadeProduto.Enabled = false;
            this.cbQuantidadeProduto.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantidadeProduto.FormattingEnabled = true;
            this.cbQuantidadeProduto.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cbQuantidadeProduto.IntegralHeight = false;
            this.cbQuantidadeProduto.Location = new System.Drawing.Point(733, 147);
            this.cbQuantidadeProduto.Name = "cbQuantidadeProduto";
            this.cbQuantidadeProduto.Size = new System.Drawing.Size(71, 33);
            this.cbQuantidadeProduto.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(830, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Valor";
            // 
            // tbDinheiro
            // 
            this.tbDinheiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDinheiro.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDinheiro.Location = new System.Drawing.Point(951, 537);
            this.tbDinheiro.MaxLength = 9;
            this.tbDinheiro.Name = "tbDinheiro";
            this.tbDinheiro.ShortcutsEnabled = false;
            this.tbDinheiro.Size = new System.Drawing.Size(116, 33);
            this.tbDinheiro.TabIndex = 46;
            this.tbDinheiro.TextChanged += new System.EventHandler(this.tbDesconto_TextChanged_1);
            this.tbDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesconto_KeyPress);
            // 
            // tbValor
            // 
            this.tbValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValor.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(951, 498);
            this.tbValor.Name = "tbValor";
            this.tbValor.ReadOnly = true;
            this.tbValor.Size = new System.Drawing.Size(116, 33);
            this.tbValor.TabIndex = 33;
            this.tbValor.TextChanged += new System.EventHandler(this.tbValor_TextChanged);
            // 
            // lblIdPedidoCriado
            // 
            this.lblIdPedidoCriado.AutoSize = true;
            this.lblIdPedidoCriado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPedidoCriado.Location = new System.Drawing.Point(700, 95);
            this.lblIdPedidoCriado.Name = "lblIdPedidoCriado";
            this.lblIdPedidoCriado.Size = new System.Drawing.Size(157, 18);
            this.lblIdPedidoCriado.TabIndex = 44;
            this.lblIdPedidoCriado.Text = "-ID PEDIDO CRIADO-";
            this.lblIdPedidoCriado.Visible = false;
            // 
            // lblDinheiroEntrada
            // 
            this.lblDinheiroEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDinheiroEntrada.AutoSize = true;
            this.lblDinheiroEntrada.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiroEntrada.Location = new System.Drawing.Point(830, 542);
            this.lblDinheiroEntrada.Name = "lblDinheiroEntrada";
            this.lblDinheiroEntrada.Size = new System.Drawing.Size(89, 25);
            this.lblDinheiroEntrada.TabIndex = 34;
            this.lblDinheiroEntrada.Text = "Dinheiro";
            // 
            // lblProdutoSelecionado
            // 
            this.lblProdutoSelecionado.AutoSize = true;
            this.lblProdutoSelecionado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoSelecionado.Location = new System.Drawing.Point(277, 126);
            this.lblProdutoSelecionado.Name = "lblProdutoSelecionado";
            this.lblProdutoSelecionado.Size = new System.Drawing.Size(208, 18);
            this.lblProdutoSelecionado.TabIndex = 42;
            this.lblProdutoSelecionado.Text = "-PRODUTO SELECIONADO-";
            this.lblProdutoSelecionado.Visible = false;
            this.lblProdutoSelecionado.TextChanged += new System.EventHandler(this.lblProdutoSelecionado_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(830, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Valor Total";
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataPagamento.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPagamento.Location = new System.Drawing.Point(1092, 415);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(141, 33);
            this.dtpDataPagamento.TabIndex = 41;
            this.dtpDataPagamento.Visible = false;
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorTotal.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorTotal.Location = new System.Drawing.Point(951, 576);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.ReadOnly = true;
            this.tbValorTotal.Size = new System.Drawing.Size(116, 33);
            this.tbValorTotal.TabIndex = 37;
            this.tbValorTotal.TextChanged += new System.EventHandler(this.tbValorTotal_TextChanged);
            // 
            // textDataPagamento
            // 
            this.textDataPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDataPagamento.AutoSize = true;
            this.textDataPagamento.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDataPagamento.Location = new System.Drawing.Point(865, 419);
            this.textDataPagamento.Name = "textDataPagamento";
            this.textDataPagamento.Size = new System.Drawing.Size(208, 25);
            this.textDataPagamento.TabIndex = 40;
            this.textDataPagamento.Text = "Data do Parcelamento";
            this.textDataPagamento.Visible = false;
            // 
            // textQuantidadeParcelas
            // 
            this.textQuantidadeParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textQuantidadeParcelas.AutoSize = true;
            this.textQuantidadeParcelas.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuantidadeParcelas.Location = new System.Drawing.Point(865, 379);
            this.textQuantidadeParcelas.Name = "textQuantidadeParcelas";
            this.textQuantidadeParcelas.Size = new System.Drawing.Size(192, 25);
            this.textQuantidadeParcelas.TabIndex = 38;
            this.textQuantidadeParcelas.Text = "Quantidade Parcelas";
            this.textQuantidadeParcelas.Visible = false;
            // 
            // cbQuantidadeParcelas
            // 
            this.cbQuantidadeParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuantidadeParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuantidadeParcelas.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantidadeParcelas.FormattingEnabled = true;
            this.cbQuantidadeParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbQuantidadeParcelas.Location = new System.Drawing.Point(1133, 375);
            this.cbQuantidadeParcelas.Name = "cbQuantidadeParcelas";
            this.cbQuantidadeParcelas.Size = new System.Drawing.Size(100, 33);
            this.cbQuantidadeParcelas.TabIndex = 39;
            this.cbQuantidadeParcelas.Visible = false;
            // 
            // panelEsconderControles
            // 
            this.panelEsconderControles.Controls.Add(this.listBoxIdEstoque);
            this.panelEsconderControles.Controls.Add(this.cbQuantidadeEstoque);
            this.panelEsconderControles.Controls.Add(this.listBoxNomeProduto);
            this.panelEsconderControles.Location = new System.Drawing.Point(12, 16);
            this.panelEsconderControles.Name = "panelEsconderControles";
            this.panelEsconderControles.Size = new System.Drawing.Size(186, 22);
            this.panelEsconderControles.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(311, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(662, 5);
            this.button1.TabIndex = 77;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ibtnResetarPedido
            // 
            this.ibtnResetarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnResetarPedido.BackColor = System.Drawing.Color.Silver;
            this.ibtnResetarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ibtnResetarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnResetarPedido.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnResetarPedido.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnResetarPedido.ForeColor = System.Drawing.Color.Black;
            this.ibtnResetarPedido.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.ibtnResetarPedido.IconColor = System.Drawing.Color.White;
            this.ibtnResetarPedido.IconSize = 30;
            this.ibtnResetarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnResetarPedido.Location = new System.Drawing.Point(1095, 20);
            this.ibtnResetarPedido.Name = "ibtnResetarPedido";
            this.ibtnResetarPedido.Rotation = 0D;
            this.ibtnResetarPedido.Size = new System.Drawing.Size(177, 72);
            this.ibtnResetarPedido.TabIndex = 54;
            this.ibtnResetarPedido.Text = "Resetar Pedido";
            this.ibtnResetarPedido.UseVisualStyleBackColor = false;
            this.ibtnResetarPedido.Click += new System.EventHandler(this.ibtnResetarPedido_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::Loja.Properties.Resources.linha_animada;
            this.pictureBox5.Location = new System.Drawing.Point(976, 90);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(296, 33);
            this.pictureBox5.TabIndex = 76;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Loja.Properties.Resources.linha_animada;
            this.pictureBox2.Location = new System.Drawing.Point(12, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 33);
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // pbCupom
            // 
            this.pbCupom.BackColor = System.Drawing.Color.White;
            this.pbCupom.Location = new System.Drawing.Point(612, 1);
            this.pbCupom.Name = "pbCupom";
            this.pbCupom.Size = new System.Drawing.Size(330, 10);
            this.pbCupom.TabIndex = 70;
            this.pbCupom.TabStop = false;
            this.pbCupom.Visible = false;
            this.pbCupom.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCupom_Paint);
            // 
            // ibtnRemoveProduto
            // 
            this.ibtnRemoveProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnRemoveProduto.BackColor = System.Drawing.Color.Salmon;
            this.ibtnRemoveProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRemoveProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnRemoveProduto.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRemoveProduto.ForeColor = System.Drawing.Color.Black;
            this.ibtnRemoveProduto.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ibtnRemoveProduto.IconColor = System.Drawing.Color.Firebrick;
            this.ibtnRemoveProduto.IconSize = 30;
            this.ibtnRemoveProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnRemoveProduto.Location = new System.Drawing.Point(1095, 193);
            this.ibtnRemoveProduto.Name = "ibtnRemoveProduto";
            this.ibtnRemoveProduto.Rotation = 0D;
            this.ibtnRemoveProduto.Size = new System.Drawing.Size(177, 96);
            this.ibtnRemoveProduto.TabIndex = 69;
            this.ibtnRemoveProduto.Text = "Remover Produto";
            this.ibtnRemoveProduto.UseVisualStyleBackColor = false;
            this.ibtnRemoveProduto.Click += new System.EventHandler(this.ibtnRemoveProduto_Click);
            // 
            // ibtnFinalizarPedido
            // 
            this.ibtnFinalizarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnFinalizarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnFinalizarPedido.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ibtnFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFinalizarPedido.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnFinalizarPedido.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnFinalizarPedido.ForeColor = System.Drawing.Color.Black;
            this.ibtnFinalizarPedido.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ibtnFinalizarPedido.IconColor = System.Drawing.Color.Green;
            this.ibtnFinalizarPedido.IconSize = 30;
            this.ibtnFinalizarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnFinalizarPedido.Location = new System.Drawing.Point(1087, 498);
            this.ibtnFinalizarPedido.Name = "ibtnFinalizarPedido";
            this.ibtnFinalizarPedido.Rotation = 0D;
            this.ibtnFinalizarPedido.Size = new System.Drawing.Size(185, 112);
            this.ibtnFinalizarPedido.TabIndex = 65;
            this.ibtnFinalizarPedido.Text = "Finalizar Venda";
            this.ibtnFinalizarPedido.UseVisualStyleBackColor = false;
            this.ibtnFinalizarPedido.Click += new System.EventHandler(this.ibtnFinalizarPedido_Click);
            // 
            // ibtnAdicionarProduto
            // 
            this.ibtnAdicionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAdicionarProduto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnAdicionarProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAdicionarProduto.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.ibtnAdicionarProduto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAdicionarProduto.IconColor = System.Drawing.Color.ForestGreen;
            this.ibtnAdicionarProduto.IconSize = 30;
            this.ibtnAdicionarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAdicionarProduto.Location = new System.Drawing.Point(835, 193);
            this.ibtnAdicionarProduto.Name = "ibtnAdicionarProduto";
            this.ibtnAdicionarProduto.Rotation = 0D;
            this.ibtnAdicionarProduto.Size = new System.Drawing.Size(240, 96);
            this.ibtnAdicionarProduto.TabIndex = 56;
            this.ibtnAdicionarProduto.Text = "Adicionar";
            this.ibtnAdicionarProduto.UseVisualStyleBackColor = false;
            this.ibtnAdicionarProduto.Click += new System.EventHandler(this.ibtnAdicionarProduto_Click);
            // 
            // ibtnCriarPedido
            // 
            this.ibtnCriarPedido.BackColor = System.Drawing.Color.Gold;
            this.ibtnCriarPedido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ibtnCriarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.ibtnCriarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.ibtnCriarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCriarPedido.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnCriarPedido.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCriarPedido.ForeColor = System.Drawing.Color.Black;
            this.ibtnCriarPedido.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.ibtnCriarPedido.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnCriarPedido.IconSize = 30;
            this.ibtnCriarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCriarPedido.Location = new System.Drawing.Point(653, 20);
            this.ibtnCriarPedido.Name = "ibtnCriarPedido";
            this.ibtnCriarPedido.Rotation = 0D;
            this.ibtnCriarPedido.Size = new System.Drawing.Size(248, 72);
            this.ibtnCriarPedido.TabIndex = 52;
            this.ibtnCriarPedido.Text = "Criar Pedido";
            this.ibtnCriarPedido.UseVisualStyleBackColor = false;
            this.ibtnCriarPedido.Click += new System.EventHandler(this.ibtnCriarPedido_Click);
            // 
            // ibtnVerParcelas
            // 
            this.ibtnVerParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnVerParcelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ibtnVerParcelas.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ibtnVerParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnVerParcelas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnVerParcelas.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnVerParcelas.ForeColor = System.Drawing.Color.Black;
            this.ibtnVerParcelas.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.ibtnVerParcelas.IconColor = System.Drawing.Color.Black;
            this.ibtnVerParcelas.IconSize = 30;
            this.ibtnVerParcelas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnVerParcelas.Location = new System.Drawing.Point(1087, 498);
            this.ibtnVerParcelas.Name = "ibtnVerParcelas";
            this.ibtnVerParcelas.Rotation = 0D;
            this.ibtnVerParcelas.Size = new System.Drawing.Size(185, 111);
            this.ibtnVerParcelas.TabIndex = 49;
            this.ibtnVerParcelas.Text = "Finalizar Venda Parcelada";
            this.ibtnVerParcelas.UseVisualStyleBackColor = false;
            this.ibtnVerParcelas.Click += new System.EventHandler(this.ibtnVerParcelas_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(835, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 33);
            this.panel1.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Pressione [ F1 ] - Em Adicionar Produto para pesquisar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJuros
            // 
            this.lblJuros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJuros.AutoSize = true;
            this.lblJuros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuros.ForeColor = System.Drawing.Color.Red;
            this.lblJuros.Location = new System.Drawing.Point(1013, 467);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(60, 16);
            this.lblJuros.TabIndex = 80;
            this.lblJuros.Text = "-JUROS-";
            this.lblJuros.Visible = false;
            // 
            // colNomeProduto
            // 
            this.colNomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomeProduto.DataPropertyName = "NOME_PRODUTO";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNomeProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNomeProduto.HeaderText = "Nome do Produto";
            this.colNomeProduto.Name = "colNomeProduto";
            this.colNomeProduto.ReadOnly = true;
            // 
            // colTamanho
            // 
            this.colTamanho.DataPropertyName = "TAMANHO";
            this.colTamanho.HeaderText = "Tamanho";
            this.colTamanho.Name = "colTamanho";
            this.colTamanho.ReadOnly = true;
            this.colTamanho.Width = 60;
            // 
            // colQuantProd
            // 
            this.colQuantProd.DataPropertyName = "QUANT_PROD";
            this.colQuantProd.HeaderText = "Qtd";
            this.colQuantProd.Name = "colQuantProd";
            this.colQuantProd.ReadOnly = true;
            this.colQuantProd.Width = 35;
            // 
            // colValorProduto
            // 
            this.colValorProduto.DataPropertyName = "VALOR_PRODUTO";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.colValorProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.colValorProduto.HeaderText = "Valor Produto";
            this.colValorProduto.Name = "colValorProduto";
            this.colValorProduto.ReadOnly = true;
            // 
            // colValorTotal
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.colValorTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.colValorTotal.HeaderText = "Valor Total";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.ReadOnly = true;
            // 
            // colIdProd
            // 
            this.colIdProd.DataPropertyName = "ID_PRODUTO";
            this.colIdProd.HeaderText = "ID";
            this.colIdProd.Name = "colIdProd";
            this.colIdProd.ReadOnly = true;
            this.colIdProd.Visible = false;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1284, 626);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ibtnResetarPedido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelEsconderControles);
            this.Controls.Add(this.pbCupom);
            this.Controls.Add(this.ibtnRemoveProduto);
            this.Controls.Add(this.ibtnFinalizarPedido);
            this.Controls.Add(this.ibtnAdicionarProduto);
            this.Controls.Add(this.ibtnCriarPedido);
            this.Controls.Add(this.ibtnVerParcelas);
            this.Controls.Add(this.tbDinheiro);
            this.Controls.Add(this.lblIdPedidoCriado);
            this.Controls.Add(this.lblProdutoSelecionado);
            this.Controls.Add(this.dtpDataPagamento);
            this.Controls.Add(this.textDataPagamento);
            this.Controls.Add(this.cbQuantidadeParcelas);
            this.Controls.Add(this.textQuantidadeParcelas);
            this.Controls.Add(this.tbValorTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDinheiroEntrada);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbQuantidadeProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvListaPedidoProdutos);
            this.Controls.Add(this.cbAdicionarProduto);
            this.Controls.Add(this.lblClienteSelecionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSelecionarCliente);
            this.Controls.Add(this.label1);
            this.Name = "Caixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.Leave += new System.EventHandler(this.Caixa_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidoProdutos)).EndInit();
            this.panelEsconderControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCupom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelecionarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClienteSelecionado;
        private System.Windows.Forms.ComboBox cbAdicionarProduto;
        private System.Windows.Forms.DataGridView dgvListaPedidoProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbQuantidadeProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lblDinheiroEntrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label textQuantidadeParcelas;
        private System.Windows.Forms.ComboBox cbQuantidadeParcelas;
        private System.Windows.Forms.Label textDataPagamento;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.Label lblProdutoSelecionado;
        private System.Windows.Forms.TextBox tbDinheiro;
        private System.Windows.Forms.ComboBox cbQuantidadeEstoque;
        private FontAwesome.Sharp.IconButton ibtnVerParcelas;
        private System.Windows.Forms.Label lblIdPedidoCriado;
        private FontAwesome.Sharp.IconButton ibtnCriarPedido;
        private FontAwesome.Sharp.IconButton ibtnResetarPedido;
        private FontAwesome.Sharp.IconButton ibtnAdicionarProduto;
        private FontAwesome.Sharp.IconButton ibtnFinalizarPedido;
        private System.Windows.Forms.ListBox listBoxIdEstoque;
        private System.Windows.Forms.ListBox listBoxNomeProduto;
        private FontAwesome.Sharp.IconButton ibtnRemoveProduto;
        private System.Windows.Forms.PictureBox pbCupom;
        private System.Windows.Forms.Panel panelEsconderControles;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProd;
    }
}