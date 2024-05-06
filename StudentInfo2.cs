using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class StudentInfo2 : Form
    { // Variables to store entered details
        public string School { get;  set; }
        public string Program { get;  set; }
        public string Level { get;  set; }


        public StudentInfo2()
        {
            InitializeComponent();
        }

        private void StudentInfo2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Capture details from text boxes into variables
            School = Txtschool.Text;
            Program = Txtprogram.Text;
            Level = Txtlevel.Text;

            // Open the next form

            StudentHealthInfor Health = new StudentHealthInfor();
            Health.Show();
            this.Close();



        }
    }
}
    
