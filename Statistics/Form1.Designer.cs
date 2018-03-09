namespace Statistics
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listShow = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnSlc = new System.Windows.Forms.Button();
            this.btnUSLC = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCmd = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listShow
            // 
            this.listShow.FormattingEnabled = true;
            this.listShow.ItemHeight = 12;
            this.listShow.Location = new System.Drawing.Point(12, 12);
            this.listShow.Name = "listShow";
            this.listShow.Size = new System.Drawing.Size(99, 220);
            this.listShow.TabIndex = 0;
            this.listShow.SelectedIndexChanged += new System.EventHandler(this.listShow_SelectedIndexChanged);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(117, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(132, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(117, 53);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(132, 64);
            this.tbInput.TabIndex = 2;
            this.tbInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnSlc
            // 
            this.btnSlc.Location = new System.Drawing.Point(117, 165);
            this.btnSlc.Name = "btnSlc";
            this.btnSlc.Size = new System.Drawing.Size(132, 23);
            this.btnSlc.TabIndex = 3;
            this.btnSlc.Text = "Show Selected";
            this.btnSlc.UseVisualStyleBackColor = true;
            this.btnSlc.Click += new System.EventHandler(this.btnSlc_Click);
            // 
            // btnUSLC
            // 
            this.btnUSLC.Location = new System.Drawing.Point(117, 194);
            this.btnUSLC.Name = "btnUSLC";
            this.btnUSLC.Size = new System.Drawing.Size(132, 23);
            this.btnUSLC.TabIndex = 4;
            this.btnUSLC.Text = "Show Unslected";
            this.btnUSLC.UseVisualStyleBackColor = true;
            this.btnUSLC.Click += new System.EventHandler(this.btnUSLC_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbLog.Location = new System.Drawing.Point(12, 238);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(237, 159);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "谷雨同学制作";
            // 
            // tbCmd
            // 
            this.tbCmd.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbCmd.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCmd.ForeColor = System.Drawing.SystemColors.Info;
            this.tbCmd.Location = new System.Drawing.Point(12, 401);
            this.tbCmd.Name = "tbCmd";
            this.tbCmd.Size = new System.Drawing.Size(237, 20);
            this.tbCmd.TabIndex = 9;
            this.tbCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(117, 136);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(132, 23);
            this.btnSwitch.TabIndex = 10;
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 434);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.tbCmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnUSLC);
            this.Controls.Add(this.btnSlc);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.listShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "统计工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listShow;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnSlc;
        private System.Windows.Forms.Button btnUSLC;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCmd;
        private System.Windows.Forms.Button btnSwitch;
    }
}

