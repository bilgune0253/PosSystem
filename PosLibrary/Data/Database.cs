using System.Data.SQLite;

namespace PosLibrary.Data
{
    public class Database
    {
        private readonly string _connectionString;
        public Database(string dbPath)
        {
            _connectionString = $"Data Source = {dbPath}";
        }
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(_connectionString);
        }
    }
            
}
