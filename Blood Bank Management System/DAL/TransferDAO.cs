using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DAL
{
    public class TransferDAO
    {
        static public DataTable loadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Transfer_Blood ORDER BY Date DESC");
            return DAO.GetDataTable(cmd);
        }
        static public void Insert(string s, string s2, string s3)
        {
            DAO.UpdateTable(new SqlCommand("INSERT INTO Transfer_Blood VALUES(" + s + ",'" + s2 + "','" + DateTime.Now +"','"+s3+ "')"));

        }

        static public DataTable Filter(DateTime date)
        {
            return DAO.GetDataTable(new SqlCommand("SELECT * FROM Transfer_Blood WHERE Date='" + date+"'"));
        }
    }
}
