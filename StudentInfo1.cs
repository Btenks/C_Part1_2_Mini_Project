using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class StudentInfo1 : Form
    {
        // Connection string to the database
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tendai\\source\\repos\\WinFormsApp1\\obj\\Debug\\net8.0-windows\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public StudentInfo1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Determine the selected gender
                string gender = "";
                if (Radiomale.Checked)
                {
                    gender = "Male";
                }
                else if (Radiofemale.Checked)
                {
                    gender = "Female";
                }

                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Prepare the SQL query
                    string query = @"INSERT INTO studentinfo (RegNo, Name, PhoneNumber, Email, HomeAddress, Gender) 
                             VALUES (@RegNo, @Name, @PhoneNumber, @Email, @HomeAddress, @Gender)";

                    // Create a command object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@RegNo", Txtregno.Text);
                        command.Parameters.AddWithValue("@Name", Txtname.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", Txtphonenumber.Text);
                        command.Parameters.AddWithValue("@Email", Txtemail.Text);
                        command.Parameters.AddWithValue("@HomeAddress", Txtaddress.Text);
                        command.Parameters.AddWithValue("@Gender", gender);

                        // Execute the command
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Proceed to the next formQ    
                        StudentInfo2 studentInfo2Form = new StudentInfo2(Txtregno.Text);
                        studentInfo2Form.Show();
                        this.Hide(); // Hide the current form
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

