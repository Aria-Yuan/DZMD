using System;
using System.IO;
using System.Timers;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp.Model;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1 
{
    public static class StaticPatient
    {
        private static string filePath = @"../.././TempData/";
        public static PatientBasic patient = new PatientBasic();
        public static String newComment;
        public static String AnesthesiaID = "";
        public static List<AnesthesiaData> operateList;
        public static List<string> patientList = new List<string>();
        public static List<string> nameList = new List<string>();
        public static AnesthesiaData anesthesiaData = new AnesthesiaData();
        public static List<Series> vitalSigns;
        private static System.Timers.Timer timer = new System.Timers.Timer(10000);

        public static void SaveTempData()
        {
            try
            {
                FileStream F = new FileStream(filePath + patient.PId + "-" + AnesthesiaID, 
                    FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                F.Close();
                StreamWriter tempFile = new StreamWriter(filePath + patient.PId + "-" + AnesthesiaID);
                tempFile.WriteLine("patientID:" + patient.PId);
                tempFile.WriteLine("AnesthesiaID:" + AnesthesiaID);
                tempFile.WriteLine("newComment:" + newComment);
                tempFile.WriteLine("StartTime:" + anesthesiaData.Thebeginningofsurgery);
                tempFile.WriteLine("TimePeriod:" + "5000");
                tempFile.WriteLine("SaveTime:" + DateTime.Now.ToLongTimeString());
                tempFile.WriteLine("Series:");
                foreach (Series series in vitalSigns)
                {
                    string points = "";
                    foreach(DataPoint p in vitalSigns[0].Points)
                    {
                        points += "{" + p.YValues[0].ToString()+ "} ";
                    }
                    tempFile.WriteLine(series.Name + ":" + points);
                }

                tempFile.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("暂存有错误!");
            }
        }

        public static void SaveToDataBase()
        {
            //暂存文件
            SaveTempData();
            //病人资料保存
            SavePatientData();
            //手术资料保存
            SaveOperationData();
        }

        //保存手术部分的资料
        private static void SaveOperationData()
        {
            new AnesthesiaDataRepository().SetOperationEndTime(StaticPatient.AnesthesiaID);
            new VitalRecordRepository().InsertVitalData(vitalSigns, AnesthesiaID, anesthesiaData.Thebeginningofsurgery);
        }

        //保存病人部分的资料
        private static void SavePatientData()
        {
            StaticPatient.patient.Comment = StaticPatient.patient.Comment + "\n"
                + DateTime.Now.ToString("yyyy-MM-dd") + ":\n"
                + StaticPatient.newComment;
            StaticPatient.newComment = "";
            new PatientBasicRepository().saveOnePatient(StaticPatient.patient);
        }

        //传入Series资料
        public static void SaveSeriesData(List<Series> series)
        {
            vitalSigns = series;
        }

        //启动定时保存，每分钟保存一次到tempfile
        public static void TimerStart()
        {
            timer.Start();
            timer.Elapsed += Timer_Elapsed; 
        }

        //timer事件：自动保存->暂存+资料库储存
        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            SaveTempData();
            SaveOperationData();
        }
    }
}
