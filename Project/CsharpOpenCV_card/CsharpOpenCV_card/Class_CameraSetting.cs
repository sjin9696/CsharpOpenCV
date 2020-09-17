using OpenCvSharp;
using System.Drawing;

namespace CsharpOpenCV_card
{
    public class CameraSetting
    {
        public string Contrast { get; set; }
        public string Brightness { get; set; }
        public CameraSetting(string contrast="0", string bright="0")
        {
            this.Contrast = contrast;
            this.Brightness = bright;
        }
        public string printInfo() { return ($"({Contrast}) , ({Brightness})"); }
        //public Color GetRGB() { return Color.FromArgb(int.Parse(Red), int.Parse(Green), int.Parse(Blue)); }
        //public Scalar GetScalar() { return new Scalar(double.Parse(Blue), double.Parse(Green), double.Parse(Red)); }
    }
}
