using System;
using System.Windows.Forms;

namespace CsharpOpenCV_card
{
    partial class Form1 : Form
    {
        public BGR bgr_Lowerb = new BGR();
        public BGR bgr_Upperb = new BGR();

        private void trackBarEventHandleSetting_BGR()
        {
            #region 트랙바 이벤트 핸들러 정의
            trackBar1_Blue.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar2_Green.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar3_Red.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar4_Green.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar5_Red.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar6_Blue.ValueChanged += new EventHandler(trackBar_ValueChanged);
            #endregion
        }
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            getTrackBarIsSetBGR((TrackBar)sender, "lowerb", bgr_Lowerb);
            getTrackBarIsSetBGR((TrackBar)sender, "upperb", bgr_Upperb);

            Form1_ButtonColor_Changed();
            Form1_GroupboxTextChanged();
        }
        private void getTrackBarIsSetBGR(TrackBar obj, string name, BGR bgr)
        {
            if (obj.Parent.Name.Contains(name))
            {
                if(obj.Name.Contains("Blue"))
                    bgr.Blue = obj.Value.ToString();
                else if(obj.Name.Contains("Green"))
                    bgr.Green = obj.Value.ToString();
                else if (obj.Name.Contains("Red"))
                    bgr.Red = obj.Value.ToString();
            }
        }
    }
}
