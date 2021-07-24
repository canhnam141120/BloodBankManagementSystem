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
            
            dataGridView1.DataSource = DonorDAO.loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];
            string getDName = dataGridViewRow.Cells[4].Value.ToString();
            DNum.Text = dataGridViewRow.Cells[0].Value.ToString();
            DPhone.Text = getDName;
            DName.Text = dataGridViewRow.Cells[1].Value.ToString();
            DAddress.Text = dataGridViewRow.Cells[5].Value.ToString();
            DAge.Text = dataGridViewRow.Cells[2].Value.ToString();
            button2.Enabled = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonorTbl WHERE DPhone LIKE '%" + DPhone.Text + "%'");
            dataGridView1.DataSource = DAO.GetDataTable(cmd);
            DAge.Text = "";
            DPhone.Text = "";
            DAddress.Text = "";
            DNum.Text = "";
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DNum.Text == "")
            {
                MessageBox.Show("Please select 1 Donor!");
            }
            else
            {
                try
                {
                    DonorDAO.Update(DName.Text, DAge.Text, DPhone.Text, DAddress.Text, DNum.Text);
                    MessageBox.Show("Update patient number " + int.Parse(DNum.Text.ToString()) + " successfully!");
                    ViewDonor_Load(sender, e);
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        private void Reset()
        {
            DName.Text = "";
            DAge.Text = "";
            DPhone.Text = "";
            DAddress.Text = "";
            DNum.Text = "";

            button2.Enabled = false;
        }
    }
}
