using System.Windows.Forms;

namespace CsharpOpenCV_card
{
    partial class Form1 : Form
    {
        private void Form1_ButtonColor_Changed()
        {
            button_lowerb.BackColor = bgr_Lowerb.GetRGB();
            button_upperb.BackColor = bgr_Upperb.GetRGB();
        }
    }
}
