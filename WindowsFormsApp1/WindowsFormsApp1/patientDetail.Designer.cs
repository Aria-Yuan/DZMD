﻿namespace WindowsFormsApp1
{
    partial class PatientDetail
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
            this.back = new System.Windows.Forms.Button();
            this.revert = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.data = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chartNol = new System.Windows.Forms.Label();
            this.chartNo = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.patientIdl = new System.Windows.Forms.Label();
            this.patientId = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.namel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.bloodl = new System.Windows.Forms.Label();
            this.blood = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.heightl = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.weightl = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.birthdayl = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.historyl = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.TextBox();
            this.button.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.data.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.next.Location = new System.Drawing.Point(680, 40);
            this.next.Margin = new System.Windows.Forms.Padding(40, 40, 13, 20);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(147, 62);
            this.next.TabIndex = 0;
            this.next.Text = "下一步";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(80, 40);
            this.back.Margin = new System.Windows.Forms.Padding(80, 40, 13, 20);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(147, 62);
            this.back.TabIndex = 8;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // revert
            // 
            this.revert.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.revert.Location = new System.Drawing.Point(280, 40);
            this.revert.Margin = new System.Windows.Forms.Padding(40, 40, 13, 20);
            this.revert.Name = "revert";
            this.revert.Size = new System.Drawing.Size(147, 62);
            this.revert.TabIndex = 18;
            this.revert.Text = "复原";
            this.revert.UseVisualStyleBackColor = true;
            this.revert.Click += new System.EventHandler(this.revert_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.save.Location = new System.Drawing.Point(480, 40);
            this.save.Margin = new System.Windows.Forms.Padding(40, 40, 13, 20);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(147, 62);
            this.save.TabIndex = 19;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button.Controls.Add(this.back);
            this.button.Controls.Add(this.revert);
            this.button.Controls.Add(this.save);
            this.button.Controls.Add(this.next);
            this.button.Location = new System.Drawing.Point(0, 575);
            this.button.Margin = new System.Windows.Forms.Padding(0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(886, 122);
            this.button.TabIndex = 31;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.data);
            this.flowLayoutPanel1.Controls.Add(this.button);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(67, 62);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(67, 62, 67, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(886, 697);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.data.Controls.Add(this.flowLayoutPanel2);
            this.data.Controls.Add(this.flowLayoutPanel4);
            this.data.Controls.Add(this.flowLayoutPanel5);
            this.data.Controls.Add(this.flowLayoutPanel10);
            this.data.Controls.Add(this.flowLayoutPanel11);
            this.data.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.data.Location = new System.Drawing.Point(4, 4);
            this.data.Margin = new System.Windows.Forms.Padding(4);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(878, 567);
            this.data.TabIndex = 33;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.chartNol);
            this.flowLayoutPanel2.Controls.Add(this.chartNo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(288, 43);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // chartNol
            // 
            this.chartNol.AutoSize = true;
            this.chartNol.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartNol.Location = new System.Drawing.Point(4, 0);
            this.chartNol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chartNol.Name = "chartNol";
            this.chartNol.Size = new System.Drawing.Size(155, 43);
            this.chartNol.TabIndex = 1;
            this.chartNol.Text = "病歷號：";
            // 
            // chartNo
            // 
            this.chartNo.AutoSize = true;
            this.chartNo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartNo.Location = new System.Drawing.Point(167, 0);
            this.chartNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chartNo.Name = "chartNo";
            this.chartNo.Size = new System.Drawing.Size(117, 43);
            this.chartNo.TabIndex = 29;
            this.chartNo.Text = "label1";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.patientIdl);
            this.flowLayoutPanel4.Controls.Add(this.patientId);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(4, 55);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(424, 43);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // patientIdl
            // 
            this.patientIdl.AutoSize = true;
            this.patientIdl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdl.Location = new System.Drawing.Point(4, 0);
            this.patientIdl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientIdl.Name = "patientIdl";
            this.patientIdl.Size = new System.Drawing.Size(291, 43);
            this.patientIdl.TabIndex = 2;
            this.patientIdl.Text = "病患身份證字號：";
            // 
            // patientId
            // 
            this.patientId.AutoSize = true;
            this.patientId.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientId.Location = new System.Drawing.Point(303, 0);
            this.patientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(117, 43);
            this.patientId.TabIndex = 30;
            this.patientId.Text = "label2";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel5.Location = new System.Drawing.Point(8, 122);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(8, 20, 8, 10);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(311, 232);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.namel);
            this.flowLayoutPanel6.Controls.Add(this.name);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(303, 50);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // namel
            // 
            this.namel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.namel.AutoSize = true;
            this.namel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namel.Location = new System.Drawing.Point(4, 4);
            this.namel.Margin = new System.Windows.Forms.Padding(4);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(155, 42);
            this.namel.TabIndex = 5;
            this.namel.Text = "病患姓名：";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(167, 4);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(132, 42);
            this.name.TabIndex = 22;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.Controls.Add(this.bloodl);
            this.flowLayoutPanel7.Controls.Add(this.blood);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(4, 62);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(303, 50);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // bloodl
            // 
            this.bloodl.AutoSize = true;
            this.bloodl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodl.Location = new System.Drawing.Point(4, 4);
            this.bloodl.Margin = new System.Windows.Forms.Padding(4);
            this.bloodl.Name = "bloodl";
            this.bloodl.Size = new System.Drawing.Size(155, 36);
            this.bloodl.TabIndex = 6;
            this.bloodl.Text = "病患血型：";
            // 
            // blood
            // 
            this.blood.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blood.Location = new System.Drawing.Point(167, 4);
            this.blood.Margin = new System.Windows.Forms.Padding(4);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(132, 42);
            this.blood.TabIndex = 23;
            this.blood.TextChanged += new System.EventHandler(this.blood_TextChanged);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.Controls.Add(this.heightl);
            this.flowLayoutPanel8.Controls.Add(this.height);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(4, 120);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(303, 50);
            this.flowLayoutPanel8.TabIndex = 2;
            // 
            // heightl
            // 
            this.heightl.AutoSize = true;
            this.heightl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightl.Location = new System.Drawing.Point(4, 4);
            this.heightl.Margin = new System.Windows.Forms.Padding(4);
            this.heightl.Name = "heightl";
            this.heightl.Size = new System.Drawing.Size(155, 36);
            this.heightl.TabIndex = 3;
            this.heightl.Text = "病患身高：";
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(167, 4);
            this.height.Margin = new System.Windows.Forms.Padding(4);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(132, 42);
            this.height.TabIndex = 26;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel9.Controls.Add(this.weightl);
            this.flowLayoutPanel9.Controls.Add(this.weight);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(4, 178);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(303, 50);
            this.flowLayoutPanel9.TabIndex = 3;
            // 
            // weightl
            // 
            this.weightl.AutoSize = true;
            this.weightl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightl.Location = new System.Drawing.Point(4, 4);
            this.weightl.Margin = new System.Windows.Forms.Padding(4);
            this.weightl.Name = "weightl";
            this.weightl.Size = new System.Drawing.Size(155, 36);
            this.weightl.TabIndex = 4;
            this.weightl.Text = "病患體重：";
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(167, 4);
            this.weight.Margin = new System.Windows.Forms.Padding(4);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(132, 42);
            this.weight.TabIndex = 25;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_KeyPress);
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.AutoSize = true;
            this.flowLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel10.Controls.Add(this.birthdayl);
            this.flowLayoutPanel10.Controls.Add(this.date);
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel10.Location = new System.Drawing.Point(10, 372);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(10, 8, 8, 10);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(521, 81);
            this.flowLayoutPanel10.TabIndex = 3;
            // 
            // birthdayl
            // 
            this.birthdayl.AutoSize = true;
            this.birthdayl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayl.Location = new System.Drawing.Point(4, 0);
            this.birthdayl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdayl.Name = "birthdayl";
            this.birthdayl.Size = new System.Drawing.Size(211, 36);
            this.birthdayl.TabIndex = 16;
            this.birthdayl.Text = "病患出生日期：";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(4, 40);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(513, 37);
            this.date.TabIndex = 28;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.AutoSize = true;
            this.flowLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel11.Controls.Add(this.historyl);
            this.flowLayoutPanel11.Controls.Add(this.history);
            this.flowLayoutPanel11.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(10, 471);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(10, 8, 8, 10);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(860, 86);
            this.flowLayoutPanel11.TabIndex = 4;
            // 
            // historyl
            // 
            this.historyl.AutoSize = true;
            this.historyl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyl.Location = new System.Drawing.Point(4, 0);
            this.historyl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.historyl.Name = "historyl";
            this.historyl.Size = new System.Drawing.Size(211, 36);
            this.historyl.TabIndex = 7;
            this.historyl.Text = "病患醫療記錄：";
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(4, 40);
            this.history.Margin = new System.Windows.Forms.Padding(4);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(852, 42);
            this.history.TabIndex = 27;
            this.history.TextChanged += new System.EventHandler(this.history_TextChanged);
            // 
            // PatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 769);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatientDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientDetail";
            this.button.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.data.ResumeLayout(false);
            this.data.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button revert;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.FlowLayoutPanel button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel data;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label patientIdl;
        private System.Windows.Forms.Label patientId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label heightl;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label weightl;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label birthdayl;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Label historyl;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label chartNol;
        private System.Windows.Forms.Label chartNo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label bloodl;
        private System.Windows.Forms.TextBox blood;
    }
}