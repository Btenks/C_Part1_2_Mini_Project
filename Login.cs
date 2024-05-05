using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tendai\\source\\repos\\WinFormsApp1\\obj\\Debug\\net8.0-windows\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username.Text != "" && Password.Text != "")
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Registration_Table WHERE username = @Username AND Pass_word = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", Username.Text);
                    command.Parameters.AddWithValue("@Password", Password.Text);
                    int v = (int)command.ExecuteScalar();
                    if (v != 1)
                    {
                        MessageBox.Show("Username and password do not match!", "Incorrect Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Welcome to your account!", "Welcome Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Open your main menu form or do whatever you need here
                        Main_Menu Main_M = new Main_Menu();
                        Main_M.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields!", "Empty Fields Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            Signup CAcc = new Signup(); // Instantiate Signup form
            CAcc.Show();
            this.Hide();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}                                      