﻿using Blood_Bank_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TransferDAO.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TransferDAO.loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TransferDAO.Filter(dateTimePicker1.Value);
        }
    }
}
