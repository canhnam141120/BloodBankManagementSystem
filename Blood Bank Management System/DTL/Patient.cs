using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DTL
{
    public class Patient
    {
        private int pnum;
        private string pname;
        private int page;
        private string pgen;
        private string pphone;
        private string paddress;
        private string pbgroup;
        private int pbloodneed;

        public Patient()
        {
        }

        public Patient(int pnum, string pname, int page, string pgen, string pphone, string paddress,string pbgroup, int pbloodneed)
        {
            this.pnum = pnum;
            this.pname = pname;
            this.page = page;
            this.pgen = pgen;
            this.pphone = pphone;
            this.paddress = paddress;
            this.pbgroup = pbgroup;
            this.pbloodneed = pbloodneed;
        }

        public int PNum { get => pnum; set => pnum = value; }
        public string PName { get => pname; set => pname = value; }
        public int PAge { get => page; set => page = value; }
        public string PGen { get => pgen; set => pgen = value; }
        public string PPhone { get => pphone; set => pphone = value; }
        public string PAddress { get => paddress; set => paddress = value; }
        public string PBgroup { get => pbgroup; set => pbgroup = value; }
        public int PBloodneed { get => pbloodneed; set => pbloodneed = value; }
    }
}
