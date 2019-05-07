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
            this.SuspendLayout();
            // 
            // editDose
            // 
            this.editDose.Location = new System.Drawing.Point(112, 46);
            this.editDose.Name = "editDose";
            this.editDose.Size = new System.Drawing.Size(193, 93);
            this.editDose.TabIndex = 0;
            this.editDose.Text = "修改注射劑量";
            this.editDose.UseVisualStyleBackColor = true;
            this.editDose.Click += new System.EventHandler(this.editDose_Click);
            // 
            // setStop
            // 
            this.setStop.Location = new System.Drawing.Point(112, 182);
            this.setStop.Name = "setStop";
            this.setStop.Size = new System.Drawing.Size(193, 93);
            this.setStop.TabIndex = 1;
            this.setStop.Text = "設為停止注射時間";
            this.setStop.UseVisualStyleBackColor = true;
            this.setStop.Click += new System.EventHandler(this.setStop_Click);
            // 
            // deleteDose
            // 
            this.deleteDose.Location = new System.Drawing.Point(112, 329);
            this.deleteDose.Name = "deleteDose";
            this.deleteDose.Size = new System.Drawing.Size(193, 93);
            this.deleteDose.TabIndex = 2;
            this.deleteDose.Text = "刪除該筆資料";
            this.deleteDose.UseVisualStyleBackColor = true;
            this.deleteDose.Click += new System.EventHandler(this.deleteDose_Click);
            // 
            // MedicineRecordEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 480);
            this.Controls.Add(this.deleteDose);
            this.Controls.Add(this.setStop);
            this.Controls.Add(this.editDose);
            this.Name = "MedicineRecordEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更改药物记录";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editDose;
        private System.Windows.Forms.Button setStop;
        private System.Windows.Forms.Button deleteDose;
    }
}