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
            Label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(459, 32);
            Label1.Name = "Label1";
            Label1.Size = new Size(604, 80);
            Label1.TabIndex = 0;
            Label1.Text = "HARARE INSTITUTE OF TECHNOLOGY\r\n          RESIDENTIAL APPLICATION ";
            // 
            // PictureBox1
            // 
            PictureBox1.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_19_at_00_47_59_57cbd009;
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBox1.Location = new Point(-3, -1);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(262, 148);
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // Button1
            // 
            Button1.BackColor = SystemColors.ActiveCaption;
            Button1.Location = new Point(399, 364);
            Button1.Name = "Button1";
            Button1.Size = new Size(286, 85);
            Button1.TabIndex = 3;
            Button1.Text = "apply now ";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // ApplicationMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_04_19_at_00_48_00_d85f03d3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1099, 745);
            Controls.Add(Button1);
            Controls.Add(PictureBox1);
            Controls.Add(Label1);
            IsMdiContainer = true;
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