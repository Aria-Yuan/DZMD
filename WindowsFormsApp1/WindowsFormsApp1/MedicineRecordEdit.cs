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

namespace WindowsFormsApp1
{
    public partial class MedicineRecordEdit : Form
    {
        private Medicinedata m;
        private MainView mainView;

        public MedicineRecordEdit()
        {
            InitializeComponent();
        }

        public MedicineRecordEdit(Medicinedata m, MainView mainView, int flag)
        {
            InitializeComponent();
            this.mainView = mainView;
            this.m = m;
            this.setStop.Visible = false;
        }

        public MedicineRecordEdit(Medicinedata m, MainView mainView)
        {
            InitializeComponent();
            this.mainView = mainView;
            this.m = m;
        }

        private void editDose_Click(object sender, EventArgs e)
        {
            MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(m, mainView, 2);
            this.Close();
            medicineDataAddForm_InListView.ShowDialog();
        }

        private void setStop_Click(object sender, EventArgs e)
        {
            mainView.setStop();
            this.Close();
        }

        private void deleteDose_Click(object sender, EventArgs e)
        {
            mainView.deleteRecord();
            this.Close();
        }
    }
}
