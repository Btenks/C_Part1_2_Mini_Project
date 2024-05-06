using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class StudentHealthInfor : Form
    {
        // Connection string to the database
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tendai\\source\\repos\\WinFormsApp1\\obj\\Debug\\net8.0-windows\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public StudentHealthInfor(string regNo)
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
                    string query = @"UPDATE studentinfo SET Allergies = @Allergies, SpecialCare = @SpecialCare, Diseases = @Diseases 
                                     WHERE RegNo = @RegNo";

                    // Create a command object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Allergies", Txtallergies.Text);
                        command.Parameters.AddWithValue("@SpecialCare", Txtspecial.Text);
                        command.Parameters.AddWithValue("@Diseases", Txtdiseases.Text);
                        command.Parameters.AddWithValue("@RegNo", Txtregno.Text);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Pass regNo to the NEXTofKin form and navigate to it
                            NEXTofKin nextOfKinForm = new NEXTofKin(Txtregno.Text);
                            nextOfKinForm.Show();

                            // Close the current form
                            this.Close();
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
