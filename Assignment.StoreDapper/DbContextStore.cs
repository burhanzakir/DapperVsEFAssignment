using Microsoft.Data.SqlClient;
using System.Data;

namespace Assignment.StoreDapper
{
    public class DbContextStore
    {
        private readonly string _connectionString;
        public DbContextStore(string sqlConnection)
        {
            _connectionString = sqlConnection;
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
