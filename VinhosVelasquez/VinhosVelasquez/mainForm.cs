using System;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/***************************
 * Para instalar Newtonsoft.Json no Visual Studio 2017,
 * proceda da seguinite forma:
 * 
 * Abra o concole do Package Manager no Menu:
 * View->Other Windows->Package Manager Console
 * 
 * Aguarde inicializar e entre com o seguinte comando:
 * PM> Install-Package Newtonsoft.Json
 * 
 * Após a instalação o pacote Newtonsoft.Json estará disponível.
 * 
 */
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VinhosVelasquez
{
	public partial class MainForm : Form
	{
		SqlConnection connection;
		string connectionString;

		public MainForm()
		{
			InitializeComponent();

			connectionString = ConfigurationManager.ConnectionStrings["VinhosVelasquez.Properties.Settings.VinhosVelasquezConnectionString"].ConnectionString;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			PopulateClients();
			Console.Text = "Load Ready!";
		}

		private void SelectedIndex_Changed(object sender, EventArgs e)
		{
			Console.Text = "Panel Changed:"+panelInterface.SelectedTab.Name;
			switch (panelInterface.SelectedTab.Name) {
				case "tabClientes":
					PopulateClients();
					break;
				case "tabItens":
					PopulateItems();
					break;
				case "tabVendas":
					PopulateSales();
					break;
				case "tabValorTotalCompras":
					PopulateTotalSalesPerClient();
					break;
				case "tabMaiorCompraAno":
					PopulateHigherSalesPerYear();
					break;
				case "tabRanking":
					PopulateNumberOfSalesPerClient();
					break;
				default:
					break;
			}
		}

		private void PopulateClients()
		{
			string query = "SELECT * FROM Clientes";

			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				DataTable tableClients = new DataTable();
				adapter.Fill(tableClients);

				BindingSource bSource = new BindingSource();
				bSource.DataSource = tableClients;
				dataGridClientes.DataSource = bSource;
			}
		}

		private void PopulateItems()
		{
			string query = "SELECT * FROM Itens";

			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				DataTable tableItems = new DataTable();
				adapter.Fill(tableItems);

				BindingSource bSource = new BindingSource();
				bSource.DataSource = tableItems;
				dataGridItens.DataSource = bSource;
			}
		}

		private void PopulateSales()
		{
			string query = "SELECT * FROM Vendas";

			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				DataTable tableItems = new DataTable();
				adapter.Fill(tableItems);

				BindingSource bSource = new BindingSource();
				bSource.DataSource = tableItems;
				dataGridVendas.DataSource = bSource;
			}
		}

		private void PopulateSalesItems(int saleId)
		{
			string query = "SELECT a.codigo, a.produto, a.variedade, a.pais, a.categoria, a.safra, a.preco FROM Itens a " +
				"INNER JOIN ItensVendas b ON a.id = b.ItemID " +
				"WHERE b.VendaId = @VendaId";

			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				command.Parameters.AddWithValue("@VendaId", saleId);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				BindingSource bSource = new BindingSource();
				bSource.DataSource = dataTable;
				dataGridItensVenda.DataSource = bSource;
			}
		}


		private void PopulateTotalSalesPerClient()
		{
			string query = "SELECT a.nome, a.cpf, b.valor_total FROM Clientes a " +
				"INNER JOIN Vendas b ON a.cpf = b.cpf_cliente " +
				"ORDER BY a.cpf";

			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				BindingSource bSource = new BindingSource();
				bSource.DataSource = dataTable;
				dataGridValorTotalCompras.DataSource = bSource;
			}
			
			// Merge and sum values per client
			int currentRow = 0;
			for (int i = 1; i<dataGridValorTotalCompras.RowCount-1; i++) {
				if (i == currentRow) continue;
				string currentCPF = dataGridValorTotalCompras.Rows[currentRow].Cells[1].Value.ToString();
				string nextCPF = dataGridValorTotalCompras.Rows[i].Cells[1].Value.ToString();
				if(currentCPF == nextCPF) {
					float newValue = float.Parse(dataGridValorTotalCompras.Rows[currentRow].Cells[2].Value.ToString());
					newValue += float.Parse(dataGridValorTotalCompras.Rows[i].Cells[2].Value.ToString());
					dataGridValorTotalCompras.Rows[currentRow].Cells[2].Value = newValue.ToString();
					dataGridValorTotalCompras.Rows.RemoveAt(i);
					i--;
				}
				else {
					currentRow++;
				}
			}
			dataGridValorTotalCompras.Sort(dataGridValorTotalCompras.Columns[2], System.ComponentModel.ListSortDirection.Descending);
			lblClienteMaiorValorTotal.Text = dataGridValorTotalCompras.Rows[0].Cells[0].Value.ToString();
			lblValorTotal.Text = dataGridValorTotalCompras.Rows[0].Cells[2].Value.ToString();
			
		}

		private void PopulateHigherSalesPerYear()
		{
			string query = "SELECT b.data, a.nome, a.cpf, b.valor_total FROM Clientes a " +
				"INNER JOIN Vendas b ON a.cpf = b.cpf_cliente " +
				"ORDER BY a.cpf";

			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				BindingSource bSource = new BindingSource();
				bSource.DataSource = dataTable;
				dataGridHigherSaleOnYear.DataSource = bSource;
			}

			// Change date for asked year only. Delete other years.
			for(int i=0; i<dataGridHigherSaleOnYear.RowCount-1; i++) {
				string str = dataGridHigherSaleOnYear.Rows[i].Cells[0].Value.ToString();
				str = str.Substring(str.Length - 4);
				if (str == txtAno.Text) {
					dataGridHigherSaleOnYear.Rows[i].Cells[0].Value = str;
				}
				else {
					dataGridHigherSaleOnYear.Rows.RemoveAt(i);
					i--;
				}
			}

			// Keep only highest sale for each client
			int currentRow = 0;
			float highestValue = 0;
			float newValue = 0;
			for (int i = 1; i < dataGridHigherSaleOnYear.RowCount - 1; i++) {
				//if (true) continue;
				if (i == currentRow) continue;
				string currentCPF = dataGridHigherSaleOnYear.Rows[currentRow].Cells[2].Value.ToString();
				string nextCPF = dataGridHigherSaleOnYear.Rows[i].Cells[2].Value.ToString();
				//if (false){ 
				if (currentCPF == nextCPF) {
					highestValue = float.Parse(dataGridHigherSaleOnYear.Rows[currentRow].Cells[3].Value.ToString());
					newValue = float.Parse(dataGridHigherSaleOnYear.Rows[i].Cells[3].Value.ToString());
					if(newValue > highestValue) {
						dataGridHigherSaleOnYear.Rows[currentRow].Cells[3].Value = newValue.ToString();
					}
					dataGridHigherSaleOnYear.Rows.RemoveAt(i);
					i--;
				}
				else {
					currentRow++;
				}
			}
			dataGridHigherSaleOnYear.Sort(dataGridHigherSaleOnYear.Columns[3], System.ComponentModel.ListSortDirection.Descending);
			clienteMaiorCompraAno.Text = dataGridHigherSaleOnYear.Rows[0].Cells[1].Value.ToString();
			valorMaiorCompraAno.Text = dataGridHigherSaleOnYear.Rows[0].Cells[3].Value.ToString();
		}

		private void PopulateNumberOfSalesPerClient()
		{
			string query = "SELECT a.nome, a.cpf FROM Clientes a " +
				"INNER JOIN Vendas b ON a.cpf = b.cpf_cliente " +
				"ORDER BY a.cpf";

			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				BindingSource bSource = new BindingSource();
				bSource.DataSource = dataTable;
				dataGridUnicSalesPerClient.DataSource = bSource;
			}
			// Add new Column with number of sales
			if (dataGridUnicSalesPerClient.Columns.Count < 3) {
				dataGridUnicSalesPerClient.Columns.Add("nrVendas", "Nro. Vendas");
				dataGridUnicSalesPerClient.Update();
			}
			int currentRow = 0;
			int salesCount = 0;
			for (int i = 1; i < dataGridUnicSalesPerClient.RowCount - 1; i++) {
				//if (true) continue;
				if (i == currentRow) continue;
				string currentCPF = dataGridUnicSalesPerClient.Rows[currentRow].Cells[1].Value.ToString();
				string nextCPF = dataGridUnicSalesPerClient.Rows[i].Cells[1].Value.ToString();
				if (currentCPF == nextCPF) {
					if (salesCount == 0) salesCount = 1;
					salesCount++;
					dataGridUnicSalesPerClient.Rows[currentRow].Cells[2].Value = salesCount.ToString();
					dataGridUnicSalesPerClient.Rows.RemoveAt(i);
					i--;
				}
				else {
					currentRow++;
					salesCount = 0;
				}
			}

			// Reorder according to fidelity
			bool changed;
			do {
				changed = false;
				for (int i = 1; i < dataGridUnicSalesPerClient.RowCount - 1; i++) {
					int nr1 = int.Parse(dataGridUnicSalesPerClient.Rows[i - 1].Cells[2].Value.ToString());
					int nr2 = int.Parse(dataGridUnicSalesPerClient.Rows[i].Cells[2].Value.ToString());
					if (nr1 < nr2) {
						SwapDatagridViewRows(i, i - 1, ref dataGridUnicSalesPerClient);
						changed = true;
					}
				}
			} while (changed == true);
			lblClienteMaisFiel.Text = dataGridUnicSalesPerClient.Rows[0].Cells[0].Value.ToString();
		}

		private void SwapDatagridViewRows(int r1, int r2, ref DataGridView grid)
		{
			for (int i = 0; i < grid.ColumnCount; i++) {
				string temp = grid.Rows[r1].Cells[i].Value.ToString();
				grid.Rows[r1].Cells[i].Value = grid.Rows[r2].Cells[i].Value.ToString();
				grid.Rows[r2].Cells[i].Value = temp;
			}
		}

		private void ImportClients()
		{
			string filename = "..\\..\\..\\cadastro.json";
			Console.Text = "Iniciada importação de clientes:" + filename;

			int newClients = 0;

			StreamReader r = new StreamReader(filename);
			string json = r.ReadToEnd();
			List<Cliente> items = JsonConvert.DeserializeObject<List<Cliente>>(json);

			foreach (Cliente c in items) {
				// Verificar se o id já existe no DB
				// Caso não exista, insere um novo cliente e incrementa newClients
				if (c.InsertDB()) {
					newClients++;
				}
			}

			Console.Text = "Novos clientes inseridos:" + newClients;
		}

		private void importClientsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ImportClients();
			PopulateClients();
		}

		private void ImportHistory()
		{
			string filename = "..\\..\\..\\historico.json";
			Console.Text = "Iniciada importação de Histórico de Compras:" + filename;

			int newSales = 0;

			StreamReader r = new StreamReader(filename);
			string json = r.ReadToEnd();
			List<Venda> vendas = JsonConvert.DeserializeObject<List<Venda>>(json);

			foreach (Venda v in vendas) {
				// Verificar se o id já existe no DB
				// Caso não exista, insere um novo cliente e incrementa newClients
				if (v.InsertDB()) {
					newSales++;
				}
			}
			Console.Text = "Novos vendas inseridas:" + newSales;
		}

		private void importHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ImportHistory();
			PopulateItems();
			PopulateSales();
		}

		private void importarTudoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			importClientsToolStripMenuItem_Click(sender, e);
			importHistoryToolStripMenuItem_Click(sender, e);
		}

		private void dataGridVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dataGridVendas.CurrentRow.Index;
			string s = dataGridVendas.Rows[r].Cells[0].Value.ToString();
			int id = int.Parse(s);

			PopulateSalesItems(id);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PopulateHigherSalesPerYear();
		}

		private void btnSugerir_Click(object sender, EventArgs e)
		{
			int r = dataGridClientes.CurrentRow.Index;
			string cpf = dataGridClientes.Rows[r].Cells[2].Value.ToString();

			FindFavoriteVarietyForClient(cpf, out string variedade);
			Console.Text = variedade;
			MostSoldVariety(variedade, out int itemId);

			string query = "SELECT a.codigo, a.produto, a.variedade, a.pais, a.categoria, a.safra, a.preco FROM Itens a " +
				"WHERE Id = " + itemId.ToString();

			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				DataTable tableItems = new DataTable();
				adapter.Fill(tableItems);

				lblCodigo.Text = tableItems.Rows[0].ItemArray.GetValue(0).ToString();
				lblProduto.Text = tableItems.Rows[0].ItemArray.GetValue(1).ToString();
				lblVariedade.Text = tableItems.Rows[0].ItemArray.GetValue(2).ToString();
				lblPais.Text = tableItems.Rows[0].ItemArray.GetValue(3).ToString();
				lblCategoria.Text = tableItems.Rows[0].ItemArray.GetValue(4).ToString();
				lblSafra.Text = tableItems.Rows[0].ItemArray.GetValue(5).ToString();
				lblPreco.Text = tableItems.Rows[0].ItemArray.GetValue(6).ToString();
			}

		}

		private void FindFavoriteVarietyForClient(string clientCPF, out string variedade)
		{
			variedade = "";
			string query;
			List<string> catList = new List<string>();
			List<int> scores;
			List<string> varScores;
			query = "SELECT  i.variedade FROM Itens i "+
				"INNER JOIN ItensVendas iv ON i.id = iv.ItemID "+
				"INNER JOIN Vendas v ON v.Id = iv.VendaId " +
				"WHERE v.cpf_cliente = @CPFcliente; ";


			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				command.Parameters.AddWithValue("@CPFcliente", clientCPF);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				for (int i = 0; i < dataTable.Rows.Count; i++) {
					variedade = dataTable.Rows[i].ItemArray.GetValue(0).ToString();
					catList.Add(variedade);
				}
			}

			scores = new List<int>();
			varScores = new List<string>();

			foreach (string c in catList) {
				if (varScores.Contains(c)) {
					int i = varScores.FindIndex(x => x == c );
					scores[i]++;
				}
				else {
					varScores.Add(c);
					scores.Add(1);
				}

			}
			int max = 0;
			int index = 0;
			for (int i=0; i<scores.Count; i++) {
				if (scores[i] > max) {
					max = scores[i];
					index = i;
				}
			}
			variedade = varScores[index];
		}

		private void MostSoldVariety(string variedade, out int id)
		{
			string query, itemId;
			List<string> itemList = new List<string>();
			List<int> scores;
			List<string> itemScores;
			query = "SELECT a.Id FROM Itens a "+
				"INNER JOIN ItensVendas b ON a.id = b.ItemID " +
				"INNER JOIN Vendas v ON v.Id = b.VendaId "+
				"WHERE a.variedade = @Variedade";


			using (connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
				command.Parameters.AddWithValue("@Variedade", variedade);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				for (int i = 0; i < dataTable.Rows.Count; i++) {
					itemId = dataTable.Rows[i].ItemArray.GetValue(0).ToString();
					itemList.Add(itemId);
				}
			}

			scores = new List<int>();
			itemScores = new List<string>();

			foreach (string c in itemList) {
				if (itemScores.Contains(c)) {
					int i = itemScores.FindIndex(x => x == c);
					scores[i]++;
				}
				else {
					itemScores.Add(c);
					scores.Add(1);
				}

			}
			int max = 0;
			int index = 0;
			for (int i = 0; i < scores.Count; i++) {
				if (scores[i] > max) {
					max = scores[i];
					index = i;
				}
			}
			id = int.Parse(itemScores[index]);
		}
	}
}
