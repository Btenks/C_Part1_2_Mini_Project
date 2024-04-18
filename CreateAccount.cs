using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{

    public partial class CreateAccount : Form
    {
        SqlConnection connect = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Tendai\\Documents\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
        public CreateAccount()
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            { 
                if(signup_hitmail.Text="" && )
            } catch { }
        }
        private void signup_hitmali_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
