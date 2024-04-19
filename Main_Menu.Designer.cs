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
            Logoutbtn.Location = new Point(73, 495);
            Logoutbtn.Margin = new Padding(3, 4, 3, 4);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(128, 67);
            Logoutbtn.TabIndex = 1;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = true;
            // 
            // ExitFromMainMenu
            // 
            ExitFromMainMenu.Location = new Point(754, 495);
            ExitFromMainMenu.Margin = new Padding(3, 4, 3, 4);
            ExitFromMainMenu.Name = "ExitFromMainMenu";
            ExitFromMainMenu.Size = new Size(128, 67);
            ExitFromMainMenu.TabIndex = 2;
            ExitFromMainMenu.Text = "Exit";
            ExitFromMainMenu.UseVisualStyleBackColor = true;
            ExitFromMainMenu.Click += ExitFromMainMenu_Click;
            // 
            // Settingsbtn
            // 
            Settingsbtn.Location = new Point(393, 363);
            Settingsbtn.Margin = new Padding(3, 4, 3, 4);
            Settingsbtn.Name = "Settingsbtn";
            Settingsbtn.Size = new Size(128, 67);
            Settingsbtn.TabIndex = 3;
            Settingsbtn.Text = "Account Settings";
            Settingsbtn.UseVisualStyleBackColor = true;
            // 
            // Explorebtn
            // 
            Explorebtn.Location = new Point(393, 259);
            Explorebtn.Margin = new Padding(3, 4, 3, 4);
            Explorebtn.Name = "Explorebtn";
            Explorebtn.Size = new Size(128, 67);
            Explorebtn.TabIndex = 4;
            Explorebtn.Text = "Explore Hostels";
            Explorebtn.UseVisualStyleBackColor = true;
            // 
            // Registrationbtn
            // 
            Registrationbtn.Location = new Point(393, 151);
            Registrationbtn.Margin = new Padding(3, 4, 3, 4);
            Registrationbtn.Name = "Registrationbtn";
            Registrationbtn.Size = new Size(128, 67);
            Registrationbtn.TabIndex = 5;
            Registrationbtn.Text = "Registration";
            Registrationbtn.UseVisualStyleBackColor = true;
            Registrationbtn.Click += Registrationbtn_Click;
            // 
            // Reglable
            // 
            Reglable.AutoSize = true;
            Reglable.Location = new Point(362, 32);
            Reglable.Name = "Reglable";
            Reglable.Size = new Size(194, 20);
            Reglable.TabIndex = 6;
            Reglable.Text = "HIT Registration Main Menu";
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_19_at_00_48_00_d85f03d3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(Reglable);
            Controls.Add(Registrationbtn);
            Controls.Add(Explorebtn);
            Controls.Add(Settingsbtn);
            Controls.Add(ExitFromMainMenu);
            Controls.Add(Logoutbtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Menu";
            Load += Main_Menu_Load;
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