using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary.DataAccess
{
    public class SqlConnector : IDataConnector
    {
        private const string db = "Clinic";

        public void CheckProductExistence(ProductModel model)
        {
            List<ProductModel> products = GetProducts_All();
            bool controlMarker = false;

            foreach (ProductModel p in products)
            {
                if (p.ProductName == model.ProductName)
                {
                    controlMarker = true;
                    model.Id = p.Id;
                }
            }

            if (controlMarker == true)
            {
                UpdateProduct(model);
            }
            else
            {
                CreateProduct(model);
            }
        }

        public void CreateDoctor(DoctorModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@NickName", model.Nickname);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@Password", model.Password);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDoctors_Insert", p, commandType: CommandType.StoredProcedure);
                
                //model.Id = p.Get<int>("@id");
            }
        }

        public void CreatePatient(PatientModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@NickName", model.Nickname);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPatients_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateProduct(ProductModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ProductName", model.ProductName);
                p.Add("@Amount", model.Amount);
                p.Add("@Unit", model.Unit);
                p.Add("@Kcal", model.Kcal);
                p.Add("@Fat", model.Fat);
                p.Add("@NKT", model.NKT);
                p.Add("@JKT", model.JKT);
                p.Add("@WKT", model.WKT);
                p.Add("@Trans", model.Trans);
                p.Add("@Cholesterol", model.Cholesterol);
                p.Add("@Sodium", model.Sodium);
                p.Add("@Potassium", model.Potassium);
                p.Add("@Carbohydrates", model.Carbohydrates);
                p.Add("@Fiber", model.Fiber);
                p.Add("@Sugar", model.Sugar);
                p.Add("@Protein", model.Protein);
                p.Add("@VitaminA", model.VitaminA);
                p.Add("@Calcium", model.Calcium);
                p.Add("@VitaminD", model.VitaminD);
                p.Add("@VitaminB12", model.VitaminB12);
                p.Add("@AscorbicAcid", model.AscorbicAcid);
                p.Add("@Iron", model.Iron);
                p.Add("@VitaminB6", model.VitaminB6);
                p.Add("@Magnesium", model.Magnesium);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spProducts_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateProduct(ProductModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", model.Id);
                p.Add("@ProductName", model.ProductName);
                p.Add("@Amount", model.Amount);
                p.Add("@Unit", model.Unit);
                p.Add("@Kcal", model.Kcal);
                p.Add("@Fat", model.Fat);
                p.Add("@NKT", model.NKT);
                p.Add("@JKT", model.JKT);
                p.Add("@WKT", model.WKT);
                p.Add("@Trans", model.Trans);
                p.Add("@Cholesterol", model.Cholesterol);
                p.Add("@Sodium", model.Sodium);
                p.Add("@Potassium", model.Potassium);
                p.Add("@Carbohydrates", model.Carbohydrates);
                p.Add("@Fiber", model.Fiber);
                p.Add("@Sugar", model.Sugar);
                p.Add("@Protein", model.Protein);
                p.Add("@VitaminA", model.VitaminA);
                p.Add("@Calcium", model.Calcium);
                p.Add("@VitaminD", model.VitaminD);
                p.Add("@VitaminB12", model.VitaminB12);
                p.Add("@AscorbicAcid", model.AscorbicAcid);
                p.Add("@Iron", model.Iron);
                p.Add("@VitaminB6", model.VitaminB6);
                p.Add("@Magnesium", model.Magnesium);

                connection.Execute("dbo.spProducts_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<DoctorModel> GetDoctors_All()
        {
            List<DoctorModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                output = connection.Query<DoctorModel>("dbo.spDoctors_GetAll").ToList();
            }
            return output;
        }

        public List<PatientModel> GetPatients_All()
        {
            List<PatientModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                output = connection.Query<PatientModel>("dbo.spPatients_GetAll").ToList();
            }
            return output;
        }

        public List<ProductModel> GetProducts_All()
        {
            List<ProductModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                output = connection.Query<ProductModel>("dbo.spProducts_GetAll").ToList();
            }
            return output;
        }
    }
}
