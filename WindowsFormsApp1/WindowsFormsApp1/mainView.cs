using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        Series series1, series2, series3;
        int sum = 1;
        bool flag = false;
        bool stop_flag = false;

        private void mainView_Load(object sender, EventArgs e)
        {
            CreateChart();
            CreateMedicineChart();
            createSeries();
            medicineLst_init();
            t.Start();
            this.MaximumSize = new Size(this.Width,this.Height);
        }

        private void CreateChart()
        {
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "vitalSignsArea";

            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;//启用X轴滚动条按钮

            chartArea.BackColor = Color.Snow;                      //背景色
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
            chartArea.AxisY.Interval = 10;
            chartArea.AxisY.LineWidth = 1;
            chartArea.AxisY.LineColor = Color.Black;
            chartArea.AxisY.Enabled = AxisEnabled.True;
            
            chartArea.AxisX.IsLabelAutoFit = true;
            chartArea.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea.AxisX.LabelStyle.Angle = -15;

            chartArea.AxisX.Interval = 1D;
            chartArea.AxisX.ScaleView.Size = 50D;
            
            chartArea.AxisX.LabelStyle.IsEndLabelVisible = true;        //show the last label
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.NotSet;
            chartArea.AxisX.TextOrientation = TextOrientation.Auto;
            chartArea.AxisX.LineWidth = 1;
            chartArea.AxisX.LineColor = Color.Black;
            chartArea.AxisX.Enabled = AxisEnabled.True;
            chartArea.AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Months;
            chartArea.AxisX.Crossing = 0;
            chartArea.AxisX.LabelStyle.Enabled = false;
            
            chartArea.Position = new ElementPosition(7, 2, 92, 97);

            chart.ChartAreas.Add(chartArea);
            chart.BackGradientStyle = GradientStyle.TopBottom;
            //图表的边框颜色
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

        private void CreateMedicineChart()
        {
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "MedicineArea";

            chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;//启用X轴滚动条按钮

            chartArea.BackColor = Color.Snow;                      //背景色
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
            chartArea.AxisY.Maximum = 360;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Interval = 20;
            chartArea.AxisY.LineWidth = 1;
            chartArea.AxisY.LineColor = Color.Black;
            chartArea.AxisY.Enabled = AxisEnabled.True;
            chartArea.AxisY.IsLabelAutoFit = false;

            chartArea.AxisX.IsLabelAutoFit = true;
            chartArea.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea.AxisX.LabelStyle.Angle = -15;

            chartArea.AxisX.Interval = 5D;
            chartArea.AxisX.ScaleView.Size = chart.ChartAreas[0].AxisX.ScaleView.Size;

            chartArea.AxisX.LabelStyle.IsEndLabelVisible = true;        //show the last label
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chartArea.AxisX.IntervalType = DateTimeIntervalType.NotSet;
            chartArea.AxisX.TextOrientation = TextOrientation.Auto;
            chartArea.AxisX.LineWidth = 1;
            chartArea.AxisX.LineColor = Color.Black;
            chartArea.AxisX.Enabled = AxisEnabled.True;
            chartArea.AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Months;
            chartArea.AxisX.Crossing = 0;
            chartArea.AxisX.LabelStyle.Enabled = false;
            
            chartArea.Position = new ElementPosition(0, 0, 99, 97);

            medicineChart.ChartAreas.Add(chartArea);
            medicineChart.BackGradientStyle = GradientStyle.TopBottom;
            //图表的边框颜色、
            medicineChart.BorderlineColor = Color.DarkGray;
            //图表的边框线条样式
            medicineChart.BorderlineDashStyle = ChartDashStyle.NotSet;
            //图表边框线条的宽度
            medicineChart.BorderlineWidth = 1;
            medicineChart.BackColor = SystemColors.Control;
            medicineChart.BackSecondaryColor = SystemColors.Control;
            //图表边框的皮肤
            //chart.BorderSkin.SkinStyle = BorderSkinStyle.None;

        }

        private void medicineLst_init()
        {
            // 设置行高
            ImageList imgList = new ImageList();
            // 分别是宽和高
            imgList.ImageSize = new Size(1, 25);
            // 这里设置listView的SmallImageList ,用imgList将其撑大
            medicineLst.SmallImageList = imgList;

            this.medicineLst.Columns.Add("");
            this.medicineLst.Columns[0].Width = -1;
            this.medicineLst.View = View.Details;
            for (int i = 0; i < 10; i++)
            {
                ListViewItem it = new ListViewItem();
                it.Text = "medicine" + i;
                medicineLst.Items.Add(it);
            }
        }
        
        private void createSeries()
        {
            //收缩压
            series1 = new Series();
            series1.ChartArea = "vitalSignsArea";
            chart.Series.Add(series1);

            //Series style
            series1.ToolTip = "#VALX,#VALY";    //鼠标停留在数据点上，显示XY值

            series1.Name = "SystolicBP";
            series1.ChartType = SeriesChartType.Spline;  // type
            series1.BorderWidth = 0;
            series1.Color = Color.Red;
            series1.XValueType = ChartValueType.Time;//x axis type
            series1.YValueType = ChartValueType.Int32;//y axis type

            //Marker
            //series1.MarkerImage = "../../picture/down.png";
            series1.MarkerStyle = MarkerStyle.Triangle;
            series1.MarkerSize = 8;
            series1.MarkerColor = Color.Red;

            //舒张压
            series2 = new Series();
            series2.ChartArea = "vitalSignsArea";
            chart.Series.Add(series2);

            //Series style
            series2.ToolTip = "#VALX,#VALY";    //鼠标停留在数据点上，显示XY值

            series2.Name = "DiastolicBP";
            series2.ChartType = SeriesChartType.Spline;  // type
            series2.BorderWidth = 0;
            series2.Color = Color.Blue;
            series2.XValueType = ChartValueType.Time;//x axis type
            series2.YValueType = ChartValueType.Int32;//y axis type

            //Marker
            //series2.MarkerImage = "../../picture/up.png";
            series2.MarkerStyle = MarkerStyle.Triangle;
            series2.MarkerSize = 8;
            series2.MarkerColor = Color.Blue;
            //Console.WriteLine(System.Environment.CurrentDirectory);

            //心跳
            series3 = new Series();
            series3.ChartArea = "vitalSignsArea";
            chart.Series.Add(series3);

            //Series style
            series3.ToolTip = "#VALX,#VALY";    //鼠标停留在数据点上，显示XY值

            series3.Name = "Heartbeat";
            series3.ChartType = SeriesChartType.Line;  // type
            series3.BorderWidth = 1;
            series3.Color = Color.DeepPink;
            series3.XValueType = ChartValueType.Time;//x axis type
            series3.YValueType = ChartValueType.Int32;//y axis type

            //Marker
            //series3.MarkerImage = "../../picture/up.png";
            series3.MarkerStyle = MarkerStyle.Circle;
            series3.MarkerSize = 8;
            series3.MarkerColor = Color.DeepPink;

            series1.Points.Add();
            series1.Points[0].IsEmpty = true;
            flag = true;
            this.chart.Legends.Clear();
        }


        static int range = 0, range1 = 0, range2 = 0;
        Random r = new Random(6);
        Random r1 = new Random(9);
        Random r2 = new Random(3);

        private void t_Tick(object sender, EventArgs e)         //timer事件
        {
            if (flag)
            {
                flag = false;
                chart.Series[0].Points.Clear();
            }
            range = r.Next(140, 200);    //随机取数 
            range1 = r1.Next(90, 120);
            range2 = r2.Next(60, 100);
            series1.Points.AddXY(sum, range);   //设置series点    
            series2.Points.AddXY(sum, range1);
            series3.Points.AddXY(sum, range2);
            sum++;
            if (sum < chart.ChartAreas[0].AxisX.ScaleView.Size)
                chart.ChartAreas[0].AxisX.ScaleView.Position = 0;
            else if(!stop_flag)
                chart.ChartAreas[0].AxisX.ScaleView.Position = sum - chart.ChartAreas[0].AxisX.ScaleView.Size;
        }

        
        //随窗口大小变动事件
        private void mainView_SizeChanged(object sender, EventArgs e)
        {
            if (chart.ChartAreas.Count != 0)
            {
                chart.ChartAreas[0].AxisX.Interval = 1D;
                medicineChart.ChartAreas[0].AxisX.Interval = 5D;
                double x = this.Size.Width - this.MinimumSize.Width;
                double l = this.MaximumSize.Width - this.MinimumSize.Width;
                chart.ChartAreas[0].AxisX.ScaleView.Size = (int)((x / l * 20) + 30 * (
                                                            1 + trackBar1.Value / 20.0));
                medicineChart.ChartAreas[0].AxisX.ScaleView.Size = (int)((x / l * 20) + 30 * (
                                                            1 + trackBar1.Value / 20.0));

                if (this.Size.Height == this.MaximumSize.Height)
                {
                    chart.ChartAreas[0].AxisY.Interval = 10;
                }
                else
                {
                    chart.ChartAreas[0].AxisY.Interval = 20;
                }

            }
           
        }

        //调整生命体征图形大小
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double x = this.Size.Width - this.MinimumSize.Width;
            double l = this.MaximumSize.Width - this.MinimumSize.Width;
            chart.ChartAreas[0].AxisX.ScaleView.Size = (int)(((x / l * 20) + 30) * (
                                                         1 + trackBar1.Value / 20.0));
        }

        private void medicineLst_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // 取消掉正在调整的事件
            e.Cancel = true;
            // 把新宽度恢复到之前的宽度
            e.NewWidth = this.medicineLst.Columns[e.ColumnIndex].Width;
        }

        private void button_Stop_Click(object sender, EventArgs e)  //切换停止开始按钮
        {
            if(stop_flag)
            {
                button_Stop.Text = "暫停滾動";
                stop_flag = false;
                //t.Start();
            }
            else
            {
                button_Stop.Text = "開始滾動";
                stop_flag = true;
                //t.Stop();
            }
        }

    }
    
}
