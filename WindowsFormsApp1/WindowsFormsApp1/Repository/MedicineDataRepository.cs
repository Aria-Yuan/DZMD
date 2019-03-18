using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Repository
{
    class MedicineDataRepository
    {

        sqlBase mycom;

        public MedicineDataRepository()
        {
            mycom = new sqlBase();
        }


        public List<Medicinedata> selectAll()
        {
            List<Medicinedata> list = new List<Medicinedata>();
            
            string sql = string.Format("select * from medicinedata ");
            MySqlDataReader sdr = mycom.executeSQLR(sql);
            while (sdr.Read())
            {
                Medicinedata a = new Medicinedata();
                a.MId = sdr[0].ToString();
                a.MName = sdr[1].ToString();
                a.Unit = sdr[2].ToString();

                list.Add(a);
            }

            mycom.closeConnect();
            return list;
        }

        public List<Medicinedata> select(String username)
        {
            List<Medicinedata> list = new List<Medicinedata>();
            
            string sql = string.Format("select * from medicinedata where MedicineName like '%" + username + "%'");
            MySqlDataReader sdr = mycom.executeSQLR(sql);
            while (sdr.Read())
            {
                Medicinedata a = new Medicinedata();
                a.MId = sdr[0].ToString();
                a.MName = sdr[1].ToString();
                a.Unit = sdr[2].ToString();

                list.Add(a);
            }

            mycom.closeConnect();
            return list;
        }

        public void addData(Medicinedata u)
        {
            string sql = string.Format("INSERT INTO medicinedata (`MedicineId`,`MedicineName`, `Unit`)  VALUES ('"
                + u.MId + "','" + u.MName + "','" + u.Unit + "')");
            mycom.executeSQLCUD(sql);

        }

        public void update(Medicinedata u)
        {
            string sql = string.Format("UPDATE medicinedata SET MedicineName = '" +
                u.MName + "',Unit = '" + u.Unit + "' WHERE MedicineID = '" + u.MId + "'");
            mycom.executeSQLCUD(sql);

        }

        public void delete(String id)
        {
            string sql = string.Format("DELETE FROM medicinedata WHERE MedicineID='" + id + "'");
            mycom.executeSQLCUD(sql);

        }

    }
}
