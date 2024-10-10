using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorPair
    {
        public Color MajorColor { get; }
        public Color MinorColor { get; }

        public ColorPair(Color majorColor, Color minorColor)
        {
            MajorColor = majorColor;
            MinorColor = minorColor;
        }
    }
}
