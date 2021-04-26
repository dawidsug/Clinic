using ClinicLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicUI.Main_Forms
{
    public partial class MealsForm : Form
    {
        //TODO Recalculate and save like a new product - when changed amount

        List<MealModel> allMeals = GlobalConfig.Connection.GetMeals_All();
        List<ProductModel> allProducts = GlobalConfig.Connection.GetProducts_All();
        List<TypeOfMealModel> allTypes = GlobalConfig.Connection.GetTypeOfMeals_All();
        List<ProductModel> selectedProducts = new List<ProductModel>();

        public MealsForm()
        {
            InitializeComponent();
            WiredUpLists();
        }

        private void WiredUpLists()
        {
            //allMeals = GlobalConfig.Connection.GetMeals_All();
            //allProducts = GlobalConfig.Connection.GetProducts_All();
            //allTypes = GlobalConfig.Connection.GetTypeOfMeals_All();

            allProductsListBox.DisplayMember = "";
            allProductsListBox.DataSource = allProducts;
            allProductsListBox.DisplayMember = "ProductName";
            
            selectedProductsListBox.DisplayMember = "";
            selectedProductsListBox.DataSource = selectedProducts;
            selectedProductsListBox.DisplayMember = "ProductName";

            allMealsListBox.DisplayMember = "";
            allMealsListBox.DataSource = allMeals;
            allMealsListBox.DisplayMember = "Name";

            typeOfMealDropDown.DataSource = allTypes;
            typeOfMealDropDown.DisplayMember = "Name";
            
        }

        private void allProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayValues(sender);
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            MealModel model = (MealModel)allMealsListBox.SelectedItem;
            ProductModel product = (ProductModel)allProductsListBox.SelectedItem;
            selectedProducts.Add(product);
            model.Products = selectedProducts;
            GlobalConfig.Connection.CheckMealExistence(model);
            allProducts = GlobalConfig.Connection.GetProducts_All();
            WiredUpLists();
        }

        private void DisplayValues(object sender)
        {
            ListBox lb = sender as ListBox;
            ProductModel selectedProduct = (ProductModel)lb.SelectedItem;

            productNameText.Text = selectedProduct.ProductName;
            amountText.Text = selectedProduct.Amount.ToString();
            unitText.Text = selectedProduct.Unit.ToString();
            kcalText.Text = selectedProduct.Kcal.ToString();
            fatText.Text = selectedProduct.Fat.ToString();
            nktText.Text = selectedProduct.NKT.ToString();
            jktText.Text = selectedProduct.JKT.ToString();
            wktText.Text = selectedProduct.WKT.ToString();
            transText.Text = selectedProduct.Trans.ToString();
            cholesterolText.Text = selectedProduct.Cholesterol.ToString();
            sodiumText.Text = selectedProduct.Sodium.ToString();
            potassiumText.Text = selectedProduct.Potassium.ToString();
            carbohydratesText.Text = selectedProduct.Carbohydrates.ToString();
            fiberText.Text = selectedProduct.Fiber.ToString();
            sugarText.Text = selectedProduct.Sugar.ToString();
            proteinText.Text = selectedProduct.Protein.ToString();
            vitaminAText.Text = selectedProduct.VitaminA.ToString();
            calciumText.Text = selectedProduct.Calcium.ToString();
            vitaminDText.Text = selectedProduct.VitaminD.ToString();
            vitaminB12Text.Text = selectedProduct.VitaminB12.ToString();
            ascorbicAcidText.Text = selectedProduct.AscorbicAcid.ToString();
            ironText.Text = selectedProduct.Iron.ToString();
            vitaminB6Text.Text = selectedProduct.VitaminB6.ToString();
            magnesiumText.Text = selectedProduct.Magnesium.ToString();
        }

        private void selectedProductsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            DisplayValues(sender);
        }

        private void displayMealValuesButton_Click(object sender, EventArgs e)
        {
            CalculateMeal();
        }

        private void CalculateMeal()
        {
            int amountSum = 0;
            int kcalSum = 0;
            int fatSum = 0;
            int nktSum = 0;
            int jktSum = 0;
            int wktSum = 0;
            int transSum = 0;
            int cholesterolSum = 0;
            int sodiumSum = 0;
            int potassiumSum = 0;
            int carbohydratesSum = 0;
            int fiberSum = 0;
            int sugarSum = 0;
            int proteinSum = 0;
            int vitaminASum = 0;
            int calciumSum = 0;
            int vitaminDSum = 0;
            int vitaminB12Sum = 0;
            int ascorbicAcidSum = 0;
            int ironSum = 0;
            int vitaminB6Sum = 0;
            int magnesiumSum = 0;
            foreach (ProductModel product in selectedProducts)
            {
                amountSum += product.Amount;
                kcalSum += product.Kcal;
                fatSum += product.Fat;
                nktSum += product.NKT;
                jktSum += product.JKT;
                wktSum += product.WKT;
                transSum += product.Trans;
                cholesterolSum += product.Cholesterol;
                sodiumSum += product.Sodium;
                potassiumSum += product.Potassium;
                carbohydratesSum += product.Carbohydrates;
                fiberSum += product.Fiber;
                sugarSum += product.Sugar;
                proteinSum += product.Protein;
                vitaminASum += product.VitaminA;
                calciumSum += product.Calcium;
                vitaminDSum += product.VitaminD;
                vitaminB12Sum =+ product.VitaminB12;
                ascorbicAcidSum =+ product.AscorbicAcid;
                ironSum = +product.Iron;
                vitaminB6Sum =+ product.VitaminB6;
                magnesiumSum =+ product.Magnesium;
            }
            //productNameText.Text = allMeals.SelectedItem;
            amountText.Text = amountSum.ToString();
            kcalText.Text = kcalSum.ToString();
            fatText.Text = fatSum.ToString();
            nktText.Text = nktSum.ToString();
            jktText.Text = jktSum.ToString();
            wktText.Text = wktSum.ToString();
            transText.Text = transSum.ToString();
            cholesterolText.Text = cholesterolSum.ToString();
            sodiumText.Text = sodiumSum.ToString();
            potassiumText.Text = potassiumSum.ToString();
            carbohydratesText.Text = carbohydratesSum.ToString();
            fiberText.Text = fiberSum.ToString();
            sugarText.Text = sugarSum.ToString();
            proteinText.Text = proteinSum.ToString();
            vitaminAText.Text = vitaminASum.ToString();
            calciumText.Text = calciumSum.ToString();
            vitaminDText.Text = vitaminDSum.ToString();
            vitaminB12Text.Text = vitaminB12Sum.ToString();
            ascorbicAcidText.Text = ascorbicAcidSum.ToString();
            ironText.Text = ironSum.ToString();
            vitaminB6Text.Text = vitaminB6Sum.ToString();
            magnesiumText.Text = magnesiumSum.ToString();
            
        }

        private void addMealButton_Click(object sender, EventArgs e)
        {
            MealModel m = new MealModel();
            TypeOfMealModel tm = new TypeOfMealModel();

            m.Name = mealNameText.Text;
            tm = (TypeOfMealModel)typeOfMealDropDown.SelectedItem;
            m.TypeOfMealId = tm.Id;

            GlobalConfig.Connection.CreateMeal(m);
            mealNameText.Text = "";
            allMeals = GlobalConfig.Connection.GetMeals_All();
            WiredUpLists();
        }

        /*private void saveMealButton_Click(object sender, EventArgs e)
        {
            MealModel m = new MealModel();
            MealModel oldMeal = (MealModel)allMealsListBox.SelectedItem;
            m.Id = oldMeal.Id;
            m.Name = oldMeal.Name;
            m.TypeOfMealId = oldMeal.TypeOfMealId;
            foreach (TypeOfMealModel type in allTypes)
            {
                if (type == typeOfMealDropDown.SelectedItem)
                {
                    m.TypeOfMealId = type.Id;
                }
            }
            foreach (ProductModel product in selectedProducts)
            {
                m.Products.Add(product);
            }
            GlobalConfig.Connection.CheckMealExistence(m);
        }*/

        private void addTypeOfMealButton_Click(object sender, EventArgs e)
        {
            TypeOfMealModel tm = new TypeOfMealModel();
            tm.Name = newTypeOfMealText.Text;

            GlobalConfig.Connection.CreateTypeOfMeal(tm);
            newTypeOfMealText.Text = "";
            allTypes = GlobalConfig.Connection.GetTypeOfMeals_All();
            WiredUpLists();
        }
        

        private void allMealsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            MealModel m = (MealModel)allMealsListBox.SelectedItem;
            selectedProducts = m.Products;
            selectedProductsListBox.DisplayMember = "";
            selectedProductsListBox.DataSource = selectedProducts;
            selectedProductsListBox.DisplayMember = "ProductName";
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (selectedProductsListBox.SelectedItem != null)
            {
                MealModel meal = (MealModel)allMealsListBox.SelectedItem;
                ProductModel selectedProduct = (ProductModel)selectedProductsListBox.SelectedItem;
                selectedProducts.Remove(selectedProduct);
                meal.Products = selectedProducts;
                GlobalConfig.Connection.CheckMealExistence(meal);
                allProducts = GlobalConfig.Connection.GetProducts_All();
                WiredUpLists(); 
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(allMealsListBox.SelectedItem != null)
            {
                MealModel meal = (MealModel)allMealsListBox.SelectedItem;
                GlobalConfig.Connection.DeleteMeal(meal);
                allMeals.Remove(meal);
                allMeals = GlobalConfig.Connection.GetMeals_All();
                WiredUpLists();
            }
        }
    }
}
