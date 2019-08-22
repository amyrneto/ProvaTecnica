using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace VinhosVelasquez
{

	class DataObject
	{
		protected SqlConnection connection;
		protected string connectionString;

		public DataObject()
		{
			connectionString = ConfigurationManager.ConnectionStrings["VinhosVelasquez.Properties.Settings.VinhosVelasquezConnectionString"].ConnectionString;
		}

		public virtual bool InsertDB()
		{
			return false;
		}

		public virtual bool UpdateDB()
		{
			return false;
		}

		public virtual bool DeleteDB()
		{
			return false;
		}

		public virtual bool ReadDB(int id)
		{
			return false;
		}
	}
}