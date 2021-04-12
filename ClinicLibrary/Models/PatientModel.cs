using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary
{
    public class PatientModel
    {
        /// <summary>
        /// Patient id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Patient first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Patient last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Patient nickname in Clinic program.
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// Patient email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Patient cellphone number.
        /// </summary>
        public string CellphoneNumber { get; set; }
        /// <summary>
        /// Diet id in database which is assigned to this Patient.
        /// </summary>
        public int Diets { get; set; }
        //TODO Diet Id will be list of DietModel! 


        public string FullName
        {
            get { return $" { FirstName } { LastName} "; }
        }
    }
}
