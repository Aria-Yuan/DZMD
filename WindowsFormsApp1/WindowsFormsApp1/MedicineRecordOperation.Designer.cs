namespace WindowsFormsApp1
{
    partial class MedicineRecordOperation
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
            this.stopInjection = new System.Windows.Forms.Button();
            this.addDose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stopInjection
            // 
            this.stopInjection.Location = new System.Drawing.Point(67, 94);
            this.stopInjection.Name = "stopInjection";
            this.stopInjection.Size = new System.Drawing.Size(175, 54);
            this.stopInjection.TabIndex = 0;
            this.stopInjection.Text = "注射完畢";
            this.stopInjection.UseVisualStyleBackColor = true;
            this.stopInjection.Click += new System.EventHandler(this.stopInjection_Click);
            // 
            // addDose
            // 
            this.addDose.Location = new System.Drawing.Point(67, 213);
            this.addDose.Name = "addDose";
            this.addDose.Size = new System.Drawing.Size(175, 54);
            this.addDose.TabIndex = 1;
            this.addDose.Text = "添加劑量";
            this.addDose.UseVisualStyleBackColor = true;
            this.addDose.Click += new System.EventHandler(this.addDose_Click);
            // 
            // MedicineRecordOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 387);
            this.Controls.Add(this.addDose);
            this.Controls.Add(this.stopInjection);
            this.Name = "MedicineRecordOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medicineRecordOperation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stopInjection;
        private System.Windows.Forms.Button addDose;
    }
}