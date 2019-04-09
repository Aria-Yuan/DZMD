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
    public partial class patientData : Form
    {

        private PatientBasicRepository patientBasicRepository = new PatientBasicRepository();
        private List<PatientBasic> pbList;
        private static PatientBasic chosenPatient;

        public static PatientBasic ChosenPatient { get => chosenPatient;}

        public patientData()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            pbList = patientBasicRepository.selectAll();
            List<string> nameList = new List<string>();
            foreach (PatientBasic pb in pbList)
                nameList.Add(pb.Name);
            patientName.DataSource = nameList;
        }

        private void goPatientDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientDetail detail = new patientDetail();
            detail.Owner = this;
            detail.Show();
        }

        private void patientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenPatient = pbList[patientName.SelectedIndex];
        }
    }
}
