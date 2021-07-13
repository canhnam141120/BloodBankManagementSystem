using Blood_Bank_Management_System.DAL;
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
    public partial class DonateBlood : Form
    {
        public DonateBlood()
        {
            InitializeComponent();
        }

        private void DonateBlood_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BloodTbl");
            dataGridView1.DataSource = DAO.GetDataTable(cmd);
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM DonorTbl");
            dataGridView2.DataSource = DAO.GetDataTable(cmd1);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView2.Rows[numrow];
            string getDNum = dataGridViewRow.Cells[0].Value.ToString();
            DNumTb.Text = getDNum;
            string getDName = dataGridViewRow.Cells[1].Value.ToString();
            DNameTb.Text = getDName;
            string getDBGroup = dataGridViewRow.Cells[6].Value.ToString();
            DBGroupTb.Text = getDBGroup;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DNumTb.Text == "")
            {
                MessageBox.Show("Please select 1 Donor");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE BloodTbl SET BStock = BStock + 1 WHERE BGroup = '" + DBGroupTb.Text + "'");
                SqlCommand cmd1 = new SqlCommand("DELETE FROM DonorTbl WHERE DNum =" + DNumTb.Text);
                DAO.UpdateTable(cmd);
                DAO.UpdateTable(cmd1);
                
                SqlCommand cmd2 = new SqlCommand("UPDATE Dashboard SET TotalBlood = TotalBlood + 1");
                DAO.UpdateTable(cmd2);
                if (DBGroupTb.Text == "A+")
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Dashboard SET [TypeBloodA+] = [TypeBloodA+] + 1");
                    DAO.UpdateTable(cmd3);
                }
                if (DBGroupTb.Text == "A-")
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Dashboard SET [TypeBloodA-] = [TypeBloodA-] + 1");
                    DAO.UpdateTable(cmd3);
                }
                if (DBGroupTb.Text == "B+")
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Dashboard SET [TypeBloodB+] = [TypeBloodB+] + 1");
                    DAO.UpdateTable(cmd3);
                }
                if (DBGroupTb.Text == "B-")
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Dashboard SET [TypeBloodB-] = [TypeBloodB-] + 1");
                    DAO.UpdateTable(cmd3);
                }
                if (DBGroupTb.Text == "O+")
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Dashboard SET [TypeBloodO+] = [TypeBloodO+] + 1");
                    DAO.UpdateTable(cmd3);
                }
                if (DBGroupTb.Text == "O-")
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Dashboard SET [TypeBloodO-] = [TypeBloodO-] + 1");
                    DAO.UpdateTable(cmd3);
                }
                if (DBGroupTb.Text == "AB+")
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Dashboard SET [TypeBloodAB+] = [TypeBloodAB+] + 1");
                    DAO.UpdateTable(cmd3);
                }
                if (DBGroupTb.Text == "AB-")
                {
                    SqlCommand cmd3 = new SqlCommand("UPDATE Dashboard SET [TypeBloodAB-] = [TypeBloodAB-] + 1");
                    DAO.UpdateTable(cmd3);
                }
                DNumTb.Text = "";
                DNameTb.Text = "";
                DBGroupTb.Text = "";
                DonateBlood_Load(sender, e);
            }
        }
    }
}
