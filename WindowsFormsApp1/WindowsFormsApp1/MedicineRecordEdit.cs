using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MedicineRecordEdit : Form
    {
        private string MName;
        private MainView mainView;

        public MedicineRecordEdit()
        {
            InitializeComponent();
        }

        public MedicineRecordEdit(string MName, MainView mainView, int flag)
        {
            InitializeComponent();
            this.mainView = mainView;
            this.MName = MName;
            this.setStop.Visible = false;
        }

        public MedicineRecordEdit(string MName, MainView mainView)
        {
            InitializeComponent();
            this.mainView = mainView;
            this.MName = MName;
        }

        private void editDose_Click(object sender, EventArgs e)
        {
            MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(MName, mainView);
            this.Close();
            medicineDataAddForm_InListView.Show();
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
