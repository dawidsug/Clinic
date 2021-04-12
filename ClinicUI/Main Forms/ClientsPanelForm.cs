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
    public partial class ClientsPanelForm : Form
    {
        private List<PatientModel> clientList = GlobalConfig.Connection.GetPatients_All();
        private PatientModel selectedPatient = new PatientModel();

        public ClientsPanelForm()
        {
            InitializeComponent();
            WiredUpLists();
        }

        private void WiredUpLists()
        {
            clientsListBox.DataSource = null;

            clientsListBox.DataSource = clientList;
            clientsListBox.DisplayMember = "FullName";
            
        }

        private void clientsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedPatient = (PatientModel)clientsListBox.SelectedItem;
            firstNameText.Text = selectedPatient.FirstName;
            lastNameText.Text = selectedPatient.LastName;
            nicknameText.Text = selectedPatient.Nickname;
            cellphoneText.Text = selectedPatient.CellphoneNumber;
            emailText.Text = selectedPatient.EmailAddress;
        }
    }
    
}
