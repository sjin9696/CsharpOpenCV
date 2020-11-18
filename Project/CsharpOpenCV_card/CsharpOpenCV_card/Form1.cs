<<<<<<< HEAD
﻿using System.Windows.Forms;
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
>>>>>>> parent of 3fd78cb... 1. 카메라 연결 구현

namespace CsharpOpenCV_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
            this.Show();
            trackBarEventHandleSetting_BGR();
            trackBarEventHandleSetting_camera();
            //OpenCV();
            CaptureCamera();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (button1.Text.Equals("Start"))
            {
                CaptureCamera();
                button1.Text = "Stop";
                isCameraRunning = 1;
            }
            else
            {
                if (capture.IsOpened())
                {
                    capture.Release();
                }

                button1.Text = "Start";
                isCameraRunning = 0;
            }
=======
>>>>>>> parent of 3fd78cb... 1. 카메라 연결 구현
        }
    }
}
