using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary
{
    public class DoctorModel
    {
        /// <summary>
        /// Doctor id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Doctor first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Doctor last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Doctor nickname in Clinic program.
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// Doctor email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Doctor cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }
        /// <summary>
        /// Password for this Doctor account.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// List of patients in database which are assigned to this doctor.
        /// </summary>
        public List<PatientModel> Patients { get; set; } = new List<PatientModel>();
    }
    
        
}
