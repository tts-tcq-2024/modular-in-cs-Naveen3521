using System.Collections.Generic;
using System.Drawing;

namespace TelCo.ColorCoder.Data
{
    public static class ColorData
    {
        public static IReadOnlyList<Color> MajorColors { get; } =
            new List<Color> { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet }.AsReadOnly();

        public static IReadOnlyList<Color> MinorColors { get; } =
            new List<Color> { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray }.AsReadOnly();
    }
}
