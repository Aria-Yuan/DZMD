using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Model;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1 
{
    class StaticPatient
    {

        public static PatientBasic patient = new PatientBasic();
        public static String newComment;
        public static String AnesthesiaID = "";
        public static List<AnesthesiaData> operateList;
        public static List<string> patientList = new List<string>();
        public static List<string> nameList = new List<string>();
        public static AnesthesiaData anesthesiaData = new AnesthesiaData();
        //public static MainView main;

    }
}
