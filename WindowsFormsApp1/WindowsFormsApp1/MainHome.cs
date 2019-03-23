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
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindListCiew(List<Medicinedata> list)
        {
            listView1.Clear();   

            this.listView1.Columns.Add("藥劑ID");
            this.listView1.Columns.Add("藥品名稱");
            this.listView1.Columns.Add("劑量單位");

            foreach(Medicinedata data in list)
            {
                ListViewItem it = new ListViewItem();
                it.Text = data.MId;
                it.SubItems.Add(data.MName);
                it.SubItems.Add(data.Unit);
            
                listView1.Items.Add(it);
            }

            this.listView1.View = View.Details;

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
                bindListCiew(sb.select(textBox1.Text));
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
            User u = new User();
            u.Code = listView1.FocusedItem.SubItems[0].Text;
            u.Name = listView1.FocusedItem.SubItems[1].Text;
            u.Pwd = listView1.FocusedItem.SubItems[2].Text;

            MedicineDataUpdate insert = new MedicineDataUpdate(u);
            insert.Owner = this;
            insert.Show();

            //if (insert.ShowDialog() == DialogResult.OK)
            //{
            //    MedicineDataRepository sb = new MedicineDataRepository();
            //    bindListCiew(sb.selectAll());
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MedicineDataRepository().delete(listView1.FocusedItem.SubItems[0].Text);
            listView1.Items.RemoveAt(listView1.FocusedItem.Index);
        }
    }
}
