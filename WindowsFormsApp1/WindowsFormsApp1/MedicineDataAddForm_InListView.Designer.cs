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
            this.SuspendLayout();
            // 
            // medicineName
            // 
            this.medicineName.AutoSize = true;
            this.medicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineName.Location = new System.Drawing.Point(42, 90);
            this.medicineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medicineName.Name = "medicineName";
            this.medicineName.Size = new System.Drawing.Size(91, 24);
            this.medicineName.TabIndex = 0;
            this.medicineName.Text = "藥物種類:";
            // 
            // Mname
            // 
            this.Mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.FormattingEnabled = true;
            this.Mname.Location = new System.Drawing.Point(142, 86);
            this.Mname.Margin = new System.Windows.Forms.Padding(4);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(185, 30);
            this.Mname.TabIndex = 1;
            this.Mname.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dose
            // 
            this.dose.AutoSize = true;
            this.dose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dose.Location = new System.Drawing.Point(397, 90);
            this.dose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dose.Name = "dose";
            this.dose.Size = new System.Drawing.Size(53, 24);
            this.dose.TabIndex = 2;
            this.dose.Text = "劑量:";
            // 
            // NMvalue
            // 
            this.NMvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMvalue.Location = new System.Drawing.Point(458, 87);
            this.NMvalue.Margin = new System.Windows.Forms.Padding(4);
            this.NMvalue.Name = "NMvalue";
            this.NMvalue.Size = new System.Drawing.Size(132, 28);
            this.NMvalue.TabIndex = 3;
            // 
            // comfirm
            // 
            this.comfirm.Location = new System.Drawing.Point(723, 272);
            this.comfirm.Margin = new System.Windows.Forms.Padding(4);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(110, 52);
            this.comfirm.TabIndex = 4;
            this.comfirm.Text = "確認";
            this.comfirm.UseVisualStyleBackColor = true;
            this.comfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // doseUnit
            // 
            this.doseUnit.AutoSize = true;
            this.doseUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doseUnit.Location = new System.Drawing.Point(608, 90);
            this.doseUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doseUnit.Name = "doseUnit";
            this.doseUnit.Size = new System.Drawing.Size(53, 24);
            this.doseUnit.TabIndex = 6;
            this.doseUnit.Text = "单位:";
            // 
            // NMunit
            // 
            this.NMunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMunit.FormattingEnabled = true;
            this.NMunit.Location = new System.Drawing.Point(669, 87);
            this.NMunit.Margin = new System.Windows.Forms.Padding(4);
            this.NMunit.Name = "NMunit";
            this.NMunit.Size = new System.Drawing.Size(122, 30);
            this.NMunit.TabIndex = 7;
            // 
            // MCunit
            // 
            this.MCunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCunit.FormattingEnabled = true;
            this.MCunit.Location = new System.Drawing.Point(679, 87);
            this.MCunit.Margin = new System.Windows.Forms.Padding(4);
            this.MCunit.Name = "MCunit";
            this.MCunit.Size = new System.Drawing.Size(122, 30);
            this.MCunit.TabIndex = 11;
            this.MCunit.Visible = false;
            // 
            // concentrationUnit
            // 
            this.concentrationUnit.AutoSize = true;
            this.concentrationUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentrationUnit.Location = new System.Drawing.Point(618, 90);
            this.concentrationUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.concentrationUnit.Name = "concentrationUnit";
            this.concentrationUnit.Size = new System.Drawing.Size(53, 24);
            this.concentrationUnit.TabIndex = 10;
            this.concentrationUnit.Text = "单位:";
            this.concentrationUnit.Visible = false;
            // 
            // MCvalue
            // 
            this.MCvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCvalue.Location = new System.Drawing.Point(459, 87);
            this.MCvalue.Margin = new System.Windows.Forms.Padding(4);
            this.MCvalue.Name = "MCvalue";
            this.MCvalue.Size = new System.Drawing.Size(132, 28);
            this.MCvalue.TabIndex = 9;
            this.MCvalue.Visible = false;
            // 
            // concentration
            // 
            this.concentration.AutoSize = true;
            this.concentration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentration.Location = new System.Drawing.Point(360, 90);
            this.concentration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.concentration.Name = "concentration";
            this.concentration.Size = new System.Drawing.Size(91, 24);
            this.concentration.TabIndex = 8;
            this.concentration.Text = "注射浓度:";
            this.concentration.Visible = false;
            // 
            // MRunit
            // 
            this.MRunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRunit.FormattingEnabled = true;
            this.MRunit.Location = new System.Drawing.Point(679, 171);
            this.MRunit.Margin = new System.Windows.Forms.Padding(4);
            this.MRunit.Name = "MRunit";
            this.MRunit.Size = new System.Drawing.Size(122, 30);
            this.MRunit.TabIndex = 15;
            this.MRunit.Visible = false;
            // 
            // flowRateUnit
            // 
            this.flowRateUnit.AutoSize = true;
            this.flowRateUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowRateUnit.Location = new System.Drawing.Point(618, 174);
            this.flowRateUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flowRateUnit.Name = "flowRateUnit";
            this.flowRateUnit.Size = new System.Drawing.Size(53, 24);
            this.flowRateUnit.TabIndex = 14;
            this.flowRateUnit.Text = "单位:";
            this.flowRateUnit.Visible = false;
            // 
            // MRvalue
            // 
            this.MRvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRvalue.Location = new System.Drawing.Point(459, 171);
            this.MRvalue.Margin = new System.Windows.Forms.Padding(4);
            this.MRvalue.Name = "MRvalue";
            this.MRvalue.Size = new System.Drawing.Size(132, 28);
            this.MRvalue.TabIndex = 13;
            this.MRvalue.Visible = false;
            // 
            // flowRate
            // 
            this.flowRate.AutoSize = true;
            this.flowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowRate.Location = new System.Drawing.Point(360, 174);
            this.flowRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flowRate.Name = "flowRate";
            this.flowRate.Size = new System.Drawing.Size(91, 24);
            this.flowRate.TabIndex = 12;
            this.flowRate.Text = "注射流速:";
            this.flowRate.Visible = false;
            // 
            // MedicineDataAddForm_InListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 365);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}