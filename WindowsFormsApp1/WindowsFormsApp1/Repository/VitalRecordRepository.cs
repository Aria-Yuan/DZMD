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

        public void InsertNewData(List<Series> datas, string AID, DateTime time)
        {
            foreach (Series series in datas)
            {
                string points = "";
                foreach (DataPoint p in datas[0].Points)
                {
                    points += "[" + p.YValues[0].ToString() + "] ";
                }
                string cmd = "INSERT INTO `dzmd`.`vitalrecord` (`AnesthesiaID`, " +
                    "`VitalSigns`, `VitalTime`, `VitalDetail`) VALUES ('" +
                    AID + "', '" + series.Name + "', '" + time.ToString("yyyy-MM-dd HH:mm:ss") +
                    "', '" + points + "');";
                Debug.WriteLine(cmd);
                mycom.executeSQLCUD(cmd);
            }
            close();
        }

        public void close()
        {
            mycom.closeConnect();
        }
    }
}
