﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class StudentInfo1 : Form
    {
        public StudentInfo1()
        {
            InitializeComponent();
        }

        private void StudentInfo1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Create a new child form
            StudentInfo2 Mwana2 = new StudentInfo2();
           

            // Display the new child form
            Mwana2.Show();
            this.Close();
        }
    }
    
}
