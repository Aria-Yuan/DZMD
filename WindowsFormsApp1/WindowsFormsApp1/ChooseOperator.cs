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
using WindowsFormsApp.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
    public partial class ChooseOperator : Form
    {
        List<AnesthesiaData> ad = StaticPatient.operateList;

        public ChooseOperator()
        {
            InitializeComponent();
            LoadData();
        }

        //查找相應的手術，加載第一次的數據
        private void LoadData()
        {
            List<string> lst = new List<string>();
            foreach (AnesthesiaData ad in ad)
                lst.Add(ad.AnesthesiaID.ToString());
            list.DataSource = lst;

            if (ad[0].OperationDate != null)
                date.Text = ad[0].OperationDate.ToString("yyyy-MM-dd");
            name.Text = StaticPatient.patient.Name;
            dname.Text = ad[0].Surgeon;
            sname.Text = ad[0].SugeryName;
            room.Text = ad[0].OperatingRoom;
            StaticPatient.AnesthesiaID = ad[0].AnesthesiaID;
        }

        //開始手術 會記錄時間
        private void Start_Click(object sender, EventArgs e)
        {
            AnesthesiaDataRepository apr = new AnesthesiaDataRepository();
            apr.SetOperationStartTime(StaticPatient.AnesthesiaID);
            new MainView().Show();
            //StaticPatient.main.StartMain();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new PatientDetail().Show();
            this.Close();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            date.Text = ad[list.SelectedIndex].OperationDate.ToString("yyyy-MM-dd");
            dname.Text = ad[list.SelectedIndex].Surgeon;
            sname.Text = ad[list.SelectedIndex].SugeryName;
            room.Text = ad[list.SelectedIndex].OperatingRoom;
            StaticPatient.AnesthesiaID = ad[list.SelectedIndex].AnesthesiaID;
        }

    }
}
