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
    class PatientBasicRepository
    {
        sqlBase mycom;

        public PatientBasicRepository()
        {
            mycom = new sqlBase();
        }

        public List<PatientBasic> selectAll()
        {
            List<PatientBasic> list = new List<PatientBasic>();

            string cmd = "select * from patientbasicdata";
            MySqlDataReader sdr = mycom.executeSQLR(cmd);
            while(sdr.Read())
            {
                PatientBasic pb = new PatientBasic();
                pb.CharNo = sdr[0].ToString();
                pb.PId = sdr[1].ToString();
                pb.Name = sdr[2].ToString();
                pb.Height = float.Parse(sdr[3].ToString());
                pb.Weight = float.Parse(sdr[4].ToString());
                pb.BloodType = sdr[5].ToString();
                pb.BirthDate = (DateTime)sdr[6];
                list.Add(pb);
            }

            return list;
        }

        public List<PatientBasic> selectAllName()
        {
            List<PatientBasic> list = new List<PatientBasic>();

            string cmd = "select name from dzmd.patientbasicdata";
            MySqlDataReader sdr = mycom.executeSQLR(cmd);
            while (sdr.Read())
            {
                PatientBasic pb = new PatientBasic();
                pb.Name = sdr[0].ToString();
                list.Add(pb);
            }

            return list;
        }

        public void close()
        {
            mycom.closeConnect();
        }
    }
}
