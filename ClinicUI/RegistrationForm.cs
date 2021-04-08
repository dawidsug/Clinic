using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicLibrary;

namespace ClinicUI
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            registryButton.ForeColor = System.Drawing.Color.FromArgb(104, 104, 104);
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
            if (passwordText.TextLength < 5)
            {
                return false;
            }
            if (passwordAgainText.TextLength < 5)
            {
                return false;
            }
            if (passwordText.Text != passwordAgainText.Text)
            {
                return false;
            }

            return true;
        }

        private void registryButton_Click(object sender, EventArgs e)
        {
            if (ValidationForm())
            {
                DoctorModel d = new DoctorModel();
                d.FirstName = firstNameText.Text;
                d.LastName = lastNameText.Text;
                d.EmailAddress = emailText.Text;
                d.CellphoneNumber = cellphoneText.Text;
                d.Nickname = nicknameText.Text;
                d.Password = passwordText.Text;

                GlobalConfig.Connection.CreateDoctor(d);

                firstNameText.Text = "";
                lastNameText.Text = "";
                emailText.Text = "";
                cellphoneText.Text = "";
                nicknameText.Text = "";
                passwordText.Text = "";
                passwordAgainText.Text = "";

                //LoginForm lf = new LoginForm();
                //lf.Show();

                this.Close();

            }
            else
            {
                if (passwordText.Text != passwordAgainText.Text || passwordText.TextLength != passwordAgainText.TextLength)
                {
                    MessageBox.Show("Passwords are not the same!");
                }
                else
                {
                    MessageBox.Show("Fill in all fields!");
                }

            }
        }
        
        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            if (progressBar.Value <= 84)
            {
                if (firstNameText.TextLength == 1)
                {
                    progressBar.Value += 16;
                }
                if (ValidationForm())
                {
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(200, 230, 46);
                } 
            }
        }

        private void firstNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (firstNameText.TextLength == 1)
                {
                    progressBar.Value -= 16;
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(104, 104, 104);
                }
                if (firstNameText.TextLength == 2)
                {
                    progressBar.Value -= 16;
                }
            }
        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {
            if (progressBar.Value <= 84)
            {
                if (lastNameText.TextLength == 1)
                {
                    progressBar.Value += 16;
                }
                if (ValidationForm())
                {
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(200, 230, 46);
                } 
            }
        }

        private void lastNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (lastNameText.TextLength == 1)
                {
                    progressBar.Value -= 16;
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(104, 104, 104);
                }
                if (lastNameText.TextLength == 2)
                {
                    progressBar.Value -= 16;
                }
            }
        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {
            if (progressBar.Value <= 84)
            {
                if (emailText.TextLength == 1)
                {
                    progressBar.Value += 16;
                }
                if (ValidationForm())
                {
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(200, 230, 46);
                } 
            }
        }

        private void emailText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (emailText.TextLength == 1)
                {
                    progressBar.Value -= 16;
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(104, 104, 104);
                }
                if (emailText.TextLength == 2)
                {
                    progressBar.Value -= 16;
                }
            }
        }

        private void cellphoneText_TextChanged(object sender, EventArgs e)
        {
            if (progressBar.Value <= 84)
            {
                if (cellphoneText.TextLength == 1)
                {
                    progressBar.Value += 16;
                }
                if (ValidationForm())
                {
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(200, 230, 46);
                } 
            }
        }

        private void cellphoneText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (cellphoneText.TextLength == 1)
                {
                    progressBar.Value -= 16;
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(104, 104, 104);
                }
                if (cellphoneText.TextLength == 2)
                {
                    progressBar.Value -= 16;
                }
            }
        }

        private void nicknameText_TextChanged(object sender, EventArgs e)
        {
            if (progressBar.Value <= 84)
            {
                if (nicknameText.TextLength == 1)
                {
                    progressBar.Value += 16;
                }
                if (ValidationForm())
                {
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(200, 230, 46);
                } 
            }
        }

        private void nicknameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (nicknameText.TextLength == 1)
                {
                    progressBar.Value -= 16;
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(104, 104, 104);
                }
                if (nicknameText.TextLength == 2)
                {
                    progressBar.Value -= 16;
                }
            }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (progressBar.Value <= 90)
            {
                if (passwordText.TextLength == 5)
                {
                    progressBar.Value += 10;
                }
                if (ValidationForm())
                {
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(200, 230, 46);
                } 
            }
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (passwordText.TextLength == 5)
                {
                    progressBar.Value -= 10;
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(104, 104, 104);
                }
                if (passwordText.TextLength == 6)
                {
                    progressBar.Value -= 10;
                }
            }
        }

        private void passwordAgainText_TextChanged(object sender, EventArgs e)
        {
            if (progressBar.Value <= 90)
            {
                if (passwordAgainText.TextLength >= 5 && passwordAgainText.Text == passwordText.Text)
                {
                    progressBar.Value += 10;
                }
                if (ValidationForm())
                {
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(200, 230, 46);
                } 
            }
        }

        private void passwordAgainText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (passwordAgainText.TextLength == 5)
                {
                    progressBar.Value -= 10;
                    registryButton.ForeColor = System.Drawing.Color.FromArgb(104, 104, 104);
                }
                if (passwordAgainText.TextLength == 6)
                {
                    progressBar.Value -= 10;
                }
            }
        }
    }
}
