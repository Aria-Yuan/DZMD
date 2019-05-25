using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repository;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class MedicineRecordEdit : Form
    {
        private AnesthesiaMedicineRecord m;
        private MedicineDataRepository medicineDataRepository = new MedicineDataRepository();
        private MainView mainView;

        public MedicineRecordEdit()
        {
            InitializeComponent();
        }

        public MedicineRecordEdit(AnesthesiaMedicineRecord m, MainView mainView, int flag)
        {
            InitializeComponent();
            this.mainView = mainView;
            this.m = m;
            this.setStop.Visible = false;
            initInfoPanel();
        }

        public MedicineRecordEdit(AnesthesiaMedicineRecord m, MainView mainView)
        {
            InitializeComponent();
            this.mainView = mainView;
            this.m = m;
            initInfoPanel();
        }

        private void initInfoPanel()
        {
            if(m.AnesthesiaType == 0)
            {
                this.continousMedicinePanel.Visible = false;
                this.medicinePanel.Visible = true;
                this.endTimeValue.Visible = false;
                this.endTimeLabel.Visible = false;
                
                this.amountValue.Text = m.ActualAmount;
                this.sartTimeValue.Text = m.StartTime.ToString("yyyy-MM-dd HH:mm:ss");
                this.medicineNameVale.Text = medicineDataRepository.selectById(m.MedicineID).MName;

            }
            else
            {
                this.medicinePanel.Visible = false;
                this.continousMedicinePanel.Visible = true;
                this.endTimeValue.Visible = true;
                this.endTimeLabel.Visible = true;

                this.concentrationValue.Text = m.ActualAmount;
                this.flowRateValue.Text = m.FlowRate;
                this.sartTimeValue.Text = m.StartTime.ToString("yyyy-MM-dd HH:mm:ss");
                if (m.EndTime.ToString("yyyy-MM-dd HH:mm:ss").Equals("0001-01-01 00:00:00"))
                    this.endTimeValue.Text = "未結束";
                else
                    this.endTimeValue.Text = m.EndTime.ToString("yyyy-MM-dd HH:mm:ss");
                this.nameValue.Text = medicineDataRepository.selectById(m.MedicineID).MName;
            }
        }

        private void editDose_Click(object sender, EventArgs e)
        {
            MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(m, mainView, 2);
            this.Close();
            medicineDataAddForm_InListView.ShowDialog();
        }

        private void setStop_Click(object sender, EventArgs e)
        {
            mainView.setStop(m);
            this.Close();
        }

        private void deleteDose_Click(object sender, EventArgs e)
        {
            mainView.deleteRecord();
            this.Close();
        }
        
    }
}
