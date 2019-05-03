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

        private double x, l;
        public MainView()
        {
            InitializeComponent();
        }

        private Series series1, series2, series3;
        private int sum = 1;
        private bool flag = false;
        private bool stop_flag = false;
        private PatientBasic patient = patientData.ChosenPatient;

        private void mainView_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(this.Width, this.Height);
            x = this.Size.Width - this.MinimumSize.Width;
            l = this.MaximumSize.Width - this.MinimumSize.Width;
            BasicData();
            CreateChart();
            //CreateMedicineChart();
            createSeries();
            createViewList();
            //medicineLst_init();
            t.Start();
        }

        private void BasicData()
        {

            birthdayd.Text = patient.BirthDate.ToString();
            named.Text = patient.Name;
            chartnd.Text = patient.CharNo;

        }

        //生命体征讯号
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
            chartArea.AxisY.Enabled = AxisEnabled.Auto;

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
            
            chartArea.Position = new ElementPosition((float)5.9, 2, (float)93.04, 97);

            chart.ChartAreas.Add(chartArea);
            chart.BackGradientStyle = GradientStyle.None;
            //图表的边框颜色
            chart.BorderlineColor = Color.DarkGray;
            //图表的边框线条样式
            chart.BorderlineDashStyle = ChartDashStyle.DashDot;
            //图表边框线条的宽度
            chart.BorderlineWidth = 1;
            chart.BackColor = SystemColors.Control;
            //图表边框的皮肤
            //chart.BorderSkin.SkinStyle = BorderSkinStyle.None;

        }

        //已加入的药物list
        static List<Medicinedata> medicineList;

        private void createViewList()
        {
            //medicineList.BackColor = Color.Snow;
            // 设置行高
            ImageList imgList = new ImageList();
            // 分别是宽和高
            imgList.ImageSize = new Size(1, 25);
            // 这里设置listView的SmallImageList ,用imgList将其撑大
            medicineData.SmallImageList = imgList;
            medicineLst.SmallImageList = imgList;

            this.medicineLst.Columns.Add("", 0, HorizontalAlignment.Center);
            this.medicineLst.Columns.Add("",this.medicineLst.Width,HorizontalAlignment.Center);
            this.medicineLst.HeaderStyle = ColumnHeaderStyle.None;
            //随机产生，测试资料
            for (int i = 0; i < 10; i++)
            {
                ListViewItem it = new ListViewItem();
                it.Text = "藥物" + i;
                it.SubItems.Add("藥物" + i);
                medicineLst.Items.Add(it);
                it = new ListViewItem();
                it.Text = "";
                medicineData.Items.Add(it);
            }
            this.medicineLst.View = View.Details;

            String date_time = DateTime.Now.ToShortTimeString() + "";
            String[] date_time2 = date_time.Split(' ');
            this.medicineData.Columns.Add(date_time2[1],0);
            this.medicineData.HeaderStyle = ColumnHeaderStyle.None;
            this.medicineData.View = View.Details;
        }
        public void createViewList_ButtonOnClick(String name)
        {
            //medicineList add one item
            ListViewItem it = new ListViewItem();
            it.Text = name;
            it.SubItems.Add(name);
            medicineLst.Items.Add(it);
            //medicineData add ml
            it = new ListViewItem();
            int count = sum - 1;
            for (int i = 0; i <= count; i++)
            {
                if (i == count)
                    it.SubItems.Add("ml");
                else
                    it.SubItems.Add("-----");
            }
            medicineData.Items.Add(it);
        }

        static int list_view_select_index = 0;
        private void medicineLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_view_select_index = medicineLst.FocusedItem.Index;
            
        }
        public void update_Medicine_mark(String medicine_num)
        {

            int count = (sum - 1) - medicineData.Items[list_view_select_index].SubItems.Count;
            for (int i = 0; i <= count; i++)
            {
                if (i == count)
                    medicineData.Items[list_view_select_index].SubItems.Add(medicine_num + "ml");
                else
                    medicineData.Items[list_view_select_index].SubItems.Add("-----");
            }


;
        }


        private void medicineLst_ItemActivate(object sender, EventArgs e)
        {
            MedicineDataAddML medicineDataAddML = new MedicineDataAddML(this);
            medicineDataAddML.Show();
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

        //添加剂量
        private void drawMedicineData()
        {
            foreach (ColumnHeader ch in medicineData.Columns)
            {
                if(ch.Index != 0)
                    ch.Width = this.medicineData.Width / (int)(((x / l * 20) + 30 * (
                                                                    1 + trackBar1.Value / 20.0)) / 5);
            }

            for (int i = 0; i < 1; i++)
            {
                ListViewItem lv = medicineData.Items[0];
                lv.SubItems.Add("剂量" + i);
                medicineData.Items.RemoveAt(i);
                medicineData.Items.Insert(i,lv);
            }
            
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
            //判断timer动了几次
            
                this.medicineData.Columns.Add("");
                drawMedicineData();
                this.medicineData.View = View.Details;
            
            sum++;
            if (sum <= chart.ChartAreas[0].AxisX.ScaleView.Size)
                chart.ChartAreas[0].AxisX.ScaleView.Position = 0;
            //记得优化多一格的问题
            else if (!stop_flag)
            {
                chart.ChartAreas[0].AxisX.ScaleView.Size = (int)(((x / l * 20) + 30 * (
                                                                1 + trackBar1.Value / 20.0)) / 5) * 5 - 1;
                chart.ChartAreas[0].AxisX.ScaleView.Position = sum - chart.ChartAreas[0].AxisX.ScaleView.Size;
            }

        }

        private void medicineRecord_Click(object sender, EventArgs e)
        {
            MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(this);
            medicineDataAddForm_InListView.Show();
        }

        private void timeRecord_Click(object sender, EventArgs e)
        {
            TimeRecordForm_inListChart timeRecordForm_InListChart = new TimeRecordForm_inListChart();
            timeRecordForm_InListChart.Show();
        }


        //随窗口大小变动事件
        private void mainView_SizeChanged(object sender, EventArgs e)
        {
            x = this.Size.Width - this.MinimumSize.Width;
            l = this.MaximumSize.Width - this.MinimumSize.Width;
            if (chart.ChartAreas.Count != 0)
            {
                chart.ChartAreas[0].AxisX.Interval = 1D;
                //medicineChart.ChartAreas[0].AxisX.Interval = 5D;
                chart.ChartAreas[0].AxisX.ScaleView.Size = (int)(((x / l * 20) + 30 * (
                                                            1 + trackBar1.Value / 20.0))/5)*5;
                //medicineChart.ChartAreas[0].AxisX.ScaleView.Size = (int)((x / l * 20) + 30 * (1 + trackBar1.Value / 20.0));

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
            chart.ChartAreas[0].AxisX.ScaleView.Size = (int)(((x / l * 20) + 30 * (
                                                            1 + trackBar1.Value / 20.0))/5) * 5;
            drawMedicineData();
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
