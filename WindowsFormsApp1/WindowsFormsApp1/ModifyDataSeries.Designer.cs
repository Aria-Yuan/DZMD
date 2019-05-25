namespace WindowsFormsApp1
{
    partial class ModifyDataSeries
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
            this.SystolicBPList = new System.Windows.Forms.FlowLayoutPanel();
            this.DiastolicBPList = new System.Windows.Forms.FlowLayoutPanel();
            this.HeartbeatList = new System.Windows.Forms.FlowLayoutPanel();
            this.timeList = new System.Windows.Forms.FlowLayoutPanel();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainview = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.mainview.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystolicBPList
            // 
            this.SystolicBPList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SystolicBPList.Location = new System.Drawing.Point(189, 3);
            this.SystolicBPList.Name = "SystolicBPList";
            this.SystolicBPList.Size = new System.Drawing.Size(180, 450);
            this.SystolicBPList.TabIndex = 0;
            // 
            // DiastolicBPList
            // 
            this.DiastolicBPList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DiastolicBPList.Location = new System.Drawing.Point(375, 3);
            this.DiastolicBPList.Name = "DiastolicBPList";
            this.DiastolicBPList.Size = new System.Drawing.Size(180, 450);
            this.DiastolicBPList.TabIndex = 1;
            // 
            // HeartbeatList
            // 
            this.HeartbeatList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.HeartbeatList.Location = new System.Drawing.Point(561, 3);
            this.HeartbeatList.Name = "HeartbeatList";
            this.HeartbeatList.Size = new System.Drawing.Size(180, 450);
            this.HeartbeatList.TabIndex = 2;
            // 
            // timeList
            // 
            this.timeList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.timeList.Location = new System.Drawing.Point(3, 3);
            this.timeList.Name = "timeList";
            this.timeList.Size = new System.Drawing.Size(180, 450);
            this.timeList.TabIndex = 3;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.AutoSize = true;
            this.save.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.save.Location = new System.Drawing.Point(804, 431);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(82, 31);
            this.save.TabIndex = 5;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.close.Location = new System.Drawing.Point(804, 483);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(82, 31);
            this.close.TabIndex = 6;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "SystolicBP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "DiastolicBP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Heartbeat";
            // 
            // mainview
            // 
            this.mainview.AutoScroll = true;
            this.mainview.Controls.Add(this.timeList);
            this.mainview.Controls.Add(this.SystolicBPList);
            this.mainview.Controls.Add(this.DiastolicBPList);
            this.mainview.Controls.Add(this.HeartbeatList);
            this.mainview.Location = new System.Drawing.Point(25, 61);
            this.mainview.Name = "mainview";
            this.mainview.Size = new System.Drawing.Size(773, 456);
            this.mainview.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(39, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "時間";
            // 
            // ModifyDataSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(929, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mainview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.Name = "ModifyDataSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyDataSeries";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyDataSeries_FormClosing);
            this.mainview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SystolicBPList;
        private System.Windows.Forms.FlowLayoutPanel DiastolicBPList;
        private System.Windows.Forms.FlowLayoutPanel HeartbeatList;
        private System.Windows.Forms.FlowLayoutPanel timeList;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel mainview;
        private System.Windows.Forms.Label label4;
    }
}