using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class AnesthesiaMedicineRecord
    {
        //麻醉單編號
        private string anesthesiaID;
        //藥品編號
        private string medicineID;
        //麻醉方式(途徑)
        private string anesthesiaType;
        //時間
        private DateTime time;
        //劑量數值
        private double ActualAmount;

        public string AnesthesiaID { get => anesthesiaID; set => anesthesiaID = value; }
        public string MedicineID { get => medicineID; set => medicineID = value; }
        public string AnesthesiaType { get => anesthesiaType; set => anesthesiaType = value; }
        public DateTime Time { get => time; set => time = value; }
        public double ActualAmount1 { get => ActualAmount; set => ActualAmount = value; }
    }
}
