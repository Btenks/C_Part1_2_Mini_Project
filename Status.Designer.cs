namespace WinFormsApp1
{
    partial class Status
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
            label7 = new Label();
            Txtregno = new TextBox();
            label1 = new Label();
            Button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(190, 131);
            label7.Name = "label7";
            label7.Size = new Size(120, 19);
            label7.TabIndex = 36;
            label7.Text = "ENTER REG NO";
            // 
            // Txtregno
            // 
            Txtregno.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtregno.Location = new Point(377, 128);
            Txtregno.Name = "Txtregno";
            Txtregno.Size = new Size(214, 26);
            Txtregno.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 21);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 37;
            label1.Text = "VIEW STATUS";
            // 
            // Button1
            // 
            Button1.BackColor = SystemColors.ActiveCaption;
            Button1.Location = new Point(237, 187);
            Button1.Margin = new Padding(3, 2, 3, 2);
            Button1.Name = "Button1";
            Button1.Size = new Size(250, 64);
            Button1.TabIndex = 38;
            Button1.Text = "SHOW STATUS";
            Button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(131, 280);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(570, 93);
            textBox1.TabIndex = 39;
            // 
            // Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Button1);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(Txtregno);
            Name = "Status";
            Text = "Status";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox Txtregno;
        private Label label1;
        private Button Button1;
        private TextBox textBox1;
    }
}