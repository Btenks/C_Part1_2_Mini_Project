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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = SystemColors.ActiveCaption;
            Logoutbtn.BackgroundImage = Properties.Resources.istockphoto;
            Logoutbtn.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            Logoutbtn.ForeColor = Color.Turquoise;
            Logoutbtn.Location = new Point(63, 369);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(131, 50);
            Logoutbtn.TabIndex = 1;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // ExitFromMainMenu
            // 
            ExitFromMainMenu.BackColor = SystemColors.ActiveCaption;
            ExitFromMainMenu.BackgroundImage = Properties.Resources.istockphoto;
            ExitFromMainMenu.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            ExitFromMainMenu.ForeColor = Color.Turquoise;
            ExitFromMainMenu.Location = new Point(659, 369);
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
            Explorebtn.Location = new Point(324, 272);
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
            Registrationbtn.Location = new Point(324, 191);
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
            Reglable.Location = new Point(198, 7);
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
            button1.Location = new Point(20, 56);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 7;
            button1.Text = "Administrator";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Handwriting", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Image = Properties.Resources.images23;
            label1.Location = new Point(324, 86);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.unnamed;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ImageLocation = "";
            pictureBox2.InitialImage = Properties.Resources.R;
            pictureBox2.Location = new Point(657, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 130);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_19_at_00_48_00_d85f03d3;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Reglable);
            panel1.Controls.Add(Registrationbtn);
            panel1.Controls.Add(Explorebtn);
            panel1.Controls.Add(ExitFromMainMenu);
            panel1.Controls.Add(Logoutbtn);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 451);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(775, 0);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 18;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_19_at_00_48_00_d85f03d3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Menu";
            Load += Main_Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Logoutbtn;
        private Button ExitFromMainMenu;
        private Button Explorebtn;
        private Button Registrationbtn;
        private Label Reglable;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label3;
    }
}