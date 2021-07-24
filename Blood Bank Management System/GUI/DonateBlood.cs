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
            dataGridView1.DataSource = BloodDAO.loadData();
            dataGridView2.DataSource = DonateDAO.loadData();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView2.Rows[numrow];
            tbID.Text = dataGridViewRow.Cells[0].Value.ToString();
            string getDNum = dataGridViewRow.Cells[1].Value.ToString();
            DNumTb.Text = getDNum;
            tbVolume.Text = dataGridViewRow.Cells[2].Value.ToString();
            string getDName = DAO.GetData(new SqlCommand( "SELECT DName FROM DonorTbl WHERE DNum =" + getDNum)).ToString();
            DNameTb.Text = getDName;
            string getDBGroup = DAO.GetData(new SqlCommand("SELECT DBGroup FROM DonorTbl WHERE DNum =" + getDNum)).ToString();
            DBGroupTb.Text = getDBGroup;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DNumTb.Text == "")
            {
                MessageBox.Show("Please select 1 Donation");
            }
            else
            {
                BloodDAO.Update(tbVolume.Text, DBGroupTb.Text);
                DonateDAO.Delete(tbID.Text);
                DNumTb.Text = "";
                DNameTb.Text = "";
                DBGroupTb.Text = "";
                DonateBlood_Load(sender, e);
            }
        }
    }
}
