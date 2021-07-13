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
    public partial class ViewDonor : Form
    {
        public ViewDonor()
        {
            InitializeComponent();
        }

        private void ViewDonor_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonorTbl");
            dataGridView1.DataSource = DAO.GetDataTable(cmd);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];
            string getDName = dataGridViewRow.Cells[1].Value.ToString();
            textBox1.Text = getDName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonorTbl WHERE DName LIKE'%" + textBox1.Text + "%'");
            dataGridView1.DataSource = DAO.GetDataTable(cmd);
        }
    }
}
