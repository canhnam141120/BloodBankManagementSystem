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
            if (DNameTb.Text == "" || DPhoneTb.Text == "" || DAgeTb.Text == "" || DAddressTb.Text == "" || DGenCb.SelectedIndex == -1 || DBGroupCb.SelectedIndex == -1 || cb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                DataTable dt = DAO.GetDataTable("SELECT * FROM DonorTbl WHERE DPhone = '" + DPhoneTb.Text + "'");
                if (dt.Rows.Count == 0) {
                    DonorDAO.Insert(DNameTb.Text, DAgeTb.Text, DGenCb.SelectedItem.ToString(), DPhoneTb.Text, DAddressTb.Text, DBGroupCb.SelectedItem.ToString(), cb.SelectedItem.ToString(), dateTimePicker1.Value);
                    int a = (int)DAO.GetData(new SqlCommand("SELECT MAX(DNum) FROM DonorTbl"));
                    DonateDAO.Insert(a, cb.SelectedItem.ToString(), dateTimePicker1.Value, DBGroupCb.SelectedItem.ToString());
                    MessageBox.Show("Donor Successfully Saved!");
                    Reset();
                }
                else
                {
                    int a = (int)DAO.GetData(new SqlCommand("SELECT DNum FROM DonorTbl WHERE DPhone = '" + DPhoneTb.Text + "'"));
                    DonateDAO.Insert(a, cb.SelectedItem.ToString(), dateTimePicker1.Value,DBGroupCb.SelectedItem.ToString());
                    MessageBox.Show("Donation Successfully!");
                    Reset();
                }
            }
        }
    }
}
