namespace WinFormsApp1
{
    partial class Main_Menu
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
            Logoutbtn = new Button();
            ExitFromMainMenu = new Button();
            Settingsbtn = new Button();
            Explorebtn = new Button();
            Registrationbtn = new Button();
            Reglable = new Label();
            SuspendLayout();
            // 
            // Logoutbtn
            // 
            Logoutbtn.Location = new Point(64, 371);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(112, 50);
            Logoutbtn.TabIndex = 1;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = true;
            // 
            // ExitFromMainMenu
            // 
            ExitFromMainMenu.Location = new Point(660, 371);
            ExitFromMainMenu.Name = "ExitFromMainMenu";
            ExitFromMainMenu.Size = new Size(112, 50);
            ExitFromMainMenu.TabIndex = 2;
            ExitFromMainMenu.Text = "Exit";
            ExitFromMainMenu.UseVisualStyleBackColor = true;
            ExitFromMainMenu.Click += ExitFromMainMenu_Click;
            // 
            // Settingsbtn
            // 
            Settingsbtn.Location = new Point(344, 272);
            Settingsbtn.Name = "Settingsbtn";
            Settingsbtn.Size = new Size(112, 50);
            Settingsbtn.TabIndex = 3;
            Settingsbtn.Text = "Account Settings";
            Settingsbtn.UseVisualStyleBackColor = true;
            // 
            // Explorebtn
            // 
            Explorebtn.Location = new Point(344, 194);
            Explorebtn.Name = "Explorebtn";
            Explorebtn.Size = new Size(112, 50);
            Explorebtn.TabIndex = 4;
            Explorebtn.Text = "Explore Hostels";
            Explorebtn.UseVisualStyleBackColor = true;
            // 
            // Registrationbtn
            // 
            Registrationbtn.Location = new Point(344, 113);
            Registrationbtn.Name = "Registrationbtn";
            Registrationbtn.Size = new Size(112, 50);
            Registrationbtn.TabIndex = 5;
            Registrationbtn.Text = "Registration";
            Registrationbtn.UseVisualStyleBackColor = true;
            Registrationbtn.Click += Registrationbtn_Click;
            // 
            // Reglable
            // 
            Reglable.AutoSize = true;
            Reglable.Location = new Point(317, 24);
            Reglable.Name = "Reglable";
            Reglable.Size = new Size(155, 15);
            Reglable.TabIndex = 6;
            Reglable.Text = "HIT Registration Main Menu";
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reglable);
            Controls.Add(Registrationbtn);
            Controls.Add(Explorebtn);
            Controls.Add(Settingsbtn);
            Controls.Add(ExitFromMainMenu);
            Controls.Add(Logoutbtn);
            Name = "Main_Menu";
            Text = "Main_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Logoutbtn;
        private Button ExitFromMainMenu;
        private Button Settingsbtn;
        private Button Explorebtn;
        private Button Registrationbtn;
        private Label Reglable;
    }
}