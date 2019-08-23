namespace VinhosVelasquez
{
	partial class MainForm
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
			if (disposing && (components != null)) {
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
			this.Console = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.importarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelInterface = new System.Windows.Forms.TabControl();
			this.tabClientes = new System.Windows.Forms.TabPage();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblSafra = new System.Windows.Forms.Label();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.lblPais = new System.Windows.Forms.Label();
			this.lblVariedade = new System.Windows.Forms.Label();
			this.lblProduto = new System.Windows.Forms.Label();
			this.btnSugerir = new System.Windows.Forms.Button();
			this.dataGridClientes = new System.Windows.Forms.DataGridView();
			this.lblClientes = new System.Windows.Forms.Label();
			this.tabItens = new System.Windows.Forms.TabPage();
			this.dataGridItens = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.tabVendas = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridItensVenda = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridVendas = new System.Windows.Forms.DataGridView();
			this.tabValorTotalCompras = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblValorTotal = new System.Windows.Forms.Label();
			this.lblClienteMaiorValorTotal = new System.Windows.Forms.Label();
			this.dataGridValorTotalCompras = new System.Windows.Forms.DataGridView();
			this.tabMaiorCompraAno = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.valorMaiorCompraAno = new System.Windows.Forms.Label();
			this.clienteMaiorCompraAno = new System.Windows.Forms.Label();
			this.dataGridHigherSaleOnYear = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAno = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tabRanking = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.lblClienteMaisFiel = new System.Windows.Forms.Label();
			this.dataGridUnicSalesPerClient = new System.Windows.Forms.DataGridView();
			this.lblPreco = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panelInterface.SuspendLayout();
			this.tabClientes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
			this.tabItens.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).BeginInit();
			this.tabVendas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridItensVenda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).BeginInit();
			this.tabValorTotalCompras.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridValorTotalCompras)).BeginInit();
			this.tabMaiorCompraAno.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridHigherSaleOnYear)).BeginInit();
			this.tabRanking.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridUnicSalesPerClient)).BeginInit();
			this.SuspendLayout();
			// 
			// Console
			// 
			this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Console.AutoSize = true;
			this.Console.Location = new System.Drawing.Point(12, 628);
			this.Console.Name = "Console";
			this.Console.Size = new System.Drawing.Size(59, 20);
			this.Console.TabIndex = 0;
			this.Console.Text = "Ready!";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1146, 33);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarTudoToolStripMenuItem,
            this.importClientsToolStripMenuItem,
            this.importHistoryToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 29);
			this.toolStripMenuItem1.Text = "File";
			// 
			// importarTudoToolStripMenuItem
			// 
			this.importarTudoToolStripMenuItem.Name = "importarTudoToolStripMenuItem";
			this.importarTudoToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
			this.importarTudoToolStripMenuItem.Text = "Importar Tudo";
			this.importarTudoToolStripMenuItem.Click += new System.EventHandler(this.importarTudoToolStripMenuItem_Click);
			// 
			// importClientsToolStripMenuItem
			// 
			this.importClientsToolStripMenuItem.Name = "importClientsToolStripMenuItem";
			this.importClientsToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
			this.importClientsToolStripMenuItem.Text = "Importar Clientes";
			this.importClientsToolStripMenuItem.Click += new System.EventHandler(this.importClientsToolStripMenuItem_Click);
			// 
			// importHistoryToolStripMenuItem
			// 
			this.importHistoryToolStripMenuItem.Name = "importHistoryToolStripMenuItem";
			this.importHistoryToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
			this.importHistoryToolStripMenuItem.Text = "Importar Histórico";
			this.importHistoryToolStripMenuItem.Click += new System.EventHandler(this.importHistoryToolStripMenuItem_Click);
			// 
			// panelInterface
			// 
			this.panelInterface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelInterface.Controls.Add(this.tabClientes);
			this.panelInterface.Controls.Add(this.tabItens);
			this.panelInterface.Controls.Add(this.tabVendas);
			this.panelInterface.Controls.Add(this.tabValorTotalCompras);
			this.panelInterface.Controls.Add(this.tabMaiorCompraAno);
			this.panelInterface.Controls.Add(this.tabRanking);
			this.panelInterface.Location = new System.Drawing.Point(0, 36);
			this.panelInterface.Name = "panelInterface";
			this.panelInterface.SelectedIndex = 0;
			this.panelInterface.Size = new System.Drawing.Size(1146, 570);
			this.panelInterface.TabIndex = 2;
			this.panelInterface.SelectedIndexChanged += new System.EventHandler(this.SelectedIndex_Changed);
			// 
			// tabClientes
			// 
			this.tabClientes.Controls.Add(this.lblPreco);
			this.tabClientes.Controls.Add(this.lblCodigo);
			this.tabClientes.Controls.Add(this.lblSafra);
			this.tabClientes.Controls.Add(this.lblCategoria);
			this.tabClientes.Controls.Add(this.lblPais);
			this.tabClientes.Controls.Add(this.lblVariedade);
			this.tabClientes.Controls.Add(this.lblProduto);
			this.tabClientes.Controls.Add(this.btnSugerir);
			this.tabClientes.Controls.Add(this.dataGridClientes);
			this.tabClientes.Controls.Add(this.lblClientes);
			this.tabClientes.Location = new System.Drawing.Point(4, 29);
			this.tabClientes.Name = "tabClientes";
			this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
			this.tabClientes.Size = new System.Drawing.Size(1138, 537);
			this.tabClientes.TabIndex = 0;
			this.tabClientes.Text = "Clientes";
			this.tabClientes.UseVisualStyleBackColor = true;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(810, 268);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(39, 20);
			this.lblCodigo.TabIndex = 10;
			this.lblCodigo.Text = "cod.";
			// 
			// lblSafra
			// 
			this.lblSafra.AutoSize = true;
			this.lblSafra.Location = new System.Drawing.Point(810, 208);
			this.lblSafra.Name = "lblSafra";
			this.lblSafra.Size = new System.Drawing.Size(45, 20);
			this.lblSafra.TabIndex = 9;
			this.lblSafra.Text = "safra";
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(810, 188);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(75, 20);
			this.lblCategoria.TabIndex = 8;
			this.lblCategoria.Text = "categoria";
			// 
			// lblPais
			// 
			this.lblPais.AutoSize = true;
			this.lblPais.Location = new System.Drawing.Point(810, 168);
			this.lblPais.Name = "lblPais";
			this.lblPais.Size = new System.Drawing.Size(38, 20);
			this.lblPais.TabIndex = 7;
			this.lblPais.Text = "pais";
			// 
			// lblVariedade
			// 
			this.lblVariedade.AutoSize = true;
			this.lblVariedade.Location = new System.Drawing.Point(810, 148);
			this.lblVariedade.Name = "lblVariedade";
			this.lblVariedade.Size = new System.Drawing.Size(78, 20);
			this.lblVariedade.TabIndex = 6;
			this.lblVariedade.Text = "variedade";
			// 
			// lblProduto
			// 
			this.lblProduto.AutoSize = true;
			this.lblProduto.Location = new System.Drawing.Point(810, 128);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(64, 20);
			this.lblProduto.TabIndex = 5;
			this.lblProduto.Text = "produto";
			// 
			// btnSugerir
			// 
			this.btnSugerir.Location = new System.Drawing.Point(790, 56);
			this.btnSugerir.Name = "btnSugerir";
			this.btnSugerir.Size = new System.Drawing.Size(340, 47);
			this.btnSugerir.TabIndex = 4;
			this.btnSugerir.Text = "Sugerir Vinho";
			this.btnSugerir.UseVisualStyleBackColor = true;
			this.btnSugerir.Click += new System.EventHandler(this.btnSugerir_Click);
			// 
			// dataGridClientes
			// 
			this.dataGridClientes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridClientes.Location = new System.Drawing.Point(12, 56);
			this.dataGridClientes.MultiSelect = false;
			this.dataGridClientes.Name = "dataGridClientes";
			this.dataGridClientes.RowTemplate.Height = 28;
			this.dataGridClientes.Size = new System.Drawing.Size(772, 475);
			this.dataGridClientes.TabIndex = 2;
			// 
			// lblClientes
			// 
			this.lblClientes.AutoSize = true;
			this.lblClientes.Location = new System.Drawing.Point(8, 23);
			this.lblClientes.Name = "lblClientes";
			this.lblClientes.Size = new System.Drawing.Size(70, 20);
			this.lblClientes.TabIndex = 1;
			this.lblClientes.Text = "Clientes:";
			// 
			// tabItens
			// 
			this.tabItens.Controls.Add(this.dataGridItens);
			this.tabItens.Controls.Add(this.label1);
			this.tabItens.Location = new System.Drawing.Point(4, 29);
			this.tabItens.Name = "tabItens";
			this.tabItens.Padding = new System.Windows.Forms.Padding(3);
			this.tabItens.Size = new System.Drawing.Size(1138, 537);
			this.tabItens.TabIndex = 1;
			this.tabItens.Text = "Itens";
			this.tabItens.UseVisualStyleBackColor = true;
			// 
			// dataGridItens
			// 
			this.dataGridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridItens.Location = new System.Drawing.Point(6, 56);
			this.dataGridItens.MultiSelect = false;
			this.dataGridItens.Name = "dataGridItens";
			this.dataGridItens.RowTemplate.Height = 28;
			this.dataGridItens.Size = new System.Drawing.Size(1124, 475);
			this.dataGridItens.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Itens:";
			// 
			// tabVendas
			// 
			this.tabVendas.Controls.Add(this.label4);
			this.tabVendas.Controls.Add(this.dataGridItensVenda);
			this.tabVendas.Controls.Add(this.label3);
			this.tabVendas.Controls.Add(this.dataGridVendas);
			this.tabVendas.Location = new System.Drawing.Point(4, 29);
			this.tabVendas.Name = "tabVendas";
			this.tabVendas.Size = new System.Drawing.Size(1138, 537);
			this.tabVendas.TabIndex = 2;
			this.tabVendas.Text = "Vendas";
			this.tabVendas.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(394, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Itens da venda:";
			// 
			// dataGridItensVenda
			// 
			this.dataGridItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridItensVenda.Location = new System.Drawing.Point(732, 85);
			this.dataGridItensVenda.Name = "dataGridItensVenda";
			this.dataGridItensVenda.RowTemplate.Height = 28;
			this.dataGridItensVenda.Size = new System.Drawing.Size(398, 333);
			this.dataGridItensVenda.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Vendas:";
			// 
			// dataGridVendas
			// 
			this.dataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridVendas.Location = new System.Drawing.Point(3, 85);
			this.dataGridVendas.MultiSelect = false;
			this.dataGridVendas.Name = "dataGridVendas";
			this.dataGridVendas.RowTemplate.Height = 28;
			this.dataGridVendas.Size = new System.Drawing.Size(723, 449);
			this.dataGridVendas.TabIndex = 0;
			this.dataGridVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVendas_CellContentClick);
			// 
			// tabValorTotalCompras
			// 
			this.tabValorTotalCompras.Controls.Add(this.label5);
			this.tabValorTotalCompras.Controls.Add(this.label6);
			this.tabValorTotalCompras.Controls.Add(this.lblValorTotal);
			this.tabValorTotalCompras.Controls.Add(this.lblClienteMaiorValorTotal);
			this.tabValorTotalCompras.Controls.Add(this.dataGridValorTotalCompras);
			this.tabValorTotalCompras.Location = new System.Drawing.Point(4, 29);
			this.tabValorTotalCompras.Name = "tabValorTotalCompras";
			this.tabValorTotalCompras.Padding = new System.Windows.Forms.Padding(3);
			this.tabValorTotalCompras.Size = new System.Drawing.Size(1138, 537);
			this.tabValorTotalCompras.TabIndex = 3;
			this.tabValorTotalCompras.Text = "Valor Total em Compras";
			this.tabValorTotalCompras.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(232, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Valor total:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(309, 20);
			this.label6.TabIndex = 3;
			this.label6.Text = "Cliente com Maior Valor Total em Compras";
			// 
			// lblValorTotal
			// 
			this.lblValorTotal.AutoSize = true;
			this.lblValorTotal.Location = new System.Drawing.Point(323, 39);
			this.lblValorTotal.Name = "lblValorTotal";
			this.lblValorTotal.Size = new System.Drawing.Size(0, 20);
			this.lblValorTotal.TabIndex = 2;
			// 
			// lblClienteMaiorValorTotal
			// 
			this.lblClienteMaiorValorTotal.AutoSize = true;
			this.lblClienteMaiorValorTotal.Location = new System.Drawing.Point(323, 19);
			this.lblClienteMaiorValorTotal.Name = "lblClienteMaiorValorTotal";
			this.lblClienteMaiorValorTotal.Size = new System.Drawing.Size(0, 20);
			this.lblClienteMaiorValorTotal.TabIndex = 1;
			// 
			// dataGridValorTotalCompras
			// 
			this.dataGridValorTotalCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridValorTotalCompras.Location = new System.Drawing.Point(6, 91);
			this.dataGridValorTotalCompras.Name = "dataGridValorTotalCompras";
			this.dataGridValorTotalCompras.RowTemplate.Height = 28;
			this.dataGridValorTotalCompras.Size = new System.Drawing.Size(841, 446);
			this.dataGridValorTotalCompras.TabIndex = 0;
			// 
			// tabMaiorCompraAno
			// 
			this.tabMaiorCompraAno.Controls.Add(this.label7);
			this.tabMaiorCompraAno.Controls.Add(this.label8);
			this.tabMaiorCompraAno.Controls.Add(this.valorMaiorCompraAno);
			this.tabMaiorCompraAno.Controls.Add(this.clienteMaiorCompraAno);
			this.tabMaiorCompraAno.Controls.Add(this.dataGridHigherSaleOnYear);
			this.tabMaiorCompraAno.Controls.Add(this.label2);
			this.tabMaiorCompraAno.Controls.Add(this.txtAno);
			this.tabMaiorCompraAno.Controls.Add(this.button1);
			this.tabMaiorCompraAno.Location = new System.Drawing.Point(4, 29);
			this.tabMaiorCompraAno.Name = "tabMaiorCompraAno";
			this.tabMaiorCompraAno.Size = new System.Drawing.Size(1138, 537);
			this.tabMaiorCompraAno.TabIndex = 4;
			this.tabMaiorCompraAno.Text = "Maior Compra no Ano";
			this.tabMaiorCompraAno.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(514, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Valor total:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(349, 13);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(250, 20);
			this.label8.TabIndex = 14;
			this.label8.Text = "Cliente com Maior Compra no Ano";
			// 
			// valorMaiorCompraAno
			// 
			this.valorMaiorCompraAno.AutoSize = true;
			this.valorMaiorCompraAno.Location = new System.Drawing.Point(605, 38);
			this.valorMaiorCompraAno.Name = "valorMaiorCompraAno";
			this.valorMaiorCompraAno.Size = new System.Drawing.Size(36, 20);
			this.valorMaiorCompraAno.TabIndex = 13;
			this.valorMaiorCompraAno.Text = "bbb";
			// 
			// clienteMaiorCompraAno
			// 
			this.clienteMaiorCompraAno.AutoSize = true;
			this.clienteMaiorCompraAno.Location = new System.Drawing.Point(605, 13);
			this.clienteMaiorCompraAno.Name = "clienteMaiorCompraAno";
			this.clienteMaiorCompraAno.Size = new System.Drawing.Size(45, 20);
			this.clienteMaiorCompraAno.TabIndex = 12;
			this.clienteMaiorCompraAno.Text = "aaaa";
			// 
			// dataGridHigherSaleOnYear
			// 
			this.dataGridHigherSaleOnYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridHigherSaleOnYear.Location = new System.Drawing.Point(12, 74);
			this.dataGridHigherSaleOnYear.Name = "dataGridHigherSaleOnYear";
			this.dataGridHigherSaleOnYear.RowTemplate.Height = 28;
			this.dataGridHigherSaleOnYear.Size = new System.Drawing.Size(1123, 460);
			this.dataGridHigherSaleOnYear.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(187, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Ano:";
			// 
			// txtAno
			// 
			this.txtAno.Location = new System.Drawing.Point(235, 38);
			this.txtAno.Name = "txtAno";
			this.txtAno.Size = new System.Drawing.Size(91, 26);
			this.txtAno.TabIndex = 9;
			this.txtAno.Text = "2016";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 20);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 47);
			this.button1.TabIndex = 8;
			this.button1.Text = "Maior Compra";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabRanking
			// 
			this.tabRanking.Controls.Add(this.label10);
			this.tabRanking.Controls.Add(this.lblClienteMaisFiel);
			this.tabRanking.Controls.Add(this.dataGridUnicSalesPerClient);
			this.tabRanking.Location = new System.Drawing.Point(4, 29);
			this.tabRanking.Name = "tabRanking";
			this.tabRanking.Size = new System.Drawing.Size(1138, 537);
			this.tabRanking.TabIndex = 5;
			this.tabRanking.Text = "Ranking de Fidelidade";
			this.tabRanking.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 21);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 20);
			this.label10.TabIndex = 18;
			this.label10.Text = "Cliente mais Fiel:";
			// 
			// lblClienteMaisFiel
			// 
			this.lblClienteMaisFiel.AutoSize = true;
			this.lblClienteMaisFiel.Location = new System.Drawing.Point(142, 21);
			this.lblClienteMaisFiel.Name = "lblClienteMaisFiel";
			this.lblClienteMaisFiel.Size = new System.Drawing.Size(45, 20);
			this.lblClienteMaisFiel.TabIndex = 16;
			this.lblClienteMaisFiel.Text = "aaaa";
			// 
			// dataGridUnicSalesPerClient
			// 
			this.dataGridUnicSalesPerClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridUnicSalesPerClient.Location = new System.Drawing.Point(3, 70);
			this.dataGridUnicSalesPerClient.Name = "dataGridUnicSalesPerClient";
			this.dataGridUnicSalesPerClient.RowTemplate.Height = 28;
			this.dataGridUnicSalesPerClient.Size = new System.Drawing.Size(808, 464);
			this.dataGridUnicSalesPerClient.TabIndex = 5;
			// 
			// lblPreco
			// 
			this.lblPreco.AutoSize = true;
			this.lblPreco.Location = new System.Drawing.Point(810, 228);
			this.lblPreco.Name = "lblPreco";
			this.lblPreco.Size = new System.Drawing.Size(49, 20);
			this.lblPreco.TabIndex = 11;
			this.lblPreco.Text = "preço";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1146, 657);
			this.Controls.Add(this.panelInterface);
			this.Controls.Add(this.Console);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Vinhos Velasquez";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelInterface.ResumeLayout(false);
			this.tabClientes.ResumeLayout(false);
			this.tabClientes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
			this.tabItens.ResumeLayout(false);
			this.tabItens.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).EndInit();
			this.tabVendas.ResumeLayout(false);
			this.tabVendas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridItensVenda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).EndInit();
			this.tabValorTotalCompras.ResumeLayout(false);
			this.tabValorTotalCompras.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridValorTotalCompras)).EndInit();
			this.tabMaiorCompraAno.ResumeLayout(false);
			this.tabMaiorCompraAno.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridHigherSaleOnYear)).EndInit();
			this.tabRanking.ResumeLayout(false);
			this.tabRanking.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridUnicSalesPerClient)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Console;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem importClientsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importHistoryToolStripMenuItem;
		private System.Windows.Forms.TabControl panelInterface;
		private System.Windows.Forms.TabPage tabClientes;
		private System.Windows.Forms.TabPage tabItens;
		private System.Windows.Forms.Label lblClientes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabVendas;
		private System.Windows.Forms.DataGridView dataGridClientes;
		private System.Windows.Forms.Button btnSugerir;
		private System.Windows.Forms.DataGridView dataGridItens;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridItensVenda;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridVendas;
		private System.Windows.Forms.ToolStripMenuItem importarTudoToolStripMenuItem;
		private System.Windows.Forms.TabPage tabValorTotalCompras;
		private System.Windows.Forms.Label lblVariedade;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.TabPage tabMaiorCompraAno;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAno;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage tabRanking;
		private System.Windows.Forms.Label lblPais;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lblSafra;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.DataGridView dataGridValorTotalCompras;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblValorTotal;
		private System.Windows.Forms.Label lblClienteMaiorValorTotal;
		private System.Windows.Forms.DataGridView dataGridHigherSaleOnYear;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label valorMaiorCompraAno;
		private System.Windows.Forms.Label clienteMaiorCompraAno;
		private System.Windows.Forms.DataGridView dataGridUnicSalesPerClient;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblClienteMaisFiel;
		private System.Windows.Forms.Label lblPreco;
	}
}

