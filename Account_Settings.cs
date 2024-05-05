using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Account_Settings : Form
    {
        SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tendai\\source\\repos\\WinFormsApp1\\obj\\Debug\\net8.0-windows\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");

        public Account_Settings()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Username.Text;
                string oldPassword = OldPassword.Text;
                string newPassword = NewPassword.Text;

                if (username != "" && oldPassword != "" && newPassword != "")
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Registration_Table WHERE username = @Username AND Pass_word = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", oldPassword);
                    int count = (int)command.ExecuteScalar();

                    if (count == 1)
                    {
                        // Update password
                        string updateQuery = "UPDATE Registration_Table SET Pass_word = @NewPassword WHERE username = @Username";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCommand.Parameters.AddWithValue("@Username", username);
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Username.Text = "";
                            OldPassword.Text = "";
                            NewPassword.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username and old password do not match!", "Incorrect Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OldPassword.UseSystemPasswordChar = !checkBox1.Checked;
            NewPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
