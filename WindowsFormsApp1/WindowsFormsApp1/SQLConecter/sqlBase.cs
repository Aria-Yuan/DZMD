using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Model
{
    public class sqlBase
    {
        MySqlConnection myconn = null;
        MySqlCommand mycom = null;
        //MySqlDataAdapter myrec = null;

        public sqlBase()
        {
            myconn = new MySqlConnection("Host=localhost;Database=DZMD;Username=root;Password=1234");
            myconn.Open();
        }

        public MySqlDataReader executeSQLR(String ins)
        {
            mycom = myconn.CreateCommand();
            string sql = string.Format(ins);
            mycom.CommandText = sql;
            mycom.CommandType = CommandType.Text;
            MySqlDataReader sdr = mycom.ExecuteReader();
            
            return sdr;
        }

        public void executeSQLCUD(String ins)
        {
            mycom = myconn.CreateCommand();
            string sql = string.Format(ins);
            mycom.CommandText = sql;
            mycom.CommandType = CommandType.Text;
            int n = mycom.ExecuteNonQuery();
            
        }

        public void closeConnect()
        {
            myconn.Close();
        }

    }
}
