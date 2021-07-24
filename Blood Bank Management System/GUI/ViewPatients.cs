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
    public partial class ViewPatients : Form
    {
        public ViewPatients()
        {
            InitializeComponent();
        }

        private void ViewPatients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PatientDAO.loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            int numrow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];
            string getPNum = dataGridViewRow.Cells[0].Value.ToString();
            PNum.Text = getPNum;
            string getPName = dataGridViewRow.Cells[1].Value.ToString();
            PName.Text = getPName;
            string getPAge = dataGridViewRow.Cells[2].Value.ToString();
            PAge.Text = getPAge;
            string getPPhone = dataGridViewRow.Cells[3].Value.ToString();
            PPhone.Text = getPPhone;
            string getPGen = dataGridViewRow.Cells[4].Value.ToString();
            PGen.SelectedItem = getPGen;
            string getPAdress = dataGridViewRow.Cells[5].Value.ToString();
            PAddress.Text = getPAdress;
            string getPBGroup = dataGridViewRow.Cells[6].Value.ToString();
            PBGroup.SelectedItem = getPBGroup;
            string getVolume = dataGridViewRow.Cells[7].Value.ToString();
            textBox1.Text = getVolume;
        }

        private void Reset()
        {
            PName.Text = "";
            PAge.Text = "";
            PPhone.Text = "";
            PAddress.Text = "";
            PGen.SelectedIndex = -1;
            PBGroup.SelectedIndex = -1;
            PNum.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PNum.Text == "")
            {
                MessageBox.Show("Please select 1 Patient!");
            }
            else
            {
                try
                {
                    PatientDAO.Delete(int.Parse(PNum.Text.ToString()));
                    MessageBox.Show("Delete patient number " + int.Parse(PNum.Text.ToString()) + " successfully!");
                    ViewPatients_Load(sender, e);
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PNum.Text == "")
            {
                MessageBox.Show("Please select 1 Patient!");
            }
            else
            {
                try
                {
                    PatientDAO.Update(PName.Text, PAge.Text, PGen.SelectedItem.ToString(), PPhone.Text, PAddress.Text, PBGroup.SelectedItem.ToString(),textBox1.Text, PNum.Text);
                    MessageBox.Show("Update patient number " + int.Parse(PNum.Text.ToString()) + " successfully!");
                    ViewPatients_Load(sender, e);
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM PatientTbl WHERE PName LIKE'%" + PName.Text + "%'");
                dataGridView1.DataSource = DAO.GetDataTable(cmd);
            PAge.Text = "";
            PPhone.Text = "";
            PAddress.Text = "";
            PGen.SelectedIndex = -1;
            PBGroup.SelectedIndex = -1;
            PNum.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
        }
    }
}
