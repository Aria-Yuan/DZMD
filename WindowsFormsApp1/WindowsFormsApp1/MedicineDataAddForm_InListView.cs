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
        private MainView mainView;
        private int flag = 0;

        public MedicineDataAddForm_InListView()
        {
            InitializeComponent();
        }

        public MedicineDataAddForm_InListView(AnesthesiaMedicineRecord m, MainView mainView)
        {
            this.mainView = mainView;
            InitializeComponent();
            this.medicineRecord = m;
            LoadData();
        }

        public MedicineDataAddForm_InListView(AnesthesiaMedicineRecord m, MainView mainView, int flag)
        {
            this.mainView = mainView;
            this.flag = flag;
            this.medicineRecord = m;
            InitializeComponent();
            LoadData();
            Console.WriteLine("HJK" + m.MedicineID);
            Mname.SelectedIndex = Mname.FindStringExact(medicineDataRepository.selectById(m.MedicineID).MName);
            Mname.Enabled = false;

            NMvalue.Text = m.ActualAmount.Split(' ')[0];
            MCvalue.Text = m.ActualAmount.Split(' ')[0];
            MRvalue.Text = m.FlowRate.Split(' ')[0];

            NMunit.SelectedIndex = NMunit.FindStringExact(medicineRecord.ActualAmount.Split(' ')[1]);
            MCunit.SelectedIndex = NMunit.FindStringExact(medicineRecord.ActualAmount.Split(' ')[1]);
            MRunit.SelectedIndex = NMunit.FindStringExact(medicineRecord.ActualAmount.Split(' ')[1]);

        }

        private void LoadData()
        {
            medicineDataList = medicineDataRepository.selectAll();
            List<string> nameList = new List<string>();
            foreach (Medicinedata md in medicineDataList)
                nameList.Add(md.MName);
            Mname.DataSource = nameList;

            List<string> NMunitLst = new List<string>();
            NMunitLst.Add("ml");
            NMunitLst.Add("mg");
            NMunitLst.Add("uml");
            NMunitLst.Add("g");
            NMunit.DataSource = NMunitLst;
            MCunit.DataSource = NMunitLst;
            MRunit.DataSource = NMunitLst;

            DateTimeChoser.AddTo(startTimeTextBox);
            DateTimeChoser.AddTo(endTimeTextBox, "請選擇");
            /*
            DateTime dt = StaticPatient.anesthesiaData.Thebeginningofsurgery;
            
            for (int i = -(int)(medicineRecord.StartTime - dt).TotalSeconds / 5; i <= 
                -(int)(medicineRecord.StartTime - DateTime.Now).TotalSeconds / 5; i++)
                StartDomainUpDown.Items.Add(medicineRecord.StartTime.AddSeconds(5 * i).ToString("yyyy-MM-dd HH:mm:ss"));
             
            StartDomainUpDown.SelectedIndex = (int)(medicineRecord.StartTime - dt).TotalSeconds / 5;

            for (int i = -StartDomainUpDown.SelectedIndex; i <= -(int)(medicineRecord.StartTime - DateTime.Now).TotalSeconds / 5; i++)
                endDomainUpDown.Items.Add(medicineRecord.StartTime.AddSeconds(5 * i).ToString("yyyy-MM-dd HH:mm:ss"));
                */
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

            /*
            medicineRecord.StartTime = DateTime.Parse(StartDomainUpDown.SelectedItem.ToString()).AddSeconds
                ((medicineRecord.StartTime - DateTime.Parse(StartDomainUpDown.SelectedItem.ToString())).TotalSeconds % 5);
                */

            medicineRecord.StartTime = DateTime.Parse(startTimeTextBox.Text).AddSeconds
                ((medicineRecord.StartTime - DateTime.Parse(startTimeTextBox.Text)).TotalSeconds % 5);
            try
            {
                medicineRecord.EndTime = DateTime.Parse(endTimeTextBox.Text).AddSeconds
                ((DateTime.Parse(endTimeTextBox.Text) - DateTime.Parse(startTimeTextBox.Text)).TotalSeconds % 5);
            }
            catch (Exception)
            {
                medicineRecord.EndTime = new DateTime(1997,8,1,0,0,0);
            }

            if (flag == 0)
                this.mainView.addMedicine(medicineRecord);
            else if(flag == 1)
                this.mainView.modifyFlowRate(medicineRecord);
            else
                this.mainView.modifyMedicine(medicineRecord);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mname.Enabled)
            {
                NMvalue.Text = medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[0];
                MCvalue.Text = medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[0];
                MRvalue.Text = medicineDataList[Mname.SelectedIndex].FlowRate.Split(' ')[0];

                NMunit.SelectedIndex = NMunit.FindStringExact(medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[1]);
                MCunit.SelectedIndex = NMunit.FindStringExact(medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[1]);
                MRunit.SelectedIndex = NMunit.FindStringExact(medicineDataList[Mname.SelectedIndex].Unit.Split(' ')[1]);
            }

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
            endDomainUpDown.Visible = !b;
            endTimeLabel.Visible = !b;
            endTimeTextBox.Visible = !b;
        }

        private void StartDomainUpDown_TextChanged(object sender, EventArgs e)
        {
            DateTime dt = StaticPatient.anesthesiaData.Thebeginningofsurgery;
            try
            {
                StartDomainUpDown.SelectedIndex = (int)(DateTime.Parse(StartDomainUpDown.Text) - dt).TotalSeconds / 5;
            }
            catch (Exception)
            {
                StartDomainUpDown.SelectedIndex = (int)(medicineRecord.StartTime - dt).TotalSeconds / 5;
            }

            endDomainUpDown.Items.Clear();
            for (int i = -StartDomainUpDown.SelectedIndex; i <= -(int)(medicineRecord.StartTime - DateTime.Now).TotalSeconds / 5; i++)
                endDomainUpDown.Items.Add(medicineRecord.StartTime.AddSeconds(5 * i).ToString("yyyy-MM-dd HH:mm:ss"));
        }
        
    }
}
