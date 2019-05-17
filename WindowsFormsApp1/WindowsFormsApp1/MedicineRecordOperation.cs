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
    public partial class MedicineRecordOperation : Form
    {
        private int selectedIndex;
        private int flag = 0;
        private Medicinedata m;
        private MainView mainView;

        public MedicineRecordOperation()
        {
            InitializeComponent();
        }

        public MedicineRecordOperation(int index, Medicinedata m, MainView mainView, int type)
        {
            this.mainView = mainView;
            this.m = m;
            selectedIndex = index;
            InitializeComponent();

            //不能停止注射的情况
            if(type == 0)
            {
                stopInjection.Visible = false;
                continueInjection.Visible = true;
                flag = 0;
                addDose.Text = "添加藥物";
            }
            //正在注射的连续形药物
            else if(type == 1)
            {
                stopInjection.Visible = true;
                continueInjection.Visible = false;
                flag = 1;
                addDose.Text = "設定当前濃度/流速";
            }
            //非连续型药物
            else if(type == 2)
            {
                stopInjection.Visible = true;
                stopInjection.Enabled = false;
                continueInjection.Visible = false;
                addDose.Text = "添加劑量";
            }
        }

        private void stopInjection_Click(object sender, EventArgs e)
        {
            mainView.continuousMStop(selectedIndex);
            this.Close();
        }

        private void addDose_Click(object sender, EventArgs e)
        {
            MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(m,mainView,flag);
            this.Close();
            medicineDataAddForm_InListView.ShowDialog();
        }
    }
}
