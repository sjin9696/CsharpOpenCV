using System;
using System.Windows.Forms;

namespace CsharpOpenCV_card
{
    partial class Form1 : Form
    {
        public CameraSetting camera = new CameraSetting();

        private void trackBarEventHandleSetting_camera()
        {
            #region 트랙바 이벤트 핸들러 정의
            trackBar_Contrast.ValueChanged += new EventHandler(CameraSetting_TrackBarChanged);
            trackBar_Bright.ValueChanged += new EventHandler(CameraSetting_TrackBarChanged);
            #endregion
        }
        private void CameraSetting_TrackBarChanged(object sender, EventArgs e)
        {
            getTrackBarIsSetCameraSetting((TrackBar)sender, "Camera", camera);
            Form1_GroupboxCamera_SettingTextChanged();
        }
        private void getTrackBarIsSetCameraSetting(TrackBar obj, string name, CameraSetting camera)
        {
            if (obj.Parent.Name.Contains(name))
            {
                if(obj.Name.Contains("Contrast"))
                    camera.Contrast = obj.Value.ToString();
                else if(obj.Name.Contains("Bright"))
                    camera.Brightness = obj.Value.ToString();
                
            }
        }
    }
}
