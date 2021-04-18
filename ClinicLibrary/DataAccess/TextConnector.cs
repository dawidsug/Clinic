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

            if(controlMarker == true)
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
    }
}
