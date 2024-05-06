using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NEXTofKin : Form
    {
        // Fields to store information from previous forms
        private string regNo;
        private string name;
        private string phoneNumber;
        private string email;
        private string homeAddress;
        private string gender;
        private string school;
        private string program;
        private string level;
        private string allergies;
        private string specialCare;
        private string diseases;

        public NEXTofKin()
        {
            InitializeComponent();
        }

        // Constructor to receive information from previous forms
        public NEXTofKin(string regNo, string name, string phoneNumber, string email, string homeAddress, string gender, string school, string program, string level, string allergies, string specialCare, string diseases) : this()
        {
            // Assign received values to fields
            this.regNo = regNo;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.homeAddress = homeAddress;
            this.gender = gender;
            this.school = school;
            this.program = program;
            this.level = level;
            this.allergies = allergies;
            this.specialCare = specialCare;
            this.diseases = diseases;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Insert data into the database
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tendai\\source\\repos\\WinFormsApp1\\obj\\Debug\\net8.0-windows\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO NextOfKinTable (RegNo, Name, PhoneNumber, Email, HomeAddress, Gender, School, Program, Level, Allergies, SpecialCare, Diseases, NextOfKinName, Relationship, NextOfKinPhoneNumber, NextOfKinEmail, NextOfKinHomeAddress, NextOfKinGender) " +
                                         "VALUES (@RegNo, @Name, @PhoneNumber, @Email, @HomeAddress, @Gender, @School, @Program, @Level, @Allergies, @SpecialCare, @Diseases, @NextOfKinName, @Relationship, @NextOfKinPhoneNumber, @NextOfKinEmail, @NextOfKinHomeAddress, @NextOfKinGender)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters for student information
                        command.Parameters.AddWithValue("@RegNo", regNo);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@HomeAddress", homeAddress);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@School", school);
                        command.Parameters.AddWithValue("@Program", program);
                        command.Parameters.AddWithValue("@Level", level);
                        command.Parameters.AddWithValue("@Allergies", allergies);
                        command.Parameters.AddWithValue("@SpecialCare", specialCare);
                        command.Parameters.AddWithValue("@Diseases", diseases);

                        // Add parameters for next of kin information
                        command.Parameters.AddWithValue("@NextOfKinName", Nametxt.Text);
                        command.Parameters.AddWithValue("@Relationship", Relationshiptxt.Text);
                        command.Parameters.AddWithValue("@NextOfKinPhoneNumber", Phonetxt.Text);
                        command.Parameters.AddWithValue("@NextOfKinEmail", Emailtxt.Text);
                        command.Parameters.AddWithValue("@NextOfKinHomeAddress", Addresstxt.Text);

                        // Determine kin gender based on radio button selection
                        string sex = Maleradio.Checked ? "Male" : "Female";
                        command.Parameters.AddWithValue("@NextOfKinGender", sex);

                        command.ExecuteNonQuery();
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

