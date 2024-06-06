#nullable disable warnings

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
