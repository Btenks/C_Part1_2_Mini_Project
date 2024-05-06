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
            Txtdiseases = new TextBox();
            Txtspecial = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Label1 = new Label();
            Txtallergies = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            Txtregno = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 230);
            label5.Name = "label5";
            label5.Size = new Size(0, 19);
            label5.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 149);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 30;
            label4.Text = "ALLERGIES";
            // 
            // Txtdiseases
            // 
            Txtdiseases.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtdiseases.Location = new Point(259, 256);
            Txtdiseases.Margin = new Padding(3, 2, 3, 2);
            Txtdiseases.Name = "Txtdiseases";
            Txtdiseases.Size = new Size(214, 26);
            Txtdiseases.TabIndex = 29;
            // 
            // Txtspecial
            // 
            Txtspecial.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtspecial.Location = new Point(259, 201);
            Txtspecial.Margin = new Padding(3, 2, 3, 2);
            Txtspecial.Name = "Txtspecial";
            Txtspecial.Size = new Size(214, 26);
            Txtspecial.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(105, 220);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 201);
            label2.Name = "label2";
            label2.Size = new Size(233, 19);
            label2.TabIndex = 26;
            label2.Text = "ANY NEED FOR SPECIAL CARE";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(166, 31);
            Label1.Name = "Label1";
            Label1.Size = new Size(261, 38);
            Label1.TabIndex = 25;
            Label1.Text = "ENTER STUDENT HEALTH DETAILS\r\n\r\n";
            // 
            // Txtallergies
            // 
            Txtallergies.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtallergies.Location = new Point(259, 146);
            Txtallergies.Margin = new Padding(3, 2, 3, 2);
            Txtallergies.Name = "Txtallergies";
            Txtallergies.Size = new Size(214, 26);
            Txtallergies.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(248, 330);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(93, 29);
            button1.TabIndex = 23;
            button1.Text = "NEXT ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 259);
            label6.Name = "label6";
            label6.Size = new Size(194, 19);
            label6.TabIndex = 32;
            label6.Text = "ANY CHRONIC DISEASES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(72, 92);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 34;
            label7.Text = "REG NO";
            // 
            // Txtregno
            // 
            Txtregno.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtregno.Location = new Point(259, 89);
            Txtregno.Name = "Txtregno";
            Txtregno.Size = new Size(214, 26);
            Txtregno.TabIndex = 33;
            // 
            // StudentHealthInfor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(574, 384);
            Controls.Add(label7);
            Controls.Add(Txtregno);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Txtdiseases);
            Controls.Add(Txtspecial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(Txtallergies);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentHealthInfor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentHealthInfor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox Txtdiseases;
        private TextBox Txtspecial;
        private Label label3;
        private Label label2;
        private Label Label1;
        private TextBox Txtallergies;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox Txtregno;
    }
}