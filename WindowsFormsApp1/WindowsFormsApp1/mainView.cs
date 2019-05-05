﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
    public partial class MainView : Form
    {
        private MedicineRecordRepository medicineRecordRepository = new MedicineRecordRepository();
        private MedicineDataRepository medicineDataRepository = new MedicineDataRepository();
        private double x, l;

        public MainView()
        {
            InitializeComponent();
        }

        private Series series1, series2, series3;
        private int sum = 1;
        private bool flag = false;
        private bool stop_flag = false;
        private int operatingSum;
        private PatientBasic patient = PatientData.ChosenPatient;

        private void mainView_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(this.Width, this.Height);
            x = this.Size.Width - this.MinimumSize.Width;
            l = this.MaximumSize.Width - this.MinimumSize.Width;
            CreateChart();
            //CreateMedicineChart();
            createSeries();
            createViewList();
            BasicData();
            //medicineLst_init();
            t.Start();
        }

        //生命体征讯号
        private void CreateChart()
        {
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "vitalSignsArea";

            chartArea.AxisX.ScrollBar.Enabled = false;//启用X轴滚动条按钮

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
            
            chartArea.Position = new ElementPosition((float)5.95, 2, (float)93.06, 97);

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
        private static List<string> medicineList = new List<string>();
        //還未停止注射的連續輸注藥物list
        private static List<Medicinedata> medicineOnList = new List<Medicinedata>();

        //添加药物
        public void addMedicine(AnesthesiaMedicineRecord m)
        {
            //判断添加的药物是否已经存在
            if (medicineList.Exists(x => x.Equals(m.MedicineID)))
            {
                DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.IndexOf(m.MedicineID)];
                //若为连续输注药物
                if (medicineOnList.Exists(x => x.MId.Equals(m.MedicineID)))
                {
                    medicineOnList.Find(x => x.MId.Equals(m.MedicineID)).Unit = m.ActualAmount;
                    medicineOnList.Find(x => x.MId.Equals(m.MedicineID)).FlowRate = m.FlowRate;
                    row.Cells[(sum - 1) / 5 - 1].Value = "————————————————▌";
                    row.Cells[(sum - 1) / 5].Value = m.ActualAmount + " ——————————";
                }
                else if(m.AnesthesiaType == 1)
                {
                    row.Cells[(sum - 1) / 5].Value = m.ActualAmount + " ——————————";

                    Medicinedata x = new Medicinedata();
                    x.MId = m.MedicineID;
                    x.MName = medicineDataRepository.selectById(m.MedicineID).MName;
                    x.Method = m.AnesthesiaType;
                    x.Unit = m.ActualAmount;
                    x.FlowRate = m.FlowRate;
                    medicineOnList.Add(x);
                }
                else
                    row.Cells[(sum - 1) / 5].Value = m.ActualAmount;

                this.medicineData.Rows.RemoveAt(medicineList.IndexOf(m.MedicineID));
                this.medicineData.Rows.Insert(0, row);
            }
            else
            {
                medicineRecordRepository.insertMRecord(m);
                medicineList.Insert(0, m.MedicineID);
                this.medicineLst.Rows.Insert(0, medicineDataRepository.selectById(medicineList[0]).MName);

                DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.Count - 1].Clone();

                if (m.AnesthesiaType == 1)
                {
                    row.Cells[(sum - 1) / 5].Value = m.ActualAmount + " ——————————";

                    Medicinedata x = new Medicinedata();
                    x.MId = m.MedicineID;
                    x.MName = medicineDataRepository.selectById(m.MedicineID).MName;
                    x.Method = m.AnesthesiaType;
                    x.Unit = m.ActualAmount;
                    x.FlowRate = m.FlowRate;
                    medicineOnList.Add(x);
                }
                else
                    row.Cells[(sum - 1) / 5].Value = m.ActualAmount;

                this.medicineData.Rows.Insert(0, row);
            }

            medicineList.RemoveAt(medicineList.IndexOf(m.MedicineID));
            medicineList.Insert(0, m.MedicineID);

        }

        private void createViewList()
        {
            this.medicineLst.Columns.Add("", "");
            this.medicineLst.Columns[0].Width = this.medicineLst.Width;

            String date_time = DateTime.Now.ToShortTimeString() + ""; 
            String[] date_time2 = date_time.Split(' ');
            this.medicineData.Columns.Add(date_time2[1], sum + "");
            DataGridViewRow row = new DataGridViewRow();
            this.medicineData.Rows.Add("");
            this.medicineData.AutoGenerateColumns = false;

        }

        private void medicineLst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MedicineRecordOperation medicineRecordOperation = new MedicineRecordOperation(this.medicineLst.CurrentCell.RowIndex, 
                                                                this.medicineLst.CurrentCell.Value.ToString(), this);
            medicineRecordOperation.Show();
        }

        public void continuousMStop(int index)
        {
            DataGridViewRow row = (DataGridViewRow)medicineData.Rows[index];
            row.Cells[(sum - 1) / 5].Value = "————————————————▌";
            this.medicineData.Rows.RemoveAt(index);
            this.medicineData.Rows.Insert(index, row);

            for(int i = 0; i < medicineOnList.Count; i++)
            {
                if (medicineOnList[i].MId == medicineList[index])
                    medicineOnList.RemoveAt(i);
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

        //添加剂量
        private void drawMedicineData()
        {
            //空白行
            DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.Count];
            row.Cells[(sum - 1) / 5].Value = "";
            medicineData.Rows.RemoveAt(medicineList.Count);
            medicineData.Rows.Insert(medicineList.Count, row);

            for(int i = 0; i < medicineOnList.Count; i++)
            {
                //剂量
                DataGridViewRow row1 = (DataGridViewRow)medicineData.Rows[medicineList.IndexOf(medicineOnList[i].MId)];
                if(medicineOnList[i].Unit.Equals(row1.Cells[((sum - 1) / 5) - 1].Value))
                    row1.Cells[(sum - 1) / 5].Value = "—————————————————";
                else
                    //row1.Cells[(sum - 1) / 5].Value = medicineOnList[i].Unit;
                    row1.Cells[(sum - 1) / 5].Value = "—————————————————";

                medicineData.Rows.RemoveAt(i);
                medicineData.Rows.Insert(i, row1);
            }

            if (!stop_flag)
                medicineData.CurrentCell = medicineData.Rows[0].Cells[medicineData.Columns.Count - 1];

            foreach (DataGridViewColumn gCol in medicineData.Columns)
                gCol.Width = this.medicineData.Width / ((int)chart.ChartAreas[0].AxisX.ScaleView.Size / 5);

            
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
            //判断timer动了几次
            if((sum-1) % 5 == 0)
            {
                this.medicineData.Columns.Add("", (sum-1)/5 + "");
                drawMedicineData();
            }

            if (sum <= chart.ChartAreas[0].AxisX.ScaleView.Size)
                chart.ChartAreas[0].AxisX.ScaleView.Position = 0;
            //记得优化多一格的问题
            else if (!stop_flag)
            {
                chart.ChartAreas[0].AxisX.ScaleView.Size = (int)(((x / l * 20) + 30 * (
                                                                1 + trackBar1.Value / 20.0)) / 5) * 5;
                if((sum)%5 != 0)
                    chart.ChartAreas[0].AxisX.ScaleView.Position = sum - chart.ChartAreas[0].AxisX.ScaleView.Size + 5 - sum%5;
                else
                    chart.ChartAreas[0].AxisX.ScaleView.Position = sum - chart.ChartAreas[0].AxisX.ScaleView.Size;
            }

        }

        private void patientDetail_Click(object sender, EventArgs e)
        {
            PatientDetail detail = new PatientDetail();
            detail.Owner = this;
            detail.Show();
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

        //病人资料
        private void BasicData()
        {

            birthdayd.Text = patient.BirthDate.ToString();
            named.Text = patient.Name;
            chartnd.Text = patient.CharNo;

        }


    }

}
