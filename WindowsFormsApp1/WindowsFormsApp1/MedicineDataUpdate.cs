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
    public partial class MedicineDataUpdate : Form
    {
        public MedicineDataUpdate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public MedicineDataUpdate(User data)
        {
            InitializeComponent();

            textBox1.Text = data.Code;
            textBox2.Text = data.Name;
            textBox3.Text = data.Pwd;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicinedata u = new Medicinedata();
            u.MId = textBox1.Text;
            u.MName = textBox2.Text;
            u.Unit = textBox3.Text;

            new MedicineDataRepository().update(u);
            this.Close();
        }
    }
}
