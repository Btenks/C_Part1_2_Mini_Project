using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class StudentInfo2 : Form
    {
        // Connection string to the database
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tendai\\source\\repos\\WinFormsApp1\\obj\\Debug\\net8.0-windows\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public StudentInfo2(string regNo)
        {
            InitializeComponent();
            Txtregno.Text = regNo; // Set the regNo in the textbox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Prepare the SQL query
                    string query = @"UPDATE studentinfo SET School = @School, Program = @Program, Level = @Level 
                                     WHERE RegNo = @RegNo";

                    // Create a command object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@School", Txtschool.Text);
                        command.Parameters.AddWithValue("@Program", Txtprogram.Text);
                        command.Parameters.AddWithValue("@Level", Txtlevel.Text);
                        command.Parameters.AddWithValue("@RegNo", Txtregno.Text);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Proceed to the next form
                            StudentHealthInfor studentHealthInfoForm = new StudentHealthInfor(Txtregno.Text);
                            studentHealthInfoForm.Show();
                            this.Hide(); // Hide the current form
                        }
                        else
                        {
                            MessageBox.Show("No records updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
