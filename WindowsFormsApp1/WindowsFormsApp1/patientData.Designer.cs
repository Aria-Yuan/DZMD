namespace WindowsFormsApp1
{
    partial class patientData
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
            this.patientName = new System.Windows.Forms.ListBox();
            this.goPatientDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientName
            // 
            this.patientName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientName.FormattingEnabled = true;
            this.patientName.ItemHeight = 26;
            this.patientName.Location = new System.Drawing.Point(860, 240);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(200, 576);
            this.patientName.TabIndex = 0;
            this.patientName.SelectedIndexChanged += new System.EventHandler(this.patientName_SelectedIndexChanged);
            // 
            // goPatientDetail
            // 
            this.goPatientDetail.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goPatientDetail.Location = new System.Drawing.Point(860, 880);
            this.goPatientDetail.Name = "goPatientDetail";
            this.goPatientDetail.Size = new System.Drawing.Size(200, 60);
            this.goPatientDetail.TabIndex = 1;
            this.goPatientDetail.Text = "病人詳細資訊";
            this.goPatientDetail.UseVisualStyleBackColor = true;
            this.goPatientDetail.Click += new System.EventHandler(this.goPatientDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(850, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "選擇病人";
            // 
            // patientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goPatientDetail);
            this.Controls.Add(this.patientName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "patientData";
            this.Text = "patientData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox patientName;
        private System.Windows.Forms.Button goPatientDetail;
        private System.Windows.Forms.Label label1;
    }
}