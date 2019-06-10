using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class DateTimeChoser
    {
        /// <summary>   
        /// 必需的设计器变量。  
        /// </summary>  
        private System.ComponentModel.IContainer components = null;

        /// <summary>   
        /// 清理所有正在使用的资源。  
        /// </summary>  
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>  
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码  

        /// <summary>   
        /// 设计器支持所需的方法 - 不要  
        /// 使用代码编辑器修改此方法的内容。  
        /// </summary>  
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel_consume = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_second = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_minute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_hour = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.panel_consume.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AllowDrop = true;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(-1, 24);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // panel_consume
            // 
            this.panel_consume.BackColor = System.Drawing.Color.White;
            this.panel_consume.Controls.Add(this.label6);
            this.panel_consume.Controls.Add(this.comboBox_second);
            this.panel_consume.Controls.Add(this.label5);
            this.panel_consume.Controls.Add(this.comboBox_minute);
            this.panel_consume.Controls.Add(this.label4);
            this.panel_consume.Controls.Add(this.comboBox_hour);
            this.panel_consume.Location = new System.Drawing.Point(-1, 186);
            this.panel_consume.Margin = new System.Windows.Forms.Padding(0);
            this.panel_consume.Name = "panel_consume";
            this.panel_consume.Size = new System.Drawing.Size(228, 37);
            this.panel_consume.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "秒";
            // 
            // comboBox_second
            // 
            this.comboBox_second.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_second.FormattingEnabled = true;
            this.comboBox_second.Location = new System.Drawing.Point(152, 9);
            this.comboBox_second.Name = "comboBox_second";
            this.comboBox_second.Size = new System.Drawing.Size(40, 21);
            this.comboBox_second.TabIndex = 14;
            this.comboBox_second.Text = "0";
            this.comboBox_second.SelectedIndexChanged += new System.EventHandler(this.TimeChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "分";
            // 
            // comboBox_minute
            // 
            this.comboBox_minute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_minute.FormattingEnabled = true;
            this.comboBox_minute.Location = new System.Drawing.Point(83, 9);
            this.comboBox_minute.Name = "comboBox_minute";
            this.comboBox_minute.Size = new System.Drawing.Size(40, 21);
            this.comboBox_minute.TabIndex = 12;
            this.comboBox_minute.Text = "0";
            this.comboBox_minute.SelectedIndexChanged += new System.EventHandler(this.TimeChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "时";
            // 
            // comboBox_hour
            // 
            this.comboBox_hour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_hour.FormattingEnabled = true;
            this.comboBox_hour.Location = new System.Drawing.Point(12, 9);
            this.comboBox_hour.Name = "comboBox_hour";
            this.comboBox_hour.Size = new System.Drawing.Size(42, 21);
            this.comboBox_hour.TabIndex = 10;
            this.comboBox_hour.Text = "0";
            this.comboBox_hour.SelectedIndexChanged += new System.EventHandler(this.TimeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_time);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 25);
            this.panel1.TabIndex = 25;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.White;
            this.label_date.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_date.Location = new System.Drawing.Point(24, 4);
            this.label_date.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(98, 16);
            this.label_date.TabIndex = 26;
            this.label_date.Text = "2016-06-12";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.White;
            this.label_time.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.Location = new System.Drawing.Point(128, 4);
            this.label_time.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(80, 16);
            this.label_time.TabIndex = 25;
            this.label_time.Text = "12:23:35";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel_consume);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 272);
            this.panel2.TabIndex = 26;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.White;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button.Location = new System.Drawing.Point(78, 236);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(76, 26);
            this.button.TabIndex = 27;
            this.button.Text = "確定";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // DateTimeChoser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "DateTimeChoser";
            this.Size = new System.Drawing.Size(227, 272);
            this.panel_consume.ResumeLayout(false);
            this.panel_consume.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel_consume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_second;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_minute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_hour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel panel2;
        
    }
}
