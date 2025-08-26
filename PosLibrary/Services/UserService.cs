using PosLibrary.Data;
using PosLibrary.Models;
using System.Data.SQLite;
namespace PosLibrary.Services
{
    public class UserService
    {
        private readonly Database _db;
        public UserService(Database db)
        {
            _db = db;
        }
        public User Login( string username, string password)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                var cmd = new SQLiteCommand("SELECT Id, Username, Password, Role FROM Users WHERE Username=@u AND Password=@p", con);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        Id = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2),
                        Role = reader.GetString(3)
                    };
                }
            }
            return null;
        }
    }
}
