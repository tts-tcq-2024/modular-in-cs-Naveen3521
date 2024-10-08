using System;

namespace TelCo.ColorCoder
{
    public static class ColorUtility
    {
        private static readonly int minorSize = ColorData.MinorColors.Length;
        private static readonly int majorSize = ColorData.MajorColors.Length;

        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            ValidatePairNumber(pairNumber);
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
             return new ColorPair(ColorData.MajorColors[majorIndex], ColorData.MinorColors[minorIndex]);
        }

        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = Array.IndexOf(ColorData.MajorColors, pair.MajorColor);
            int minorIndex = Array.IndexOf(ColorData.MinorColors, pair.MinorColor);
            if (majorIndex == -1 || minorIndex == -1)
                throw new ArgumentException($"Unknown Colors: {pair}");
            return (majorIndex * minorSize) + (minorIndex + 1);
        }

        private static void ValidatePairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
                throw new ArgumentOutOfRangeException($"PairNumber is outside the allowed range or is null");
        }
    }
}
