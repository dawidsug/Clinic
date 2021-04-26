using ClinicUI.Main_Forms;
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
    public partial class MainForm : Form
    {
        private Form activeForm;
        private Button currentButton;

        public MainForm()
        {
            InitializeComponent();
            OpenMainForms(new ClientsPanelForm(), clientsPanelButton);
        }


        private void clientsPanelButton_Click(object sender, EventArgs e)
        {
            mainFormLeftPanel.BackColor = System.Drawing.Color.FromArgb(125, 122, 226);
            productsButton.BackColor = System.Drawing.Color.FromArgb(125, 122, 226);
            mealsButton.BackColor = System.Drawing.Color.FromArgb(125, 122, 226);
            dietsButton.BackColor = System.Drawing.Color.FromArgb(125, 122, 226);
            clientsPanelButton.BackColor = System.Drawing.Color.FromArgb(125, 122, 226);
            newClientButton.BackColor = System.Drawing.Color.FromArgb(125, 122, 226);

            OpenMainForms(new ClientsPanelForm(), sender);
        }


        private void newClientButton_Click(object sender, EventArgs e)
        {
            mainFormLeftPanel.BackColor = System.Drawing.Color.FromArgb(173, 204, 64);
            productsButton.BackColor = System.Drawing.Color.FromArgb(173, 204, 64);
            mealsButton.BackColor = System.Drawing.Color.FromArgb(173, 204, 64);
            dietsButton.BackColor = System.Drawing.Color.FromArgb(173, 204, 64);
            clientsPanelButton.BackColor = System.Drawing.Color.FromArgb(173, 204, 64);
            newClientButton.BackColor = System.Drawing.Color.FromArgb(173, 204, 64);

            OpenMainForms(new NewClientForm(), sender);
        }


        private void ingredientsButton_Click(object sender, EventArgs e)
        {
            mainFormLeftPanel.BackColor = System.Drawing.Color.FromArgb(51, 145, 170);
            productsButton.BackColor = System.Drawing.Color.FromArgb(51, 145, 170);
            mealsButton.BackColor = System.Drawing.Color.FromArgb(51, 145, 170);
            dietsButton.BackColor = System.Drawing.Color.FromArgb(51, 145, 170);
            clientsPanelButton.BackColor = System.Drawing.Color.FromArgb(51, 145, 170);
            newClientButton.BackColor = System.Drawing.Color.FromArgb(51, 145, 170);
            
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            mainFormLeftPanel.BackColor = System.Drawing.Color.FromArgb(167, 216, 210);
            productsButton.BackColor = System.Drawing.Color.FromArgb(167, 216, 210);
            mealsButton.BackColor = System.Drawing.Color.FromArgb(167, 216, 210);
            dietsButton.BackColor = System.Drawing.Color.FromArgb(167, 216, 210);
            clientsPanelButton.BackColor = System.Drawing.Color.FromArgb(167, 216, 210);
            newClientButton.BackColor = System.Drawing.Color.FromArgb(167, 216, 210);

            OpenMainForms(new ProductsForm(), sender);
        }

        private void mealsButton_Click(object sender, EventArgs e)
        {
            mainFormLeftPanel.BackColor = System.Drawing.Color.FromArgb(222, 209, 200);
            productsButton.BackColor = System.Drawing.Color.FromArgb(222, 209, 200);
            mealsButton.BackColor = System.Drawing.Color.FromArgb(222, 209, 200);
            dietsButton.BackColor = System.Drawing.Color.FromArgb(222, 209, 200);
            clientsPanelButton.BackColor = System.Drawing.Color.FromArgb(222, 209, 200);
            newClientButton.BackColor = System.Drawing.Color.FromArgb(222, 209, 200);

            OpenMainForms(new MealsForm(), sender);
        }

        private void dietsButton_Click(object sender, EventArgs e)
        {
            mainFormLeftPanel.BackColor = System.Drawing.Color.FromArgb(150, 133, 169);
            productsButton.BackColor = System.Drawing.Color.FromArgb(150, 133, 169);
            mealsButton.BackColor = System.Drawing.Color.FromArgb(150, 133, 169);
            dietsButton.BackColor = System.Drawing.Color.FromArgb(150, 133, 169);
            clientsPanelButton.BackColor = System.Drawing.Color.FromArgb(150, 133, 169);
            newClientButton.BackColor = System.Drawing.Color.FromArgb(150, 133, 169);

            OpenMainForms(new DietsForm(), sender);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                currentButton = (Button)btnSender;
                currentButton.BackColor = System.Drawing.Color.FromArgb(121, 110, 135);
            }
        }


        private void OpenMainForms(Form formInForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = formInForm;
            formInForm.TopLevel = false;
            formInForm.FormBorderStyle = FormBorderStyle.None;
            formInForm.Dock = DockStyle.Fill;
            this.mainFormCenterPanel.Controls.Add(formInForm);
            this.mainFormCenterPanel.Tag = formInForm;
            formInForm.BringToFront();
            formInForm.Show();
            nameOfPageLabel.Text = formInForm.Text;
            mainFormTopPanel.BackColor = mainFormLeftPanel.BackColor;

        }

    }
}
