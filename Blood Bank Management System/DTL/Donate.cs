using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DTL
{
    public class Donate
    {
        private int donateid;
        private int donorid;
        private int volumeblood;
        private DateTime date;

        public Donate()
        {
        }

        public Donate(int donateid, int donorid, int volumeblood, DateTime date)
        {
            this.donateid = donateid;
            this.donorid = donorid;
            this.volumeblood = volumeblood;
            this.date = date;
        }

        public int DonateID { get => donateid; set => donateid = value; }
        public int DonorID { get => donorid; set => donorid = value; }
        public int VolumeBlood { get => volumeblood; set => volumeblood = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
