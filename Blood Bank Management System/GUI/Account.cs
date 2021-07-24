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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = AccountDAO.loadAccount();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            int numrow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[numrow];
            string getId = dataGridViewRow.Cells[0].Value.ToString();
            IDTb.Text = getId;
            string getUserName = dataGridViewRow.Cells[1].Value.ToString();
            UserNameTb.Text = getUserName;
            string getPassword = dataGridViewRow.Cells[2].Value.ToString();
            PasswordTb.Text = getPassword;
        }

        private void Reset()
        {
            UserNameTb.Text = "";
            PasswordTb.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            btnSave.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "")
            {
                MessageBox.Show("Please select 1 Account!");
            }
            else
            {
                try
                {
                    AccountDAO.Delete(IDTb.Text);
                    MessageBox.Show("Delete successfully!");
                    AddUser_Load(sender, e);
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing infomation!");
            }
            else
            {
                try
                {
                    AccountDAO.Insert(UserNameTb.Text, PasswordTb.Text);
                    MessageBox.Show("Add employees successfully!");
                    AddUser_Load(sender, e);
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
            if (UserNameTb.Text == "")
            {
                MessageBox.Show("Please select 1 Patient!");
            }
            else
            {
                try
                {
                    AccountDAO.Update(UserNameTb.Text, PasswordTb.Text, IDTb.Text);
                    MessageBox.Show("Update successfully!");
                    AddUser_Load(sender, e);
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            UserNameTb.Text = "";
            PasswordTb.Text = "";
        }
    }
}
