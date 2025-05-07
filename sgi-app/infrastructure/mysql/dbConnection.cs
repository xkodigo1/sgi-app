using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sgi_app.infrastructure.mysql
{
    public class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection()
        {
            string server = "localhost";
            string db = "sgi-db";
            string user = "root";
            string password = "root";
            string port = "3306";

            _connectionString = $"Server={server};Port={port};User ID={user};Password={password};Database={db};";
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                var connection = new MySqlConnection(_connectionString);
                connection.Open();
                Console.WriteLine("Conexión realizada");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conexión no establecida. Error: " + ex.Message);
                return null;
            }
        }
    }
}
