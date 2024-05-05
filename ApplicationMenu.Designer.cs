namespace WinFormsApp1
{
    partial class ApplicationMenu
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
            Label1 = new Label();
            PictureBox1 = new PictureBox();
            Button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(275, 16);
            Label1.Name = "Label1";
            Label1.Size = new Size(479, 64);
            Label1.TabIndex = 0;
            Label1.Text = "HARARE INSTITUTE OF TECHNOLOGY\r\n          RESIDENTIAL APPLICATION ";
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Location = new Point(1, 11);
            PictureBox1.Margin = new Padding(3, 2, 3, 2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(229, 111);
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            PictureBox1.Click += PictureBox1_Click;
            // 
            // Button1
            // 
            Button1.BackColor = SystemColors.ActiveCaption;
            Button1.Location = new Point(349, 273);
            Button1.Margin = new Padding(3, 2, 3, 2);
            Button1.Name = "Button1";
            Button1.Size = new Size(250, 64);
            Button1.TabIndex = 3;
            Button1.Text = "apply now ";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // ApplicationMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_19_at_00_48_00_d85f03d3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 559);
            Controls.Add(Label1);
            Controls.Add(Button1);
            Controls.Add(PictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ApplicationMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplicationMenu";
            Load += ApplicationMenu_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private PictureBox PictureBox1;
        private Button Button1;
    }
}