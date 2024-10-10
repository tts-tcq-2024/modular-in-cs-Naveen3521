using System;

namespace TelCo.ColorCoder
{
    public static class ColorUtility
    {
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            ValidatePairNumber(pairNumber);
            return CalculateColorPair(pairNumber);
        }

        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = GetColorIndex(ColorMap.MajorColors, pair.MajorColor);
            int minorIndex = GetColorIndex(ColorMap.MinorColors, pair.MinorColor);

            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException($"Unknown Colors: {pair}");
            }

            return (majorIndex * ColorMap.MinorColors.Length) + (minorIndex + 1);
        }

        private static int GetColorIndex(Color[] colors, Color color)
        {
            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i] == color)
                {
                    return i;
                }
            }
            return -1;
        }

        private static void ValidatePairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > ColorMap.MajorColors.Length * ColorMap.MinorColors.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(pairNumber), $"Pair number {pairNumber} is out of range.");
            }
        }

        private static ColorPair CalculateColorPair(int pairNumber)
        {
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / ColorMap.MinorColors.Length;
            int minorIndex = zeroBasedPairNumber % ColorMap.MinorColors.Length;

            return new ColorPair
            {
                MajorColor = ColorMap.MajorColors[majorIndex],
                MinorColor = ColorMap.MinorColors[minorIndex]
            };
        }
    }
}
