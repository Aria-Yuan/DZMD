using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Repository
{
    class VitalRecordRepository
    {
        sqlBase mycom;
        public VitalRecordRepository()
        {
            mycom = new sqlBase();
        }

        private void InsertNewSingleVitalData(string AID, string name, string data, DateTime time)
        {
            string cmd = "INSERT INTO `dzmd`.`vitalrecord` (`AnesthesiaID`, " +
                "`VitalSigns`, `VitalTime`, `VitalDetail`) VALUES ('" +
                AID + "', '" + name + "', '" + time.ToString("yyyy-MM-dd HH:mm:ss") +
                "', '" + data + "');";
            mycom.executeSQLCUD(cmd);
        }

        private void UpdataSingleVitalData(string AID, string name, string data, DateTime time)
        {
            string cmd = "UPDATE `dzmd`.`vitalrecord` SET `VitalTime` = '" + 
                time.ToString("yyyy-MM-dd HH:mm:ss") + "', `VitalDetail` = '" + 
                data + "' WHERE (`VitalSigns` = '" + name + "') and (`AnesthesiaID` = '" + 
                AID + "');";
            mycom.executeSQLCUD(cmd);
        }

        public void InsertVitalData(List<Series> datas, string AID, DateTime time)
        {
            foreach (Series series in datas)
            {
                string points = "";
                foreach (DataPoint p in datas[0].Points)
                {
                    points += "[" + p.YValues[0].ToString() + "] ";
                }
                try
                {
                    InsertNewSingleVitalData(AID, series.Name, points, time);
                }
                catch(Exception e)
                {
                    UpdataSingleVitalData(AID, series.Name, points, time);
                }
            }
            close();
        }

        public void close()
        {
            mycom.closeConnect();
        }
    }
}
