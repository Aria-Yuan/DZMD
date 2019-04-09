using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class PatientBasic
    {
        //病例編號
        private string charNo;
        //身份證字號
        private string pId;
        //姓名
        private string name;
        //體重
        private double weight;
        //身高
        private double height;
        //血型
        private string bloodType;
        //生日
        private DateTime birthDate;
        //疾病史
        private string comment;

        public string CharNo { get => charNo; set => charNo = value; }
        public string PId { get => pId; set => pId = value; }
        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Height { get => height; set => height = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string BloodType { get => bloodType; set => bloodType = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}
