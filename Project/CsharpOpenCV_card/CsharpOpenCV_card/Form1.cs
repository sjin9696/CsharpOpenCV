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
            OpenCV();
        }
    }
}
