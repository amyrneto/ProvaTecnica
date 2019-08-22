using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace VinhosVelasquez
{
	class Item:DataObject
	{
		public string codigo { get; set; }
		public string produto { get; set; }
		public string variedade { get; set; }
		public string pais { get; set; }
		public string categoria { get; set; }
		public string safra { get; set; }
		public float preco { get; set; }
		
		public Item()
		{
			codigo = "";
		}

		public bool InsertDB(out int id)
		{
			id = -1;
			using (connection = new System.Data.SqlClient.SqlConnection(connectionString)) {
				// Insert only if id does not exist.
				string query = "SELECT Id, codigo FROM Itens WHERE " +
					"produto = @Produto AND " +
					"variedade = @Variedade AND " +
					"pais = @Pais AND " +
					"categoria = @Categoria AND " +
					"safra = @Safra AND " +
					"preco = @Preco;";

				using (System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(query, connection)) {
					adapter.SelectCommand.Parameters.AddWithValue("@Produto", produto);
					adapter.SelectCommand.Parameters.AddWithValue("@Variedade", variedade);
					adapter.SelectCommand.Parameters.AddWithValue("@Pais", pais);
					adapter.SelectCommand.Parameters.AddWithValue("@Categoria", categoria);
					adapter.SelectCommand.Parameters.AddWithValue("@Safra", safra);
					adapter.SelectCommand.Parameters.AddWithValue("@Preco", preco);

					DataTable dt = new DataTable();
					adapter.Fill(dt);
					BindingSource bSource = new BindingSource();
					bSource.DataSource = dt;
					
					
					if (dt.Rows.Count != 0) {
						//string sid = bSource.List[0].ToString();
						id = dt.Rows[0].Field<int>(0);
						string codItem = dt.Rows[0].Field<string>(1);
						codItem = codItem.Trim();
						if(codItem == "" && codigo != "") {
							// 
							codItem = codigo;
							// Update table with item code
						}
						return false;
					}
				}
				// Insere o item
				query = "INSERT INTO Itens VALUES(@Codigo, @Produto, @Variedade, @Pais, @Categoria, @Safra, @Preco); SELECT SCOPE_IDENTITY();";

				using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection)) {
					connection.Open();
					command.Parameters.AddWithValue("@Codigo", codigo);
					command.Parameters.AddWithValue("@Produto", produto);
					command.Parameters.AddWithValue("@Variedade", variedade);
					command.Parameters.AddWithValue("@Pais", pais);
					command.Parameters.AddWithValue("@Categoria", categoria);
					command.Parameters.AddWithValue("@Safra", safra);
					command.Parameters.AddWithValue("@Preco", preco);
					id = Convert.ToInt32(command.ExecuteScalar());
					//command.ExecuteNonQuery();
				}
			}
			return true;
		}

	}
}
