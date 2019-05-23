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
            mycom = new sqlBase();
            //string sql = string.Format("INSERT INTO anesthesiamedicinerecord (`MedicineID`,`Time`, `ActualAmount`, `FlowRate`)  VALUES ('"
            //    + a.MedicineID + "','" + a.Time + "','" + a.ActualAmount + "','" + a.FlowRate + "')");
            string sql = string.Format("INSERT INTO anesthesiamedicinerecord (`MedicineID`,`ActualAmount`,`AnesthesiaType`,`AnesthesiaID`, `Time`,`FlowRate`)  VALUES ('"
                + a.MedicineID + "','" + a.ActualAmount + "','" + a.AnesthesiaType + "','" + a.AnesthesiaID + "','" + a.Time.ToString("yyyy-MM-dd HH:mm:ss") + "','" + a.FlowRate + "')");
            mycom.executeSQLCUD(sql);
            mycom.closeConnect();
        }

        //查找某个药物最新的一笔记录
        public AnesthesiaMedicineRecord findNewestRecord(AnesthesiaMedicineRecord a)
        {
            mycom = new sqlBase();

            AnesthesiaMedicineRecord target = new AnesthesiaMedicineRecord();
            string sql = string.Format("SELECT * FROM anesthesiamedicinerecord a WHERE a.MedicineID = '" + a.MedicineID + "' AND a.AnesthesiaID = '" + a.AnesthesiaID +
                "' AND a.ActualAmount = '" + a.ActualAmount + "' AND Time = (SELECT Max(b.Time) FROM anesthesiamedicinerecord b WHERE b.AnesthesiaID = '" + a.AnesthesiaID +
                "' AND b.MedicineID = '" + a.MedicineID + "' AND b.ActualAmount = '" + a.ActualAmount + "')");
            
            MySqlDataReader sdr = mycom.executeSQLR(sql);
            while (sdr.Read())
            {
                target.ID = sdr[0].ToString();
                target.AnesthesiaID = sdr[1].ToString();
                target.MedicineID = sdr[2].ToString();
                target.AnesthesiaType = (int)sdr[3];
                if(sdr[4].ToString() != "")
                    target.Time = (DateTime)sdr[4];
                target.ActualAmount = sdr[5].ToString();
                target.FlowRate  = sdr[6].ToString();
            }

            mycom.closeConnect();
            return target;
        }
        
    }
}
