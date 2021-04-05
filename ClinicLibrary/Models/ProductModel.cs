using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary
{
    public class ProductModel
    {
        /// <summary>
        /// Product id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of product.
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Ingredient id in database.
        /// </summary>
        public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();
        //When doctor will be creating product that he will be able to change the amount of ingredient in that product. And then will create new ingredient with name IngredientNewamount.
    }
}
