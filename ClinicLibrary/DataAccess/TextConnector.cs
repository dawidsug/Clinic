using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary.DataAccess
{
    public class TextConnector : IDataConnector
    {
        public void CreateDoctor(DoctorModel model)
        {
            List<DoctorModel> doctors = GlobalConfig.DoctorFile.FullFilePath().LoadFile().ConvertToDoctorModel();
            int currentId = 1;
            if (doctors.Count > 0)
            {
                currentId = doctors.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            doctors.Add(model);

            doctors.SaveToDoctorFile();
        }

        public void CreatePatient(PatientModel model)
        {
            List<PatientModel> patients = GlobalConfig.DoctorFile.FullFilePath().LoadFile().ConvertToPatientModel();
            int currentId = 1;
            if (patients.Count > 0)
            {
                currentId = patients.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            patients.Add(model);

            patients.SaveToPatientFile();
        }

        public void CheckProductExistence(ProductModel model)
        {
            List<ProductModel> products = GlobalConfig.ProductFile.FullFilePath().LoadFile().ConvertToProductModel();
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
                model.UpdateProductToFile();
            }
            else
            {
                CreateProduct(model);
            }

        }

        public void CreateProduct(ProductModel model)
        {
            List<ProductModel> products = GlobalConfig.ProductFile.FullFilePath().LoadFile().ConvertToProductModel();
            int currentId = 1;
            if (products.Count > 0)
            {
                currentId = products.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            products.Add(model);

            products.SaveToProductFile();
        }

        public List<DoctorModel> GetDoctors_All()
        {
            List<DoctorModel> doctors = GlobalConfig.DoctorFile.FullFilePath().LoadFile().ConvertToDoctorModel();
            return doctors;
        }

        public List<PatientModel> GetPatients_All()
        {
            List<PatientModel> patients = GlobalConfig.PatientFile.FullFilePath().LoadFile().ConvertToPatientModel();
            return patients;
        }

        public List<ProductModel> GetProducts_All()
        {
            List<ProductModel> patients = GlobalConfig.ProductFile.FullFilePath().LoadFile().ConvertToProductModel();
            return patients;
        }

        public void CreateMeal(MealModel model)
        {
            List<MealModel> meals = GlobalConfig.MealFile.FullFilePath().LoadFile().ConvertToMealModel();
            int currentId = 1;
            if (meals.Count > 0)
            {
                currentId = meals.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            meals.Add(model);

            meals.SaveToMealFile();
        }

        public List<MealModel> GetMeals_All()
        {
            List<MealModel> meals = GlobalConfig.MealFile.FullFilePath().LoadFile().ConvertToMealModel();
            return meals;
        }

        public void CreateTypeOfMeal(TypeOfMealModel model)
        {
            List<TypeOfMealModel> typeMeals = GlobalConfig.TypeOfMealFile.FullFilePath().LoadFile().ConvertToTypeMealModel();
            int currentId = 1;
            if (typeMeals.Count > 0)
            {
                currentId = typeMeals.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            typeMeals.Add(model);

            typeMeals.SaveToTypeMealFile();
        }

        public List<TypeOfMealModel> GetTypeOfMeals_All()
        {
            List<TypeOfMealModel> typeMeals = GlobalConfig.TypeOfMealFile.FullFilePath().LoadFile().ConvertToTypeMealModel();
            return typeMeals;
        }

        public void CheckMealExistence(MealModel model)
        {
            List<MealModel> meals = GlobalConfig.MealFile.FullFilePath().LoadFile().ConvertToMealModel();
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
                model.UpdateMealToFile();
            }
            else
            {
                CreateMeal(model);
            }
        }
        
        public void DeleteMeal(MealModel model)
        {
            List<MealModel> meals = GlobalConfig.MealFile.FullFilePath().LoadFile().ConvertToMealModel();
            MealModel toRemove = new MealModel();
            if (meals.Count != 0)
            {
                foreach (MealModel meal in meals)
                {
                    if (model.Id == meal.Id)
                    {
                        toRemove = meal;
                    }
                } 
            }
            meals.Remove(toRemove);
            meals.SaveToMealFile();
        }
    }
}
