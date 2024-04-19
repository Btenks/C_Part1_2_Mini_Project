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
    public partial class ApplicationMenu : Form
    {
        public ApplicationMenu()
        {
            InitializeComponent();
            // Set the main form as an MDI container
            IsMdiContainer = true;
        }

        private void ApplicationMenu_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Create a new child form
            StudentInfo1 Mwana1 = new StudentInfo1();

            // Display the child form
            Mwana1.Show();
            Button1.Visible = false;
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Main_Menu qwerty = new Main_Menu();
            
            qwerty.Show();
            this.Close();
        }
    }
}
