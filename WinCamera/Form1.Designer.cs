namespace WinCamera
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnKinescopeStop = new System.Windows.Forms.Button();
            this.btnKinescopeBegin = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSnapPic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(18, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 610);
            this.panel1.TabIndex = 0;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(454, 85);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(254, 28);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "C:\\TEMP\\abc.bmp";
            // 
            // btnKinescopeStop
            // 
            this.btnKinescopeStop.Location = new System.Drawing.Point(716, 17);
            this.btnKinescopeStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKinescopeStop.Name = "btnKinescopeStop";
            this.btnKinescopeStop.Size = new System.Drawing.Size(200, 44);
            this.btnKinescopeStop.TabIndex = 2;
            this.btnKinescopeStop.Text = "KinescopeStop";
            this.btnKinescopeStop.UseVisualStyleBackColor = true;
            this.btnKinescopeStop.Click += new System.EventHandler(this.btnKinescopeStop_Click);
            // 
            // btnKinescopeBegin
            // 
            this.btnKinescopeBegin.Location = new System.Drawing.Point(454, 17);
            this.btnKinescopeBegin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKinescopeBegin.Name = "btnKinescopeBegin";
            this.btnKinescopeBegin.Size = new System.Drawing.Size(216, 42);
            this.btnKinescopeBegin.TabIndex = 3;
            this.btnKinescopeBegin.Text = "KinescopeBegin";
            this.btnKinescopeBegin.UseVisualStyleBackColor = true;
            this.btnKinescopeBegin.Click += new System.EventHandler(this.btnKinescopeBegin_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(176, 50);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(202, 10);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(184, 51);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSnapPic
            // 
            this.btnSnapPic.Location = new System.Drawing.Point(716, 69);
            this.btnSnapPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSnapPic.Name = "btnSnapPic";
            this.btnSnapPic.Size = new System.Drawing.Size(144, 56);
            this.btnSnapPic.TabIndex = 6;
            this.btnSnapPic.Text = "SnapPic";
            this.btnSnapPic.UseVisualStyleBackColor = true;
            this.btnSnapPic.Click += new System.EventHandler(this.btnSnapPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "存储路径及文件名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 765);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSnapPic);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnKinescopeBegin);
            this.Controls.Add(this.btnKinescopeStop);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnKinescopeStop;
        private System.Windows.Forms.Button btnKinescopeBegin;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSnapPic;
        private System.Windows.Forms.Label label1;
    }
}

