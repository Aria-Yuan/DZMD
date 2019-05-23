using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class ModifyDataSeries : Form
    {
        Font fontContent = new Font("Microsoft JhengHei UI", 18f);
        Font fontTitle = new Font("Microsoft JhengHei UI", 22f, FontStyle.Bold);
        Padding paddingData = new Padding(8, 5, 0, 2);
        Padding paddingTime = new Padding(5, 7, 0, 2);
        DateTime current = StaticPatient.anesthesiaData.Thebeginningofsurgery;
        Series[] seriesList;
        FlowLayoutPanel[] main;

        public ModifyDataSeries()
        {
            InitializeComponent();
        }

        public void LoadView(Series[] seriesList)
        {
            this.seriesList = seriesList;
            int count = seriesList[0].Points.Count;
            main = new FlowLayoutPanel[]{ SystolicBPList, DiastolicBPList, HeartbeatList};
            for (int lists = 0; lists < 3; lists++)
            {
                /*
                main[lists].Controls.Add(new Label()
                {
                    Text = seriesList[lists].Name.ToString(),
                    Font = fontTitle,
                    AutoSize = true
                });
                */
                string name = main[lists].Name;
                for (int i = 0; i < count; i ++)
                {
                    main[lists].Controls.Add(SingleData(seriesList[lists].Points[i], i, name));
                }
                main[lists].FlowDirection = FlowDirection.TopDown;
                main[lists].AutoSize = true;
                //main[lists].AutoScroll = true;
                main[lists].AutoSize = false;
                main[lists].Width = 180;
            }
            /*
            timeList.Controls.Add(new Label()
            {
                Text = "手術時間",
                Font = fontTitle,
                AutoSize = true
            });
            */
            for (int i = 0; i < count; i++)
            {
                timeList.Controls.Add(SingleTime(i));
            }
            timeList.FlowDirection = FlowDirection.TopDown;
            timeList.AutoSize = true;
            //timeList.AutoScroll = true;
            timeList.AutoSize = false;
            timeList.Width = 180;

            mainview.AutoScroll = true;

        }

        private TextBox SingleData(DataPoint point, int index, string name)
        { 
            return new TextBox()
            {
                Text = point.YValues[0].ToString(),
                Font = fontContent,
                Margin = paddingData,
                Name = name + index.ToString()
            };
        }

        private FlowLayoutPanel SingleTime(int index)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();

            flp.Controls.Add(new Label()
            {
                Text = current.AddSeconds(5*index).ToString("hh:mm:ss"),
                Font = fontContent,
                Margin = paddingTime,
                AutoSize = true
            });
            flp.AutoSize = true;

            return flp;
        }

        private void ModifyDataSeries_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int j = 0;
                string name = main[i].Name;
                foreach(TextBox data in main[i].Controls)
                {
                    seriesList[i].Points[j].SetValueY(double.Parse(data.Text));
                    j ++;
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MainView m = (MainView)this.Owner;
            m.ChangeSeries(seriesList);
            this.Close();
        }
    }
}
