namespace WinFormsApp1
{
    partial class StudentHealthInfor
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
            label6 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(94, 307);
            label5.Name = "label5";
            label5.Size = new Size(0, 22);
            label5.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 158);
            label4.Name = "label4";
            label4.Size = new Size(114, 22);
            label4.TabIndex = 30;
            label4.Text = "ALLERGIES";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(318, 284);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 27);
            textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(318, 219);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 27);
            textBox2.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 293);
            label3.Name = "label3";
            label3.Size = new Size(0, 22);
            label3.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 228);
            label2.Name = "label2";
            label2.Size = new Size(290, 22);
            label2.TabIndex = 26;
            label2.Text = "ANY NEED FOR SPECIAL CARE";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(188, 65);
            Label1.Name = "Label1";
            Label1.Size = new Size(329, 44);
            Label1.TabIndex = 25;
            Label1.Text = "ENTER STUDENT HEALTH DETAILS\r\n\r\n";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(318, 154);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(281, 391);
            button1.Name = "button1";
            button1.Size = new Size(106, 39);
            button1.TabIndex = 23;
            button1.Text = "NEXT ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 293);
            label6.Name = "label6";
            label6.Size = new Size(239, 22);
            label6.TabIndex = 32;
            label6.Text = "ANY CHRONIC DISEASES";
            // 
            // StudentHealthInfor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(656, 512);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "StudentHealthInfor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentHealthInfor";
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
        private Label label6;
    }
}