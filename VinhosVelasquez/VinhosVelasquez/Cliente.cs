using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VinhosVelasquez
{
	class Cliente:DataObject
	{
		public int id { get; set; }
		public string nome { get; set; }
		public string cpf { get; set; }

		

		public override bool InsertDB()
		{
			using (connection = new System.Data.SqlClient.SqlConnection(connectionString)) {
				if (id > 0) {
					// Insert only if id does not exist.
					System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM Clientes WHERE id=" + id.ToString(), connection);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					if (dt.Rows.Count != 0) {
						return false;
					}
				}
				// Insere o cliente this
				string query = "INSERT INTO Clientes VALUES(@nomeCliente, @cpfCliente)";
								
				using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection)) {
					connection.Open();
					command.Parameters.AddWithValue("@nomeCliente", nome);
					command.Parameters.AddWithValue("@cpfCliente", cpf);
					command.ExecuteNonQuery();
				}
			}
			return true;
		}
	}


}
