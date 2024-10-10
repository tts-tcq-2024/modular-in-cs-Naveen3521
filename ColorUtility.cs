using System;
using TelCo.ColorCoder.Models;
using System.Drawing;
using TelCo.ColorCoder.Data;

namespace TelCo.ColorCoder.Utilities
{
    public static class ColorUtility
    {
        public static ColorModel GetColorFromPairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > ColorData.MajorColors.Count * ColorData.MinorColors.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(pairNumber), "Pair number is outside the allowed range.");
            }

            int majorIndex = (pairNumber - 1) / ColorData.MinorColors.Count;
            int minorIndex = (pairNumber - 1) % ColorData.MinorColors.Count;

            return new ColorModel(ColorData.MajorColors[majorIndex], ColorData.MinorColors[minorIndex]);
        }

        public static int GetPairNumberFromColor(ColorModel pair)
        {
            int majorIndex = Array.IndexOf(ColorData.MajorColors.ToArray(), pair.MajorColor);
            int minorIndex = Array.IndexOf(ColorData.MinorColors.ToArray(), pair.MinorColor);

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException($"Unknown Colors: {pair.ToString()}");
            }

            return (majorIndex * ColorData.MinorColors.Count) + (minorIndex + 1);
        }
    }
}
