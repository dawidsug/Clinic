using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary
{
    public class DayModel
    {
        /// <summary>
        /// Day id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Diet id for which this day applies.
        /// </summary>
        public int DietId { get; set; }
        /// <summary>
        /// Type of meal id in that day.
        /// </summary>
        public List<MealModel> Meals { get; set; } = new List<MealModel>();
    }
}
