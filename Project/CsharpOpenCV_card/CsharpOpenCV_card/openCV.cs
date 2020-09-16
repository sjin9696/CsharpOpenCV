using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpOpenCV_card
{
    partial class Form1 : Form
    {
        public void openCV()
        {
            trackBarEventHandleSetting();

            VideoCapture video = new VideoCapture(0);
            Mat frame = new Mat();
            Mat yellow = new Mat(); //전처리 결과를 저장할 Mat
            Mat dst;

            Point[][] contours; // 윤곽선의 실제 값이 저장 
            HierarchyIndex[] hierarchies;
            Scalar lowerb = new Scalar(0, 127, 127);
            Scalar upperb = new Scalar(100, 255, 255);

            while (Cv2.WaitKey(33) != 'q')
            {
                video.Read(frame);
                Cv2.InRange(frame, lowerb, upperb, yellow);
                Cv2.FindContours(yellow, out contours, out hierarchies, RetrievalModes.Tree, ContourApproximationModes.ApproxTC89KCOS);
                List<Point[]> new_contours = new List<Point[]>();
                foreach (Point[] p in contours)
                {
                    double length = Cv2.ArcLength(p, true);
                    if (length > 100)
                    {
                        new_contours.Add(p);
                    }
                }
                dst = frame.Clone(); //연산결과를 저장할 mat
                Cv2.DrawContours(dst, new_contours, -1, new Scalar(255, 0, 0), 2, LineTypes.AntiAlias, null, 1);
                Cv2.ImShow("dst", dst);
            }
            frame.Dispose();
            video.Release();
            Cv2.DestroyAllWindows();
        }

    }
}
