namespace WindowsFormsApp1
{
    partial class patientDetail
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
            this.confirm = new System.Windows.Forms.Button();
            this.chartNol = new System.Windows.Forms.Label();
            this.patientIdl = new System.Windows.Forms.Label();
            this.heightl = new System.Windows.Forms.Label();
            this.weightl = new System.Windows.Forms.Label();
            this.namel = new System.Windows.Forms.Label();
            this.bloodl = new System.Windows.Forms.Label();
            this.historyl = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.chartNo = new System.Windows.Forms.Label();
            this.patientId = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.blood = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Label();
            this.birthdayl = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(384, 273);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(62, 23);
            this.confirm.TabIndex = 0;
            this.confirm.Text = "確認";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // chartNol
            // 
            this.chartNol.AutoSize = true;
            this.chartNol.Location = new System.Drawing.Point(80, 40);
            this.chartNol.Name = "chartNol";
            this.chartNol.Size = new System.Drawing.Size(55, 13);
            this.chartNol.TabIndex = 1;
            this.chartNol.Text = "病歷號：";
            // 
            // patientIdl
            // 
            this.patientIdl.AutoSize = true;
            this.patientIdl.Location = new System.Drawing.Point(218, 40);
            this.patientIdl.Name = "patientIdl";
            this.patientIdl.Size = new System.Drawing.Size(103, 13);
            this.patientIdl.TabIndex = 2;
            this.patientIdl.Text = "病患身份證字號：";
            // 
            // heightl
            // 
            this.heightl.AutoSize = true;
            this.heightl.Location = new System.Drawing.Point(80, 149);
            this.heightl.Name = "heightl";
            this.heightl.Size = new System.Drawing.Size(67, 13);
            this.heightl.TabIndex = 3;
            this.heightl.Text = "病患身高：";
            // 
            // weightl
            // 
            this.weightl.AutoSize = true;
            this.weightl.Location = new System.Drawing.Point(254, 149);
            this.weightl.Name = "weightl";
            this.weightl.Size = new System.Drawing.Size(67, 13);
            this.weightl.TabIndex = 4;
            this.weightl.Text = "病患體重：";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Location = new System.Drawing.Point(80, 76);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(67, 13);
            this.namel.TabIndex = 5;
            this.namel.Text = "病患姓名：";
            // 
            // bloodl
            // 
            this.bloodl.AutoSize = true;
            this.bloodl.Location = new System.Drawing.Point(254, 76);
            this.bloodl.Name = "bloodl";
            this.bloodl.Size = new System.Drawing.Size(67, 13);
            this.bloodl.TabIndex = 6;
            this.bloodl.Text = "病患血型：";
            // 
            // historyl
            // 
            this.historyl.AutoSize = true;
            this.historyl.Location = new System.Drawing.Point(80, 188);
            this.historyl.Name = "historyl";
            this.historyl.Size = new System.Drawing.Size(91, 13);
            this.historyl.TabIndex = 7;
            this.historyl.Text = "病患醫療記錄：";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(316, 273);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(62, 23);
            this.back.TabIndex = 8;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // chartNo
            // 
            this.chartNo.AutoSize = true;
            this.chartNo.Location = new System.Drawing.Point(141, 40);
            this.chartNo.Name = "chartNo";
            this.chartNo.Size = new System.Drawing.Size(35, 13);
            this.chartNo.TabIndex = 9;
            this.chartNo.Text = "label1";
            // 
            // patientId
            // 
            this.patientId.AutoSize = true;
            this.patientId.Location = new System.Drawing.Point(327, 40);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(35, 13);
            this.patientId.TabIndex = 10;
            this.patientId.Text = "label2";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(153, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 11;
            this.name.Text = "label3";
            // 
            // blood
            // 
            this.blood.AutoSize = true;
            this.blood.Location = new System.Drawing.Point(327, 76);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(35, 13);
            this.blood.TabIndex = 12;
            this.blood.Text = "label4";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(154, 148);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(35, 13);
            this.height.TabIndex = 13;
            this.height.Text = "label5";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(328, 147);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(35, 13);
            this.weight.TabIndex = 14;
            this.weight.Text = "label6";
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Location = new System.Drawing.Point(178, 187);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(35, 13);
            this.history.TabIndex = 15;
            this.history.Text = "label7";
            // 
            // birthdayl
            // 
            this.birthdayl.AutoSize = true;
            this.birthdayl.Location = new System.Drawing.Point(80, 111);
            this.birthdayl.Name = "birthdayl";
            this.birthdayl.Size = new System.Drawing.Size(91, 13);
            this.birthdayl.TabIndex = 16;
            this.birthdayl.Text = "病患出生日期：";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(178, 110);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(35, 13);
            this.birthday.TabIndex = 17;
            this.birthday.Text = "label2";
            // 
            // patientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 327);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.birthdayl);
            this.Controls.Add(this.history);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.blood);
            this.Controls.Add(this.name);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.chartNo);
            this.Controls.Add(this.back);
            this.Controls.Add(this.historyl);
            this.Controls.Add(this.bloodl);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.weightl);
            this.Controls.Add(this.heightl);
            this.Controls.Add(this.patientIdl);
            this.Controls.Add(this.chartNol);
            this.Controls.Add(this.confirm);
            this.Name = "patientDetail";
            this.Text = "patientDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label chartNol;
        private System.Windows.Forms.Label patientIdl;
        private System.Windows.Forms.Label heightl;
        private System.Windows.Forms.Label weightl;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label bloodl;
        private System.Windows.Forms.Label historyl;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label chartNo;
        private System.Windows.Forms.Label patientId;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label blood;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Label birthdayl;
        private System.Windows.Forms.Label birthday;
    }
}