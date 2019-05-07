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
        private int selectedIndex;
        private string MName;
        private MainView mainView;

        public MedicineRecordOperation()
        {
            InitializeComponent();
        }

        public MedicineRecordOperation(int index, string MName, MainView mainView)
        {
            this.mainView = mainView;
            this.MName = MName;
            selectedIndex = index;
            InitializeComponent();
        }

        private void stopInjection_Click(object sender, EventArgs e)
        {
            mainView.continuousMStop(selectedIndex);
            this.Close();
        }

        private void addDose_Click(object sender, EventArgs e)
        {
            MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(MName,mainView);
            this.Close();
            medicineDataAddForm_InListView.ShowDialog();
        }
    }
}
