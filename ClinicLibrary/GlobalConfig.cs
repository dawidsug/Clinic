using ClinicLibrary.DataAccess;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary
{
    public static class GlobalConfig
    {
        public const string DoctorFile = "DoctorModel.csv";
        public const string PatientFile = "PatientModel.csv";
        public const string ProductFile = "ProductModel.csv";
        public const string MealFile = "MealModel.csv";
        public const string TypeOfMealFile = "TypeOfMealModel.csv";

        public static IDataConnector Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        
        public static string CNNString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
