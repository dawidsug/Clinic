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

//TODO Save excluded products

namespace ClinicUI.Main_Forms
{
    public partial class NewClientForm : Form
    {
        List<string> SexType = new List<string>();
        List<ProductModel> AllProducts = GlobalConfig.Connection.GetProducts_All();
        List<ProductModel> ExcludedProducts = new List<ProductModel>();

        public NewClientForm()
        {
            InitializeComponent();
            InitializeSexDropDown();
            WiredUpLists();
        }

        private void WiredUpLists()
        {
            allProductsListBox.DisplayMember = "";
            allProductsListBox.DataSource = AllProducts;
            allProductsListBox.DisplayMember = "ProductName";
            excludedProductsListBox.DisplayMember = "";
            excludedProductsListBox.DataSource = ExcludedProducts;
            excludedProductsListBox.DisplayMember = "ProductName";
        }

        private void InitializeSexDropDown()
        {
            SexType.Add("Male");
            SexType.Add("Female");
            sexDropDown.DataSource = SexType;
        }

        private bool ValidationForm()
        {
            if (firstNameText.TextLength == 0)
            {
                return false;
            }
            if (lastNameText.TextLength == 0)
            {
                return false;
            }
            if (emailText.TextLength == 0)
            {
                return false;
            }
            if (cellphoneText.TextLength == 0)
            {
                return false;
            }
            if (nicknameText.TextLength == 0)
            {
                return false;
            }
            if (nicknameText.TextLength == 0)
            {
                return false;
            }
            if (weightText.TextLength == 0)
            {
                return false;
            }
            if (heightText.TextLength == 0)
            {
                return false;
            }
            if (ageText.TextLength == 0)
            {
                return false;
            }
            if (sexDropDown.SelectedItem == null)
            {
                return false;
            }

            return true;
        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            if (ValidationForm())
            {
                PatientModel p = new PatientModel();
                p.FirstName = firstNameText.Text;
                p.LastName = lastNameText.Text;
                p.EmailAddress = emailText.Text;
                p.CellphoneNumber = cellphoneText.Text;
                p.Nickname = nicknameText.Text;
                p.Weight = Int32.Parse(weightText.Text);
                p.Height = Int32.Parse(heightText.Text);
                p.Age = Int32.Parse(ageText.Text);
                p.Sex = (string)sexDropDown.SelectedItem;

                GlobalConfig.Connection.CreatePatient(p);

                firstNameText.Text = "";
                lastNameText.Text = "";
                emailText.Text = "";
                cellphoneText.Text = "";
                nicknameText.Text = "";
                weightText.Text = "";
                heightText.Text = "";
                ageText.Text = "";
            }
            else
            {
                MessageBox.Show("Fill in all fields!");
            }
        }

        private void excludeButton_Click(object sender, EventArgs e)
        {
            ProductModel product = new ProductModel();
            foreach (ProductModel p in AllProducts)
            {
                if(p == (ProductModel)allProductsListBox.SelectedItem)
                {
                    product = p;
                }
            }
            ExcludedProducts.Add(product);
            AllProducts.Remove(product);
            WiredUpLists();
        }

        private void deselectButton_Click(object sender, EventArgs e)
        {
            ProductModel product = new ProductModel();
            foreach (ProductModel p in ExcludedProducts)
            {
                if (p == (ProductModel)excludedProductsListBox.SelectedItem)
                {
                    product = p;
                }
            }
            AllProducts.Add(product);
            ExcludedProducts.Remove(product);
            WiredUpLists();
        }
    }
}
