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
          
        
        }

        private void MedicineDataAddForm_InListView_Load(object sender, EventArgs e)
        {
            LoadData();
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
            this.mainView.addMedicine(medicineDataList[Mname.SelectedIndex]);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NMvalue.Text = medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[0];
            List<string> NMunitLst = new List<string>();
            NMunitLst.Add("ml");
            NMunitLst.Add("mg");
            NMunitLst.Add("uml");
            NMunitLst.Add("g");
            NMunit.DataSource = NMunitLst;
            NMunit.SelectedIndex = NMunit.FindStringExact(medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[1]);

            if(medicineDataList[Mname.SelectedIndex].Method == 1)
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

        /*
        private void continuous_CheckedChanged(object sender, EventArgs e)
        {
            NMunit.Visible = !NMunit.Visible;
            NMvalue.Visible = !NMvalue.Visible;
            dose.Visible = !dose.Visible;
            doseUnit.Visible = !doseUnit.Visible;

            MCunit.Visible = !MCunit.Visible;
            MCvalue.Visible = !MCvalue.Visible;
            MRunit.Visible = !MRunit.Visible;
            MRvalue.Visible = !MRvalue.Visible;
            concentration.Visible = !concentration.Visible;
            concentrationUnit.Visible = !concentrationUnit.Visible;
            flowRate.Visible = !flowRate.Visible;
            flowRateUnit.Visible = !flowRateUnit.Visible;
        }*/
    }
}
