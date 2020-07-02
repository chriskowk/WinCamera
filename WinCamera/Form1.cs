using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinCamera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public webcam wcam = null;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            start();
            this.btnKinescopeStop.Enabled = false;
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            wcam.Start();
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            wcam.Stop();
        }

        private void btnSnapPic_Click(object sender, System.EventArgs e)
        {
            //得到路径。例：d:/a.bmp
            string myPath = this.txtPath.Text;
            if (myPath == "")
            {
                MessageBox.Show("必须填写路径！");
                return;
            }
            else
            {
                wcam.GrabImagePath = myPath;
                wcam.GrabImage();
                MessageBox.Show("截图成功！");
            }
        }

        public void start()
        {
            //以panel1为容器显示视频内容
            wcam = new webcam(panel1.Handle, 0, 0, this.panel1.Width, this.panel1.Height);
            wcam.Start();
        }

        private void panel1_SizeChanged(object sender, System.EventArgs e)
        {
            if (wcam != null)
            {
                wcam.Stop();
                wcam.Height = this.panel1.Height;
                wcam.Width = this.panel1.Width;
                wcam.Start();
            }
        }

        private delegate void delegateKinescope();
        private void btnKinescopeBegin_Click(object sender, System.EventArgs e)
        {
            //得到路径。例：d:/a.avi
            string myPath = this.txtPath.Text;
            if (myPath == "")
            {
                MessageBox.Show("必须填写路径！");
                return;
            }
            else
            {
                wcam.KinescopePath = myPath;
                delegateKinescope myK = new delegateKinescope(wcam.Kinescope);
                Thread threadKinescope = new Thread(new ThreadStart(myK));
                threadKinescope.Start();
                this.btnKinescopeBegin.Enabled = false;
                this.btnKinescopeStop.Enabled = true;
            }
        }
        public void starKinescope()
        {
            delegateKinescope myK = new delegateKinescope(wcam.Kinescope);
        }

        private void btnKinescopeStop_Click(object sender, System.EventArgs e)
        {
            wcam.StopKinescope();
            this.btnKinescopeBegin.Enabled = true;
            this.btnKinescopeStop.Enabled = false;
        }
    }
}
