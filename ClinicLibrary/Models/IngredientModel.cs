using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLibrary
{
    public class IngredientModel
    {
        /// <summary>
        /// Ingredient id in database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ingredient name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Amount of ingredient to calculations in grams.
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// The amount of kcal.
        /// </summary>
        public int Kcal { get; set; }
        /// <summary>
        /// The amount of fat.
        /// </summary>
        public int Fat { get; set; }
        /// <summary>
        /// The amount of saturated fatty acids.
        /// </summary>
        public int NKT { get; set; }
        /// <summary>
        /// The amount of monounsaturated fatty acids.
        /// </summary>
        public int JKT { get; set; }
        /// <summary>
        /// The amount of polyunsaturated fatty acids.
        /// </summary>
        public int WKT { get; set; }
        /// <summary>
        /// The amount of cholesterol.
        /// </summary>
        public int Cholesterol { get; set; }
        /// <summary>
        /// The amount of sodium.
        /// </summary>
        public int Sodium { get; set; }
        /// <summary>
        /// The amount of potassium.
        /// </summary>
        public int Potassium { get; set; }
        /// <summary>
        /// The amount of corbohydrates.
        /// </summary>
        public int Carbohydrates { get; set; }
        /// <summary>
        /// The amount of fiber.
        /// </summary>
        public int Fiber { get; set; }
        /// <summary>
        /// The amount of sugar.
        /// </summary>
        public int Sugar { get; set; }
        /// <summary>
        /// The amount of protein.
        /// </summary>
        public int Protein { get; set; }
        /// <summary>
        /// The amount of vitamin A.
        /// </summary>
        public int VitaminA { get; set; }
        /// <summary>
        /// The amount of calcium.
        /// </summary>
        public int Calcium { get; set; }
        /// <summary>
        /// The amount of vitamin D.
        /// </summary>
        public int VitaminD { get; set; }
        /// <summary>
        /// The amount of vitamin B12.
        /// </summary>
        public int VitaminB12 { get; set; }
        /// <summary>
        /// The amount of ascorbic acid.
        /// </summary>
        public int AscorbicAcid { get; set; }
        /// <summary>
        /// The amount of iron.
        /// </summary>
        public int Iron { get; set; }
        /// <summary>
        /// The amount of vitamin B6.
        /// </summary>
        public int VitaminB6 { get; set; }
        /// <summary>
        /// The amount of magnesium.
        /// </summary>
        public int Magnesium { get; set; }
    }
}
