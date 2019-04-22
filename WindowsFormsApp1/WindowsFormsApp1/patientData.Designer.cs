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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientName
            // 
            this.patientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.patientName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientName.FormattingEnabled = true;
            this.patientName.ItemHeight = 25;
            this.patientName.Location = new System.Drawing.Point(185, 124);
            this.patientName.Margin = new System.Windows.Forms.Padding(4);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(376, 479);
            this.patientName.TabIndex = 0;
            this.patientName.SelectedIndexChanged += new System.EventHandler(this.patientName_SelectedIndexChanged);
            // 
            // goPatientDetail
            // 
            this.goPatientDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.goPatientDetail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goPatientDetail.Location = new System.Drawing.Point(253, 621);
            this.goPatientDetail.Margin = new System.Windows.Forms.Padding(4, 10, 4, 30);
            this.goPatientDetail.Name = "goPatientDetail";
            this.goPatientDetail.Size = new System.Drawing.Size(240, 55);
            this.goPatientDetail.TabIndex = 1;
            this.goPatientDetail.Text = "病人詳細資訊";
            this.goPatientDetail.UseVisualStyleBackColor = true;
            this.goPatientDetail.Click += new System.EventHandler(this.goPatientDetail_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 20, 4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "選擇病人";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.goPatientDetail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.patientName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 741);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // patientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(747, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "patientData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientData";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox patientName;
        private System.Windows.Forms.Button goPatientDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}