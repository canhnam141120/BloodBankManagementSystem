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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool checkLogin()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoginTbl WHERE UserName = N'" + textBox1.Text + "' AND Password =N'" + textBox2.Text + "'");
            DataTable result = DAO.GetDataTable(cmd);
            return result.Rows.Count > 0;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                Mainform main = new Mainform();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed! Try again!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(checkLogin() && textBox1.Text == "admin")
            {
                Mainform main = new Mainform(textBox1.Text);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed! You are not admin!");
            }
        }
    }
}
