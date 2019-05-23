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
using WindowsFormsApp1.Repository;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class MainView : Form
    {
        private MedicineRecordRepository medicineRecordRepository = new MedicineRecordRepository();
        private MedicineDataRepository medicineDataRepository = new MedicineDataRepository();
        private PatientBasicRepository patientBasicRepository = new PatientBasicRepository();
        private AnesthesiaDataRepository anesthesiaDataRepository = new AnesthesiaDataRepository();
        private double x, l;

        private Series series1, series2, series3;
        private int sum = 1;
        private bool flag = false;
        private bool stop_flag = false;//timer暂停
        private bool isLocked = false;//是否正在编辑（锁）
        private int operatingSum, operatingIndex;
        private string stopSign = "————————————————▌";
        private string continuousSign = "—————————————————";
        private string startContinuousSign = " ——————————";
        private PatientBasic patient = StaticPatient.patient;
        private DateTime time;

        static int range = 0, range1 = 0, range2 = 0;
        Random r = new Random(6);
        Random r1 = new Random(9);
        Random r2 = new Random(3);

        DataPoint dp;
        Boolean isOnPoint = false;
        int pointIndex;
        String seriesName;

        public MainView()
        {
            InitializeComponent();
            //StartMain();
        }
        
        private void mainView_Load(object sender, EventArgs e)
        {
            SetButtomsInvalid();
            this.MaximumSize = new Size(this.Width, this.Height);
            x = this.Size.Width - this.MinimumSize.Width;
            l = this.MaximumSize.Width - this.MinimumSize.Width;
            LoadAnesthessiaData();
            CreateChart();
            //CreateMedicineChart();
            createSeries();
            createViewList();
            BasicDataShow();
            //medicineLst_init();
            t.Start();
            SetButtomsValid();
        }

        private void LoadAnesthessiaData()
        {
            StaticPatient.anesthesiaData = 
                anesthesiaDataRepository.SelectByAnesthesiaID(StaticPatient.AnesthesiaID);
            time = StaticPatient.anesthesiaData.Thebeginningofsurgery;
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

            chartArea.AxisX.IsLabelAutoFit = false;
            chartArea.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea.AxisX.LabelStyle.Angle = -50;

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
        private static List<AnesthesiaMedicineRecord> medicineOnList = new List<AnesthesiaMedicineRecord>();

        //修改当前注射流速
        public void modifyFlowRate(AnesthesiaMedicineRecord m)
        {
            isLocked = true;
            m.Time = StaticPatient.anesthesiaData.Thebeginningofsurgery.AddSeconds(operatingSum * 5);
            m.AnesthesiaID = StaticPatient.AnesthesiaID;
            if (m.AnesthesiaType == 0)
                medicineData.Rows[operatingIndex].Cells[operatingSum].Value = m.ActualAmount;
            else
            {
                if (medicineData.Rows[operatingIndex].Cells[operatingSum - 1].Value.Equals(continuousSign))
                    medicineData.Rows[operatingIndex].Cells[operatingSum - 1].Value = stopSign;
                else
                    medicineData.Rows[operatingIndex].Cells[operatingSum - 1].Value =
                        medicineData.Rows[operatingIndex].Cells[operatingSum - 1].Value.ToString().Split(' ')[0]
                        + medicineData.Rows[operatingIndex].Cells[operatingSum - 1].Value.ToString().Split(' ')[1]
                        + " ——————————▌";

                for (int i = 0; i < medicineOnList.Count; i++)
                {
                    if (medicineOnList[i].MedicineID.Equals(medicineList[operatingIndex].Split(' ')[0]))
                        medicineOnList.RemoveAt(i);
                }

                //判断是否已经添加
                if (medicineList.Exists(x => x.Split(' ')[0].Equals(m.MedicineID) &&
                    (x.Split(' ').Length == 1 || (x.Split(' ')[1] + " " + x.Split(' ')[2]).Equals(m.ActualAmount))))
                {
                    DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.IndexOf(m.MedicineID + " " + m.ActualAmount)];
                    row.Cells[operatingSum].Value = m.FlowRate + startContinuousSign;
                    for (int i = operatingSum + 1; i <= (int)((sum - 1) / 5); i++)
                        row.Cells[i].Value = continuousSign;

                    medicineOnList.Add(m);
                    this.medicineData.Rows.RemoveAt(medicineList.IndexOf(m.MedicineID + " " + m.ActualAmount));
                    this.medicineData.Rows.Insert(0, row);
                }
                else
                {
                    medicineList.Insert(0, m.MedicineID + " " + m.ActualAmount);
                    DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.Count - 1].Clone();
                    this.medicineLst.Rows.Insert(0, medicineDataRepository.selectById(m.MedicineID).MName + " "
                                                    + m.ActualAmount);

                    row.Cells[operatingSum].Value = m.FlowRate + startContinuousSign;
                    for (int i = operatingSum + 1; i <= (int)((sum - 1) / 5); i++)
                        row.Cells[i].Value = continuousSign;

                    medicineOnList.Add(m);
                    this.medicineData.Rows.Insert(0, row);
                }
            }

            //药物名称重新排序
            string currentName;
            if (m.AnesthesiaType == 0)
                currentName = m.MedicineID;
            else
                currentName = m.MedicineID + " " + m.ActualAmount;
            DataGridViewRow r = (DataGridViewRow)medicineLst.Rows[medicineList.IndexOf(currentName)];
            medicineLst.Rows.RemoveAt(medicineList.IndexOf(currentName));
            medicineLst.Rows.Insert(0, r);
            medicineList.RemoveAt(medicineList.IndexOf(currentName));
            medicineList.Insert(0, currentName);
            medicineLst.CurrentCell = null;
            isLocked = false;
        }

        //修改药物
        public void modifyMedicine(AnesthesiaMedicineRecord m)
        {
            isLocked = true;
            //要写村进资料库的部分
            if (m.AnesthesiaType == 0)
            {
                DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.IndexOf(m.MedicineID)];
                row.Cells[operatingSum].Value = m.ActualAmount;
                this.medicineData.Rows.RemoveAt(medicineList.IndexOf(m.MedicineID));
                this.medicineData.Rows.Insert(0, row);
            }
            else
            {
                //浓度是否修改
                if(!m.ActualAmount.Equals(medicineList[operatingIndex].Split(' ')[1]+" "+ medicineList[operatingIndex].Split(' ')[2]))
                {
                    DataGridViewRow row1 = (DataGridViewRow)medicineData.Rows[operatingIndex];
                    DataGridViewRow row2;
                    //是否已经有添加过
                    if (medicineList.Exists(x => x.Equals(m.MedicineID + " " + m.ActualAmount)))
                        row2 = (DataGridViewRow)medicineData.Rows[medicineList.IndexOf(m.MedicineID + " " + m.ActualAmount)];
                    else
                    {
                        medicineList.Insert(0, m.MedicineID + " " + m.ActualAmount);
                        this.medicineLst.Rows.Insert(0, medicineDataRepository.selectById(m.MedicineID).MName + " "
                                                        + m.ActualAmount);
                        row2 = (DataGridViewRow)medicineData.Rows[medicineList.Count - 1].Clone();
                    }

                    int forward = operatingSum;
                    int backward = operatingSum;

                    if (!(row1.Cells[forward].Value.Equals(stopSign)
                        || row1.Cells[forward].Value.Equals(continuousSign)))
                        forward++;

                    while (forward < row1.Cells.Count && row1.Cells[forward].Value != null  
                        && (row1.Cells[forward].Value.Equals(stopSign)
                        || row1.Cells[forward].Value.Equals(continuousSign)))
                    {
                        row2.Cells[forward].Value = row1.Cells[forward].Value;
                        row1.Cells[forward].Value = null;
                        forward++;
                    }

                    //如果正在注射
                    if (forward == row1.Cells.Count)
                    {
                        medicineOnList.Find(x => x.MedicineID.Equals(m.MedicineID)).ActualAmount = m.ActualAmount;
                        medicineOnList.Find(x => x.MedicineID.Equals(m.MedicineID)).FlowRate = m.FlowRate;
                    }

                    while (row1.Cells[backward].Value == null || (row1.Cells[backward].Value.Equals(continuousSign) || row1.Cells[backward].Value.Equals(stopSign)))
                    {
                        if(row1.Cells[backward].Value != null)
                            row2.Cells[backward].Value = row1.Cells[backward].Value;
                        row1.Cells[backward].Value = null;
                        backward--;
                    }
                    row2.Cells[backward].Value = m.FlowRate + startContinuousSign;
                    row1.Cells[backward].Value = null;

                    if (medicineList.Exists(x => x.Equals(m.MedicineID + " " + m.ActualAmount)))
                        this.medicineData.Rows.RemoveAt(medicineList.IndexOf(m.MedicineID + " " + m.ActualAmount));
                    this.medicineData.Rows.Insert(0, row2);
                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow)medicineData.Rows[operatingIndex];

                    int forward = operatingSum;
                    int backward = operatingSum;
                    //往后找有没有停止符号
                    while (forward < row.Cells.Count && !row.Cells[forward].Value.Equals(stopSign))
                    {
                        forward++;
                    }

                    //如果没有找到停止符号
                    if (forward == row.Cells.Count)
                    {
                        medicineOnList.Find(x => x.MedicineID.Equals(m.MedicineID)).ActualAmount = m.ActualAmount;
                        medicineOnList.Find(x => x.MedicineID.Equals(m.MedicineID)).FlowRate = m.FlowRate;
                    }
                    while (row.Cells[backward].Value.Equals(continuousSign) || row.Cells[backward].Value.Equals(stopSign))
                        backward--;
                    row.Cells[backward].Value = m.FlowRate + startContinuousSign;
                    
                    this.medicineData.Rows.RemoveAt(operatingIndex);
                    this.medicineData.Rows.Insert(0, row);
                }
            }

            //药物名称重新排序
            string currentName;
            if (m.AnesthesiaType == 0)
                currentName = m.MedicineID;
            else
                currentName = m.MedicineID + " " + m.ActualAmount;
            DataGridViewRow r = (DataGridViewRow)medicineLst.Rows[medicineList.IndexOf(currentName)];
            medicineLst.Rows.RemoveAt(medicineList.IndexOf(currentName));
            medicineLst.Rows.Insert(0, r);
            medicineList.RemoveAt(medicineList.IndexOf(currentName));
            medicineList.Insert(0, currentName);
            medicineLst.CurrentCell = null;
            isLocked = false;
        }

        //添加药物
        public void addMedicine(AnesthesiaMedicineRecord m)
        {
            isLocked = true;
            m.Time = StaticPatient.anesthesiaData.Thebeginningofsurgery.AddSeconds(operatingSum*5);
            m.AnesthesiaID = StaticPatient.AnesthesiaID;
            medicineRecordRepository.insertMRecord(m);
            if (m.AnesthesiaType == 0)
            {
                //是否已经添加过
                if (medicineList.Exists(x => x.Split(' ')[0].Equals(m.MedicineID)))
                {
                    DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.IndexOf(m.MedicineID)];
                    row.Cells[operatingSum].Value = m.ActualAmount;
                    this.medicineData.Rows.RemoveAt(medicineList.IndexOf(m.MedicineID));
                    this.medicineData.Rows.Insert(0, row);
                }
                else
                {
                    medicineList.Insert(0, m.MedicineID);
                    DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.Count - 1].Clone();
                    this.medicineLst.Rows.Insert(0, medicineDataRepository.selectById(m.MedicineID).MName);
                    row.Cells[operatingSum].Value = m.ActualAmount;
                    this.medicineData.Rows.Insert(0, row);
                }
            }
            else
            {
                //是否有正在注射的 先停掉
                if (medicineOnList.Exists(x => x.MedicineID.Equals(m.MedicineID)))
                {
                    int templeCurrentSum = operatingSum;
                    int templeIndex = 0;
                    for (int i = 0; i < medicineList.Count; i++)
                    {
                        if (medicineList[i].Equals(m.MedicineID + " " +
                            medicineOnList.Find(x => x.MedicineID.Equals(m.MedicineID)).ActualAmount))
                            templeIndex = i;
                    }
                    
                    if (medicineData.Rows[templeIndex].Cells[operatingSum - 1].Value.Equals(continuousSign))
                        medicineData.Rows[templeIndex].Cells[operatingSum - 1].Value = stopSign;
                    else
                        medicineData.Rows[templeIndex].Cells[operatingSum - 1].Value =
                            medicineData.Rows[templeIndex].Cells[operatingSum - 1].Value.ToString().Split(' ')[0]
                            + medicineData.Rows[templeIndex].Cells[operatingSum - 1].Value.ToString().Split(' ')[1]
                            + " ——————————▌";

                    //将停止符号的后面的清空
                    while (templeCurrentSum < medicineData.ColumnCount)
                    {
                        medicineData.Rows[templeIndex].Cells[templeCurrentSum].Value = null;
                        templeCurrentSum++;
                        if (templeCurrentSum >= medicineData.ColumnCount)
                            break;
                    }

                    for (int i = 0; i < medicineOnList.Count; i++)
                    {
                        if (medicineOnList[i].MedicineID.Equals(medicineList[templeIndex].Split(' ')[0]))
                            medicineOnList.RemoveAt(i);
                    }
                }

                //判断是否已经添加
                if (medicineList.Exists(x => x.Split(' ')[0].Equals(m.MedicineID) &&
                    (x.Split(' ').Length == 1 || (x.Split(' ')[1] + " " + x.Split(' ')[2]).Equals(m.ActualAmount))))
                {
                    DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.IndexOf(m.MedicineID + " " + m.ActualAmount)];
                    row.Cells[operatingSum].Value = m.FlowRate + startContinuousSign;
                    for (int i = operatingSum + 1; i <= (int)((sum - 1) / 5); i++)
                        row.Cells[i].Value = continuousSign;

                    medicineOnList.Add(m);
                    this.medicineData.Rows.RemoveAt(medicineList.IndexOf(m.MedicineID + " " + m.ActualAmount));
                    this.medicineData.Rows.Insert(0, row);
                }
                else
                {
                    medicineList.Insert(0, m.MedicineID + " " + m.ActualAmount);
                    DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.Count - 1].Clone();
                    this.medicineLst.Rows.Insert(0, medicineDataRepository.selectById(m.MedicineID).MName + " "
                                                    + m.ActualAmount);

                    row.Cells[operatingSum].Value = m.FlowRate + startContinuousSign;
                    for (int i = operatingSum + 1; i <= (int)((sum - 1) / 5); i++)
                        row.Cells[i].Value = continuousSign;

                    medicineOnList.Add(m);
                    this.medicineData.Rows.Insert(0, row);
                }
            }
            
             //药物名称重新排序
            string currentName;
            if (m.AnesthesiaType == 0)
                currentName = m.MedicineID;
            else
                currentName = m.MedicineID + " " + m.ActualAmount;
            DataGridViewRow r = (DataGridViewRow)medicineLst.Rows[medicineList.IndexOf(currentName)];
            medicineLst.Rows.RemoveAt(medicineList.IndexOf(currentName));
            medicineLst.Rows.Insert(0, r);
            medicineList.RemoveAt(medicineList.IndexOf(currentName));
            medicineList.Insert(0, currentName);
            medicineLst.CurrentCell = null;
            isLocked = false;
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

        public void continuousMStop(int index)
        {
            DataGridViewRow row = (DataGridViewRow)medicineData.Rows[index];
            row.Cells[operatingSum].Value = stopSign;
            for (int i = operatingSum + 1; i <= (int)((sum - 1) / 5); i++)
                row.Cells[i].Value = "";

            this.medicineData.Rows.RemoveAt(index);
            this.medicineData.Rows.Insert(0, row);

            for (int i = 0; i < medicineOnList.Count; i++)
            {
                if (medicineOnList[i].MedicineID == medicineList[index].Split(' ')[0])
                    medicineOnList.RemoveAt(i);
            }

            //药物名称重新排序
            DataGridViewRow r = (DataGridViewRow)medicineLst.Rows[index];
            medicineLst.Rows.RemoveAt(index);
            medicineLst.Rows.Insert(0, r);
            medicineList.Insert(0, medicineList[index]);
            medicineList.RemoveAt(index+1);
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

        //随timer添加剂量（for连续输注）
        private void drawMedicineData()
        {
            //空白行
            DataGridViewRow row = (DataGridViewRow)medicineData.Rows[medicineList.Count];
            row.Cells[(sum - 1) / 5].Value = "";
            medicineData.Rows.RemoveAt(medicineList.Count);
            medicineData.Rows.Insert(medicineList.Count, row);

            for(int i = 0; i < medicineOnList.Count && !isLocked; i++)
            {
                //写进资料库
                AnesthesiaMedicineRecord a = medicineOnList[i];
                //a.Time = sum;
                a.Time = time;
                medicineRecordRepository.insertMRecord(a);

                //剂量
                string currentId = medicineOnList[i].MedicineID + " " + medicineOnList[i].ActualAmount;
                DataGridViewRow row1 = (DataGridViewRow)medicineData.Rows[medicineList.IndexOf(currentId)];
                
                if (row1.Cells[(sum - 1) / 5].Value == null)
                    row1.Cells[(sum - 1) / 5].Value = continuousSign;

                medicineData.Rows.RemoveAt(medicineList.IndexOf(currentId));
                medicineData.Rows.Insert(medicineList.IndexOf(currentId), row1);
            }

            if (!stop_flag)
                medicineData.CurrentCell = medicineData.Rows[0].Cells[medicineData.Columns.Count - 1];

            foreach (DataGridViewColumn gCol in medicineData.Columns)
                gCol.Width = this.medicineData.Width / ((int)chart.ChartAreas[0].AxisX.ScaleView.Size / 5);

            
        }

        //timer事件
        private void t_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                chart.Series[0].Points.Clear();
                chart.ChartAreas[0].AxisX.LabelStyle.Enabled = true;
            }
            string timeString = time.ToString("HH:mm:ss");
            range = r.Next(140, 200);    //随机取数 
            range1 = r1.Next(90, 120);
            range2 = r2.Next(60, 100);
            series1.Points.AddXY(timeString, range);   //设置series点    
            series2.Points.AddXY(timeString, range1);
            series3.Points.AddXY(timeString, range2);
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

            time = time.AddSeconds(5);

        }

        private void patientDetail_Click(object sender, EventArgs e)
        {
            AnesthesiaDataRepository adr = new AnesthesiaDataRepository();
            
            Debug.WriteLine(adr.SelectByAnesthesiaID(StaticPatient.AnesthesiaID).AnesthesiaID);
            PatientDetail detail = new PatientDetail();
            detail.Owner = this;
            detail.ChangeButton();
            detail.ShowDialog();
        }
        
        private void medicineRecord_Click(object sender, EventArgs e)
        {
            operatingSum = (int)((sum - 1) / 5);
            MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(this);
            medicineDataAddForm_InListView.ShowDialog();
        }

        private void timeRecord_Click(object sender, EventArgs e)
        {
            TimeRecordForm_inListChart timeRecordForm_InListChart = new TimeRecordForm_inListChart();
            timeRecordForm_InListChart.ShowDialog();
        }

        private void chart_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == ChartElementType.DataPoint)
            {
                this.Cursor = Cursors.Hand;
                pointIndex = e.HitTestResult.PointIndex;
                dp = e.HitTestResult.Series.Points[pointIndex];
                isOnPoint = true;
                seriesName = e.HitTestResult.Series.Name;
            }
            else
            {
                this.Cursor = Cursors.Default;
                isOnPoint = false;
            }
        }

        private void chart_MouseClick(object sender, MouseEventArgs e)
        {
            if (isOnPoint)
            {
                Debug.WriteLine(dp.XValue);
                ChangePoint changePoint = new ChangePoint();
                changePoint.Owner = this;
                changePoint.SetValue(dp.XValue, dp.YValues[0], seriesName, pointIndex);
                changePoint.Show();
            }
        }

        //修改数据点
        public void ChangePoint(double y, String type, int time)
        {
            Series[] series = { series1, series2, series3 };
            foreach(Series s in series)
            {
                if(s.Name.Equals(type))
                {
                    s.Points[time].SetValueY(y);
                }
            }
        }
        
        private void medicineData_DoubleClick(object sender, EventArgs e)
        {
            operatingSum = medicineData.CurrentCell.ColumnIndex;
            operatingIndex = medicineData.CurrentCell.RowIndex;
            if (medicineData.CurrentCell.RowIndex == medicineData.Rows.Count-1)
            {
                MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(this);
                medicineDataAddForm_InListView.ShowDialog();
            }
            else
            {
                Medicinedata m = medicineDataRepository.selectById(medicineList[medicineData.CurrentCell.RowIndex].Split(' ')[0]);
                if(m.Method == 1)
                    m.Unit = medicineList[medicineData.CurrentCell.RowIndex].Split(' ')[1] + " " + medicineList[medicineData.CurrentCell.RowIndex].Split(' ')[2];

                //判斷注射方式
                if (m.Method == 0)
                {
                    //所操作的單元格為空則默認新增
                    if (medicineData.CurrentCell.Value == null)
                    {
                        MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(m, this, 0);
                        medicineDataAddForm_InListView.ShowDialog();
                    }
                    //若不為空則跳出視窗供使用者選擇 刪除/修改
                    else
                    {
                        MedicineRecordEdit medicineRecordEdit = new MedicineRecordEdit(m, this, 0);
                        medicineRecordEdit.ShowDialog();
                    }
                }
                else
                {
                    //所操作的單元格為空則默認新增
                    if (medicineData.CurrentCell.Value == null)
                    {
                        MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(m, this, 0);
                        medicineDataAddForm_InListView.ShowDialog();
                    }
                    //若不為空則跳出視窗供使用者選擇 刪除/修改
                    else
                    {
                        MedicineRecordEdit medicineRecordEdit = new MedicineRecordEdit(m, this);
                        medicineRecordEdit.ShowDialog();
                    }
                }
            }
        }

        //删除某条药物记录
        public void deleteRecord()
        {
            Medicinedata m = medicineDataRepository.selectById(medicineList[operatingIndex].Split()[0]);

            if (m.Method == 1)
            {
                medicineData.Rows[operatingIndex].Cells[operatingSum].Value = "1";
                int backward = operatingSum;
                int forward = operatingSum + 1;
                while (medicineData.Rows[operatingIndex].Cells[backward].Value != null
                    && !medicineData.Rows[operatingIndex].Cells[backward].Value.Equals(stopSign))
                {
                    medicineData.Rows[operatingIndex].Cells[backward].Value = "";
                    backward--;
                    if (backward < 0)
                        break;
                }
                while (forward < medicineData.ColumnCount &&
                    (medicineData.Rows[operatingIndex].Cells[forward].Value != null
                    && (medicineData.Rows[operatingIndex].Cells[forward].Value.Equals(continuousSign)
                    || medicineData.Rows[operatingIndex].Cells[forward].Value.Equals(stopSign))))
                {
                    medicineData.Rows[operatingIndex].Cells[forward].Value = "";
                    forward++;
                    if (forward >= medicineData.ColumnCount)
                    {
                        for (int i = 0; i < medicineOnList.Count; i++)
                        {
                            if (medicineOnList[i].MedicineID.Equals(medicineList[operatingIndex].Split()[0]))
                                medicineOnList.RemoveAt(i);
                        }
                        break;
                    }
                }

                if (forward >= medicineData.ColumnCount)
                {
                    for (int i = 0; i < medicineOnList.Count; i++)
                    {
                        if (medicineOnList[i].MedicineID.Equals(medicineList[operatingIndex].Split()[0]))
                            medicineOnList.RemoveAt(i);
                    }
                }

            }
            else
                medicineData.Rows[operatingIndex].Cells[operatingSum].Value = "";
        }

        public void setStop()
        {
            if (medicineData.Rows[operatingIndex].Cells[operatingSum].Value != null
                   && (!medicineData.Rows[operatingIndex].Cells[operatingSum].Value.Equals(continuousSign)
                   && !medicineData.Rows[operatingIndex].Cells[operatingSum].Value.Equals(stopSign)))
                medicineData.Rows[operatingIndex].Cells[operatingSum].Value 
                    = medicineData.Rows[operatingIndex].Cells[operatingSum].Value.ToString().Split(' ')[0]
                    + medicineData.Rows[operatingIndex].Cells[operatingSum].Value.ToString().Split(' ')[1]
                    + " ——————————▌";
            else
                medicineData.Rows[operatingIndex].Cells[operatingSum].Value = stopSign;

            operatingSum++;

            while (operatingSum < medicineData.ColumnCount &&
                   (medicineData.Rows[operatingIndex].Cells[operatingSum].Value != null
                   && (medicineData.Rows[operatingIndex].Cells[operatingSum].Value.Equals(continuousSign)
                   || medicineData.Rows[operatingIndex].Cells[operatingSum].Value.Equals(stopSign))))
            {
                medicineData.Rows[operatingIndex].Cells[operatingSum].Value = null;
                operatingSum++;
                if (operatingSum >= medicineData.ColumnCount)
                    break;
            }

            if (operatingSum >= medicineData.ColumnCount)
            {
                for (int i = 0; i < medicineOnList.Count; i++)
                {
                    if (medicineOnList[i].MedicineID.Equals(medicineList[operatingIndex].Split(' ')[0]))
                        medicineOnList.RemoveAt(i);
                }
            }
        }

        public void setContinue()
        {
            AnesthesiaMedicineRecord a = new AnesthesiaMedicineRecord();
            a.MedicineID = medicineList[operatingIndex].Split(' ')[0];
            a.ActualAmount = medicineList[operatingIndex].Split(' ')[1] + " " + medicineList[operatingIndex].Split(' ')[2];
            a.AnesthesiaID = StaticPatient.AnesthesiaID;

            addMedicine(medicineRecordRepository.findNewestRecord(a));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SavePatientData();
            SaveOperationData();
        }

        //結束後保存手術資料
        private void SaveOperationData()
        {
            new AnesthesiaDataRepository().SetOperationEndTime(StaticPatient.AnesthesiaID);
        }

        //結束後保存病人資料
        private void SavePatientData()
        {
            StaticPatient.patient.Comment = StaticPatient.patient.Comment + "\n" 
                + DateTime.Now.ToString("yyyy-MM-dd") + ":\n"
                + StaticPatient.newComment;
            StaticPatient.newComment = "";
            patientBasicRepository.saveOnePatient(StaticPatient.patient);
        }

        private void medicineLst_DoubleClick(object sender, EventArgs e)
        {
            operatingSum = (int)((sum - 1)/5);
            operatingIndex = medicineLst.CurrentCell.RowIndex;
            try
            {
                Medicinedata m = medicineDataRepository.selectById(medicineList[medicineLst.CurrentCell.RowIndex].Split(' ')[0]);
                if (m.Method == 0)
                {
                    MedicineRecordOperation medicineRecordOperation = new MedicineRecordOperation(this.medicineLst.CurrentCell.RowIndex,
                                                                    medicineDataRepository.selectById(medicineList[this.medicineLst.
                                                                    CurrentCell.RowIndex].Split(' ')[0]), this, 2);
                    medicineRecordOperation.ShowDialog();
                }
                else
                {
                    if(medicineOnList.Exists(x => x.MedicineID.Equals(m.MId)))
                    {
                        MedicineRecordOperation medicineRecordOperation = new MedicineRecordOperation(this.medicineLst.CurrentCell.RowIndex,
                                                                    medicineDataRepository.selectById(medicineList[this.medicineLst.
                                                                    CurrentCell.RowIndex].Split(' ')[0]), this, 1);
                        medicineRecordOperation.ShowDialog();
                    }
                    else
                    {
                        MedicineRecordOperation medicineRecordOperation = new MedicineRecordOperation(this.medicineLst.CurrentCell.RowIndex,
                                                                    medicineDataRepository.selectById(medicineList[this.medicineLst.
                                                                    CurrentCell.RowIndex].Split(' ')[0]), this, 0);
                        medicineRecordOperation.ShowDialog();
                    }
                }
            }
            catch(Exception)
            {
                MedicineDataAddForm_InListView medicineDataAddForm_InListView = new MedicineDataAddForm_InListView(this);
                medicineDataAddForm_InListView.ShowDialog();
            }
            this.medicineLst.CurrentCell = null;
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

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            StaticPatient.AnesthesiaID = null;
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ModifyDataSeries m = new ModifyDataSeries();
            Series[] data = { series1, series2, series3 };
            m.Owner = this;
            m.LoadView(data);
            m.Show();
        }

        //切换停止开始按钮
        private void button_Stop_Click(object sender, EventArgs e)  
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

        //病人资料显示
        private void BasicDataShow()
        {

            birthdayd.Text = patient.BirthDate.ToString();
            named.Text = patient.Name;
            chartnd.Text = patient.CharNo;

        }

        //重新获得焦点 更新病人资料
        private void MainView_Activated(object sender, EventArgs e)
        {
            patient = StaticPatient.patient;
            BasicDataShow();
        }

        public void StartMain()
        {
            if (!StaticPatient.AnesthesiaID.Equals(""))
                Pick();
            else
                mainView_Load();
            
        }

        private void Pick()
        {
            new PatientData(false).Show();
            this.Hide();
        }

        private void mainView_Load()
        {
            this.MaximumSize = new Size(this.Width, this.Height);
            x = this.Size.Width - this.MinimumSize.Width;
            l = this.MaximumSize.Width - this.MinimumSize.Width;
            CreateChart();
            //CreateMedicineChart();
            createSeries();
            createViewList();
            BasicDataShow();
            //medicineLst_init();
            t.Start();
        }

        private void SetButtomsInvalid()
        {
            patientDetail.Enabled = false;
            button_Stop.Enabled = false;
            medicineRecord.Enabled = false;
            timeRecord.Enabled = false;
            changeData.Enabled = false;
            endIt.Enabled = false;
        }
        private void SetButtomsValid()
        {
            patientDetail.Enabled = true;
            button_Stop.Enabled = true;
            medicineRecord.Enabled = true;
            timeRecord.Enabled = true;
            changeData.Enabled = true;
            endIt.Enabled = true;
        }

        public void ChangeSeries(Series[] series)
        {
            series1 = series[0];
            series2 = series[1];
            series3 = series[2];
        }

    }

}
