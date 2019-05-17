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
    public partial class PatientHistory : Form
    {
        public PatientHistory()
        {
            InitializeComponent();
        }

        public void LoadData(string name, string history)
        {
            this.name.Text = name;
            this.content.Text = history;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
