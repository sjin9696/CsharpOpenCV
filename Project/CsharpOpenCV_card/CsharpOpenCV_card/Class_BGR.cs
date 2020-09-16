using System.Drawing;

namespace CsharpOpenCV_card
{
    public class BGR
    {
        public string Blue { get; set; }
        public string Green { get; set; }
        public string Red { get; set; }
        public BGR(string blue = "0", string green = "0", string red = "0")
        {
            this.Blue = blue;
            this.Green = green;
            this.Red = red;
        }
        public string printBGRInfo() { return ($"({Blue}) , ({Green}) , ({Red})"); }
        public Color RGB(){return Color.FromArgb(int.Parse(Red), int.Parse(Green), int.Parse(Blue)); }
    }
}
