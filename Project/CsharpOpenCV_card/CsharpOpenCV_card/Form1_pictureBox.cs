using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CsharpOpenCV_card
{
    partial class Form1: Form
    {
        VideoCapture capture = new VideoCapture(1);
        Mat frame;
        Bitmap image;
        private Thread camera_thread;
        int isCameraRunning = 0;
        private void CaptureCamera()
        {
            camera_thread = new Thread(new ThreadStart(CaptureCameraCallback));
            camera_thread.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture.Open(0);

            while (isCameraRunning == 1)
            {
                capture.Read(frame);
                if (!frame.Empty())
                {
                    image = BitmapConverter.ToBitmap(frame);
                    
                    pictureBox1.Image = image;
                }
                image = null;
            }

        }
    }

}
