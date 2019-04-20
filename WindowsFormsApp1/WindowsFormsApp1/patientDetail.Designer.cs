namespace WindowsFormsApp1
{
    partial class patientDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.next = new System.Windows.Forms.Button();
            this.chartNol = new System.Windows.Forms.Label();
            this.patientIdl = new System.Windows.Forms.Label();
            this.heightl = new System.Windows.Forms.Label();
            this.weightl = new System.Windows.Forms.Label();
            this.namel = new System.Windows.Forms.Label();
            this.bloodl = new System.Windows.Forms.Label();
            this.historyl = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.birthdayl = new System.Windows.Forms.Label();
            this.revert = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.blood = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.chartNo = new System.Windows.Forms.Label();
            this.patientId = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.next.Location = new System.Drawing.Point(520, 30);
            this.next.Margin = new System.Windows.Forms.Padding(30, 30, 10, 30);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(110, 50);
            this.next.TabIndex = 0;
            this.next.Text = "下一步";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // chartNol
            // 
            this.chartNol.AutoSize = true;
            this.chartNol.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartNol.Location = new System.Drawing.Point(635, 89);
            this.chartNol.Name = "chartNol";
            this.chartNol.Size = new System.Drawing.Size(123, 35);
            this.chartNol.TabIndex = 1;
            this.chartNol.Text = "病歷號：";
            // 
            // patientIdl
            // 
            this.patientIdl.AutoSize = true;
            this.patientIdl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdl.Location = new System.Drawing.Point(635, 165);
            this.patientIdl.Name = "patientIdl";
            this.patientIdl.Size = new System.Drawing.Size(231, 35);
            this.patientIdl.TabIndex = 2;
            this.patientIdl.Text = "病患身份證字號：";
            // 
            // heightl
            // 
            this.heightl.AutoSize = true;
            this.heightl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.heightl.Location = new System.Drawing.Point(635, 524);
            this.heightl.Name = "heightl";
            this.heightl.Size = new System.Drawing.Size(117, 26);
            this.heightl.TabIndex = 3;
            this.heightl.Text = "病患身高：";
            // 
            // weightl
            // 
            this.weightl.AutoSize = true;
            this.weightl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.weightl.Location = new System.Drawing.Point(923, 524);
            this.weightl.Name = "weightl";
            this.weightl.Size = new System.Drawing.Size(117, 26);
            this.weightl.TabIndex = 4;
            this.weightl.Text = "病患體重：";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.namel.Location = new System.Drawing.Point(635, 267);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(117, 26);
            this.namel.TabIndex = 5;
            this.namel.Text = "病患姓名：";
            // 
            // bloodl
            // 
            this.bloodl.AutoSize = true;
            this.bloodl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bloodl.Location = new System.Drawing.Point(635, 355);
            this.bloodl.Name = "bloodl";
            this.bloodl.Size = new System.Drawing.Size(117, 26);
            this.bloodl.TabIndex = 6;
            this.bloodl.Text = "病患血型：";
            // 
            // historyl
            // 
            this.historyl.AutoSize = true;
            this.historyl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.historyl.Location = new System.Drawing.Point(635, 619);
            this.historyl.Name = "historyl";
            this.historyl.Size = new System.Drawing.Size(159, 26);
            this.historyl.TabIndex = 7;
            this.historyl.Text = "病患醫療記錄：";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(10, 30);
            this.back.Margin = new System.Windows.Forms.Padding(10, 30, 30, 30);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(110, 50);
            this.back.TabIndex = 8;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // birthdayl
            // 
            this.birthdayl.AutoSize = true;
            this.birthdayl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.birthdayl.Location = new System.Drawing.Point(635, 440);
            this.birthdayl.Name = "birthdayl";
            this.birthdayl.Size = new System.Drawing.Size(159, 26);
            this.birthdayl.TabIndex = 16;
            this.birthdayl.Text = "病患出生日期：";
            // 
            // revert
            // 
            this.revert.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.revert.Location = new System.Drawing.Point(180, 30);
            this.revert.Margin = new System.Windows.Forms.Padding(30);
            this.revert.Name = "revert";
            this.revert.Size = new System.Drawing.Size(110, 50);
            this.revert.TabIndex = 18;
            this.revert.Text = "复原";
            this.revert.UseVisualStyleBackColor = true;
            this.revert.Click += new System.EventHandler(this.revert_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.save.Location = new System.Drawing.Point(350, 30);
            this.save.Margin = new System.Windows.Forms.Padding(30);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 50);
            this.save.TabIndex = 19;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(758, 267);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 34);
            this.name.TabIndex = 22;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // blood
            // 
            this.blood.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.blood.Location = new System.Drawing.Point(758, 355);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(100, 34);
            this.blood.TabIndex = 23;
            this.blood.TextChanged += new System.EventHandler(this.blood_TextChanged);
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.weight.Location = new System.Drawing.Point(1046, 524);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 34);
            this.weight.TabIndex = 25;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_KeyPress);
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.height.Location = new System.Drawing.Point(758, 524);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 34);
            this.height.TabIndex = 26;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.history.Location = new System.Drawing.Point(640, 657);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(640, 34);
            this.history.TabIndex = 27;
            this.history.TextChanged += new System.EventHandler(this.history_TextChanged);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.date.Location = new System.Drawing.Point(800, 440);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(386, 34);
            this.date.TabIndex = 28;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // chartNo
            // 
            this.chartNo.AutoSize = true;
            this.chartNo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartNo.Location = new System.Drawing.Point(764, 89);
            this.chartNo.Name = "chartNo";
            this.chartNo.Size = new System.Drawing.Size(92, 35);
            this.chartNo.TabIndex = 29;
            this.chartNo.Text = "label1";
            // 
            // patientId
            // 
            this.patientId.AutoSize = true;
            this.patientId.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientId.Location = new System.Drawing.Point(872, 165);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(92, 35);
            this.patientId.TabIndex = 30;
            this.patientId.Text = "label2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.back);
            this.flowLayoutPanel1.Controls.Add(this.revert);
            this.flowLayoutPanel1.Controls.Add(this.save);
            this.flowLayoutPanel1.Controls.Add(this.next);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(640, 850);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(640, 120);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // patientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.chartNo);
            this.Controls.Add(this.date);
            this.Controls.Add(this.history);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.blood);
            this.Controls.Add(this.name);
            this.Controls.Add(this.birthdayl);
            this.Controls.Add(this.historyl);
            this.Controls.Add(this.bloodl);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.weightl);
            this.Controls.Add(this.heightl);
            this.Controls.Add(this.patientIdl);
            this.Controls.Add(this.chartNol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "patientDetail";
            this.Text = "patientDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chartNol;
        private System.Windows.Forms.Label patientIdl;
        private System.Windows.Forms.Label heightl;
        private System.Windows.Forms.Label weightl;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label bloodl;
        private System.Windows.Forms.Label historyl;
        private System.Windows.Forms.Label birthdayl;

        private System.Windows.Forms.Label chartNo;
        private System.Windows.Forms.Label patientId;

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button revert;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button next;

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox blood;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox history;

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}