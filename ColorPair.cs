using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorPair
    {
        public Color MajorColor { get; set; }
        public Color MinorColor { get; set; }

        public override string ToString()
        {
            return $"MajorColor: {MajorColor.Name}, MinorColor: {MinorColor.Name}";
        }
    }
}
