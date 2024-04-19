namespace WinFormsApp1
{
    partial class StudentInfo1
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
            button1 = new Button();
            textBox1 = new TextBox();
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(213, 335);
            button1.Name = "button1";
            button1.Size = new Size(106, 26);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(239, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 31);
            textBox1.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(182, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(249, 22);
            Label1.TabIndex = 2;
            Label1.Text = "ENTER STUDENT DETAILS\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 83);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 3;
            label2.Text = "REG NO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 146);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 4;
            label3.Text = "NAME";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(239, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(239, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(239, 249);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(205, 31);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 208);
            label4.Name = "label4";
            label4.Size = new Size(162, 22);
            label4.TabIndex = 8;
            label4.Text = "PHONE NUMBER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 258);
            label5.Name = "label5";
            label5.Size = new Size(70, 22);
            label5.TabIndex = 9;
            label5.Text = "EMAIL";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(537, 199);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 22);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "FEMALE ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(537, 137);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 22);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "MALE ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(553, 83);
            label6.Name = "label6";
            label6.Size = new Size(89, 22);
            label6.TabIndex = 12;
            label6.Text = "GENDER";
            // 
            // StudentInfo1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(751, 392);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "StudentInfo1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentInfo1";
            Load += StudentInfo1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label Label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
    }
}