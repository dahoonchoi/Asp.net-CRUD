using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models.Connection
{
    public class Dbinfo
    {
        public static SqlConnection MsConnection()
        {
            return new SqlConnection(DbString());
        }
        public static string DbString()
        {
            return new SqlConnectionStringBuilder
            {
                DataSource = "testserverd.database.windows.net",
                InitialCatalog = "Testdb",
                UserID = "cdh",
                Password = "@kh4645as9787"
            }.ToString();
            
            
        }
    }
}
