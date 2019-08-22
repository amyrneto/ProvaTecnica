using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VinhosVelasquez
{
	class Venda:DataObject
	{
		public string codigo { get; set; }
		public string data { get; set; }
		public string cliente { get; set; }
		public List<Item> itens { get; set; }
		public float valorTotal { get; set; }


		public override bool InsertDB()
		{
			using (connection = new System.Data.SqlClient.SqlConnection(connectionString)) {
				// check if the sales exist by code
				string query = "SELECT * FROM Vendas WHERE " +
					"codigo = @Codigo AND " +
					"data = @Data AND " +
					"cpf_cliente = @cpfCliente AND " +
					"valor_total = @valorTotal";
				using (System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(query, connection)) {
					adapter.SelectCommand.Parameters.AddWithValue("@Codigo", codigo);
					adapter.SelectCommand.Parameters.AddWithValue("@Data", data);
					adapter.SelectCommand.Parameters.AddWithValue("@cpfCliente", cliente);
					adapter.SelectCommand.Parameters.AddWithValue("@valorTotal", valorTotal);

					DataTable dt = new DataTable();
					adapter.Fill(dt);
					if (dt.Rows.Count != 0) {
						return false;
					}
				}

				query = "INSERT INTO Vendas VALUES(@Codigo, @Data, @cpfCliente, @valorTotal); SELECT SCOPE_IDENTITY();";
				int vendaId;
				using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection)) {
					connection.Open();
					command.Parameters.AddWithValue("@Codigo", codigo);
					command.Parameters.AddWithValue("@Data", data);
					command.Parameters.AddWithValue("@cpfCliente", cliente);
					command.Parameters.AddWithValue("@valorTotal", valorTotal);
					vendaId = Convert.ToInt32(command.ExecuteScalar());
					//command.ExecuteNonQuery();
				}

				// Parsear Itens
				foreach (Item i in itens) {
					i.InsertDB(out int itemId);

					query = "INSERT INTO ItensVendas VALUES(@codVenda, @codItem)";

					using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection)) {
						command.Parameters.AddWithValue("@codItem", itemId);
						command.Parameters.AddWithValue("@codVenda", vendaId);
						command.ExecuteNonQuery();
					}
				}
			}
			return true;
		}
	}
}

