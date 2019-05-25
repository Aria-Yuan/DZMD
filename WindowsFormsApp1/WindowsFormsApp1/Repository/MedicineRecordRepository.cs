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
            string sql = string.Format("INSERT INTO anesthesiamedicinerecord (`MedicineID`,`ActualAmount`,`AnesthesiaType`,`AnesthesiaID`, `StartTime`,`FlowRate`)  VALUES ('"
                + a.MedicineID + "','" + a.ActualAmount + "','" + a.AnesthesiaType + "','" + a.AnesthesiaID + "','" + a.StartTime.ToString("yyyy-MM-dd HH:mm:ss") + "','" + a.FlowRate + "')");
            mycom.executeSQLCUD(sql);
            mycom.closeConnect();
        }

        //查找某个药物最新的一笔记录
        public AnesthesiaMedicineRecord findNewestRecord(AnesthesiaMedicineRecord a)
        {
            mycom = new sqlBase();

            AnesthesiaMedicineRecord target = new AnesthesiaMedicineRecord();
            string sql = string.Format("SELECT * FROM anesthesiamedicinerecord a WHERE a.MedicineID = '" + a.MedicineID + "' AND a.AnesthesiaID = '" + a.AnesthesiaID +
                "' AND a.ActualAmount = '" + a.ActualAmount + "' AND StartTime = (SELECT Max(b.StartTime) FROM anesthesiamedicinerecord b WHERE b.AnesthesiaID = '" + a.AnesthesiaID +
                "' AND b.MedicineID = '" + a.MedicineID + "' AND b.ActualAmount = '" + a.ActualAmount + "')");
            
            MySqlDataReader sdr = mycom.executeSQLR(sql);
            while (sdr.Read())
            {
                target.ID = sdr[0].ToString();
                target.AnesthesiaID = sdr[1].ToString();
                target.MedicineID = sdr[2].ToString();
                target.AnesthesiaType = (int)sdr[3];
                if(sdr[4].ToString() != "")
                    target.StartTime = (DateTime)sdr[4];
                if (sdr[5].ToString() != "")
                    target.EndTime = (DateTime)sdr[5];
                target.ActualAmount = sdr[6].ToString();
                target.FlowRate  = sdr[7].ToString();
            }

            mycom.closeConnect();
            return target;
        }

        //查找某一条药物记录
        public AnesthesiaMedicineRecord findRecordByTime(AnesthesiaMedicineRecord a)
        {
            mycom = new sqlBase();
            AnesthesiaMedicineRecord target = new AnesthesiaMedicineRecord();

            string sql = string.Format("SELECT * FROM anesthesiamedicinerecord a WHERE a.MedicineID = '" + a.MedicineID + "' AND a.AnesthesiaID = '" + a.AnesthesiaID +
                "' AND StartTime <= '" + a.StartTime.ToString("yyyy-MM-dd HH:mm:ss") + "' AND (EndTime >= '" + a.StartTime.ToString("yyyy-MM-dd HH:mm:ss") + "' OR EndTime is null)");

            Console.WriteLine(sql);
            MySqlDataReader sdr = mycom.executeSQLR(sql);
            while (sdr.Read())
            {
                target.ID = sdr[0].ToString();
                target.AnesthesiaID = sdr[1].ToString();
                target.MedicineID = sdr[2].ToString();
                target.AnesthesiaType = (int)sdr[3];
                if (sdr[4].ToString() != "")
                    target.StartTime = (DateTime)sdr[4];
                if (sdr[5].ToString() != "")
                    target.EndTime = (DateTime)sdr[5];
                target.ActualAmount = sdr[6].ToString();
                target.FlowRate = sdr[7].ToString();
            }

            mycom.closeConnect();
            return target;
        }

        //删除药物记录
        public void deleteByTime(AnesthesiaMedicineRecord a)
        {
            mycom = new sqlBase();
            string sql;
            if (a.AnesthesiaType == 0)
                sql = "DELETE FROM anesthesiamedicinerecord WHERE StartTime = '" + a.StartTime.ToString("yyyy-MM-dd HH:mm:ss") + "' AND MedicineID = '" 
                    + a.MedicineID + "' AND AnesthesiaID = '" + a.AnesthesiaID + "'";
            else
                sql = "DELETE FROM anesthesiamedicinerecord WHERE StartTime = '" + a.StartTime.ToString("yyyy-MM-dd HH:mm:ss") + "' AND MedicineID = '"
                    + a.MedicineID + "' AND AnesthesiaID = '" + a.AnesthesiaID + "' AND ActualAmount = '" + a.ActualAmount + "'";

            mycom.executeSQLCUD(sql);
            mycom.closeConnect();
        }

        //修改药物记录
        public void updateByTime(AnesthesiaMedicineRecord a)
        {
            mycom = new sqlBase();
            string sql;
            if (a.AnesthesiaType == 0)
                sql = "UPDATE anesthesiamedicinerecord SET ActualAmount = '" + a.ActualAmount + "' WHERE StartTime = '" + a.StartTime.ToString("yyyy-MM-dd HH:mm:ss")
                    + "' AND MedicineID = '"  + a.MedicineID + "' AND AnesthesiaID = '" + a.AnesthesiaID + "'";
            else
                sql = "UPDATE anesthesiamedicinerecord SET ActualAmount = '" + a.ActualAmount + "' , FlowRate = '" + a.FlowRate +
                    "' WHERE StartTime = '" + a.StartTime.ToString("yyyy-MM-dd HH:mm:ss") + "' AND MedicineID = '"
                    + a.MedicineID + "' AND AnesthesiaID = '" + a.AnesthesiaID + "'";

            Console.WriteLine(sql);
            mycom.executeSQLCUD(sql);
            mycom.closeConnect();
        }

        //設置停止時間
        public void setEndTime(AnesthesiaMedicineRecord a)
        {
            mycom = new sqlBase();

            string sql = "UPDATE anesthesiamedicinerecord SET EndTime = '" + a.EndTime.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE StartTime = '" 
                + a.StartTime.ToString("yyyy-MM-dd HH:mm:ss") + "' AND MedicineID = '" + a.MedicineID + "' AND AnesthesiaID = '" + a.AnesthesiaID + "'";

            Console.WriteLine(sql);
            mycom.executeSQLCUD(sql);
            mycom.closeConnect();
        }

    }
}
