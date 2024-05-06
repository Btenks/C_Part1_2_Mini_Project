using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Signup : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tendai\\source\\repos\\WinFormsApp1\\obj\\Debug\\net8.0-windows\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (signup_hitmail.Text != "" && signup_username.Text != "" && signup_password.Text != ""
                    && Confirm_Password.Text != "")
                {
                    if (signup_password.Text == Confirm_Password.Text)
                    {
                        int v = check(signup_hitmail.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("Insert into Registration_Table values(@Hitmail," +
                                "@username, @Confirm_Password, @Pass_word)", connection); // corrected syntax: added closing parenthesis
                            command.Parameters.AddWithValue("@Hitmail", signup_hitmail.Text);
                            command.Parameters.AddWithValue("@username", signup_username.Text);
                            command.Parameters.AddWithValue("@Pass_word", signup_password.Text);
                            command.Parameters.AddWithValue("@Confirm_Password", Confirm_Password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Account has been created successfully! Welcome HIT Student!", "Account Created Successfully",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            signup_hitmail.Text = "";
                            signup_username.Text = "";
                            signup_password.Text = "";
                            Confirm_Password.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("You are already Registered", "Redundancy Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password does not match!", "Matching Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the Blanks!", "Empty Sections Error!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int check(string Hitmail)
        {
            connection.Open();
            string query = "select count(*) from Registration_Table where Hitmail = @Hitmail"; // corrected syntax: added parameterized query
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Hitmail", Hitmail);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.UseSystemPasswordChar = !checkBox3.Checked;
            Confirm_Password.UseSystemPasswordChar = !checkBox3.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
