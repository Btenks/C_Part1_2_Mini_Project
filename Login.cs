using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
namespace WinFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = (Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tendai\\source\\repos\\WinFormsApp1\\obj\\Debug\\net8.0-windows\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }


         
        private void Button3_Click(object sender, EventArgs e)
        {/*
                if (Username.Text != "" && Password.Text != "")
            {
                string query = "select count(*) from Registration_Table where username = '" + Username.Text + "' and " +
                    "password='" + Password.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Password and username do not match!", "Incorect Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connection.Close();
                    _ = MessageBox.Show("Welcome to Your account", "Welcome Student",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);             */

            Main_Menu Main_M = new Main_Menu();
            Main_M.Show();
            this.Hide();

        }
    }
}
           
            /*
           else
            {
                MessageBox.Show("Please fill in all the Blanks!", "Empty sections Error!",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
        private void Signupbtn_Click(object sender, EventArgs e)
        {
            Signup CAcc = new();
            CAcc.Show();
            this.Hide();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
            */                                              