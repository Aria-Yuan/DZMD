namespace WindowsFormsApp1
{
    partial class MedicineRecordEdit
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
            this.editDose = new System.Windows.Forms.Button();
            this.setStop = new System.Windows.Forms.Button();
            this.deleteDose = new System.Windows.Forms.Button();
            this.continousMedicinePanel = new System.Windows.Forms.Panel();
            this.nameValue = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sartTimeValue = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.concentrationLabel = new System.Windows.Forms.Label();
            this.flowRateLabel = new System.Windows.Forms.Label();
            this.concentrationValue = new System.Windows.Forms.Label();
            this.endTimeValue = new System.Windows.Forms.Label();
            this.flowRateValue = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.injectionLabel = new System.Windows.Forms.Label();
            this.amountValue = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.injectionValue = new System.Windows.Forms.Label();
            this.medicineNameLabel = new System.Windows.Forms.Label();
            this.medicineNameVale = new System.Windows.Forms.Label();
            this.medicinePanel = new System.Windows.Forms.Panel();
            this.continousMedicinePanel.SuspendLayout();
            this.medicinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editDose
            // 
            this.editDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDose.Location = new System.Drawing.Point(569, 267);
            this.editDose.Margin = new System.Windows.Forms.Padding(2);
            this.editDose.Name = "editDose";
            this.editDose.Size = new System.Drawing.Size(145, 76);
            this.editDose.TabIndex = 0;
            this.editDose.Text = "修改注射劑量";
            this.editDose.UseVisualStyleBackColor = true;
            this.editDose.Click += new System.EventHandler(this.editDose_Click);
            // 
            // setStop
            // 
            this.setStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setStop.Location = new System.Drawing.Point(327, 267);
            this.setStop.Margin = new System.Windows.Forms.Padding(2);
            this.setStop.Name = "setStop";
            this.setStop.Size = new System.Drawing.Size(145, 76);
            this.setStop.TabIndex = 1;
            this.setStop.Text = "設為停止注射時間";
            this.setStop.UseVisualStyleBackColor = true;
            this.setStop.Click += new System.EventHandler(this.setStop_Click);
            // 
            // deleteDose
            // 
            this.deleteDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDose.Location = new System.Drawing.Point(84, 267);
            this.deleteDose.Margin = new System.Windows.Forms.Padding(2);
            this.deleteDose.Name = "deleteDose";
            this.deleteDose.Size = new System.Drawing.Size(145, 76);
            this.deleteDose.TabIndex = 2;
            this.deleteDose.Text = "刪除該筆資料";
            this.deleteDose.UseVisualStyleBackColor = true;
            this.deleteDose.Click += new System.EventHandler(this.deleteDose_Click);
            // 
            // continousMedicinePanel
            // 
            this.continousMedicinePanel.Controls.Add(this.nameValue);
            this.continousMedicinePanel.Controls.Add(this.nameLabel);
            this.continousMedicinePanel.Controls.Add(this.sartTimeValue);
            this.continousMedicinePanel.Controls.Add(this.endTimeLabel);
            this.continousMedicinePanel.Controls.Add(this.concentrationLabel);
            this.continousMedicinePanel.Controls.Add(this.flowRateLabel);
            this.continousMedicinePanel.Controls.Add(this.concentrationValue);
            this.continousMedicinePanel.Controls.Add(this.endTimeValue);
            this.continousMedicinePanel.Controls.Add(this.flowRateValue);
            this.continousMedicinePanel.Controls.Add(this.startTimeLabel);
            this.continousMedicinePanel.Location = new System.Drawing.Point(43, 35);
            this.continousMedicinePanel.Name = "continousMedicinePanel";
            this.continousMedicinePanel.Size = new System.Drawing.Size(713, 203);
            this.continousMedicinePanel.TabIndex = 3;
            this.continousMedicinePanel.Visible = false;
            // 
            // nameValue
            // 
            this.nameValue.AutoSize = true;
            this.nameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValue.Location = new System.Drawing.Point(129, 23);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(107, 24);
            this.nameValue.TabIndex = 20;
            this.nameValue.Text = "medicine1";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(27, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 24);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "藥品名稱";
            // 
            // sartTimeValue
            // 
            this.sartTimeValue.AutoSize = true;
            this.sartTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sartTimeValue.Location = new System.Drawing.Point(164, 82);
            this.sartTimeValue.Name = "sartTimeValue";
            this.sartTimeValue.Size = new System.Drawing.Size(165, 24);
            this.sartTimeValue.TabIndex = 18;
            this.sartTimeValue.Text = "2019/5/16 12:45:12";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel.Location = new System.Drawing.Point(393, 82);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(96, 24);
            this.endTimeLabel.TabIndex = 17;
            this.endTimeLabel.Text = "結束時間：";
            // 
            // concentrationLabel
            // 
            this.concentrationLabel.AutoSize = true;
            this.concentrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentrationLabel.Location = new System.Drawing.Point(62, 145);
            this.concentrationLabel.Name = "concentrationLabel";
            this.concentrationLabel.Size = new System.Drawing.Size(96, 24);
            this.concentrationLabel.TabIndex = 16;
            this.concentrationLabel.Text = "注射濃度：";
            // 
            // flowRateLabel
            // 
            this.flowRateLabel.AutoSize = true;
            this.flowRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowRateLabel.Location = new System.Drawing.Point(393, 145);
            this.flowRateLabel.Name = "flowRateLabel";
            this.flowRateLabel.Size = new System.Drawing.Size(96, 24);
            this.flowRateLabel.TabIndex = 15;
            this.flowRateLabel.Text = "注射流速：";
            // 
            // concentrationValue
            // 
            this.concentrationValue.AutoSize = true;
            this.concentrationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentrationValue.Location = new System.Drawing.Point(164, 145);
            this.concentrationValue.Name = "concentrationValue";
            this.concentrationValue.Size = new System.Drawing.Size(55, 24);
            this.concentrationValue.TabIndex = 14;
            this.concentrationValue.Text = "10 ml";
            // 
            // endTimeValue
            // 
            this.endTimeValue.AutoSize = true;
            this.endTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeValue.Location = new System.Drawing.Point(495, 82);
            this.endTimeValue.Name = "endTimeValue";
            this.endTimeValue.Size = new System.Drawing.Size(67, 24);
            this.endTimeValue.TabIndex = 13;
            this.endTimeValue.Text = "未結束";
            // 
            // flowRateValue
            // 
            this.flowRateValue.AutoSize = true;
            this.flowRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowRateValue.Location = new System.Drawing.Point(495, 145);
            this.flowRateValue.Name = "flowRateValue";
            this.flowRateValue.Size = new System.Drawing.Size(60, 24);
            this.flowRateValue.TabIndex = 12;
            this.flowRateValue.Text = "10 u/s";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.Location = new System.Drawing.Point(62, 82);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(96, 24);
            this.startTimeLabel.TabIndex = 11;
            this.startTimeLabel.Text = "開始時間：";
            // 
            // injectionLabel
            // 
            this.injectionLabel.AutoSize = true;
            this.injectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectionLabel.Location = new System.Drawing.Point(66, 95);
            this.injectionLabel.Name = "injectionLabel";
            this.injectionLabel.Size = new System.Drawing.Size(96, 24);
            this.injectionLabel.TabIndex = 21;
            this.injectionLabel.Text = "注射時間：";
            // 
            // amountValue
            // 
            this.amountValue.AutoSize = true;
            this.amountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountValue.Location = new System.Drawing.Point(499, 95);
            this.amountValue.Name = "amountValue";
            this.amountValue.Size = new System.Drawing.Size(50, 24);
            this.amountValue.TabIndex = 22;
            this.amountValue.Text = "10ml";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(397, 95);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(96, 24);
            this.amountLabel.TabIndex = 23;
            this.amountLabel.Text = "注射劑量：";
            // 
            // injectionValue
            // 
            this.injectionValue.AutoSize = true;
            this.injectionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectionValue.Location = new System.Drawing.Point(168, 95);
            this.injectionValue.Name = "injectionValue";
            this.injectionValue.Size = new System.Drawing.Size(165, 24);
            this.injectionValue.TabIndex = 24;
            this.injectionValue.Text = "2019/5/16 12:45:12";
            // 
            // medicineNameLabel
            // 
            this.medicineNameLabel.AutoSize = true;
            this.medicineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineNameLabel.Location = new System.Drawing.Point(35, 11);
            this.medicineNameLabel.Name = "medicineNameLabel";
            this.medicineNameLabel.Size = new System.Drawing.Size(90, 24);
            this.medicineNameLabel.TabIndex = 25;
            this.medicineNameLabel.Text = "藥品名稱";
            // 
            // medicineNameVale
            // 
            this.medicineNameVale.AutoSize = true;
            this.medicineNameVale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineNameVale.Location = new System.Drawing.Point(137, 11);
            this.medicineNameVale.Name = "medicineNameVale";
            this.medicineNameVale.Size = new System.Drawing.Size(151, 24);
            this.medicineNameVale.TabIndex = 26;
            this.medicineNameVale.Text = "medicineName";
            // 
            // medicinePanel
            // 
            this.medicinePanel.Controls.Add(this.medicineNameVale);
            this.medicinePanel.Controls.Add(this.medicineNameLabel);
            this.medicinePanel.Controls.Add(this.injectionValue);
            this.medicinePanel.Controls.Add(this.amountLabel);
            this.medicinePanel.Controls.Add(this.amountValue);
            this.medicinePanel.Controls.Add(this.injectionLabel);
            this.medicinePanel.Location = new System.Drawing.Point(84, 61);
            this.medicinePanel.Name = "medicinePanel";
            this.medicinePanel.Size = new System.Drawing.Size(630, 177);
            this.medicinePanel.TabIndex = 5;
            // 
            // MedicineRecordEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 420);
            this.Controls.Add(this.medicinePanel);
            this.Controls.Add(this.continousMedicinePanel);
            this.Controls.Add(this.deleteDose);
            this.Controls.Add(this.setStop);
            this.Controls.Add(this.editDose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MedicineRecordEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更改药物记录";
            this.continousMedicinePanel.ResumeLayout(false);
            this.continousMedicinePanel.PerformLayout();
            this.medicinePanel.ResumeLayout(false);
            this.medicinePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editDose;
        private System.Windows.Forms.Button setStop;
        private System.Windows.Forms.Button deleteDose;
        private System.Windows.Forms.Panel continousMedicinePanel;
        private System.Windows.Forms.Label nameValue;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sartTimeValue;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label concentrationLabel;
        private System.Windows.Forms.Label flowRateLabel;
        private System.Windows.Forms.Label concentrationValue;
        private System.Windows.Forms.Label endTimeValue;
        private System.Windows.Forms.Label flowRateValue;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Panel medicinePanel;
        private System.Windows.Forms.Label medicineNameVale;
        private System.Windows.Forms.Label medicineNameLabel;
        private System.Windows.Forms.Label injectionValue;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label amountValue;
        private System.Windows.Forms.Label injectionLabel;
    }
}