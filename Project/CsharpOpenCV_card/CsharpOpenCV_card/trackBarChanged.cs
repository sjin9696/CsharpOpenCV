using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpOpenCV_card
{
    public partial class Form1 : Form
    {

        private void trackBar_EventHandle()
        {
            #region 트랙바 이벤트 핸들러 정의
            trackBar1.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar2.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar3.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar4.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar5.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar6.ValueChanged += new EventHandler(trackBar_ValueChanged);
            #endregion

        }
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(((TrackBar)sender).Name + " value : " + e.ToString());
            //((TrackBar)sender).Name 선택된 요소의 이름 가져오는 방법
        }
    }
}
