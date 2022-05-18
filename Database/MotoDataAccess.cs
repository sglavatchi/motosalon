using Dapper;
using Motosalon.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Motosalon.Database
{
    internal class MotoDataAccess : DataAccessBase
    {
        public static List<MotorcycleBaseClass> LoadMoto()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MotorcycleBaseClass>("SELECT * FROM MotoTable", new DynamicParameters());

                return output.ToList();
            }
        }

        public static void SaveMoto(MotorcycleBaseClass motorcycle)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO MotoTable (brand,model,color,kindOfFuel,power) VALUES (@Brand, @Model, @FuelType, @Power)", motorcycle);
            }
        }
    }
}
