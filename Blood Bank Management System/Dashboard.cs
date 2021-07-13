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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT TotalDonor FROM Dashboard");
            DonorTb.Text = DAO.GetData(cmd).ToString();
            SqlCommand cmd1 = new SqlCommand("SELECT TotalTransfers FROM Dashboard");
            TransTb.Text = DAO.GetData(cmd1).ToString();
            SqlCommand cmd2 = new SqlCommand("SELECT TotalBlood FROM Dashboard");
            BloodTb.Text = DAO.GetData(cmd2).ToString();
            SqlCommand cmd3 = new SqlCommand("SELECT [TypeBloodA+] FROM Dashboard");
            A1Tb.Text = DAO.GetData(cmd3).ToString();
            SqlCommand cmd4 = new SqlCommand("SELECT [TypeBloodA-] FROM Dashboard");
            A2Tb.Text = DAO.GetData(cmd4).ToString();
            SqlCommand cmd5 = new SqlCommand("SELECT [TypeBloodB+] FROM Dashboard");
            B1Tb.Text = DAO.GetData(cmd5).ToString();
            SqlCommand cmd6 = new SqlCommand("SELECT [TypeBloodB-] FROM Dashboard");
            B2Tb.Text = DAO.GetData(cmd6).ToString();
            SqlCommand cmd7 = new SqlCommand("SELECT [TypeBloodO+] FROM Dashboard");
            O1Tb.Text = DAO.GetData(cmd7).ToString();
            SqlCommand cmd8 = new SqlCommand("SELECT [TypeBloodO-] FROM Dashboard");
            O2Tb.Text = DAO.GetData(cmd8).ToString();
            SqlCommand cmd9 = new SqlCommand("SELECT [TypeBloodAB+] FROM Dashboard");
            AB1Tb.Text = DAO.GetData(cmd9).ToString();
            SqlCommand cmd10 = new SqlCommand("SELECT [TypeBloodAB-] FROM Dashboard");
            AB2Tb.Text = DAO.GetData(cmd10).ToString();

        }
    }
}
