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

namespace ClinicUI
{
    public partial class LoginForm : Form
    {
        List<DoctorModel> actualDoctors = GlobalConfig.Connection.GetDoctors_All();

        public LoginForm()
        {
            InitializeComponent();
            WiredUpLists();
        }

        private void WiredUpLists()
        {
            doctorsDropDown.DataSource = null;
            doctorsDropDown.DataSource = actualDoctors;
            doctorsDropDown.DisplayMember = "Nickname";
        }

        private void newDoctorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
        }
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            DoctorModel d = (DoctorModel)doctorsDropDown.SelectedItem;
            foreach (DoctorModel doctor in actualDoctors)
            {
                if(doctor.Nickname == d.Nickname)
                {
                    if(doctor.Password == passwordText.Text)
                    {
                        MainForm mf = new MainForm();
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password is not correct! Try once again.");
                    }
                }
            }
        }

        private void doctorsDropDown_DropDown(object sender, EventArgs e)
        {
            actualDoctors = GlobalConfig.Connection.GetDoctors_All();
            WiredUpLists();
        }
    }
}
