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
    public partial class MedicineDataAddML : Form
    {
        MainView mainView;
        public MedicineDataAddML()
        {
            InitializeComponent();
        }
        public MedicineDataAddML(MainView mainView)
        {
            InitializeComponent();
            this.mainView = mainView;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //mainView.update_Medicine_mark(textBox1.Text);

        }
    }
}
