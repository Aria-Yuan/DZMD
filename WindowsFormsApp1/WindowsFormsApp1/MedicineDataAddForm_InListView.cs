using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;
namespace WindowsFormsApp1
{
    public partial class MedicineDataAddForm_InListView : Form
    {
        private MedicineDataRepository medicineDataRepository = new MedicineDataRepository();
        private AnesthesiaMedicineRecord medicineRecord = new AnesthesiaMedicineRecord();
        private List<Medicinedata> medicineDataList;
        private static Medicinedata choseMedicineData;
        private MainView mainView;

        public MedicineDataAddForm_InListView()
        {
            InitializeComponent();
        }

        public MedicineDataAddForm_InListView(MainView mainView)
        {
            this.mainView = mainView;
            InitializeComponent();
            LoadData();

        }

        public MedicineDataAddForm_InListView(string MName, MainView mainView)
        {
            this.mainView = mainView;
            InitializeComponent();
            LoadData();
            Mname.SelectedIndex = Mname.FindStringExact(MName);
            Mname.Enabled = false;

        }

        private void LoadData()
        {
            medicineDataList = medicineDataRepository.selectAll();
            List<string> nameList = new List<string>();
            foreach (Medicinedata md in medicineDataList)
                nameList.Add(md.MName);
            Mname.DataSource = nameList;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            medicineRecord.MedicineID = medicineDataList[Mname.SelectedIndex].MId;
            medicineRecord.AnesthesiaType = medicineDataList[Mname.SelectedIndex].Method;
            if (medicineDataList[Mname.SelectedIndex].Method == 0)
            {
                medicineRecord.ActualAmount = NMvalue.Text + " " + NMunit.Text;
                
            }
            else
            {
                medicineRecord.ActualAmount = MCvalue.Text + " " + MCunit.Text;
                medicineRecord.FlowRate = MRvalue.Text + " " + MRunit.Text;
            }

            this.mainView.addMedicine(medicineRecord);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NMvalue.Text = medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[0];
            MCvalue.Text = medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[0];
            List<string> NMunitLst = new List<string>();
            NMunitLst.Add("ml");
            NMunitLst.Add("mg");
            NMunitLst.Add("uml");
            NMunitLst.Add("g");
            NMunit.DataSource = NMunitLst;
            NMunit.SelectedIndex = NMunit.FindStringExact(medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[1]);
            MCunit.DataSource = NMunitLst;
            MCunit.SelectedIndex = NMunit.FindStringExact(medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[1]);


            if (medicineDataList[Mname.SelectedIndex].Method == 1)
                changeLables(false);
            else
                changeLables(true);
        }

        public void changeLables(Boolean b)
        {
            NMunit.Visible = b;
            NMvalue.Visible = b;
            dose.Visible = b;
            doseUnit.Visible = b;

            MCunit.Visible = !b;
            MCvalue.Visible = !b;
            MRunit.Visible = !b;
            MRvalue.Visible = !b;
            concentration.Visible = !b;
            concentrationUnit.Visible = !b;
            flowRate.Visible = !b;
            flowRateUnit.Visible = !b;
        }
        
    }
}
