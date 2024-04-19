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
        public StudentHealthInfor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NEXTofKin1 Next = new NEXTofKin1();
           
            // Display the new child form
            Next.Show();
            this.Close();
        }
    }
}
