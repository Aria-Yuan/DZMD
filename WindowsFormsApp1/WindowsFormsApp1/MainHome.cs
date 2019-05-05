using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
    public partial class MainHome : Form
    {
        public MainHome()
        {
            InitializeComponent();
            MedicineDataRepository sb = new MedicineDataRepository();
            bindListCiew(sb.selectAll());

            listView1.Columns.Clear();
            listView1.ColumnHeadersVisible = false;
            listView1.Columns.Add("sss", "name");
            listView1.Columns.Add("sss", "name");
            listView1.Columns.Add("sss", "name");
            listView1.Columns.Add("sss", "name");

            listView1.TopLeftHeaderCell.Value = "eeee";


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindListCiew(List<Medicinedata> list)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MedicineDataRepository sb = new MedicineDataRepository();
            if(textBox1.Text.Length == 0)
            {
                bindListCiew(sb.selectAll());
            }
            else
            {
                bindListCiew(sb.selectByName(textBox1.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicineDataAdd insert = new MedicineDataAdd();
            insert.Owner = this;
            insert.Show();

            //if (insert.ShowDialog() == DialogResult.OK)
            //{
            //    MedicineDataRepository sb = new MedicineDataRepository();
            //    bindListCiew(sb.selectAll());
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {


            //if (insert.ShowDialog() == DialogResult.OK)
            //{
            //    MedicineDataRepository sb = new MedicineDataRepository();
            //    bindListCiew(sb.selectAll());
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
