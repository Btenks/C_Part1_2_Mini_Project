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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void ExitFromMainMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registrationbtn_Click(object sender, EventArgs e)
        {

            ApplicationMenu Parent = new ApplicationMenu();
            Parent.Show();
            this.Hide();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Account_Settings showForm = new Account_Settings();
            showForm.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
