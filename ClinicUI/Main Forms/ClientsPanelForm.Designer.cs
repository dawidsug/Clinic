namespace ClinicUI.Main_Forms
{
    partial class ClientsPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsPanelForm));
            this.activeClientDietsBox = new System.Windows.Forms.ListBox();
            this.unselectButton = new System.Windows.Forms.Button();
            this.listOfDietsBox = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.clientsListLabel = new System.Windows.Forms.Label();
            this.activeClientDietsLabel = new System.Windows.Forms.Label();
            this.listOfDietsLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.nicknameText = new System.Windows.Forms.TextBox();
            this.cellphoneText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.newClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activeClientDietsBox
            // 
            this.activeClientDietsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activeClientDietsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activeClientDietsBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activeClientDietsBox.FormattingEnabled = true;
            this.activeClientDietsBox.ItemHeight = 21;
            this.activeClientDietsBox.Location = new System.Drawing.Point(231, 139);
            this.activeClientDietsBox.Name = "activeClientDietsBox";
            this.activeClientDietsBox.Size = new System.Drawing.Size(335, 357);
            this.activeClientDietsBox.TabIndex = 1;
            // 
            // unselectButton
            // 
            this.unselectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unselectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.unselectButton.FlatAppearance.BorderSize = 0;
            this.unselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unselectButton.Font = new System.Drawing.Font("Impact", 15F);
            this.unselectButton.ForeColor = System.Drawing.Color.Black;
            this.unselectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.unselectButton.Location = new System.Drawing.Point(334, 501);
            this.unselectButton.Name = "unselectButton";
            this.unselectButton.Size = new System.Drawing.Size(122, 62);
            this.unselectButton.TabIndex = 15;
            this.unselectButton.Text = "Unselect";
            this.unselectButton.UseVisualStyleBackColor = false;
            // 
            // listOfDietsBox
            // 
            this.listOfDietsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfDietsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfDietsBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfDietsBox.FormattingEnabled = true;
            this.listOfDietsBox.ItemHeight = 21;
            this.listOfDietsBox.Location = new System.Drawing.Point(572, 139);
            this.listOfDietsBox.Name = "listOfDietsBox";
            this.listOfDietsBox.Size = new System.Drawing.Size(348, 357);
            this.listOfDietsBox.TabIndex = 16;
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.selectButton.FlatAppearance.BorderSize = 0;
            this.selectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectButton.Font = new System.Drawing.Font("Impact", 15F);
            this.selectButton.ForeColor = System.Drawing.Color.Black;
            this.selectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.selectButton.Location = new System.Drawing.Point(680, 501);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(122, 62);
            this.selectButton.TabIndex = 18;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = false;
            // 
            // clientsListBox
            // 
            this.clientsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientsListBox.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.ItemHeight = 21;
            this.clientsListBox.Location = new System.Drawing.Point(12, 139);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(213, 357);
            this.clientsListBox.TabIndex = 19;
            this.clientsListBox.SelectedValueChanged += new System.EventHandler(this.clientsListBox_SelectedValueChanged);
            // 
            // clientsListLabel
            // 
            this.clientsListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsListLabel.AutoSize = true;
            this.clientsListLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientsListLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.clientsListLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientsListLabel.Location = new System.Drawing.Point(52, 104);
            this.clientsListLabel.Name = "clientsListLabel";
            this.clientsListLabel.Size = new System.Drawing.Size(130, 32);
            this.clientsListLabel.TabIndex = 20;
            this.clientsListLabel.Text = "Clients List";
            // 
            // activeClientDietsLabel
            // 
            this.activeClientDietsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activeClientDietsLabel.AutoSize = true;
            this.activeClientDietsLabel.BackColor = System.Drawing.Color.Transparent;
            this.activeClientDietsLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.activeClientDietsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.activeClientDietsLabel.Location = new System.Drawing.Point(296, 104);
            this.activeClientDietsLabel.Name = "activeClientDietsLabel";
            this.activeClientDietsLabel.Size = new System.Drawing.Size(201, 32);
            this.activeClientDietsLabel.TabIndex = 21;
            this.activeClientDietsLabel.Text = "Active Client Diets";
            // 
            // listOfDietsLabel
            // 
            this.listOfDietsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfDietsLabel.AutoSize = true;
            this.listOfDietsLabel.BackColor = System.Drawing.Color.Transparent;
            this.listOfDietsLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.listOfDietsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listOfDietsLabel.Location = new System.Drawing.Point(678, 104);
            this.listOfDietsLabel.Name = "listOfDietsLabel";
            this.listOfDietsLabel.Size = new System.Drawing.Size(134, 32);
            this.listOfDietsLabel.TabIndex = 22;
            this.listOfDietsLabel.Text = "List of Diets";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstNameLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.firstNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(124, 32);
            this.firstNameLabel.TabIndex = 23;
            this.firstNameLabel.Text = "First Name";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.nicknameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nicknameLabel.Location = new System.Drawing.Point(312, 9);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(118, 32);
            this.nicknameLabel.TabIndex = 24;
            this.nicknameLabel.Text = "Nickname";
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.cellphoneLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.cellphoneLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cellphoneLabel.Location = new System.Drawing.Point(312, 41);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(121, 32);
            this.cellphoneLabel.TabIndex = 25;
            this.cellphoneLabel.Text = "Cellphone";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastNameLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.lastNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 41);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 32);
            this.lastNameLabel.TabIndex = 26;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.emailLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.emailLabel.Location = new System.Drawing.Point(643, 9);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(159, 32);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email Address";
            // 
            // firstNameText
            // 
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameText.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameText.Location = new System.Drawing.Point(148, 16);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(158, 21);
            this.firstNameText.TabIndex = 29;
            // 
            // lastNameText
            // 
            this.lastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameText.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameText.Location = new System.Drawing.Point(148, 48);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(158, 21);
            this.lastNameText.TabIndex = 30;
            // 
            // nicknameText
            // 
            this.nicknameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nicknameText.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nicknameText.Location = new System.Drawing.Point(448, 16);
            this.nicknameText.Name = "nicknameText";
            this.nicknameText.Size = new System.Drawing.Size(158, 21);
            this.nicknameText.TabIndex = 31;
            // 
            // cellphoneText
            // 
            this.cellphoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cellphoneText.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellphoneText.Location = new System.Drawing.Point(448, 48);
            this.cellphoneText.Name = "cellphoneText";
            this.cellphoneText.Size = new System.Drawing.Size(158, 21);
            this.cellphoneText.TabIndex = 32;
            // 
            // emailText
            // 
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailText.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailText.Location = new System.Drawing.Point(649, 48);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(158, 21);
            this.emailText.TabIndex = 33;
            // 
            // newClientButton
            // 
            this.newClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.newClientButton.FlatAppearance.BorderSize = 0;
            this.newClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newClientButton.Font = new System.Drawing.Font("Impact", 15F);
            this.newClientButton.ForeColor = System.Drawing.Color.Black;
            this.newClientButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newClientButton.Location = new System.Drawing.Point(41, 501);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(146, 62);
            this.newClientButton.TabIndex = 34;
            this.newClientButton.Text = "New Client";
            this.newClientButton.UseVisualStyleBackColor = false;
            // 
            // ClientsPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(110)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(932, 576);
            this.Controls.Add(this.newClientButton);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.cellphoneText);
            this.Controls.Add(this.nicknameText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.cellphoneLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.listOfDietsLabel);
            this.Controls.Add(this.activeClientDietsLabel);
            this.Controls.Add(this.clientsListLabel);
            this.Controls.Add(this.clientsListBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.listOfDietsBox);
            this.Controls.Add(this.unselectButton);
            this.Controls.Add(this.activeClientDietsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsPanelForm";
            this.Text = "CLIENTS PANEL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox activeClientDietsBox;
        private System.Windows.Forms.Button unselectButton;
        private System.Windows.Forms.ListBox listOfDietsBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ListBox clientsListBox;
        private System.Windows.Forms.Label clientsListLabel;
        private System.Windows.Forms.Label activeClientDietsLabel;
        private System.Windows.Forms.Label listOfDietsLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox nicknameText;
        private System.Windows.Forms.TextBox cellphoneText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button newClientButton;
    }
}