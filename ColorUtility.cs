using System;

namespace TelCo.ColorCoder
{
    public static class ColorUtility
    {
        public static ColorModel GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = ColorMap.MinorColors.Length;
            int majorSize = ColorMap.MajorColors.Length;

            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException($"Argument PairNumber: {pairNumber} is outside the allowed range.");
            }

            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            return new ColorModel
            {
                MajorColor = ColorMap.MajorColors[majorIndex],
                MinorColor = ColorMap.MinorColors[minorIndex]
            };
        }

        public static int GetPairNumberFromColor(ColorModel colorModel)
        {
            int majorIndex = Array.IndexOf(ColorMap.MajorColors, colorModel.MajorColor);
            int minorIndex = Array.IndexOf(ColorMap.MinorColors, colorModel.MinorColor);

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException($"Unknown Colors: {pair}");
            }

            return (majorIndex * ColorMap.MinorColors.Length) + (minorIndex + 1);
        }
    }
}

