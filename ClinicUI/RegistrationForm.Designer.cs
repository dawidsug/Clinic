namespace ClinicUI
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.registrationLeftPanel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.newDoctorLabel = new System.Windows.Forms.Label();
            this.registryLabel = new System.Windows.Forms.Label();
            this.registryButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.personalDataLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordAgainLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.cellphoneText = new System.Windows.Forms.TextBox();
            this.nicknameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordAgainText = new System.Windows.Forms.TextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.registrationLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationLeftPanel
            // 
            this.registrationLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.registrationLeftPanel.Controls.Add(this.progressBar);
            this.registrationLeftPanel.Controls.Add(this.newDoctorLabel);
            this.registrationLeftPanel.Controls.Add(this.registryLabel);
            this.registrationLeftPanel.Controls.Add(this.registryButton);
            resources.ApplyResources(this.registrationLeftPanel, "registrationLeftPanel");
            this.registrationLeftPanel.Name = "registrationLeftPanel";
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // newDoctorLabel
            // 
            resources.ApplyResources(this.newDoctorLabel, "newDoctorLabel");
            this.newDoctorLabel.Name = "newDoctorLabel";
            // 
            // registryLabel
            // 
            resources.ApplyResources(this.registryLabel, "registryLabel");
            this.registryLabel.Name = "registryLabel";
            // 
            // registryButton
            // 
            this.registryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.registryButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.registryButton, "registryButton");
            this.registryButton.ForeColor = System.Drawing.Color.Black;
            this.registryButton.Name = "registryButton";
            this.registryButton.UseVisualStyleBackColor = false;
            this.registryButton.Click += new System.EventHandler(this.registryButton_Click);
            // 
            // firstNameLabel
            // 
            resources.ApplyResources(this.firstNameLabel, "firstNameLabel");
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Name = "firstNameLabel";
            // 
            // personalDataLabel
            // 
            resources.ApplyResources(this.personalDataLabel, "personalDataLabel");
            this.personalDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.personalDataLabel.Name = "personalDataLabel";
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Name = "emailLabel";
            // 
            // cellphoneLabel
            // 
            resources.ApplyResources(this.cellphoneLabel, "cellphoneLabel");
            this.cellphoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.cellphoneLabel.Name = "cellphoneLabel";
            // 
            // nicknameLabel
            // 
            resources.ApplyResources(this.nicknameLabel, "nicknameLabel");
            this.nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLabel.Name = "nicknameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Name = "passwordLabel";
            // 
            // passwordAgainLabel
            // 
            resources.ApplyResources(this.passwordAgainLabel, "passwordAgainLabel");
            this.passwordAgainLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordAgainLabel.Name = "passwordAgainLabel";
            // 
            // firstNameText
            // 
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.firstNameText, "firstNameText");
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            this.firstNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstNameText_KeyDown);
            // 
            // lastNameText
            // 
            this.lastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lastNameText, "lastNameText");
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.TextChanged += new System.EventHandler(this.lastNameText_TextChanged);
            this.lastNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastNameText_KeyDown);
            // 
            // emailText
            // 
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.emailText, "emailText");
            this.emailText.Name = "emailText";
            this.emailText.TextChanged += new System.EventHandler(this.emailText_TextChanged);
            this.emailText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailText_KeyDown);
            // 
            // cellphoneText
            // 
            this.cellphoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.cellphoneText, "cellphoneText");
            this.cellphoneText.Name = "cellphoneText";
            this.cellphoneText.TextChanged += new System.EventHandler(this.cellphoneText_TextChanged);
            this.cellphoneText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cellphoneText_KeyDown);
            // 
            // nicknameText
            // 
            this.nicknameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.nicknameText, "nicknameText");
            this.nicknameText.Name = "nicknameText";
            this.nicknameText.TextChanged += new System.EventHandler(this.nicknameText_TextChanged);
            this.nicknameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nicknameText_KeyDown);
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.passwordText, "passwordText");
            this.passwordText.Name = "passwordText";
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            this.passwordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordText_KeyDown);
            // 
            // passwordAgainText
            // 
            this.passwordAgainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.passwordAgainText, "passwordAgainText");
            this.passwordAgainText.Name = "passwordAgainText";
            this.passwordAgainText.TextChanged += new System.EventHandler(this.passwordAgainText_TextChanged);
            this.passwordAgainText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordAgainText_KeyDown);
            // 
            // warningLabel
            // 
            resources.ApplyResources(this.warningLabel, "warningLabel");
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.Name = "warningLabel";
            // 
            // RegistrationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.passwordAgainText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.nicknameText);
            this.Controls.Add(this.cellphoneText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.passwordAgainLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.cellphoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.personalDataLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.registrationLeftPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrationForm";
            this.registrationLeftPanel.ResumeLayout(false);
            this.registrationLeftPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel registrationLeftPanel;
        private System.Windows.Forms.Button registryButton;
        private System.Windows.Forms.Label registryLabel;
        private System.Windows.Forms.Label newDoctorLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label personalDataLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordAgainLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox cellphoneText;
        private System.Windows.Forms.TextBox nicknameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox passwordAgainText;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label warningLabel;
    }
}

