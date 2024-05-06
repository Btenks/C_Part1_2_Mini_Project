using System;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class NEXTofKin : Form
    {
        // Connection string to the database
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tendai\\source\\repos\\WinFormsApp1\\obj\\Debug\\net8.0-windows\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private string regNo;

        public NEXTofKin(string regNo)
        {
            InitializeComponent();
            this.regNo = regNo;
            Txtregno.Text = regNo;
            // Store the regNo
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
                    string query = @"UPDATE studentinfo 
                                     SET NextOfKinName = @NextOfKinName, 
                                         Relationship = @Relationship, 
                                         NextOfKinPhoneNumber = @NextOfKinPhoneNumber, 
                                         NextOfKinEmail = @NextOfKinEmail, 
                                         NextOfKinHomeAddress = @NextOfKinHomeAddress, 
                                         NextOfKinGender = @NextOfKinGender
                                     WHERE RegNo = @RegNo";

                    // Create a command object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@RegNo", regNo);
                        command.Parameters.AddWithValue("@NextOfKinName", Nametxt.Text);
                        command.Parameters.AddWithValue("@Relationship", Relationshiptxt.Text);
                        command.Parameters.AddWithValue("@NextOfKinPhoneNumber", Phonetxt.Text);
                        command.Parameters.AddWithValue("@NextOfKinEmail", Emailtxt.Text);
                        command.Parameters.AddWithValue("@NextOfKinHomeAddress", Addresstxt.Text);

                        // Determine kin gender based on radio button selection
                        string nextOfKinGender = Maleradio.Checked ? "Male" : "Female";
                        command.Parameters.AddWithValue("@NextOfKinGender", nextOfKinGender);

                        // Execute the command
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Navigate to the Terms form
                        Terms termsForm = new Terms();
                        termsForm.Show();

                        // Close the current form
                        this.Close();
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
