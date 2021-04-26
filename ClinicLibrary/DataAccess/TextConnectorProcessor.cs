using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePatch"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<DoctorModel> ConvertToDoctorModel(this List<string> lines)
        {
            List<DoctorModel> output = new List<DoctorModel>();
            List<PatientModel> patients = GlobalConfig.PatientFile.FullFilePath().LoadFile().ConvertToPatientModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                DoctorModel d = new DoctorModel();
                d.Id = int.Parse(cols[0]);
                d.FirstName = cols[1];
                d.LastName = cols[2];
                d.Nickname = cols[3];
                d.EmailAddress = cols[4];
                d.CellphoneNumber = cols[5];
                d.Password = cols[6];

                if (cols.Length > 7)
                {
                    string[] patientsIds = cols[7].Split('|');

                    foreach (string id in patientsIds)
                    {
                        d.Patients.Add(patients.Where(x => x.Id == int.Parse(id)).First());
                    } 
                }

                output.Add(d);
            }

            return output;
        }
        public static List<ProductModel> ConvertToProductModel(this List<string> lines)
        {
            List<ProductModel> output = new List<ProductModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ProductModel p = new ProductModel();
                p.Id = int.Parse(cols[0]);
                p.ProductName = cols[1];
                p.Amount = int.Parse(cols[2]);
                p.Unit = cols[3];
                p.Kcal = int.Parse(cols[4]);
                p.Fat = int.Parse(cols[5]);
                p.NKT = int.Parse(cols[6]);
                p.JKT = int.Parse(cols[7]);
                p.WKT = int.Parse(cols[8]);
                p.Trans = int.Parse(cols[9]);
                p.Cholesterol = int.Parse(cols[10]);
                p.Sodium = int.Parse(cols[11]);
                p.Potassium = int.Parse(cols[12]);
                p.Carbohydrates = int.Parse(cols[13]);
                p.Fiber = int.Parse(cols[14]);
                p.Sugar = int.Parse(cols[15]);
                p.Protein = int.Parse(cols[16]);
                p.VitaminA = int.Parse(cols[17]);
                p.Calcium = int.Parse(cols[18]);
                p.VitaminD = int.Parse(cols[19]);
                p.VitaminB12 = int.Parse(cols[20]);
                p.AscorbicAcid = int.Parse(cols[21]);
                p.Iron = int.Parse(cols[22]);
                p.VitaminB6 = int.Parse(cols[23]);
                p.Magnesium = int.Parse(cols[24]);
                /*
                if (cols.Length > 25)
                {
                    string[] patientsIds = cols[25].Split('|');

                    foreach (string id in patientsIds)
                    {
                        d.Patients.Add(patients.Where(x => x.Id == int.Parse(id)).First());
                    }
                }
                */
                output.Add(p);
            }

            return output;
        }

        public static List<MealModel> ConvertToMealModel(this List<string> lines)
        {
            List<MealModel> output = new List<MealModel>();
            List<ProductModel> products = GlobalConfig.ProductFile.FullFilePath().LoadFile().ConvertToProductModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MealModel m = new MealModel();
                m.Id = int.Parse(cols[0]);
                m.Name = cols[1];
                m.TypeOfMealId = int.Parse(cols[2]);

                if (cols.Length > 3)
                {
                    string[] productsIds = cols[3].Split('|');

                    foreach (string id in productsIds)
                    {
                        if (id != "")
                        {
                            m.Products.Add(products.Where(x => x.Id == int.Parse(id)).First()); 
                        }
                    }
                }

                output.Add(m);
            }

            return output;
        }

        public static List<TypeOfMealModel> ConvertToTypeMealModel(this List<string> lines)
        {
            List<TypeOfMealModel> output = new List<TypeOfMealModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TypeOfMealModel tm = new TypeOfMealModel();
                tm.Id = int.Parse(cols[0]);
                tm.Name = cols[1];

                output.Add(tm);
            }

            return output;
        }

        public static void SaveToDoctorFile(this List<DoctorModel> models)
        {
            List<string> lines = new List<string>();

            foreach (DoctorModel d in models)
            {
                lines.Add($"{ d.Id },{ d.FirstName },{ d.LastName },{ d.Nickname },{ d.EmailAddress },{ d.CellphoneNumber },{ d.Password }");
            }

            File.WriteAllLines(GlobalConfig.DoctorFile.FullFilePath(), lines);
        }

        public static void SaveToPatientFile(this List<PatientModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PatientModel p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.Nickname },{ p.EmailAddress },{ p.CellphoneNumber }");
            }

            File.WriteAllLines(GlobalConfig.PatientFile.FullFilePath(), lines);
        }

        public static void SaveToProductFile(this List<ProductModel> models)
        {
            List<string> lines = new List<string>();

            foreach (ProductModel p in models)
            {
                lines.Add($"{ p.Id },{ p.ProductName },{ p.Amount },{ p.Unit },{ p.Kcal },{ p.Fat },{ p.NKT },{ p.JKT },{ p.WKT },{ p.Trans },{ p.Cholesterol },{ p.Sodium },{ p.Potassium },{ p.Carbohydrates },{ p.Fiber },{ p.Sugar },{ p.Protein },{ p.VitaminA },{ p.Calcium },{ p.VitaminD },{ p.VitaminB12 },{ p.AscorbicAcid },{ p.Iron },{ p.VitaminB6 },{ p.Magnesium }");
            }

            File.WriteAllLines(GlobalConfig.ProductFile.FullFilePath(), lines);
        }

        public static void SaveToMealFile(this List<MealModel> models)
        {
            List<string> lines = new List<string>();

            foreach (MealModel m in models)
            {
                lines.Add($"{ m.Id },{ m.Name },{ m.TypeOfMealId },{ ConvertProductsListToString(m.Products) }");
            }

            File.WriteAllLines(GlobalConfig.MealFile.FullFilePath(), lines);
        }

        public static void SaveToTypeMealFile(this List<TypeOfMealModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TypeOfMealModel tm in models)
            {
                lines.Add($"{ tm.Id },{ tm.Name }");
            }

            File.WriteAllLines(GlobalConfig.TypeOfMealFile.FullFilePath(), lines);
        }

        public static List<PatientModel> ConvertToPatientModel(this List<string> lines)
        {
            List<PatientModel> output = new List<PatientModel>();
            //List<DietModel> diets = GlobalConfig.PatientFile.FullFilePath().LoadFile().ConvertToDietModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PatientModel p = new PatientModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.Nickname = cols[3];
                p.EmailAddress = cols[4];
                p.CellphoneNumber = cols[5];
                //TODO When Patient model will be changed uncomment this
                /*
                string[] dietsIds = cols[6].Split('|');

                foreach (string id in dietsIds)
                {
                    p.Diets.Add(diets.Where(x => x.Id == int.Parse(id)).First());
                }*/

                output.Add(p);
            }

            return output;
        }

        public static void UpdateProductToFile(this ProductModel product)
        {
            List<ProductModel> products = GlobalConfig.ProductFile.FullFilePath().LoadFile().ConvertToProductModel();

            ProductModel oldProduct = new ProductModel();

            foreach (ProductModel p in products)
            {
                if (p.Id == product.Id)
                {
                    oldProduct = p;
                }
            }

            products.Remove(oldProduct);

            products.Add(product);

            List<string> lines = new List<string>();

            foreach (ProductModel p in products)
            {
                lines.Add($"{ p.Id },{ p.ProductName },{ p.Amount },{ p.Unit },{ p.Kcal },{ p.Fat },{ p.NKT },{ p.JKT },{ p.WKT },{ p.Trans },{ p.Cholesterol },{ p.Sodium },{ p.Potassium },{ p.Carbohydrates },{ p.Fiber },{ p.Sugar },{ p.Protein },{ p.VitaminA },{ p.Calcium },{ p.VitaminD },{ p.VitaminB12 },{ p.AscorbicAcid },{ p.Iron },{ p.VitaminB6 },{ p.Magnesium }");
            }
            File.WriteAllLines(GlobalConfig.ProductFile.FullFilePath(), lines);
        }

        public static void UpdateMealToFile(this MealModel meal)
        {
            List<MealModel> meals = GlobalConfig.MealFile.FullFilePath().LoadFile().ConvertToMealModel();

            MealModel oldMeal = new MealModel();

            foreach (MealModel m in meals)
            {
                if (m.Id == meal.Id)
                {
                    oldMeal = m;
                }
            }

            meals.Remove(oldMeal);

            meals.Add(meal);

            List<string> lines = new List<string>();

            foreach (MealModel m in meals)
            {
                lines.Add($"{ m.Id },{ m.Name },{ m.TypeOfMealId },{ ConvertProductsListToString(m.Products) }");
            }
            File.WriteAllLines(GlobalConfig.MealFile.FullFilePath(), lines);
        }

        private static string ConvertProductsListToString(List<ProductModel> products)
        {
            string output = "";

            if (products.Count == 0)
            {
                return "";
            }

            foreach (ProductModel p in products)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
