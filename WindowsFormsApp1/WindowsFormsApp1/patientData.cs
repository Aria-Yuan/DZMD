using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
    public partial class PatientData : Form
    {

        private List<PatientBasic> pbList;
        private List<string> names;

        public PatientData(Boolean back)
        {
            if (!back)
                GetData();

            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            names = StaticPatient.nameList;
            patientName.DataSource = names;
        }

        private void GetData()
        {
            PatientBasicRepository pbr = new PatientBasicRepository();
            pbList = pbr.selectAllIdAndName();
            foreach (PatientBasic pb in pbList)
            {
                StaticPatient.patientList.Add(pb.CharNo);
                StaticPatient.nameList.Add(pb.Name);
            }
        }

        private void goPatientDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientDetail().Show();
        }

        private void patientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            StaticPatient.patient.CharNo = StaticPatient.patientList[patientName.SelectedIndex];
        }
    }
}
