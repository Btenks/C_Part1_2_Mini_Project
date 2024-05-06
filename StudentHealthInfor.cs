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
    public partial class StudentHealthInfor : Form
    {
        public string Allergies { get; set; }
        public string SpecialCare { get; set; }
        public string Diseases { get; set; }
       
        public StudentHealthInfor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Capture health information from text boxes into variables
            Allergies = Txtallegies.Text;
            SpecialCare = Txtspecial.Text;
            Diseases = Txtdiseases.Text;

            NEXTofKin Next = new NEXTofKin();
            Next.Show();
            this.Close();
        }

        private void Txtspecial_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentHealthInfor_Load(object sender, EventArgs e)
        {

        }
    }
}
