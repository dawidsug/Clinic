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

        public List<DoctorModel> GetDoctors_All()
        {
            List<DoctorModel> doctors = GlobalConfig.DoctorFile.FullFilePath().LoadFile().ConvertToDoctorModel();
            return doctors;
        }
    }
}
