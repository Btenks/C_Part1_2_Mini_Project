namespace WinFormsApp1
{
    partial class Account_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Settings));
            panel1 = new Panel();
            label1 = new Label();
            NewPassword = new TextBox();
            label9 = new Label();
            btnSaveChanges = new Button();
            label14 = new Label();
            label13 = new Label();
            checkBox1 = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            OldPassword = new TextBox();
            Username = new TextBox();
            label11 = new Label();
            button3 = new Button();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuText;
            panel1.BackgroundImage = Properties.Resources.download;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(NewPassword);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnSaveChanges);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(OldPassword);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 497);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Papyrus", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(352, 256);
            label1.Name = "label1";
            label1.Size = new Size(144, 30);
            label1.TabIndex = 20;
            label1.Text = "New Password";
            // 
            // NewPassword
            // 
            NewPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            NewPassword.Location = new Point(217, 308);
            NewPassword.Multiline = true;
            NewPassword.Name = "NewPassword";
            NewPassword.PasswordChar = '*';
            NewPassword.Size = new Size(430, 35);
            NewPassword.TabIndex = 19;
            NewPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.IndianRed;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(769, 3);
            label9.Name = "label9";
            label9.Size = new Size(24, 25);
            label9.TabIndex = 18;
            label9.Text = "X";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.MidnightBlue;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 14F);
            btnSaveChanges.ForeColor = SystemColors.ControlLightLight;
            btnSaveChanges.Location = new Point(563, 436);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(172, 55);
            btnSaveChanges.TabIndex = 15;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Papyrus", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(359, 74);
            label14.Name = "label14";
            label14.Size = new Size(105, 30);
            label14.TabIndex = 14;
            label14.Text = "Username";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Papyrus", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(353, 161);
            label13.Name = "label13";
            label13.Size = new Size(140, 30);
            label13.TabIndex = 13;
            label13.Text = "Old Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI", 13F);
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(359, 361);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(155, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(3, 379);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(214, 111);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.unnamed;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ImageLocation = "";
            pictureBox2.InitialImage = Properties.Resources.R;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 130);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Papyrus", 18F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(353, -2);
            label10.Name = "label10";
            label10.Size = new Size(120, 38);
            label10.TabIndex = 5;
            label10.Text = "Settings";
            // 
            // OldPassword
            // 
            OldPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            OldPassword.Location = new Point(214, 194);
            OldPassword.Multiline = true;
            OldPassword.Name = "OldPassword";
            OldPassword.PasswordChar = '*';
            OldPassword.Size = new Size(430, 35);
            OldPassword.TabIndex = 7;
            OldPassword.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            Username.Location = new Point(214, 107);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.Size = new Size(433, 35);
            Username.TabIndex = 6;
            // 
            // label11
            // 
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(232, 435);
            button3.Name = "button3";
            button3.Size = new Size(198, 55);
            button3.TabIndex = 0;
            button3.Text = "Back to Main Menu";
            button3.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 12;
            // 
            // Account_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Account_Settings";
            Text = "Account_Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Button btnSaveChanges;
        private Label label14;
        private Label label13;
        private CheckBox checkBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label10;
        private TextBox OldPassword;
        private TextBox Username;
        private Label label11;
        private Button button3;
        private Label label12;
        private Label label1;
        private TextBox NewPassword;
    }
}