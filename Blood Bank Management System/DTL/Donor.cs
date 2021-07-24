using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DTL
{
    public class Donor
    {
        private int dnum;
        private string dname;
        private int dage;
        private string dgen;
        private string dphone;
        private string daddress;
        private string dbgroup;

        public Donor()
        {
        }

        public Donor(int dnum, string dname, int dage, string dgen, string dphone, string daddress, string dbgroup)
        {
            this.dnum = dnum;
            this.dname = dname;
            this.dage = dage;
            this.dgen = dgen;
            this.dphone = dphone;
            this.daddress = daddress;
            this.dbgroup = dbgroup;
            
        }

        public int DNum { get => dnum; set => dnum = value; }
        public string DName { get => dname; set => dname = value; }
        public int DAge { get => dage; set => dage = value; }
        public string DGen { get => dgen; set => dgen = value; }
        public string DPhone { get => dphone; set => dphone = value; }
        public string DAddress { get => daddress; set => daddress = value; }
        public string DBgroup { get => dbgroup; set => dbgroup = value; }
    }
}
