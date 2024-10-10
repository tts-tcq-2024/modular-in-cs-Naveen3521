using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class ColorService
    {
        public static ColorModel GetColorFromPairNumber(int pairNumber)
        {
            ValidatePairNumber(pairNumber);

            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / ColorData.MinorColors.Length;
            int minorIndex = zeroBasedPairNumber % ColorData.MinorColors.Length;

            return new ColorModel
            {
                MajorColor = ColorData.MajorColors[majorIndex],
                MinorColor = ColorData.MinorColors[minorIndex]
            };
        }

        public static int GetPairNumberFromColor(ColorModel colorModel)
        {
            int majorIndex = Array.IndexOf(ColorData.MajorColors, colorModel.MajorColor);
            int minorIndex = Array.IndexOf(ColorData.MinorColors, colorModel.MinorColor);

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException($"Unknown Colors: {colorModel}");
            }

            return (majorIndex * ColorData.MinorColors.Length) + (minorIndex + 1);
        }

        private static void ValidatePairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > ColorData.MajorColors.Length * ColorData.MinorColors.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(pairNumber), $"Pair number {pairNumber} is outside the allowed range.");
            }
        }
    }
}
