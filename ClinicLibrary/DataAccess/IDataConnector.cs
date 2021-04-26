using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary.DataAccess
{
    public interface IDataConnector
    {
        void CreateDoctor(DoctorModel model);
        void CreatePatient(PatientModel model);
        void CreateProduct(ProductModel model);
        void CheckProductExistence(ProductModel model);
        void CreateMeal(MealModel model);
        void CreateTypeOfMeal(TypeOfMealModel model);
        void CheckMealExistence(MealModel model);
        void DeleteMeal(MealModel model);
        List<DoctorModel> GetDoctors_All();
        List<PatientModel> GetPatients_All();
        List<ProductModel> GetProducts_All();
        List<MealModel> GetMeals_All();
        List<TypeOfMealModel> GetTypeOfMeals_All();

    }
}
