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
    public partial class BloodTransfert : Form
    {
        public BloodTransfert()
        {
            InitializeComponent();
        }

        private void BloodTransfert_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT PNum FROM PatientTbl");
            comboBox2.DataSource = DAO.GetDataTable(cmd);
            comboBox2.ValueMember = "PNum";
            comboBox2.DisplayMember = "PNum";
            comboBox2.SelectedIndex = -1;
        }


        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT PName From PatientTbl WHERE PNum = " + comboBox2.SelectedValue.ToString());
            textBox1.Text = DAO.GetData(cmd1).ToString();
            SqlCommand cmd2 = new SqlCommand("SELECT PBGroup From PatientTbl WHERE PNum = " + comboBox2.SelectedValue.ToString());
            textBox2.Text = DAO.GetData(cmd2).ToString();

            SqlCommand cmd3 = new SqlCommand("SELECT BStock FROM BloodTbl WHERE BGroup = '" + textBox2.Text + "'");
            int BStock = int.Parse(DAO.GetData(cmd3).ToString());
            if(BStock == 0)
            {
                label13.Visible = true;
                label13.Text = "Stock not avaiable!";
                button2.Visible = false;
            }
            if(BStock > 0)
            {
                label13.Visible = true;
                label13.Text = "Avaiables Stock";
                button2.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE BloodTbl SET BStock = BStock - 1 WHERE BGroup = '" + textBox2.Text + "'");
                DAO.UpdateTable(cmd);
                SqlCommand cmd1 = new SqlCommand("DELETE FROM PatientTbl WHERE PNum = " + comboBox2.SelectedValue.ToString());
                DAO.UpdateTable(cmd1);
                SqlCommand cmd2 = new SqlCommand("UPDATE Dashboard SET TotalTransfers = TotalTransfers + 1");
                DAO.UpdateTable(cmd2);
                comboBox2.SelectedIndex = -1;
                textBox1.Text = "";
                textBox2.Text = "";
                BloodTransfert_Load(sender, e);
                MessageBox.Show("Transfert successfull!");
                button2.Visible = false;
                label13.Visible = false;
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            
        }
    }
}
