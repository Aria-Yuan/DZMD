using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; 

namespace WindowsFormsApp1
{
    public partial class mainView : Form
    {
        public mainView()
        {
            InitializeComponent();
        }

        Series series1, series2;
        int sum = 1;
        bool flag = false;

        private void mainView_Load(object sender, EventArgs e)
        {
            CreateChart();
            createSeries();
            t.Start();
        }

        private void CreateChart()
        {
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "FirstArea";

            chartArea.CursorX.IsUserEnabled = true;
            chartArea.CursorX.IsUserSelectionEnabled = true;
            chartArea.CursorX.SelectionColor = Color.SkyBlue;
            chartArea.CursorY.IsUserEnabled = true;
            chartArea.CursorY.AutoScroll = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;
            chartArea.CursorY.SelectionColor = Color.SkyBlue;

            chartArea.CursorX.IntervalType = DateTimeIntervalType.Auto;
            chartArea.AxisX.ScaleView.Zoomable = false;
            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;//启用X轴滚动条按钮

            chartArea.BackColor = Color.White;                      //背景色
            //chartArea.BackSecondaryColor = Color.White;                 //渐变背景色
            //chartArea.BackGradientStyle = GradientStyle.TopBottom;      //渐变方式
            chartArea.BackHatchStyle = ChartHatchStyle.None;            //背景阴影
            chartArea.BorderDashStyle = ChartDashStyle.NotSet;          //边框线样式
            chartArea.BorderWidth = 1;                                  //边框宽度
            chartArea.BorderColor = Color.DarkGray;

            chartArea.AxisX.MajorGrid.Enabled = true;
            chartArea.AxisX.MajorGrid.LineColor = Color.DarkGray;
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.LineColor = Color.DarkGray;

            // Axis
            chartArea.AxisY.LabelAutoFitStyle = LabelAutoFitStyles.None;
            chartArea.AxisY.LabelStyle.Font = new Font(chartArea.AxisY.LabelStyle.Font.Name, 9);
            chartArea.AxisY.Maximum = 240;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Interval = 20;
            chartArea.AxisY.LineWidth = 1;
            chartArea.AxisY.LineColor = Color.Black;
            chartArea.AxisY.Enabled = AxisEnabled.True;
            
            chartArea.AxisX.IsLabelAutoFit = true;
            chartArea.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea.AxisX.LabelStyle.Angle = -15;


            chartArea.AxisX.LabelStyle.IsEndLabelVisible = true;        //show the last label
            chartArea.AxisX.Interval = 10;
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.NotSet;
            chartArea.AxisX.TextOrientation = TextOrientation.Auto;
            chartArea.AxisX.LineWidth = 1;
            chartArea.AxisX.LineColor = Color.Black;
            chartArea.AxisX.Enabled = AxisEnabled.True;
            chartArea.AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Months;
            chartArea.AxisX.Crossing = 0;
            chartArea.AxisX.LabelStyle.Enabled = false;

            chartArea.Position.Height = 95;
            chartArea.Position.Width = 98;
            chartArea.Position.X = 1;
            chartArea.Position.Y = 1;

            chart.ChartAreas.Add(chartArea);
            chart.BackGradientStyle = GradientStyle.TopBottom;
            //图表的边框颜色、
            chart.BorderlineColor = Color.DarkGray;
            //图表的边框线条样式
            chart.BorderlineDashStyle = ChartDashStyle.DashDot;
            //图表边框线条的宽度
            chart.BorderlineWidth = 1;
            chart.BackColor = SystemColors.Control;
            chart.BackSecondaryColor = SystemColors.Control;
            //图表边框的皮肤
            //chart.BorderSkin.SkinStyle = BorderSkinStyle.None;

        }

        private void createSeries()
        {
            //收缩压
            series1 = new Series();
            series1.ChartArea = "FirstArea";
            chart.Series.Add(series1);

            //Series1 style
            series1.ToolTip = "#VALX,#VALY";    //鼠标停留在数据点上，显示XY值

            series1.Name = "series1";
            series1.ChartType = SeriesChartType.Spline;  // type
            series1.BorderWidth = 0;
            series1.Color = Color.Red;
            series1.XValueType = ChartValueType.Time;//x axis type
            series1.YValueType = ChartValueType.Int32;//y axis type

            //Marker
            series1.MarkerStyle = MarkerStyle.Triangle;
            series1.MarkerSize = 8;
            series1.MarkerColor = Color.Red;

            //舒张压
            series2 = new Series();
            series2.ChartArea = "FirstArea";
            chart.Series.Add(series2);

            //Series1 style
            series2.ToolTip = "#VALX,#VALY";    //鼠标停留在数据点上，显示XY值

            series2.Name = "series2";
            series2.ChartType = SeriesChartType.Spline;  // type
            series2.BorderWidth = 0;
            series2.Color = Color.Red;
            series2.XValueType = ChartValueType.Time;//x axis type
            series2.YValueType = ChartValueType.Int32;//y axis type

            //Marker
            series2.MarkerStyle = MarkerStyle.Triangle;
            series2.MarkerSize = 8;
            series2.MarkerColor = Color.Blue;

            this.chart.Legends.Clear();
        }


        static int range = 0, range1 = 0;
        Random r = new Random(6);
        Random r1 = new Random(9);

        //用来设置切换视图时的视角
        private void chart_SelectionRangeChanged(object sender, CursorEventArgs e)
        {
            //无数据时返回
            if (chart.Series[0].Points.Count == 0)
                return;

            double start_position = 0.0;
            double end_position = 0.0;
            double myInterval = 0.0;
            start_position = e.NewSelectionStart;
            end_position = e.NewSelectionEnd;
            myInterval = Math.Abs(start_position - end_position);
            if (myInterval == 0.0)
                return;

            //X轴视图起点
            chart.ChartAreas[0].AxisX.ScaleView.Position = Math.Min(start_position, end_position);
            //X轴视图长度
            chart.ChartAreas[0].AxisX.ScaleView.Size = myInterval;
            //X轴间隔
            if (myInterval < 11.0)
            {
                chart.ChartAreas[0].AxisX.Interval = 1;
            }
            else
            {
                chart.ChartAreas[0].AxisX.Interval = Math.Floor(myInterval / 10);
            }
            flag = true;

        }

        private void t_Tick(object sender, EventArgs e)         //timer事件
        {
            if (flag)
                return;
            else
            {
                range = r.Next(140, 200);    //随机取数 
                range1 = r1.Next(80, 120);
                series1.Points.AddXY(sum, range);   //设置series点    
                series2.Points.AddXY(sum, range1);
                sum++;
                chart.ChartAreas[0].AxisX.Interval = 1D;
                chart.ChartAreas[0].AxisX.ScaleView.Size = 10D;
                if (sum <= chart.ChartAreas[0].AxisX.ScaleView.Size)
                    chart.ChartAreas[0].AxisX.ScaleView.Position = 1;
                else
                    chart.ChartAreas[0].AxisX.ScaleView.Position = sum - chart.ChartAreas[0].AxisX.ScaleView.Size;
            }
        }

        private void button_Stop_Click(object sender, EventArgs e)  //切换停止开始按钮
        {
            switch (button_Stop.Text)
            {
                case "Stop":
                    {
                        button_Stop.Text = "Start";
                        t.Stop();
                        break;
                    }
                case "Start":
                    {
                        button_Stop.Text = "Stop";
                        t.Start();
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
    }
    
}
