namespace WindowsFormsApp1
{
    partial class MedicineDataAddForm_InListView
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
            this.medicineName = new System.Windows.Forms.Label();
            this.Mname = new System.Windows.Forms.ComboBox();
            this.dose = new System.Windows.Forms.Label();
            this.NMvalue = new System.Windows.Forms.TextBox();
            this.comfirm = new System.Windows.Forms.Button();
            this.doseUnit = new System.Windows.Forms.Label();
            this.NMunit = new System.Windows.Forms.ComboBox();
            this.MCunit = new System.Windows.Forms.ComboBox();
            this.concentrationUnit = new System.Windows.Forms.Label();
            this.MCvalue = new System.Windows.Forms.TextBox();
            this.concentration = new System.Windows.Forms.Label();
            this.MRunit = new System.Windows.Forms.ComboBox();
            this.flowRateUnit = new System.Windows.Forms.Label();
            this.MRvalue = new System.Windows.Forms.TextBox();
            this.flowRate = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startTLabel = new System.Windows.Forms.Label();
            this.StartDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.endDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // medicineName
            // 
            this.medicineName.AutoSize = true;
            this.medicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineName.Location = new System.Drawing.Point(86, 190);
            this.medicineName.Name = "medicineName";
            this.medicineName.Size = new System.Drawing.Size(77, 20);
            this.medicineName.TabIndex = 0;
            this.medicineName.Text = "藥物種類:";
            // 
            // Mname
            // 
            this.Mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.FormattingEnabled = true;
            this.Mname.Location = new System.Drawing.Point(160, 187);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(140, 28);
            this.Mname.TabIndex = 1;
            this.Mname.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dose
            // 
            this.dose.AutoSize = true;
            this.dose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dose.Location = new System.Drawing.Point(352, 190);
            this.dose.Name = "dose";
            this.dose.Size = new System.Drawing.Size(45, 20);
            this.dose.TabIndex = 2;
            this.dose.Text = "劑量:";
            // 
            // NMvalue
            // 
            this.NMvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMvalue.Location = new System.Drawing.Point(404, 187);
            this.NMvalue.Name = "NMvalue";
            this.NMvalue.Size = new System.Drawing.Size(100, 26);
            this.NMvalue.TabIndex = 3;
            // 
            // comfirm
            // 
            this.comfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comfirm.Location = new System.Drawing.Point(596, 331);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(82, 42);
            this.comfirm.TabIndex = 4;
            this.comfirm.Text = "確認";
            this.comfirm.UseVisualStyleBackColor = true;
            this.comfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // doseUnit
            // 
            this.doseUnit.AutoSize = true;
            this.doseUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doseUnit.Location = new System.Drawing.Point(520, 190);
            this.doseUnit.Name = "doseUnit";
            this.doseUnit.Size = new System.Drawing.Size(45, 20);
            this.doseUnit.TabIndex = 6;
            this.doseUnit.Text = "单位:";
            // 
            // NMunit
            // 
            this.NMunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMunit.FormattingEnabled = true;
            this.NMunit.Location = new System.Drawing.Point(579, 187);
            this.NMunit.Name = "NMunit";
            this.NMunit.Size = new System.Drawing.Size(92, 28);
            this.NMunit.TabIndex = 7;
            // 
            // MCunit
            // 
            this.MCunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCunit.FormattingEnabled = true;
            this.MCunit.Location = new System.Drawing.Point(579, 187);
            this.MCunit.Name = "MCunit";
            this.MCunit.Size = new System.Drawing.Size(99, 28);
            this.MCunit.TabIndex = 11;
            this.MCunit.Visible = false;
            // 
            // concentrationUnit
            // 
            this.concentrationUnit.AutoSize = true;
            this.concentrationUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentrationUnit.Location = new System.Drawing.Point(528, 190);
            this.concentrationUnit.Name = "concentrationUnit";
            this.concentrationUnit.Size = new System.Drawing.Size(45, 20);
            this.concentrationUnit.TabIndex = 10;
            this.concentrationUnit.Text = "单位:";
            this.concentrationUnit.Visible = false;
            // 
            // MCvalue
            // 
            this.MCvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCvalue.Location = new System.Drawing.Point(404, 187);
            this.MCvalue.Name = "MCvalue";
            this.MCvalue.Size = new System.Drawing.Size(100, 26);
            this.MCvalue.TabIndex = 9;
            this.MCvalue.Visible = false;
            // 
            // concentration
            // 
            this.concentration.AutoSize = true;
            this.concentration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentration.Location = new System.Drawing.Point(324, 190);
            this.concentration.Name = "concentration";
            this.concentration.Size = new System.Drawing.Size(77, 20);
            this.concentration.TabIndex = 8;
            this.concentration.Text = "注射浓度:";
            this.concentration.Visible = false;
            // 
            // MRunit
            // 
            this.MRunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRunit.FormattingEnabled = true;
            this.MRunit.Location = new System.Drawing.Point(579, 255);
            this.MRunit.Name = "MRunit";
            this.MRunit.Size = new System.Drawing.Size(99, 28);
            this.MRunit.TabIndex = 15;
            this.MRunit.Visible = false;
            // 
            // flowRateUnit
            // 
            this.flowRateUnit.AutoSize = true;
            this.flowRateUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowRateUnit.Location = new System.Drawing.Point(528, 258);
            this.flowRateUnit.Name = "flowRateUnit";
            this.flowRateUnit.Size = new System.Drawing.Size(45, 20);
            this.flowRateUnit.TabIndex = 14;
            this.flowRateUnit.Text = "单位:";
            this.flowRateUnit.Visible = false;
            // 
            // MRvalue
            // 
            this.MRvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRvalue.Location = new System.Drawing.Point(404, 255);
            this.MRvalue.Name = "MRvalue";
            this.MRvalue.Size = new System.Drawing.Size(100, 26);
            this.MRvalue.TabIndex = 13;
            this.MRvalue.Visible = false;
            // 
            // flowRate
            // 
            this.flowRate.AutoSize = true;
            this.flowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowRate.Location = new System.Drawing.Point(324, 258);
            this.flowRate.Name = "flowRate";
            this.flowRate.Size = new System.Drawing.Size(77, 20);
            this.flowRate.TabIndex = 12;
            this.flowRate.Text = "注射流速:";
            this.flowRate.Visible = false;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel.Location = new System.Drawing.Point(395, 88);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(81, 20);
            this.endTimeLabel.TabIndex = 16;
            this.endTimeLabel.Text = "結束時間：";
            // 
            // startTLabel
            // 
            this.startTLabel.AutoSize = true;
            this.startTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTLabel.Location = new System.Drawing.Point(86, 88);
            this.startTLabel.Name = "startTLabel";
            this.startTLabel.Size = new System.Drawing.Size(77, 20);
            this.startTLabel.TabIndex = 17;
            this.startTLabel.Text = "開始時間:";
            // 
            // StartDomainUpDown
            // 
            this.StartDomainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDomainUpDown.Location = new System.Drawing.Point(169, 86);
            this.StartDomainUpDown.Name = "StartDomainUpDown";
            this.StartDomainUpDown.Size = new System.Drawing.Size(200, 26);
            this.StartDomainUpDown.TabIndex = 21;
            this.StartDomainUpDown.Text = "請選擇時間";
            this.StartDomainUpDown.Visible = false;
            this.StartDomainUpDown.TextChanged += new System.EventHandler(this.StartDomainUpDown_TextChanged);
            // 
            // endDomainUpDown
            // 
            this.endDomainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDomainUpDown.Location = new System.Drawing.Point(478, 86);
            this.endDomainUpDown.Name = "endDomainUpDown";
            this.endDomainUpDown.Size = new System.Drawing.Size(200, 26);
            this.endDomainUpDown.TabIndex = 22;
            this.endDomainUpDown.Text = "請選擇時間";
            this.endDomainUpDown.Visible = false;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeTextBox.Location = new System.Drawing.Point(169, 86);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(200, 26);
            this.startTimeTextBox.TabIndex = 23;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeTextBox.Location = new System.Drawing.Point(478, 86);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(200, 26);
            this.endTimeTextBox.TabIndex = 24;
            // 
            // MedicineDataAddForm_InListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 416);
            this.Controls.Add(this.endTimeTextBox);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.endDomainUpDown);
            this.Controls.Add(this.StartDomainUpDown);
            this.Controls.Add(this.startTLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.MRunit);
            this.Controls.Add(this.flowRateUnit);
            this.Controls.Add(this.MRvalue);
            this.Controls.Add(this.flowRate);
            this.Controls.Add(this.MCunit);
            this.Controls.Add(this.concentrationUnit);
            this.Controls.Add(this.MCvalue);
            this.Controls.Add(this.concentration);
            this.Controls.Add(this.NMunit);
            this.Controls.Add(this.doseUnit);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.NMvalue);
            this.Controls.Add(this.dose);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.medicineName);
            this.Name = "MedicineDataAddForm_InListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加藥物";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label medicineName;
        private System.Windows.Forms.ComboBox Mname;
        private System.Windows.Forms.Label dose;
        private System.Windows.Forms.TextBox NMvalue;
        private System.Windows.Forms.Button comfirm;
        private System.Windows.Forms.Label doseUnit;
        private System.Windows.Forms.ComboBox NMunit;
        private System.Windows.Forms.ComboBox MCunit;
        private System.Windows.Forms.Label concentrationUnit;
        private System.Windows.Forms.TextBox MCvalue;
        private System.Windows.Forms.Label concentration;
        private System.Windows.Forms.ComboBox MRunit;
        private System.Windows.Forms.Label flowRateUnit;
        private System.Windows.Forms.TextBox MRvalue;
        private System.Windows.Forms.Label flowRate;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label startTLabel;
        private System.Windows.Forms.DomainUpDown StartDomainUpDown;
        private System.Windows.Forms.DomainUpDown endDomainUpDown;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
    }
}