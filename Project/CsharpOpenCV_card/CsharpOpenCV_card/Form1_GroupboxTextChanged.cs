using System.Windows.Forms;

namespace CsharpOpenCV_card
{
    partial class Form1 : Form
    {

        private void Form1_GroupboxTextChanged()
        {
            groupBox_lowerb.Text = "lowerb" + bgr_Lowerb.printBGRInfo();
            groupBox_upperb.Text = "upperb" + bgr_Upperb.printBGRInfo();
        }
        private void Form1_GroupboxCamera_SettingTextChanged()
        {
            groupBox_Contrast.Text = "Contrast (" + camera.Contrast;
            groupBox_Bright.Text = "Bright (" + camera.Brightness;
        }
    }
}
