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
    public partial class NewClientForm : Form
    {
        List<string> SexType = new List<string>();
        List<ProductModel> AllProducts = new List<ProductModel>();
        List<ProductModel> ExcludedProducts = new List<ProductModel>();

        public NewClientForm()
        {
            InitializeComponent();
            InitializeSexDropDown();
            WiredUpLists();
        }

        private void WiredUpLists()
        {
            allProductsListBox.DataSource = AllProducts;
            excludedProductsListBox.DataSource = ExcludedProducts;
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
            foreach (ProductModel p in AllProducts)
            {
                if(p.ProductName == (string)allProductsListBox.SelectedItem)
                {
                    ExcludedProducts.Add(p);
                    AllProducts.Remove(p);
                }
            }
            WiredUpLists();
        }

        private void deselectButton_Click(object sender, EventArgs e)
        {
            foreach (ProductModel p in ExcludedProducts)
            {
                if (p.ProductName == (string)excludedProductsListBox.SelectedItem)
                {
                    AllProducts.Add(p);
                    ExcludedProducts.Remove(p);
                }
            }
            WiredUpLists();
        }
    }
}
