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
        public NewClientForm()
        {
            InitializeComponent();
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

                GlobalConfig.Connection.CreatePatient(p);

                firstNameText.Text = "";
                lastNameText.Text = "";
                emailText.Text = "";
                cellphoneText.Text = "";
                nicknameText.Text = "";
            }
            else
            {
                MessageBox.Show("Fill in all fields!");
            }
        }
    }
}
