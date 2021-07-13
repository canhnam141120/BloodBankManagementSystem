using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Blood_Bank_Management_System.DAL;

namespace Blood_Bank_Management_System
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            DNameTb.Text = "";
            DAgeTb.Text = "";
            DPhoneTb.Text = "";
            DAddressTb.Text = "";
            DGenCb.SelectedIndex = -1;
            DBGroupCb.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DPhoneTb.Text == "" || DAgeTb.Text == "" ||DAddressTb.Text == "" || DGenCb.SelectedIndex == -1 || DBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    SqlCommand sql = new SqlCommand( "insert into DonorTbl values('" + DNameTb.Text + "'," + DAgeTb.Text + ",'" + DGenCb.SelectedItem.ToString() + "','" + DPhoneTb.Text + "','" + DAddressTb.Text + "','" + DBGroupCb.SelectedItem.ToString() + "')");
                    DAO.UpdateTable(sql);
                    SqlCommand cmd2 = new SqlCommand("UPDATE Dashboard SET TotalDonor = TotalDonor + 1");
                    DAO.UpdateTable(cmd2);
                    MessageBox.Show("Donor Successfully Saved!");
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
