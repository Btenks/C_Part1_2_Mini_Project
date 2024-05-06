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
            Txtallegies = new TextBox();
            button1 = new Button();
            label6 = new Label();
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
            label4.Location = new Point(82, 118);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 30;
            label4.Text = "ALLERGIES";
            // 
            // Txtdiseases
            // 
            Txtdiseases.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtdiseases.Location = new Point(278, 213);
            Txtdiseases.Margin = new Padding(3, 2, 3, 2);
            Txtdiseases.Multiline = true;
            Txtdiseases.Name = "Txtdiseases";
            Txtdiseases.Size = new Size(180, 21);
            Txtdiseases.TabIndex = 29;
            // 
            // Txtspecial
            // 
            Txtspecial.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtspecial.Location = new Point(278, 164);
            Txtspecial.Margin = new Padding(3, 2, 3, 2);
            Txtspecial.Multiline = true;
            Txtspecial.Name = "Txtspecial";
            Txtspecial.Size = new Size(180, 21);
            Txtspecial.TabIndex = 28;
            Txtspecial.TextChanged += Txtspecial_TextChanged;
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
            label2.Location = new Point(10, 171);
            label2.Name = "label2";
            label2.Size = new Size(233, 19);
            label2.TabIndex = 26;
            label2.Text = "ANY NEED FOR SPECIAL CARE";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(164, 49);
            Label1.Name = "Label1";
            Label1.Size = new Size(261, 38);
            Label1.TabIndex = 25;
            Label1.Text = "ENTER STUDENT HEALTH DETAILS\r\n\r\n";
            // 
            // Txtallegies
            // 
            Txtallegies.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtallegies.Location = new Point(278, 116);
            Txtallegies.Margin = new Padding(3, 2, 3, 2);
            Txtallegies.Multiline = true;
            Txtallegies.Name = "Txtallegies";
            Txtallegies.Size = new Size(180, 21);
            Txtallegies.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(246, 293);
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
            label6.Location = new Point(19, 220);
            label6.Name = "label6";
            label6.Size = new Size(194, 19);
            label6.TabIndex = 32;
            label6.Text = "ANY CHRONIC DISEASES";
            // 
            // StudentHealthInfor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(574, 384);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Txtdiseases);
            Controls.Add(Txtspecial);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(Txtallegies);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentHealthInfor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentHealthInfor";
            Load += StudentHealthInfor_Load;
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
        private TextBox Txtallegies;
        private Button button1;
        private Label label6;
    }
}