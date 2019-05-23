using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class AnesthesiaMedicineRecord
    {
        //記錄編號
        private string id;
        //麻醉單編號
        private string anesthesiaID;
        //藥品編號
        private string medicineID;
        //麻醉方式(途徑) 0-非連續 1-連續
        private int anesthesiaType;
        //時間
        private DateTime time;
        //劑量數值
        private string actualAmount;
        //連續輸注流速
        private string flowRate;

        public string ID { get => id; set => id = value; }
        public string AnesthesiaID { get => anesthesiaID; set => anesthesiaID = value; }
        public string MedicineID { get => medicineID; set => medicineID = value; }
        public int AnesthesiaType { get => anesthesiaType; set => anesthesiaType = value; }
        public DateTime Time { get => time; set => time = value; }
        public string ActualAmount { get => actualAmount; set => actualAmount = value; }
        public string FlowRate { get => flowRate; set => flowRate = value; }
    }
}
