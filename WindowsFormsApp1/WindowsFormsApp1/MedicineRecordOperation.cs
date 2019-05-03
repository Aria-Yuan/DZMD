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
    public partial class MedicineRecordOperation : Form
    {
        MainView mainView;
        public MedicineRecordOperation()
        {
            InitializeComponent();
        }

        public MedicineRecordOperation(MainView m)
        {
            this.mainView = m;
            InitializeComponent();
        }

        private void stopInjection_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void addDose_Click(object sender, EventArgs e)
        {
            MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(mainView);
            this.Close();
            medicineDataAddForm_InListView.Show();
        }
    }
}
