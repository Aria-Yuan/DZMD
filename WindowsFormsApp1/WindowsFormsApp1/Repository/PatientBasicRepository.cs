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
                pb.Comment = sdr[7].ToString();
                list.Add(pb);
            }

            close();
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

        public Boolean saveOnePatient(PatientBasic patient)
        {

            string cmd = "UPDATE patientbasicdata SET";
            cmd += " Name='" + patient.Name + "'";
            cmd += " ,BodyWeight=" + patient.Weight;
            cmd += " ,BodyHeight=" + patient.Height;
            cmd += " ,BloodType='" + patient.BloodType + "'";
            cmd += " ,BirthDate='" + patient.BirthDate.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            cmd += " ,MedicalHistory='" + patient.Comment + "'";

            cmd += " WHERE ChartNo='" + patient.CharNo + "'";
            cmd += " and PersonalIDNumber='" + patient.PId + "'";

            //Console.Write(cmd);
            MySqlDataReader sdr = mycom.executeSQLR(cmd);

            close();
            return true;

        }

        public void close()
        {
            mycom.closeConnect();
        }
    }
}
