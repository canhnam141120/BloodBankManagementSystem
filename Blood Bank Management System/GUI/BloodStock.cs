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
    public partial class BloodStock : Form
    {
        public BloodStock()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
        }

        private void BloodStock_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BloodDAO.loadData();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "All Blood Stock")
            {
                BloodStock_Load(sender, e);
            }
            else
            {
                dataGridView1.DataSource = BloodDAO.searchData(comboBox2.SelectedItem.ToString());
            }

        }

    }
}
