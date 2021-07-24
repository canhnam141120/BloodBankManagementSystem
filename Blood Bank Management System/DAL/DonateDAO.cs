using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DAL
{
    public class DonateDAO
    {
        static public DataTable loadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonationTbl ORDER BY Date DESC");
            return DAO.GetDataTable(cmd);
        }

        static public void Insert(int a, string num, DateTime date, string bgroup)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO DonationTbl VALUES(" + a + ",'" + num + "','" + date + "','" +bgroup+ "')");
            DAO.UpdateTable(cmd);
        }

        static public void Delete(string id)
        {
            SqlCommand cmd1 = new SqlCommand("DELETE FROM DonationTbl WHERE DonateID =" + id);
            DAO.UpdateTable(cmd1);
        }

        
    }
}
