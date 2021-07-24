using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DAL
{
    public class DonorDAO
    {
        static public DataTable loadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonorTbl ORDER BY Date DESC");
            return DAO.GetDataTable(cmd);
        }
        static public void Insert(string name, string age, string gen, string phone, string address, string Bgroup, string volume,DateTime date)
        {
            SqlCommand sql = new SqlCommand("insert into DonorTbl values('" + name + "'," + age + ",'" + gen + "','" + phone + "','" + address + "','" + Bgroup + "',"+ volume+",'"+date+ "')");
            DAO.UpdateTable(sql);
        }

        static public void Update(string name, string age, string phone, string address, string num)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[DonorTbl] SET DName ='" + name + "',DAge ='" + age + "',DPhone='" +phone
                        + "',DAdress ='" + address + "' WHERE DNum = " + num);
            DAO.UpdateTable(cmd);
        }
    }
}
