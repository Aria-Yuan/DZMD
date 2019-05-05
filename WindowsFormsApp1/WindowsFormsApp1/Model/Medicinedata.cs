using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Medicinedata
    {
        //藥劑編號
        private string mId;
        //藥品名稱
        private string mName;
        //劑量單位
        private string unit;
        //注射方式
        private int method;

        public string MId { get => mId; set => mId = value; }
        public string MName { get => mName; set => mName = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Method { get => method; set => method = value; }
    }
}
