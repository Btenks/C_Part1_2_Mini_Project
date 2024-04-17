﻿using System;
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

namespace WinFormsApp1
{

    public partial class CreateAccount : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tendai\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30");
        public CreateAccount()
        {
            InitializeComponent();
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
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string checkUsername = "SELECT * FROM admin WHERE username = '"
                        + signup_username.Text.Trim() + "'";

                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(signup_username.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO admin (email, username, pasword, date_created) "
                                "VALUES(@email,@username,@pass,@date)";
                            DateTime date = DateTime.Today;

                            using SqlCommand cmd = new SqlCommand(insertData, connect)) ;
                            {
                                cmd.Parameters.AddWithValue("@email", signup_hitmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", signup_hitmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@username", signup_hitmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", date);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void signup_hitmali_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
