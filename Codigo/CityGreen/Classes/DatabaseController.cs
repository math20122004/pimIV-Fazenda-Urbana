using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityGreen.Classes
{
    public class DatabaseController
    {
        private string connectionString = "Server=34.39.146.249;Database=CityGreen;User Id=sqlserver;Password=desktop123;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
