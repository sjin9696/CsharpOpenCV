using System.Windows.Forms;

namespace CsharpOpenCV_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }
    }
}
