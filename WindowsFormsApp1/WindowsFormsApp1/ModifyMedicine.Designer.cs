namespace WindowsFormsApp1
{
    partial class ModifyMedicine
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
            this.MCunit = new System.Windows.Forms.ComboBox();
            this.concentrationUnit = new System.Windows.Forms.Label();
            this.MCvalue = new System.Windows.Forms.TextBox();
            this.concentration = new System.Windows.Forms.Label();
            this.Mname = new System.Windows.Forms.ComboBox();
            this.medicineName = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MCunit
            // 
            this.MCunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCunit.FormattingEnabled = true;
            this.MCunit.Location = new System.Drawing.Point(570, 83);
            this.MCunit.Name = "MCunit";
            this.MCunit.Size = new System.Drawing.Size(92, 28);
            this.MCunit.TabIndex = 21;
            this.MCunit.Visible = false;
            // 
            // concentrationUnit
            // 
            this.concentrationUnit.AutoSize = true;
            this.concentrationUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentrationUnit.Location = new System.Drawing.Point(519, 86);
            this.concentrationUnit.Name = "concentrationUnit";
            this.concentrationUnit.Size = new System.Drawing.Size(45, 20);
            this.concentrationUnit.TabIndex = 20;
            this.concentrationUnit.Text = "单位:";
            this.concentrationUnit.Visible = false;
            // 
            // MCvalue
            // 
            this.MCvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCvalue.Location = new System.Drawing.Point(405, 83);
            this.MCvalue.Name = "MCvalue";
            this.MCvalue.Size = new System.Drawing.Size(100, 26);
            this.MCvalue.TabIndex = 19;
            this.MCvalue.Visible = false;
            // 
            // concentration
            // 
            this.concentration.AutoSize = true;
            this.concentration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentration.Location = new System.Drawing.Point(325, 86);
            this.concentration.Name = "concentration";
            this.concentration.Size = new System.Drawing.Size(77, 20);
            this.concentration.TabIndex = 18;
            this.concentration.Text = "注射浓度:";
            this.concentration.Visible = false;
            // 
            // Mname
            // 
            this.Mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.FormattingEnabled = true;
            this.Mname.Location = new System.Drawing.Point(160, 82);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(140, 28);
            this.Mname.TabIndex = 13;
            // 
            // medicineName
            // 
            this.medicineName.AutoSize = true;
            this.medicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineName.Location = new System.Drawing.Point(80, 86);
            this.medicineName.Name = "medicineName";
            this.medicineName.Size = new System.Drawing.Size(77, 20);
            this.medicineName.TabIndex = 12;
            this.medicineName.Text = "藥物種類:";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(563, 207);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(99, 41);
            this.submit.TabIndex = 22;
            this.submit.Text = "確認修改";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(98, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 24);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "刪除該筆資料";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ModifyMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 308);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.MCunit);
            this.Controls.Add(this.concentrationUnit);
            this.Controls.Add(this.MCvalue);
            this.Controls.Add(this.concentration);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.medicineName);
            this.Name = "ModifyMedicine";
            this.Text = "ModifyMedicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MCunit;
        private System.Windows.Forms.Label concentrationUnit;
        private System.Windows.Forms.TextBox MCvalue;
        private System.Windows.Forms.Label concentration;
        private System.Windows.Forms.ComboBox Mname;
        private System.Windows.Forms.Label medicineName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}