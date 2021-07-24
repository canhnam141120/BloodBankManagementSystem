using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System.DAL
{
    public class PatientDAO
    {
        static public DataTable loadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PatientTbl");
            return DAO.GetDataTable(cmd);
        }

        static public void Insert(string name, string age, string gen, string phone, string address, string Bgroup, string need)
        {
            SqlCommand sql = new SqlCommand("insert into PatientTbl values('" + name + "'," + age + ",'" + phone + "','" + gen + "','" + address + "','" + Bgroup + "'," + need + ")");
            DAO.UpdateTable(sql);
        }

        static public void Update(string name, string age, string gen, string phone, string address, string Bgroup,string volume, string PNum)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[PatientTbl] SET PName ='" +name + "',PAge ='" + age + "',PPhone='" + phone
                        + "',PGender ='" + gen + "', PBgroup = '" + Bgroup + "',PAdrress ='" + address +"',PBloodNeed=" + volume+ " WHERE PNum = " + PNum);
            DAO.UpdateTable(cmd);
        }

        static public void Delete(int i)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM PatientTbl WHERE PNum = " + i);
            DAO.UpdateTable(cmd);
        }
    }
}
