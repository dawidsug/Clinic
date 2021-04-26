using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary
{
    public class MealModel
    {
        /// <summary>
        /// Meal id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of meal.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Type of meal id in database.
        /// </summary>
        public int TypeOfMealId { get; set; }
        /// <summary>
        /// List of products in that meal.
        /// </summary>
        public List<ProductModel> Products { get; set; } = new List<ProductModel>();
        
    }
}
