using Dapper;
using Motosalon.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Motosalon.Database
{
    internal class UserDataAccess : DataAccessBase
    {
        public static List<User> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("SELECT * FROM UsersTable", new DynamicParameters());

                return output.ToList();
            }
        }

        public static void SaveUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO UsersTable (login,password,email) VALUES (@Login, @Password, @Email)", user);
            }
        }
    }
}
