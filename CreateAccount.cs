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
using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{

    public partial class CreateAccount : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Tendai\\Documents\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
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
                                "@username, @Confrim_Password, @Pass_word", connection);
                            command.Parameters.AddWithValue("@Hitmail", signup_hitmail.Text);
                            command.Parameters.AddWithValue("@username", signup_username.Text);
                            command.Parameters.AddWithValue("@Pass_word", signup_password.Text);
                            command.Parameters.AddWithValue("@Confirm_Password", Confirm_Password.Text);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Account has been sreated successfully! Welcome HIT Student!", "Account Created successfully",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                    MessageBox.Show("Please fill in all the Blanks!", "Empty sections Error!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int check(string Hitmail)
        {
            connection.Open();
            string query = "select count(*) from Registration_Table where Hitmail ='" + Hitmail + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                signup_password.UseSystemPasswordChar = false;
                Confirm_Password.UseSystemPasswordChar = false;
            }
            else
            {
                signup_password.UseSystemPasswordChar = true;
                Confirm_Password.UseSystemPasswordChar = true;
            }
        }
    }
}