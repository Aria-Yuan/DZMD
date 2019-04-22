using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TimeRecordForm_inListChart : Form
    {
        public TimeRecordForm_inListChart()
        {
            InitializeComponent();
        }

        private void TimeRecordForm_inListChart_Load(object sender, EventArgs e)
        {
            String date_time = DateTime.Now.ToShortTimeString() + "";
            String[] date_time2 = date_time.Split(' ');
            textBox1.Text = date_time2[1];
            textBox2.Text = date_time2[1];
            textBox3.Text = date_time2[1];
            textBox4.Text = date_time2[1];
            textBox5.Text = date_time2[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
