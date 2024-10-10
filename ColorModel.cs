using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorModel
    {
        public Color MajorColor { get; set; }
        public Color MinorColor { get; set; }

        public ColorModel(int majorIndex, int minorIndex)
        {
            MajorColor = ColorData.MajorColors[majorIndex];
            MinorColor = ColorData.MajorColors[minorIndex];
        }
    }
}
