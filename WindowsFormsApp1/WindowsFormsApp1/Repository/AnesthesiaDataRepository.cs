using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Model;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Repository
{
    class AnesthesiaDataRepository
    {
        sqlBase mycom;

        public AnesthesiaDataRepository()
        {
            mycom = new sqlBase();
        }

        public List<AnesthesiaData> SelectByChartNo(string name)
        {
            List<AnesthesiaData> list = new List<AnesthesiaData>();
            string cmd = "SELECT * FROM dzmd.anesthesiadata WHERE ChartNo = '"
                + name + "'";

            MySqlDataReader sdr = mycom.executeSQLR(cmd);
            while (sdr.Read())
                list.Add(Read(sdr));

            close();

            return list;
        }

        public AnesthesiaData SelectByAnesthesiaID(string id)
        {
            List<AnesthesiaData> list = new List<AnesthesiaData>();
            string cmd = "SELECT * FROM dzmd.anesthesiadata WHERE AnesthesiaID = '"
                + id + "'";

            MySqlDataReader sdr = mycom.executeSQLR(cmd);
            while (sdr.Read())
                list.Add(Read(sdr));

            close();

            return list[0];
        }

        public void SetOperationStartTime(string id)
        {
            string cmd = "UPDATE anesthesiadata SET Thebeginningofsurgery = '"
                + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                + "' WHERE AnesthesiaID = '"
                + id + "'";
            MySqlDataReader sdr = mycom.executeSQLR(cmd);
            close();
        }
        public void SetOperationEndTime(string id)
        {
            string cmd = "UPDATE anesthesiadata SET Theendofsurgery = '"
                + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                + "' WHERE AnesthesiaID = '"
                + id + "'";
            MySqlDataReader sdr = mycom.executeSQLR(cmd);
            close();
        }

        private AnesthesiaData Read(MySqlDataReader sdr)
        {
            AnesthesiaData ad = new AnesthesiaData();
            
            ad.AnesthesiaID = sdr[0].ToString();
            ad.ChartNo = sdr[1].ToString();
            if (sdr[2].ToString() != "")
                ad.OperationDate = (DateTime)sdr[2];
            ad.SugeryDiagnosis = sdr[3].ToString();
            ad.SugeryName = sdr[4].ToString();
            ad.Surgeon = sdr[5].ToString();
            ad.OperatingRoom = sdr[6].ToString();
            ad.Emergencyoperation = sdr[7].ToString() == null ? false : true;
            if (sdr[8].ToString() != "")
                ad.Thepreparingofsurgery = (DateTime)sdr[8];
            if (sdr[9].ToString() != "")
                ad.Thebeginningofsurgery = (DateTime)sdr[9];
            if (sdr[10].ToString() != "")
                ad.ExcisionTime = (DateTime)sdr[10];
            if (sdr[11].ToString() != "")
                ad.Theendofsurgery = (DateTime)sdr[11];
            if (sdr[12].ToString() != "")
                ad.IntotheOperatingRoom = (DateTime)sdr[12];
            if (sdr[13].ToString() != "")
                ad.SubmitOperatingRoom = (DateTime)sdr[13];
            if (sdr[14].ToString() != "")
                ad.Anesthesiapretime = (DateTime)sdr[14];
            if (sdr[15].ToString() != "")
                ad.Anesthesiaindstarttime = (DateTime)sdr[15];
            if (sdr[16].ToString() != "")
                ad.Anesthesiaindendtime = (DateTime)sdr[16];
            if (sdr[17].ToString() != "")
                ad.Anesthesiaendtime = (DateTime)sdr[17];
            ad.Anesthesialine = sdr[18].ToString();
            ad.Anesthesiadoctor = sdr[19].ToString();
            ad.Anesthesianurse = sdr[20].ToString();
            ad.AnesthesiaRISKLEVEL = sdr[21].ToString();
            ad.TestValueBefore = sdr[22].ToString();
            if (sdr[23].ToString() != "")
                ad.SBPBefore = Int32.Parse(sdr[23].ToString());
            if (sdr[24].ToString() != "")
                ad.DBPBefore = Int32.Parse(sdr[24].ToString());
            if (sdr[25].ToString() != "")
                ad.MAPBefore = Int32.Parse(sdr[25].ToString());
            if (sdr[26].ToString() != "")
                ad.BOLDBefore = Int32.Parse(sdr[26].ToString());
            if (sdr[27].ToString() != "")
                ad.PluseBefore = Int32.Parse(sdr[27].ToString());
            ad.ConsciousnessBefore = sdr[28].ToString();
            if (sdr[29].ToString() != "")
                ad.SBPAfter = Int32.Parse(sdr[29].ToString());
            if (sdr[30].ToString() != "")
                ad.DBPAfter = Int32.Parse(sdr[30].ToString());
            if (sdr[31].ToString() != "")
                ad.MAPAfter = Int32.Parse(sdr[31].ToString());
            if (sdr[32].ToString() != "")
                ad.BOLDAfter = Int32.Parse(sdr[32].ToString());
            if (sdr[33].ToString() != "")
                ad.PluseAfter = Int32.Parse(sdr[33].ToString());
            ad.ConsciousnessAfter = sdr[34].ToString();
            return ad;
        }

        public void close()
        {
            mycom.closeConnect();
        }

    }
}
