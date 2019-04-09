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
    public partial class MedicineDataAdd : Form
    {
        public MedicineDataAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicinedata newOne = new Medicinedata();
            newOne.MId = textBox1.Text;
            newOne.MName = textBox2.Text;
            newOne.Unit = textBox3.Text;

            new MedicineDataRepository().addData(newOne);
            //this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MedicineDataAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
