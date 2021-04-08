namespace ClinicUI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.doctorsDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.newDoctorLink = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Impact", 19.8F);
            this.loginLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginLabel.Location = new System.Drawing.Point(160, 79);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(91, 41);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.nicknameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nicknameLabel.Location = new System.Drawing.Point(149, 171);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(118, 32);
            this.nicknameLabel.TabIndex = 4;
            this.nicknameLabel.Text = "Nickname";
            // 
            // doctorsDropDown
            // 
            this.doctorsDropDown.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doctorsDropDown.FormattingEnabled = true;
            this.doctorsDropDown.Location = new System.Drawing.Point(47, 206);
            this.doctorsDropDown.Name = "doctorsDropDown";
            this.doctorsDropDown.Size = new System.Drawing.Size(342, 42);
            this.doctorsDropDown.TabIndex = 5;
            this.doctorsDropDown.DropDown += new System.EventHandler(this.doctorsDropDown_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(149, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Impact", 16.2F);
            this.passwordText.Location = new System.Drawing.Point(47, 286);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(342, 33);
            this.passwordText.TabIndex = 11;
            // 
            // newDoctorLink
            // 
            this.newDoctorLink.AutoSize = true;
            this.newDoctorLink.BackColor = System.Drawing.Color.Transparent;
            this.newDoctorLink.Location = new System.Drawing.Point(44, 390);
            this.newDoctorLink.Name = "newDoctorLink";
            this.newDoctorLink.Size = new System.Drawing.Size(133, 17);
            this.newDoctorLink.TabIndex = 12;
            this.newDoctorLink.TabStop = true;
            this.newDoctorLink.Text = "Create new account";
            this.newDoctorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newDoctorLink_LinkClicked);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(233)))), ((int)(((byte)(214)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Impact", 15F);
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginButton.Location = new System.Drawing.Point(143, 325);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(122, 62);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 550);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.newDoctorLink);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorsDropDown);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.loginLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.ComboBox doctorsDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.LinkLabel newDoctorLink;
        private System.Windows.Forms.Button loginButton;
    }
}