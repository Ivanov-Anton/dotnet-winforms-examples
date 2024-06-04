#nullable disable warnings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace dotnet_winforms_examples
{
    public class DatabaseManager
    {
        private static DatabaseManager instance;

        private DatabaseManager() { }

        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                }
                return instance;
            }
        }

        public NpgsqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return new NpgsqlConnection(connectionString);
        }
    }


}
