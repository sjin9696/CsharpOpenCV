using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Point = OpenCvSharp.Point;

namespace CsharpOpenCV_card
{
    partial class Form1 : Form
    {
        public void OpenCV()
        {
            try
            {
                //최대사이즈 1280*960
                VideoCapture video = new VideoCapture(0);
                Mat frame = new Mat();
                Mat yellow = new Mat(); //전처리 결과를 저장할 Mat
                Mat dst;
                Point[][] contours; // 윤곽선의 실제 값이 저장 
                HierarchyIndex[] hierarchies;
                video.FrameWidth = 5000;
                video.FrameHeight = 5000;

                video.Read(frame);

                Console.WriteLine(video.FrameWidth + "*"+ video.FrameHeight);
                while (Cv2.WaitKey(33) != 'q')
                {
                    video.Read(frame);

                    video.Contrast = double.Parse(camera.Contrast);
                    video.Brightness = double.Parse(camera.Brightness);

                    Cv2.InRange(frame, bgr_Lowerb.GetScalar(), bgr_Upperb.GetScalar(), yellow);
                    Cv2.FindContours(yellow, out contours, out hierarchies, RetrievalModes.Tree, ContourApproximationModes.ApproxTC89KCOS);
                    List<Point[]> new_contours = new List<Point[]>();
                    foreach (Point[] p in contours)
                    {
                        double length = Cv2.ArcLength(p, true);
                        double area = Cv2.ContourArea(p, true);
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
                yellow.Dispose();
                video.Release();
                Cv2.DestroyAllWindows();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

    }
}
