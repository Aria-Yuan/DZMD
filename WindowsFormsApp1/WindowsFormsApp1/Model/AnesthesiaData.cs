using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Model
{
    public class AnesthesiaData
    {
        //麻醉單編號
        private string anesthesiaID ;
        //病歷編號
        private string chartNo ;
        //手術排定日期 
        private DateTime operationDate ;
        //手術診斷
        private string sugeryDiagnosis ;
        //手術名稱
        private string sugeryName ;
        //手術醫師
        private string surgeon ;
        //手術房編號 
        private string operatingRoom ;
        //急診刀 
        private Boolean emergencyoperation ;
        //手術準備時間
        private DateTime thepreparingofsurgery ;
        //手術開始時間 
        private DateTime thebeginningofsurgery ;
        //手術劃刀時間
        private DateTime excisionTime ;
        //手術結束時間
        private DateTime theendofsurgery ;
        //病患進入手術室時間 
        private DateTime intotheOperatingRoom ;
        //病患離開手術室時間
        private DateTime submitOperatingRoom ;
        //麻醉準備時間
        private DateTime anesthesiapretime ;
        //麻醉誘導開始時間
        private DateTime anesthesiaindstarttime ;
        //麻醉誘導結束時間
        private DateTime anesthesiaindendtime ;
        //麻醉結束時間
        private DateTime anesthesiaendtime ;
        //麻醉相關管路
        private string anesthesialine ;
        //麻醉醫師 array (醫師名稱-開始時間-結束時間)
        private string anesthesiadoctor ;
        //麻醉護理師 array (護理師名稱-開始時間-結束時間)
        private string anesthesianurse ;
        //麻醉風險等級 ASA str
        private string anesthesiaRISKLEVEL ;
        //術前檢驗值 array (檢驗名稱-數值-單位-時間)
        private string testValueBefore ;
        //術前收縮壓 int
        private int sBPBefore ;
        //術前舒張壓 int
        private int dBPBefore;
        //術前平均壓 int
        private int mAPBefore;
        //術前血氧 int
        private int bOLDBefore;
        //術前脈搏 int
        private int pluseBefore;
        //術前意識狀態 str
        private string consciousnessBefore;
        //術後收縮壓 int 
        private int sBPAfter;
        //術後舒張壓 
        private int dBPAfter;
        //術後平均壓 int
        private int mAPAfter;
        //術後血氧 int
        private int bOLDAfter;
        //術後脈搏 int
        private int pluseAfter;
        //術後意識狀態 str
        private string consciousnessAfter;

        public string AnesthesiaID { get => anesthesiaID; set => anesthesiaID = value; }
        public string ChartNo { get => chartNo; set => chartNo = value; }
        public DateTime OperationDate { get => operationDate; set => operationDate = value; }
        public string SugeryDiagnosis { get => sugeryDiagnosis; set => sugeryDiagnosis = value; }
        public string SugeryName { get => sugeryName; set => sugeryName = value; }
        public string Surgeon { get => surgeon; set => surgeon = value; }
        public string OperatingRoom { get => operatingRoom; set => operatingRoom = value; }
        public bool Emergencyoperation { get => emergencyoperation; set => emergencyoperation = value; }
        public DateTime Thepreparingofsurgery { get => thepreparingofsurgery; set => thepreparingofsurgery = value; }
        public DateTime Thebeginningofsurgery { get => thebeginningofsurgery; set => thebeginningofsurgery = value; }
        public DateTime ExcisionTime { get => excisionTime; set => excisionTime = value; }
        public DateTime Theendofsurgery { get => theendofsurgery; set => theendofsurgery = value; }
        public DateTime IntotheOperatingRoom { get => intotheOperatingRoom; set => intotheOperatingRoom = value; }
        public DateTime SubmitOperatingRoom { get => submitOperatingRoom; set => submitOperatingRoom = value; }
        public DateTime Anesthesiapretime { get => anesthesiapretime; set => anesthesiapretime = value; }
        public DateTime Anesthesiaindstarttime { get => anesthesiaindstarttime; set => anesthesiaindstarttime = value; }
        public DateTime Anesthesiaindendtime { get => anesthesiaindendtime; set => anesthesiaindendtime = value; }
        public DateTime Anesthesiaendtime { get => anesthesiaendtime; set => anesthesiaendtime = value; }
        public string Anesthesialine { get => anesthesialine; set => anesthesialine = value; }
        public string Anesthesiadoctor { get => anesthesiadoctor; set => anesthesiadoctor = value; }
        public string Anesthesianurse { get => anesthesianurse; set => anesthesianurse = value; }
        public string AnesthesiaRISKLEVEL { get => anesthesiaRISKLEVEL; set => anesthesiaRISKLEVEL = value; }
        public string TestValueBefore { get => testValueBefore; set => testValueBefore = value; }
        public int SBPBefore { get => sBPBefore; set => sBPBefore = value; }
        public int DBPBefore { get => dBPBefore; set => dBPBefore = value; }
        public int MAPBefore { get => mAPBefore; set => mAPBefore = value; }
        public int BOLDBefore { get => bOLDBefore; set => bOLDBefore = value; }
        public int PluseBefore { get => pluseBefore; set => pluseBefore = value; }
        public string ConsciousnessBefore { get => consciousnessBefore; set => consciousnessBefore = value; }
        public int SBPAfter { get => sBPAfter; set => sBPAfter = value; }
        public int DBPAfter { get => dBPAfter; set => dBPAfter = value; }
        public int MAPAfter { get => mAPAfter; set => mAPAfter = value; }
        public int BOLDAfter { get => bOLDAfter; set => bOLDAfter = value; }
        public int PluseAfter { get => pluseAfter; set => pluseAfter = value; }
        public string ConsciousnessAfter { get => consciousnessAfter; set => consciousnessAfter = value; }
    }
}
