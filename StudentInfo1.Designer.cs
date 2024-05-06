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
            Txtregno = new TextBox();
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Txtname = new TextBox();
            Txtphonenumber = new TextBox();
            Txtemail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            Radiofemale = new RadioButton();
            Radiomale = new RadioButton();
            label6 = new Label();
            Txtaddress = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(273, 383);
            button1.Name = "button1";
            button1.Size = new Size(106, 39);
            button1.TabIndex = 0;
            button1.Text = "NEXT ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Txtregno
            // 
            Txtregno.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtregno.Location = new Point(239, 80);
            Txtregno.Name = "Txtregno";
            Txtregno.Size = new Size(205, 26);
            Txtregno.TabIndex = 1;
            Txtregno.TextChanged += Txtregno_TextChanged;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(239, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(198, 19);
            Label1.TabIndex = 2;
            Label1.Text = "ENTER STUDENT DETAILS\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 83);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 3;
            label2.Text = "REG NO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 146);
            label3.Name = "label3";
            label3.Size = new Size(55, 19);
            label3.TabIndex = 4;
            label3.Text = "NAME";
            // 
            // Txtname
            // 
            Txtname.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtname.Location = new Point(239, 137);
            Txtname.Name = "Txtname";
            Txtname.Size = new Size(205, 26);
            Txtname.TabIndex = 5;
            // 
            // Txtphonenumber
            // 
            Txtphonenumber.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtphonenumber.Location = new Point(239, 199);
            Txtphonenumber.Name = "Txtphonenumber";
            Txtphonenumber.Size = new Size(205, 26);
            Txtphonenumber.TabIndex = 6;
            // 
            // Txtemail
            // 
            Txtemail.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtemail.Location = new Point(239, 249);
            Txtemail.Name = "Txtemail";
            Txtemail.Size = new Size(205, 26);
            Txtemail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 208);
            label4.Name = "label4";
            label4.Size = new Size(132, 19);
            label4.TabIndex = 8;
            label4.Text = "PHONE NUMBER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 258);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 9;
            label5.Text = "EMAIL";
            // 
            // Radiofemale
            // 
            Radiofemale.AutoSize = true;
            Radiofemale.Location = new Point(532, 204);
            Radiofemale.Name = "Radiofemale";
            Radiofemale.Size = new Size(71, 18);
            Radiofemale.TabIndex = 10;
            Radiofemale.TabStop = true;
            Radiofemale.Text = "FEMALE ";
            Radiofemale.UseVisualStyleBackColor = true;
            // 
            // Radiomale
            // 
            Radiomale.AutoSize = true;
            Radiomale.Location = new Point(532, 156);
            Radiomale.Name = "Radiomale";
            Radiomale.Size = new Size(57, 18);
            Radiomale.TabIndex = 11;
            Radiomale.TabStop = true;
            Radiomale.Text = "MALE ";
            Radiomale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(532, 116);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 12;
            label6.Text = "GENDER";
            // 
            // Txtaddress
            // 
            Txtaddress.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtaddress.Location = new Point(239, 297);
            Txtaddress.Name = "Txtaddress";
            Txtaddress.Size = new Size(205, 26);
            Txtaddress.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 306);
            label7.Name = "label7";
            label7.Size = new Size(128, 19);
            label7.TabIndex = 28;
            label7.Text = "HOME ADDRESS";
            // 
            // StudentInfo1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(707, 445);
            Controls.Add(Txtaddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Radiomale);
            Controls.Add(Radiofemale);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Txtemail);
            Controls.Add(Txtphonenumber);
            Controls.Add(Txtname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(Txtregno);
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
        private TextBox Txtregno;
        private Label Label1;
        private Label label2;
        private Label label3;
        private TextBox Txtname;
        private TextBox Txtphonenumber;
        private TextBox Txtemail;
        private Label label4;
        private Label label5;
        private RadioButton Radiofemale;
        private RadioButton Radiomale;
        private Label label6;
        private TextBox Txtaddress;
        private Label label7;
    }
}