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
    public partial class ChangePoint : Form
    {

        //Form parent;
        //bool isMain;

        /***
    public ChangePoint(bool isMain)
    {
        InitializeComponent();
        this.isMain = isMain;
        if (isMain)
        {
            parent = (MainView)this.Owner;
        }
        else
        {
            parent = (ModifyDataSeries)this.Owner;
        }
    }
    ***/

        public ChangePoint()
        {
            InitializeComponent();
        }

        //初始的xy值
        public void SetValue(double x, double y, String type, int time)
        {
            current.Text = StaticPatient.anesthesiaData.
                Thebeginningofsurgery.AddSeconds(5*time).ToString("HH:mm:ss");
            yn.Text = y.ToString();
            this.type.Text = type;
            this.time.Text = time.ToString();
        }

        //获取当前xy值
        public double[] GetValue()
        {
            return new double[]{Double.Parse(current.Text), Double.Parse(yn.Text)};
        }

        //xy修改只能输入小数（数字和小数点）以及删除，其他按键无效

        private void xn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void yn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确认：呼叫修改数据点
        private void button2_Click(object sender, EventArgs e)
        {
            //if (isMain)
            //{
                MainView mv = (MainView)this.Owner;
                mv.ChangePoint(Double.Parse(yn.Text),
                    this.type.Text, Int32.Parse(this.time.Text));
                this.Close();
            //}
            //else
            //{

            //}
        }
    }
}
