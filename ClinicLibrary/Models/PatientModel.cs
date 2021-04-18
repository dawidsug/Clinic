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
        /// Patient weight.
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Patient height.
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Patient sex.
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// Patient age.
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Diet id in database which is assigned to this Patient.
        /// </summary>
        public List<DietModel> Diets { get; set; }
        /// <summary>
        /// Ingredients that the patient doesn't want or can't eat.
        /// </summary>
        public List<ProductModel> ExcludedProducts { get; set; }

        public string FullName
        {
            get { return $" { FirstName } { LastName} "; }
        }
    }
}
