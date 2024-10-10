using System.Drawing;

namespace TelCo.ColorCoder.Models
{
    public class ColorModel
    {
        public Color MajorColor { get; }
        public Color MinorColor { get; }

        public ColorModel(Color majorColor, Color minorColor)
        {
            MajorColor = majorColor;
            MinorColor = minorColor;
        }
    }
}
