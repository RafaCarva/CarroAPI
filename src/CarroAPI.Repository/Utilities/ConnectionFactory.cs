using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CarroAPI.Repository.Utilities
{
    public static class ConnectionFactory
    {
        private static string _sqlConnection =
    "server=23.98.153.101;database=DeveloperDB09;user=developer;password=dev123DEV123";
        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(_sqlConnection);

            conn.Open();

            return conn;
        }
    }
}
