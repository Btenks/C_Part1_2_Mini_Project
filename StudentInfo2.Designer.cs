namespace WinFormsApp1
{
    partial class StudentInfo2
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
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 280);
            label5.Name = "label5";
            label5.Size = new Size(0, 22);
            label5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 136);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 21;
            label4.Text = "SCHOOL";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(285, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 31);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(285, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 31);
            textBox2.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 266);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 17;
            label3.Text = "LEVEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 201);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 16;
            label2.Text = "PROGRAM";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(155, 38);
            Label1.Name = "Label1";
            Label1.Size = new Size(356, 44);
            Label1.TabIndex = 15;
            Label1.Text = "ENTER STUDENT ACADEMIC DETAILS\r\n\r\n";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(285, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 31);
            textBox1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(248, 364);
            button1.Name = "button1";
            button1.Size = new Size(106, 39);
            button1.TabIndex = 13;
            button1.Text = "NEXT ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StudentInfo2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(623, 461);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "StudentInfo2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentInfo2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label Label1;
        private TextBox textBox1;
        private Button button1;
    }
}