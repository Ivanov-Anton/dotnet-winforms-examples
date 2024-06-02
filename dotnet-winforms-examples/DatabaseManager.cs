using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace dotnet_winforms_examples
{
    internal class DatabaseManager
    {
        private static readonly Lazy<DatabaseManager> instance = new Lazy<DatabaseManager>(() => new DatabaseManager());

        private NpgsqlConnection connection;

        private DatabaseManager()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            // Initialize database connection
            
            connection = new NpgsqlConnection(connectionString);
        }

        public static DatabaseManager Instance => instance.Value;

        public NpgsqlConnection GetConnection()
        {
            return connection;
        }
    }
}
