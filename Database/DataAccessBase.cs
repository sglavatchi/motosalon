using System.Configuration;

namespace Motosalon.Database
{
    public class DataAccessBase
    {
       public static string LoadConnectionString(string id = "DefaultConnection")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
