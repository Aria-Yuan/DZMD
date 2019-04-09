using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class VitalRecord
    {
        //麻醉單編號
        private string anesthesiaID;
        //類別
        private string vitalSign;
        //時間
        private DateTime vitalTime;
        //讀取內容
        private string vitalDetail;

        public string AnesthesiaID { get => anesthesiaID; set => anesthesiaID = value; }
        public string VitalSign { get => vitalSign; set => vitalSign = value; }
        public DateTime VitalTime { get => vitalTime; set => vitalTime = value; }
        public string VitalDetail { get => vitalDetail; set => vitalDetail = value; }
    }
}
