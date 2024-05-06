namespace WinFormsApp1
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            Confirm_Password = new TextBox();
            label2 = new Label();
            checkBox3 = new CheckBox();
            signup_password = new TextBox();
            label1 = new Label();
            label10 = new Label();
            signup_username = new TextBox();
            button1 = new Button();
            signup_hitmail = new TextBox();
            label11 = new Label();
            button3 = new Button();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuText;
            panel1.BackgroundImage = Properties.Resources.istockphoto;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Confirm_Password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(signup_password);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(signup_username);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(signup_hitmail);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 452);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Papyrus", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(359, 434);
            label8.Name = "label8";
            label8.Size = new Size(101, 18);
            label8.TabIndex = 1;
            label8.Text = "@BTENKS95";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(192, 147);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(776, 3);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 17;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Confirm_Password
            // 
            Confirm_Password.Font = new Font("Segoe UI", 15.75F);
            Confirm_Password.Location = new Point(198, 292);
            Confirm_Password.Multiline = true;
            Confirm_Password.Name = "Confirm_Password";
            Confirm_Password.PasswordChar = '*';
            Confirm_Password.Size = new Size(441, 38);
            Confirm_Password.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Papyrus", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(341, 248);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 15;
            label2.Text = "Confirm Password";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Font = new Font("Segoe UI", 12F);
            checkBox3.ForeColor = SystemColors.ControlLightLight;
            checkBox3.Location = new Point(359, 356);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(138, 25);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "Show Password";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.Font = new Font("Segoe UI", 15.75F);
            signup_password.Location = new Point(198, 207);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(441, 38);
            signup_password.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Papyrus", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(356, 179);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 11;
            label1.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Papyrus", 18F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(341, 4);
            label10.Name = "label10";
            label10.Size = new Size(166, 38);
            label10.TabIndex = 5;
            label10.Text = "Get Started";
            // 
            // signup_username
            // 
            signup_username.Font = new Font("Segoe UI", 15.75F);
            signup_username.Location = new Point(198, 137);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(441, 39);
            signup_username.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(3, 400);
            button1.Name = "button1";
            button1.Size = new Size(125, 39);
            button1.TabIndex = 1;
            button1.Text = "Signup";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // signup_hitmail
            // 
            signup_hitmail.Font = new Font("Segoe UI", 15.75F);
            signup_hitmail.Location = new Point(198, 70);
            signup_hitmail.Multiline = true;
            signup_hitmail.Name = "signup_hitmail";
            signup_hitmail.Size = new Size(444, 36);
            signup_hitmail.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Papyrus", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(356, 109);
            label11.Name = "label11";
            label11.Size = new Size(91, 25);
            label11.TabIndex = 4;
            label11.Text = "Username";
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(662, 400);
            button3.Name = "button3";
            button3.Size = new Size(138, 39);
            button3.TabIndex = 0;
            button3.Text = "Back to Login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Papyrus", 12F, FontStyle.Bold | FontStyle.Italic);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(356, 42);
            label12.Name = "label12";
            label12.Size = new Size(140, 25);
            label12.TabIndex = 3;
            label12.Text = "Hitmail Address";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox Confirm_Password;
        private Label label2;
        private CheckBox checkBox3;
        private TextBox signup_password;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label8;
        private Label label10;
        private TextBox signup_username;
        private Button button1;
        private TextBox signup_hitmail;
        private Label label11;
        private Button button3;
        private Label label12;
        private Label label3;
    }
}