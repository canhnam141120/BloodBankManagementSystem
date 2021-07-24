using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Mainform : Form
    {
        string username;
        public Mainform()
        {
            InitializeComponent();
            label11.Visible = false;
            panel12.Visible = false;
        }

        public Mainform(string username)
        {
            this.username = username;
            InitializeComponent();
            label11.Visible = true;
            panel12.Visible = true;
            AddUser user = new AddUser();
            Embed(panel11, user);
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
        }

        private void Embed(Panel p, Form f)
        {
            p.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            p.Controls.Add(f);//thêm form mới vào panel
            p.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.BackgroundImage = null;
            panel3.Visible = true;
            Donor donor = new Donor();
            Embed(panel11, donor);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.BackgroundImage = null;
            panel5.Visible = true;
            ViewDonor viewDonor = new ViewDonor();
            Embed(panel11, viewDonor);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.BackgroundImage = null;
            panel4.Visible = true;
            Patient patient = new Patient();
            Embed(panel11, patient);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.BackgroundImage = null;
            panel6.Visible = true;
            ViewPatients viewpatient = new ViewPatients();
            Embed(panel11, viewpatient);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel3.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.BackgroundImage = null;
            panel7.Visible = true;
            BloodStock bloodStock = new BloodStock();
            Embed(panel11, bloodStock);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel3.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.BackgroundImage = null;
            panel8.Visible = true;
            BloodTransfert bloodTransfert = new BloodTransfert();
            Embed(panel11, bloodTransfert);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel3.Visible = false;
            panel10.Visible = false;
            panel11.BackgroundImage = null;
            panel9.Visible = true;
            Dashboard dashboard = new Dashboard();
            Embed(panel11, dashboard);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel3.Visible = false;
            panel11.BackgroundImage = null;
            panel10.Visible = true;
            DonateBlood donate = new DonateBlood();
            Embed(panel11, donate);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
