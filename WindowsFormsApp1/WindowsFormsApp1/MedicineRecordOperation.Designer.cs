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
            this.modify = new System.Windows.Forms.Button();
            this.continueInjection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stopInjection
            // 
            this.stopInjection.AccessibleName = "stopInjection";
            this.stopInjection.Location = new System.Drawing.Point(48, 35);
            this.stopInjection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopInjection.Name = "stopInjection";
            this.stopInjection.Size = new System.Drawing.Size(131, 44);
            this.stopInjection.TabIndex = 0;
            this.stopInjection.Text = "暂停注射";
            this.stopInjection.UseVisualStyleBackColor = true;
            this.stopInjection.Click += new System.EventHandler(this.stopInjection_Click);
            // 
            // addDose
            // 
            this.addDose.Location = new System.Drawing.Point(48, 122);
            this.addDose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addDose.Name = "addDose";
            this.addDose.Size = new System.Drawing.Size(131, 44);
            this.addDose.TabIndex = 1;
            this.addDose.Text = "添加劑量";
            this.addDose.UseVisualStyleBackColor = true;
            this.addDose.Click += new System.EventHandler(this.addDose_Click);
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(48, 213);
            this.modify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(131, 44);
            this.modify.TabIndex = 2;
            this.modify.Text = "修改药物";
            this.modify.UseVisualStyleBackColor = true;
            // 
            // continueInjection
            // 
            this.continueInjection.AccessibleName = "continueInjection";
            this.continueInjection.Location = new System.Drawing.Point(48, 35);
            this.continueInjection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.continueInjection.Name = "continueInjection";
            this.continueInjection.Size = new System.Drawing.Size(131, 44);
            this.continueInjection.TabIndex = 3;
            this.continueInjection.Text = "继续注射";
            this.continueInjection.UseVisualStyleBackColor = true;
            this.continueInjection.Click += new System.EventHandler(this.continueInjection_Click);
            // 
            // MedicineRecordOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 314);
            this.Controls.Add(this.continueInjection);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.addDose);
            this.Controls.Add(this.stopInjection);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MedicineRecordOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medicineRecordOperation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stopInjection;
        private System.Windows.Forms.Button addDose;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button continueInjection;
    }
}