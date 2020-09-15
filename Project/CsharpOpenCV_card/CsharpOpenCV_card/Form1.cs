using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpOpenCV_card
{
    public partial class Form1 : Form
    {
        VideoCapture video = new VideoCapture(0);
        Mat frame = new Mat();
        public Form1()
        {
            InitializeComponent();
            

            while (Cv2.WaitKey(33) != 'q')
            {
                video.Read(frame);
                Cv2.ImShow("frame", frame);
            }
        }
        ~Form1()
        {
            frame.Dispose();
            video.Release();
            Cv2.DestroyAllWindows();

        }
    }
}
