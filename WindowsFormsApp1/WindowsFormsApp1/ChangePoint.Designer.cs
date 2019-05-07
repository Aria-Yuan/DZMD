namespace WindowsFormsApp1
{
    partial class ChangePoint
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
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.yn = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.xn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(125, 127);
            this.x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(25, 29);
            this.x.TabIndex = 0;
            this.x.Text = "x";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.y.Location = new System.Drawing.Point(125, 208);
            this.y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(25, 29);
            this.y.TabIndex = 1;
            this.y.Text = "y";
            // 
            // yn
            // 
            this.yn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.yn.Location = new System.Drawing.Point(243, 208);
            this.yn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yn.Name = "yn";
            this.yn.Size = new System.Drawing.Size(132, 34);
            this.yn.TabIndex = 3;
            this.yn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yn_KeyPress);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(97, 59);
            this.type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(101, 36);
            this.type.TabIndex = 4;
            this.type.Text = "label1";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.time.Location = new System.Drawing.Point(247, 59);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(101, 36);
            this.time.TabIndex = 5;
            this.time.Text = "label2";
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(72, 300);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(145, 48);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(289, 300);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(145, 48);
            this.confirm.TabIndex = 7;
            this.confirm.Text = "確認";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.button2_Click);
            // 
            // xn
            // 
            this.xn.AutoSize = true;
            this.xn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.xn.Location = new System.Drawing.Point(237, 127);
            this.xn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xn.Name = "xn";
            this.xn.Size = new System.Drawing.Size(85, 29);
            this.xn.TabIndex = 8;
            this.xn.Text = "label1";
            // 
            // ChangePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 423);
            this.Controls.Add(this.xn);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.time);
            this.Controls.Add(this.type);
            this.Controls.Add(this.yn);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.TextBox yn;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label xn;
    }
}