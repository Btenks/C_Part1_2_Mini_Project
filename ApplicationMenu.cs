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

            // Set the parent form of the child form to the main form
            Mwana1.MdiParent = this;

            // Define the offset value to adjust the vertical position of the child form
            int offset = 200; // Adjust this value to your preference

            // Calculate the desired Y-coordinate for the child form
            int desiredY = (this.Height - Mwana1.Height) / 2 + offset;

            // Set the location of the child form
            Mwana1.Location = new Point((this.Width - Mwana1.Width) / 2, desiredY);

            // Display the child form
            Mwana1.Show();
            Button1.Visible = false;
        }
    }
}
