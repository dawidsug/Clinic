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

                connection.Execute("dbo.spDoctor_Insert", p, commandType: CommandType.StoredProcedure);

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

                connection.Execute("dbo.spPatient_Insert", p, commandType: CommandType.StoredProcedure);
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
    }
}
