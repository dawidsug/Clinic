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
    }
}
