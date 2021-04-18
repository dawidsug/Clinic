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
    public partial class ProductsForm : Form
    {
        List<string> Units = new List<string>();
        List<ProductModel> AllProducts = GlobalConfig.Connection.GetProducts_All();

        public ProductsForm()
        {
            InitializeComponent();
            InitalizeUnitDropDown();
            WiredUpLists();
        }

        private void WiredUpLists()
        {
            AllProducts = GlobalConfig.Connection.GetProducts_All();
            allProductsListBox.DisplayMember = "";
            allProductsListBox.DataSource = AllProducts;
            allProductsListBox.DisplayMember = "ProductName";
        }

        private void InitalizeUnitDropDown()
        {
            Units.Add("ug");
            Units.Add("mg");
            Units.Add("g");
            Units.Add("ml");
            Units.Add("l");
            Units.Add("dm3");
            unitDropDown.DataSource = Units;
        }

        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            productNameText.Text = "";
            amountText.Text = "";
            kcalText.Text = "";
            fatText.Text = "";
            nktText.Text = "";
            jktText.Text = "";
            wktText.Text = "";
            transText.Text = "";
            cholesterolText.Text = "";
            sodiumText.Text = "";
            potassiumText.Text = "";
            carbohydratesText.Text = "";
            fiberText.Text = "";
            sugarText.Text = "";
            proteinText.Text = "";
            vitaminAText.Text = "";
            calciumText.Text = "";
            vitaminDText.Text = "";
            vitaminB12Text.Text = "";
            ascorbicAcidText.Text = "";
            ironText.Text = "";
            vitaminB6Text.Text = "";
            magnesiumText.Text = "";
        }

        private bool ValidationForm()
        {
            if (productNameText.Text.Length == 0)
            {
                return false;
            }
            if (amountText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(amountText.Text))
            {
                return false;
            }
            if (kcalText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(kcalText.Text))
            {
                return false;
            }
            if (fatText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(fatText.Text))
            {
                return false;
            }
            if (nktText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(nktText.Text))
            {
                return false;
            }
            if (jktText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(jktText.Text))
            {
                return false;
            }
            if (wktText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(wktText.Text))
            {
                return false;
            }
            if (transText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(transText.Text))
            {
                return false;
            }
            if (cholesterolText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(cholesterolText.Text))
            {
                return false;
            }
            if (sodiumText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(sodiumText.Text))
            {
                return false;
            }
            if (potassiumText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(potassiumText.Text))
            {
                return false;
            }
            if (carbohydratesText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(carbohydratesText.Text))
            {
                return false;
            }
            if (fiberText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(fiberText.Text))
            {
                return false;
            }
            if (sugarText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(sugarText.Text))
            {
                return false;
            }
            if (proteinText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(proteinText.Text))
            {
                return false;
            }
            if (vitaminAText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(vitaminAText.Text))
            {
                return false;
            }
            if (calciumText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(calciumText.Text))
            {
                return false;
            }
            if (vitaminDText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(vitaminDText.Text))
            {
                return false;
            }
            if (vitaminB12Text.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(vitaminB12Text.Text))
            {
                return false;
            }
            if (ascorbicAcidText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(ascorbicAcidText.Text))
            {
                return false;
            }
            if (ironText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(ironText.Text))
            {
                return false;
            }
            if (vitaminB6Text.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(vitaminB6Text.Text))
            {
                return false;
            }
            if (magnesiumText.Text.Length == 0)
            {
                return false;
            }
            if (!NumberValidation(magnesiumText.Text))
            {
                return false;
            }

            return true;
        }

        private bool NumberValidation(string text)
        {
            bool output = true;
            int textLength = text.Length;
            for (int i = 0; i < textLength; i++)
            {
                if (!Char.IsNumber(text, i))
                {
                    output = false;
                }
            }
            return output;
        }

        private void addOrUpdateButton_Click(object sender, EventArgs e)
        {
            if(ValidationForm())
            {
                ProductModel p = new ProductModel();
                p.ProductName = productNameText.Text;
                p.Amount = Int32.Parse(amountText.Text);
                p.Unit = (string)unitDropDown.SelectedItem;
                p.Kcal = Int32.Parse(kcalText.Text);
                p.Fat = Int32.Parse(fatText.Text);
                p.NKT = Int32.Parse(nktText.Text);
                p.JKT = Int32.Parse(jktText.Text);
                p.WKT = Int32.Parse(wktText.Text);
                p.Trans = Int32.Parse(transText.Text);
                p.Cholesterol = Int32.Parse(cholesterolText.Text);
                p.Sodium = Int32.Parse(sodiumText.Text);
                p.Potassium = Int32.Parse(potassiumText.Text);
                p.Carbohydrates = Int32.Parse(carbohydratesText.Text);
                p.Fiber = Int32.Parse(fiberText.Text);
                p.Sugar = Int32.Parse(sugarText.Text);
                p.Protein = Int32.Parse(proteinText.Text);
                p.VitaminA = Int32.Parse(vitaminAText.Text);
                p.Calcium = Int32.Parse(calciumText.Text);
                p.VitaminD = Int32.Parse(vitaminDText.Text);
                p.VitaminB12 = Int32.Parse(vitaminB12Text.Text);
                p.AscorbicAcid = Int32.Parse(ascorbicAcidText.Text);
                p.Iron = Int32.Parse(ironText.Text);
                p.VitaminB6 = Int32.Parse(vitaminB6Text.Text);
                p.Magnesium = Int32.Parse(magnesiumText.Text);

                GlobalConfig.Connection.CheckProductExistence(p);
                //TODO create save and load product files - update sql tables, ignore igredient table and update product table

                ClearFields();
                WiredUpLists();
            }
            else
            {
                MessageBox.Show("Fill in all fields!");
            }
        }

        private void allProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductModel selectedProduct = (ProductModel)allProductsListBox.SelectedItem;

            productNameText.Text = selectedProduct.ProductName;
            amountText.Text = selectedProduct.Amount.ToString();
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
    }
}
