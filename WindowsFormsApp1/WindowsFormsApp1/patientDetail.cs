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
    public partial class patientDetail : Form
    {

        private PatientBasic patient;

        public patientDetail()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            patient = patientData.ChosenPatient;

            chartNo.Text = patient.CharNo;
            name.Text = patient.Name;
            patientId.Text = patient.PId;
            weight.Text = patient.Weight.ToString();
            height.Text = patient.Height.ToString();
            blood.Text = patient.BloodType;
            history.Text = patient.Comment;
            birthday.Text = patient.BirthDate.ToString();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            new MainView().Show();
            this.Close();
        }
    }
}
