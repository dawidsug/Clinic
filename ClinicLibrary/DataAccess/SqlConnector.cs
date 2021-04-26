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

        public void CheckMealExistence(MealModel model)
        {
            List<MealModel> meals = GetMeals_All();
            bool controlMarker = false;

            foreach (MealModel m in meals)
            {
                if (m.Name == model.Name)
                {
                    controlMarker = true;
                    model.Id = m.Id;
                }
            }

            if (controlMarker == true)
            {
                UpdateMeal(model);
            }
            else
            {
                CreateMeal(model);
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

        public void CreateMeal(MealModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@TypeOfMealId", model.TypeOfMealId);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spMeals_Insert", p, commandType: CommandType.StoredProcedure);
                if (model.Products != null)
                {
                    foreach (ProductModel product in model.Products)
                    {
                        p = new DynamicParameters();
                        p.Add("@MealId", model.Id);
                        p.Add("@ProductId", product.Id);
                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        connection.Execute("dbo.spMealProducts_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        public void UpdateMeal(MealModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@MealId", model.Id);
                connection.Execute("dbo.spMealProducts_DeleteMeal", p, commandType: CommandType.StoredProcedure);

                if (model.Products != null)
                {
                    foreach (ProductModel product in model.Products)
                    {
                        p = new DynamicParameters();
                        p.Add("@MealId", model.Id);
                        p.Add("@ProductId", product.Id);
                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        connection.Execute("dbo.spMealProducts_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }

        public List<MealModel> GetMeals_All()
        {
            List<MealModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                output = connection.Query<MealModel>("dbo.spMeals_GetAll").ToList();
                foreach (MealModel meal in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@MealId", meal.Id);
                    meal.Products = connection.Query<ProductModel>("dbo.spProducts_GetByMeal", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }

        public void CreateTypeOfMeal(TypeOfMealModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTypeOfMeals_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<TypeOfMealModel> GetTypeOfMeals_All()
        {
            List<TypeOfMealModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                output = connection.Query<TypeOfMealModel>("dbo.spTypeOfMeals_GetAll").ToList();
            }
            return output;
        }

        /*public List<ProductModel> GetProductsByMealId()
        {
            List<ProductModel> output = new List<ProductModel>();
            List<MealModel> meals = new List<MealModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                meals = connection.Query<MealModel>("dbo.spMeals_GetAll").ToList();
                foreach (MealModel meal in meals)
                {
                    var p = new DynamicParameters();
                    p.Add("@MealId", meal.Id);
                    output = connection.Query<ProductModel>("dbo.MealProducts_GetByMeal", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }*/

        public void DeleteMeal(MealModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CNNString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@MealId", model.Id);
                connection.Execute("dbo.spMealProducts_DeleteMeal", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();
                p.Add("@id", model.Id);
                connection.Execute("dbo.spMeals_DeleteMeal", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
