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
    public partial class Terms : Form
    {
        public Terms()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Terms_Load(object sender, EventArgs e)
        {
            // Load and display the terms and conditions text
            richTextBox1.Text = GetTermsAndConditionsText();
        }

        private string GetTermsAndConditionsText()
        {
            // Retrieve the terms and conditions text from a data source
            // You can replace this with your own logic to fetch the text from a database, file, or any other source.

            // Example: Hardcoded terms and conditions text
            // ...
            string termsText = "Terms and Conditions for School Residential Accommodation"
                + Environment.NewLine + Environment.NewLine
                + "1. Students must abide by the rules and regulations set by the school."
                + Environment.NewLine
                + "2. Students are responsible for the cleanliness and maintenance of their assigned rooms."
                + Environment.NewLine
                + "3. Students must adhere to the specified curfew timings."
                + Environment.NewLine
                + "4. Any damage to the school property will be the responsibility of the student."
                + Environment.NewLine
                + "5. Students must respect the privacy and personal space of their fellow residents."
                + Environment.NewLine
                + "6. ...";

            return termsText;
            // ...


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form when the button is clicked
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show a message box with the completion message
            MessageBox.Show("Application was completed. The administrator will get back to you shortly.", "Application Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Application.Exit();
        }
    }
}
    

