using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DTL
{
    public class Transfer
    {
        private int transferid;
        private int patientid;
        private int volumeblood;
        private DateTime date;

        public Transfer()
        {
        }

        public Transfer(int transferid, int patientid, int volumeblood, DateTime date)
        {
            this.transferid = transferid;
            this.patientid = patientid;
            this.volumeblood = volumeblood;
            this.date = date;
        }

        public int TransferID { get => transferid; set => transferid = value; }
        public int PatientID { get => patientid; set => patientid = value; }
        public int VolumeBlood { get => volumeblood; set => volumeblood = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
