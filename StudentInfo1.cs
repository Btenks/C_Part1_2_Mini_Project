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
    public partial class StudentInfo1 : Form
    {
        // Variables to store entered details
        public string regNo;
        public string name;
        public string phoneNumber;
        public string email;
        public string homeAddress;
        public string gender;



        public StudentInfo1()
        {
            InitializeComponent();
        }

        private void StudentInfo1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {  // Capture details from text boxes into variables
                regNo = Txtregno.Text;
                name = Txtname.Text;
                phoneNumber = Txtphonenumber.Text;
                email = Txtemail.Text;
                homeAddress = Txtaddress.Text;

                // Determine gender based on radio button selection
                if (Radiomale.Checked)
                {
                    gender = "Male";
                }
                else if (Radiofemale.Checked)
                {
                    gender = "Female";
                }

                // Open the next form
                StudentInfo2 Mwana2 = new StudentInfo2();
                Mwana2.Show();
                this.Close();
            }
        }

        private void Txtregno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

