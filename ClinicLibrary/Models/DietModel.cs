using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary
{
    public class DietModel
    {
        /// <summary>
        /// Diet id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Diet name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Number of days in that diet.
        /// </summary>
        public int NumberOfDays { get; set; }
        /// <summary>
        /// List of days in that diet.
        /// </summary>
        public List<DayModel> Days { get; set; } = new List<DayModel>();
    }
}
