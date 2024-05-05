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
            Explorebtn = new Button();
            Registrationbtn = new Button();
            Reglable = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = SystemColors.ActiveCaption;
            Logoutbtn.BackgroundImage = Properties.Resources.istockphoto;
            Logoutbtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            Logoutbtn.ForeColor = Color.Turquoise;
            Logoutbtn.Location = new Point(64, 371);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(131, 50);
            Logoutbtn.TabIndex = 1;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            // 
            // ExitFromMainMenu
            // 
            ExitFromMainMenu.BackColor = SystemColors.ActiveCaption;
            ExitFromMainMenu.BackgroundImage = Properties.Resources.istockphoto;
            ExitFromMainMenu.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            ExitFromMainMenu.ForeColor = Color.Turquoise;
            ExitFromMainMenu.Location = new Point(660, 371);
            ExitFromMainMenu.Name = "ExitFromMainMenu";
            ExitFromMainMenu.Size = new Size(131, 50);
            ExitFromMainMenu.TabIndex = 2;
            ExitFromMainMenu.Text = "Exit";
            ExitFromMainMenu.UseVisualStyleBackColor = false;
            ExitFromMainMenu.Click += ExitFromMainMenu_Click;
            // 
            // Explorebtn
            // 
            Explorebtn.BackColor = SystemColors.ActiveCaption;
            Explorebtn.BackgroundImage = Properties.Resources.istockphoto;
            Explorebtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            Explorebtn.ForeColor = Color.Turquoise;
            Explorebtn.Location = new Point(325, 274);
            Explorebtn.Name = "Explorebtn";
            Explorebtn.Size = new Size(220, 50);
            Explorebtn.TabIndex = 4;
            Explorebtn.Text = "Explore Hostels";
            Explorebtn.UseVisualStyleBackColor = false;
            // 
            // Registrationbtn
            // 
            Registrationbtn.BackColor = SystemColors.ActiveCaption;
            Registrationbtn.BackgroundImage = Properties.Resources.istockphoto;
            Registrationbtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            Registrationbtn.ForeColor = Color.Turquoise;
            Registrationbtn.Location = new Point(325, 193);
            Registrationbtn.Name = "Registrationbtn";
            Registrationbtn.Size = new Size(220, 50);
            Registrationbtn.TabIndex = 5;
            Registrationbtn.Text = "Registration";
            Registrationbtn.UseVisualStyleBackColor = false;
            Registrationbtn.Click += Registrationbtn_Click;
            // 
            // Reglable
            // 
            Reglable.AutoSize = true;
            Reglable.BackColor = Color.Transparent;
            Reglable.Font = new Font("Lucida Handwriting", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reglable.ForeColor = SystemColors.ButtonFace;
            Reglable.Location = new Point(199, 9);
            Reglable.Name = "Reglable";
            Reglable.Size = new Size(430, 31);
            Reglable.TabIndex = 6;
            Reglable.Text = "HIT Registration Main Menu";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImage = Properties.Resources.istockphoto;
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.Turquoise;
            button1.Location = new Point(21, 58);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 7;
            button1.Text = "Registration";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Handwriting", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Image = Properties.Resources.images23;
            label1.Location = new Point(325, 88);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 8;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_19_at_00_48_00_d85f03d3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Reglable);
            Controls.Add(Registrationbtn);
            Controls.Add(Explorebtn);
            Controls.Add(ExitFromMainMenu);
            Controls.Add(Logoutbtn);
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
        private Button Explorebtn;
        private Button Registrationbtn;
        private Label Reglable;
        private Button button1;
        private Label label1;
    }
}