using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DAL
{
    public class BloodDAO
    {
        static public DataTable loadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM BloodTbl");
            return DAO.GetDataTable(cmd);
        }

        static public DataTable searchData(string s)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * From BloodTbl WHERE BGroup = '" + s + "'");
            return DAO.GetDataTable(cmd1);
        }

        static public void Update(string volume, string Bgroup)
        {
            SqlCommand cmd = new SqlCommand("UPDATE BloodTbl SET BStock = BStock + " + volume + "WHERE BGroup = '" + Bgroup + "'");
            DAO.UpdateTable(cmd);
        }
    }
}
