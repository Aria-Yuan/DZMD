
namespace WindowsFormsApp1
{
    partial class MainView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.medicineData = new System.Windows.Forms.DataGridView();
            this.medicineLst = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timeRecord = new System.Windows.Forms.Button();
            this.medicineRecord = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Stop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.patientData = new System.Windows.Forms.Panel();
            this.birthdayd = new System.Windows.Forms.Label();
            this.named = new System.Windows.Forms.Label();
            this.chartnd = new System.Windows.Forms.Label();
            this.patientDetail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineLst)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.patientData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CausesValidation = false;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 349F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1031F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1901, 1031);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.chart, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(352, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1546, 1027);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1546, 564);
            this.chart.TabIndex = 19;
            this.chart.Text = "chart1";
            this.chart.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart_GetToolTipText);
            this.chart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart_MouseClick);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel6.Controls.Add(this.medicineData, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.medicineLst, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 566);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1540, 459);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // medicineData
            // 
            this.medicineData.AllowUserToAddRows = false;
            this.medicineData.AllowUserToDeleteRows = false;
            this.medicineData.AllowUserToResizeColumns = false;
            this.medicineData.AllowUserToResizeRows = false;
            this.medicineData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medicineData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineData.ColumnHeadersVisible = false;
            this.medicineData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineData.Location = new System.Drawing.Point(154, 2);
            this.medicineData.Margin = new System.Windows.Forms.Padding(0, 2, 15, 2);
            this.medicineData.MultiSelect = false;
            this.medicineData.Name = "medicineData";
            this.medicineData.RowHeadersVisible = false;
            this.medicineData.RowTemplate.Height = 25;
            this.medicineData.RowTemplate.ReadOnly = true;
            this.medicineData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.medicineData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.medicineData.Size = new System.Drawing.Size(1371, 455);
            this.medicineData.TabIndex = 1;
            this.medicineData.DoubleClick += new System.EventHandler(this.medicineData_DoubleClick);
            // 
            // medicineLst
            // 
            this.medicineLst.AllowUserToAddRows = false;
            this.medicineLst.AllowUserToDeleteRows = false;
            this.medicineLst.AllowUserToResizeColumns = false;
            this.medicineLst.AllowUserToResizeRows = false;
            this.medicineLst.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.medicineLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicineLst.ColumnHeadersVisible = false;
            this.medicineLst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineLst.Location = new System.Drawing.Point(3, 2);
            this.medicineLst.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.medicineLst.Name = "medicineLst";
            this.medicineLst.RowHeadersVisible = false;
            this.medicineLst.RowTemplate.Height = 25;
            this.medicineLst.RowTemplate.ReadOnly = true;
            this.medicineLst.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.medicineLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.medicineLst.Size = new System.Drawing.Size(151, 455);
            this.medicineLst.TabIndex = 2;
            this.medicineLst.DoubleClick += new System.EventHandler(this.medicineLst_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 1027);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.timeRecord, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.medicineRecord, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 542);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(36, 0, 36, 0);
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(337, 286);
            this.tableLayoutPanel5.TabIndex = 29;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(45, 151);
            this.button5.Margin = new System.Windows.Forms.Padding(9);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5);
            this.button5.Size = new System.Drawing.Size(247, 53);
            this.button5.TabIndex = 5;
            this.button5.Text = "保留";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(45, 222);
            this.button3.Margin = new System.Windows.Forms.Padding(9);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(247, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "手術結束";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // timeRecord
            // 
            this.timeRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRecord.Location = new System.Drawing.Point(45, 80);
            this.timeRecord.Margin = new System.Windows.Forms.Padding(9);
            this.timeRecord.Name = "timeRecord";
            this.timeRecord.Padding = new System.Windows.Forms.Padding(5);
            this.timeRecord.Size = new System.Drawing.Size(247, 53);
            this.timeRecord.TabIndex = 2;
            this.timeRecord.Text = "事件記錄";
            this.timeRecord.UseVisualStyleBackColor = true;
            this.timeRecord.Click += new System.EventHandler(this.timeRecord_Click);
            // 
            // medicineRecord
            // 
            this.medicineRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medicineRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineRecord.Location = new System.Drawing.Point(45, 9);
            this.medicineRecord.Margin = new System.Windows.Forms.Padding(9);
            this.medicineRecord.Name = "medicineRecord";
            this.medicineRecord.Padding = new System.Windows.Forms.Padding(5);
            this.medicineRecord.Size = new System.Drawing.Size(247, 53);
            this.medicineRecord.TabIndex = 0;
            this.medicineRecord.Text = "藥物記錄";
            this.medicineRecord.UseVisualStyleBackColor = true;
            this.medicineRecord.Click += new System.EventHandler(this.medicineRecord_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.patientData, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 536);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button_Stop);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel2.Size = new System.Drawing.Size(331, 136);
            this.panel2.TabIndex = 25;
            // 
            // button_Stop
            // 
            this.button_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Stop.Location = new System.Drawing.Point(219, 79);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(97, 44);
            this.button_Stop.TabIndex = 25;
            this.button_Stop.Text = "暫停滾動";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(0, 20);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(327, 56);
            this.trackBar1.TabIndex = 24;
            this.trackBar1.Tag = "";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // patientData
            // 
            this.patientData.BackColor = System.Drawing.SystemColors.Control;
            this.patientData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.patientData.Controls.Add(this.birthdayd);
            this.patientData.Controls.Add(this.named);
            this.patientData.Controls.Add(this.chartnd);
            this.patientData.Controls.Add(this.patientDetail);
            this.patientData.Controls.Add(this.label5);
            this.patientData.Controls.Add(this.label6);
            this.patientData.Controls.Add(this.label7);
            this.patientData.Controls.Add(this.label8);
            this.patientData.Controls.Add(this.label9);
            this.patientData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientData.Location = new System.Drawing.Point(3, 2);
            this.patientData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientData.Name = "patientData";
            this.patientData.Size = new System.Drawing.Size(331, 149);
            this.patientData.TabIndex = 14;
            // 
            // birthdayd
            // 
            this.birthdayd.AutoSize = true;
            this.birthdayd.Location = new System.Drawing.Point(65, 96);
            this.birthdayd.Name = "birthdayd";
            this.birthdayd.Size = new System.Drawing.Size(46, 17);
            this.birthdayd.TabIndex = 8;
            this.birthdayd.Text = "label3";
            // 
            // named
            // 
            this.named.AutoSize = true;
            this.named.Location = new System.Drawing.Point(65, 58);
            this.named.Name = "named";
            this.named.Size = new System.Drawing.Size(46, 17);
            this.named.TabIndex = 7;
            this.named.Text = "label2";
            // 
            // chartnd
            // 
            this.chartnd.AutoSize = true;
            this.chartnd.Location = new System.Drawing.Point(65, 20);
            this.chartnd.Name = "chartnd";
            this.chartnd.Size = new System.Drawing.Size(46, 17);
            this.chartnd.TabIndex = 6;
            this.chartnd.Text = "label1";
            // 
            // patientDetail
            // 
            this.patientDetail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDetail.Location = new System.Drawing.Point(279, 108);
            this.patientDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientDetail.Name = "patientDetail";
            this.patientDetail.Size = new System.Drawing.Size(37, 23);
            this.patientDetail.TabIndex = 5;
            this.patientDetail.Text = "...";
            this.patientDetail.UseVisualStyleBackColor = true;
            this.patientDetail.Click += new System.EventHandler(this.patientDetail_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "床號：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "科別：";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "生日：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "姓名：";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "病歷號：";
            // 
            // t
            // 
            this.t.Interval = 1000;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 1031);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1917, 1033);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            this.Load += new System.EventHandler(this.mainView_Load);
            this.SizeChanged += new System.EventHandler(this.mainView_SizeChanged);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicineData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineLst)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.patientData.ResumeLayout(false);
            this.patientData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel patientData;
        private System.Windows.Forms.Button patientDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button timeRecord;
        private System.Windows.Forms.Button medicineRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView medicineData;
        private System.Windows.Forms.Label birthdayd;
        private System.Windows.Forms.Label named;
        private System.Windows.Forms.Label chartnd;
        private System.Windows.Forms.DataGridView medicineLst;
    }
}

