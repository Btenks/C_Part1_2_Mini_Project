﻿namespace WinFormsApp1
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
            label4 = new Label();
            Txtlevel = new TextBox();
            Txtprogram = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Label1 = new Label();
            Txtschool = new TextBox();
            button1 = new Button();
            label5 = new Label();
            Txtregno = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 268);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 15;
            label4.Text = "LEVEL";
            // 
            // Txtlevel
            // 
            Txtlevel.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtlevel.Location = new Point(241, 261);
            Txtlevel.Name = "Txtlevel";
            Txtlevel.Size = new Size(205, 26);
            Txtlevel.TabIndex = 14;
            // 
            // Txtprogram
            // 
            Txtprogram.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtprogram.Location = new Point(241, 207);
            Txtprogram.Name = "Txtprogram";
            Txtprogram.Size = new Size(205, 26);
            Txtprogram.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 214);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 12;
            label3.Text = "PROGRAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 166);
            label2.Name = "label2";
            label2.Size = new Size(73, 19);
            label2.TabIndex = 11;
            label2.Text = "SCHOOL";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(129, 48);
            Label1.Name = "Label1";
            Label1.Size = new Size(214, 19);
            Label1.TabIndex = 10;
            Label1.Text = "ENTER ACADEMIC DETAILS ";
            // 
            // Txtschool
            // 
            Txtschool.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtschool.Location = new Point(241, 159);
            Txtschool.Name = "Txtschool";
            Txtschool.Size = new Size(205, 26);
            Txtschool.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(189, 317);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "NEXT ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 109);
            label5.Name = "label5";
            label5.Size = new Size(109, 19);
            label5.TabIndex = 18;
            label5.Text = "REG NUMBER";
            // 
            // Txtregno
            // 
            Txtregno.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtregno.Location = new Point(241, 102);
            Txtregno.Name = "Txtregno";
            Txtregno.Size = new Size(205, 26);
            Txtregno.TabIndex = 17;
            // 
            // StudentInfo2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(552, 385);
            Controls.Add(label5);
            Controls.Add(Txtregno);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(Txtlevel);
            Controls.Add(Txtprogram);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(Txtschool);
            Name = "StudentInfo2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentInfo2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox Txtlevel;
        private TextBox Txtprogram;
        private Label label3;
        private Label label2;
        private Label Label1;
        private TextBox Txtschool;
        private Button button1;
        private Label label5;
        private TextBox Txtregno;
    }
}