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
    class MedicineRecordRepository
    {
        sqlBase mycom;
        
        public MedicineRecordRepository()
        {
            mycom = new sqlBase();
        }

        public void insertMRecord(AnesthesiaMedicineRecord a)
        {
            //string sql = string.Format("INSERT INTO anesthesiamedicinerecord (`MedicineID`,`Time`, `ActualAmount`, `FlowRate`)  VALUES ('"
            //    + a.MedicineID + "','" + a.Time + "','" + a.ActualAmount + "','" + a.FlowRate + "')");
            string sql = string.Format("INSERT INTO anesthesiamedicinerecord (`MedicineID`,`ActualAmount`,`AnesthesiaType`, `FlowRate`)  VALUES ('"
                + a.MedicineID + "','" + a.ActualAmount + "','" + a.AnesthesiaType + "','" + a.FlowRate + "')");
            mycom.executeSQLCUD(sql);
        }

    }
}
