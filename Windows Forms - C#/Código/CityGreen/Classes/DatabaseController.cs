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
        private string connectionString = "Server=DESKTOP-C8MJ6C3;Database=CityGreen;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }    

}

