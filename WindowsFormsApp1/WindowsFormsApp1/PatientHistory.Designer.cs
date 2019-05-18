namespace WindowsFormsApp1
{
    partial class PatientHistory
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
            this.title = new System.Windows.Forms.Label();
            this.namel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(105, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(79, 13);
            this.title.TabIndex = 0;
            this.title.Text = "病患歷史記錄";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Location = new System.Drawing.Point(108, 83);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(67, 13);
            this.namel.TabIndex = 1;
            this.namel.Text = "病患姓名：";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(185, 83);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 2;
            this.name.Text = "label3";
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Location = new System.Drawing.Point(108, 118);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(35, 13);
            this.content.TabIndex = 3;
            this.content.Text = "label4";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(100, 405);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 4;
            this.close.Text = "關閉";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 529);
            this.Controls.Add(this.close);
            this.Controls.Add(this.content);
            this.Controls.Add(this.name);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.title);
            this.Name = "PatientHistory";
            this.Text = "PatientHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label content;
        private System.Windows.Forms.Button close;
    }
}