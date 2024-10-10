using System;
using TelCo.ColorCoder;
using System.Linq;

namespace TelCo.ColorCoder
{
    public static class ColorUtility
    {
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            ValidatePairNumber(pairNumber);
            int majorIndex = (pairNumber - 1) / ColorData.MinorColors.Count;
            int minorIndex = (pairNumber - 1) % ColorData.MinorColors.Count;
            return new ColorPair(ColorData.MajorColors[majorIndex], ColorData.MinorColors[minorIndex]);
        }

        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = Array.IndexOf(ColorData.MajorColors.ToArray(), pair.MajorColor);
            int minorIndex = Array.IndexOf(ColorData.MinorColors.ToArray(), pair.MinorColor);

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException($"Unknown Colors: {pair}");
            }

            return (majorIndex * ColorData.MinorColors.Count) + (minorIndex + 1);
        }

        private static void ValidatePairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > ColorData.MajorColors.Count * ColorData.MinorColors.Count)
            {
                throw new ArgumentOutOfRangeException($"Argument PairNumber: {pairNumber} is outside the allowed range");
            }
        }
    }
}
