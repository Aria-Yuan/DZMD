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
            comboBox1.DataSource = nameList;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.mainView.createViewList_ButtonOnClick(comboBox1.Text);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = medicineDataList[comboBox1.SelectedIndex].Unit;
        }
    }
}
