namespace ClinicUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainFormLeftPanel = new System.Windows.Forms.Panel();
            this.newClientButton = new System.Windows.Forms.Button();
            this.clientsPanelButton = new System.Windows.Forms.Button();
            this.dietsButton = new System.Windows.Forms.Button();
            this.mealsButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.ingredientsButton = new System.Windows.Forms.Button();
            this.mainFormTopPanel = new System.Windows.Forms.Panel();
            this.nameOfPageLabel = new System.Windows.Forms.Label();
            this.mainFormCenterPanel = new System.Windows.Forms.Panel();
            this.mainFormLeftPanel.SuspendLayout();
            this.mainFormTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormLeftPanel
            // 
            this.mainFormLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.mainFormLeftPanel.Controls.Add(this.newClientButton);
            this.mainFormLeftPanel.Controls.Add(this.clientsPanelButton);
            this.mainFormLeftPanel.Controls.Add(this.dietsButton);
            this.mainFormLeftPanel.Controls.Add(this.mealsButton);
            this.mainFormLeftPanel.Controls.Add(this.productsButton);
            this.mainFormLeftPanel.Controls.Add(this.mainLabel);
            this.mainFormLeftPanel.Controls.Add(this.ingredientsButton);
            this.mainFormLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainFormLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFormLeftPanel.Name = "mainFormLeftPanel";
            this.mainFormLeftPanel.Size = new System.Drawing.Size(194, 623);
            this.mainFormLeftPanel.TabIndex = 1;
            // 
            // newClientButton
            // 
            this.newClientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.newClientButton.FlatAppearance.BorderSize = 0;
            this.newClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newClientButton.Font = new System.Drawing.Font("Impact", 15F);
            this.newClientButton.ForeColor = System.Drawing.Color.Black;
            this.newClientButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newClientButton.Location = new System.Drawing.Point(0, 159);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(194, 62);
            this.newClientButton.TabIndex = 7;
            this.newClientButton.Text = "New Client";
            this.newClientButton.UseVisualStyleBackColor = false;
            this.newClientButton.Click += new System.EventHandler(this.newClientButton_Click);
            // 
            // clientsPanelButton
            // 
            this.clientsPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.clientsPanelButton.FlatAppearance.BorderSize = 0;
            this.clientsPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsPanelButton.Font = new System.Drawing.Font("Impact", 15F);
            this.clientsPanelButton.ForeColor = System.Drawing.Color.Black;
            this.clientsPanelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientsPanelButton.Location = new System.Drawing.Point(0, 91);
            this.clientsPanelButton.Name = "clientsPanelButton";
            this.clientsPanelButton.Size = new System.Drawing.Size(194, 62);
            this.clientsPanelButton.TabIndex = 6;
            this.clientsPanelButton.Text = "Clients Panel";
            this.clientsPanelButton.UseVisualStyleBackColor = false;
            this.clientsPanelButton.Click += new System.EventHandler(this.clientsPanelButton_Click);
            // 
            // dietsButton
            // 
            this.dietsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.dietsButton.FlatAppearance.BorderSize = 0;
            this.dietsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dietsButton.Font = new System.Drawing.Font("Impact", 15F);
            this.dietsButton.ForeColor = System.Drawing.Color.Black;
            this.dietsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dietsButton.Location = new System.Drawing.Point(0, 431);
            this.dietsButton.Name = "dietsButton";
            this.dietsButton.Size = new System.Drawing.Size(194, 62);
            this.dietsButton.TabIndex = 5;
            this.dietsButton.Text = "Diets";
            this.dietsButton.UseVisualStyleBackColor = false;
            this.dietsButton.Click += new System.EventHandler(this.dietsButton_Click);
            // 
            // mealsButton
            // 
            this.mealsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.mealsButton.FlatAppearance.BorderSize = 0;
            this.mealsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mealsButton.Font = new System.Drawing.Font("Impact", 15F);
            this.mealsButton.ForeColor = System.Drawing.Color.Black;
            this.mealsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mealsButton.Location = new System.Drawing.Point(0, 363);
            this.mealsButton.Name = "mealsButton";
            this.mealsButton.Size = new System.Drawing.Size(194, 62);
            this.mealsButton.TabIndex = 4;
            this.mealsButton.Text = "Meals";
            this.mealsButton.UseVisualStyleBackColor = false;
            this.mealsButton.Click += new System.EventHandler(this.mealsButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Impact", 15F);
            this.productsButton.ForeColor = System.Drawing.Color.Black;
            this.productsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.productsButton.Location = new System.Drawing.Point(0, 295);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(194, 62);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainLabel.Location = new System.Drawing.Point(3, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(174, 75);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Clinic";
            // 
            // ingredientsButton
            // 
            this.ingredientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.ingredientsButton.FlatAppearance.BorderSize = 0;
            this.ingredientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredientsButton.Font = new System.Drawing.Font("Impact", 15F);
            this.ingredientsButton.ForeColor = System.Drawing.Color.Black;
            this.ingredientsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ingredientsButton.Location = new System.Drawing.Point(0, 227);
            this.ingredientsButton.Name = "ingredientsButton";
            this.ingredientsButton.Size = new System.Drawing.Size(194, 62);
            this.ingredientsButton.TabIndex = 0;
            this.ingredientsButton.Text = "Ingredients";
            this.ingredientsButton.UseVisualStyleBackColor = false;
            this.ingredientsButton.Click += new System.EventHandler(this.ingredientsButton_Click);
            // 
            // mainFormTopPanel
            // 
            this.mainFormTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(133)))), ((int)(((byte)(169)))));
            this.mainFormTopPanel.Controls.Add(this.nameOfPageLabel);
            this.mainFormTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainFormTopPanel.Location = new System.Drawing.Point(194, 0);
            this.mainFormTopPanel.Name = "mainFormTopPanel";
            this.mainFormTopPanel.Size = new System.Drawing.Size(1141, 92);
            this.mainFormTopPanel.TabIndex = 2;
            // 
            // nameOfPageLabel
            // 
            this.nameOfPageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOfPageLabel.AutoSize = true;
            this.nameOfPageLabel.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameOfPageLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameOfPageLabel.Location = new System.Drawing.Point(398, 22);
            this.nameOfPageLabel.Name = "nameOfPageLabel";
            this.nameOfPageLabel.Size = new System.Drawing.Size(285, 60);
            this.nameOfPageLabel.TabIndex = 2;
            this.nameOfPageLabel.Text = "Clients Panel";
            // 
            // mainFormCenterPanel
            // 
            this.mainFormCenterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFormCenterPanel.Location = new System.Drawing.Point(194, 91);
            this.mainFormCenterPanel.Name = "mainFormCenterPanel";
            this.mainFormCenterPanel.Size = new System.Drawing.Size(1141, 532);
            this.mainFormCenterPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 623);
            this.Controls.Add(this.mainFormTopPanel);
            this.Controls.Add(this.mainFormLeftPanel);
            this.Controls.Add(this.mainFormCenterPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Panel";
            this.mainFormLeftPanel.ResumeLayout(false);
            this.mainFormLeftPanel.PerformLayout();
            this.mainFormTopPanel.ResumeLayout(false);
            this.mainFormTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainFormLeftPanel;
        private System.Windows.Forms.Button clientsPanelButton;
        private System.Windows.Forms.Button dietsButton;
        private System.Windows.Forms.Button mealsButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button ingredientsButton;
        private System.Windows.Forms.Panel mainFormTopPanel;
        private System.Windows.Forms.Label nameOfPageLabel;
        private System.Windows.Forms.Panel mainFormCenterPanel;
        private System.Windows.Forms.Button newClientButton;
    }
}