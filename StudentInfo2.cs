using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class StudentInfo2 : Form
    {
        public StudentInfo2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentHealthInfor Health = new StudentHealthInfor();


            // Display the new child form
            Health.Show();
            this.Close();
        }
    }
    
}
