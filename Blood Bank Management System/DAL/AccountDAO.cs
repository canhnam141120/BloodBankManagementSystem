using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DAL
{
    public class AccountDAO
    {
        static public DataTable loadAccount()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoginTbl");
            return DAO.GetDataTable(cmd);
        }
        static public void Insert(string user, string pass)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO LoginTbl([UserName],[Password]) VALUES('" + user + "','" + pass + "')");
            DAO.UpdateTable(cmd);
        }
        static public void Delete(string id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM LoginTbl WHERE ID = '" + id + "'");
            DAO.UpdateTable(cmd);
        }

        static public void Update(string user, string pass, string id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE LoginTbl SET UserName ='" + user + "',Password ='" + pass + "'WHERE ID = '" + id + "'");
            DAO.UpdateTable(cmd);
        }
    }
}
