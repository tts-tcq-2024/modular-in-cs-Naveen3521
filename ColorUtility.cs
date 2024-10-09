using System;

namespace TelCo.ColorCoder
{
    public static class ColorUtility
    {
        public static ColorModel GetColorFromPairNumber(int? pairNumber)
        {
            ValidatePairNumber(pairNumber);
            int zeroBasedPairNumber = pairNumber.Value - 1;
            int majorIndex = zeroBasedPairNumber / ColorMap.MinorColors.Length;
            int minorIndex = zeroBasedPairNumber % ColorMap.MinorColors.Length;

            return new ColorModel
            {
                MajorColor = ColorMap.MajorColors[majorIndex],
                MinorColor = ColorMap.MinorColors[minorIndex]
            };
        }

        private static void ValidatePairNumber(int? pairNumber)
        {
            if (!pairNumber.HasValue)
                throw new ArgumentNullException(nameof(pairNumber), "Pair number cannot be null.");
            if (pairNumber < 1 || pairNumber > ColorMap.MajorColors.Length * ColorMap.MinorColors.Length)
                throw new ArgumentOutOfRangeException(nameof(pairNumber), $"Argument PairNumber: {pairNumber} is outside the allowed range.");
        }

        public static int GetPairNumberFromColor(ColorModel colorModel)
        {
            int majorIndex = Array.IndexOf(ColorMap.MajorColors, colorModel.MajorColor);
            int minorIndex = Array.IndexOf(ColorMap.MinorColors, colorModel.MinorColor);

            if (majorIndex == -1 || minorIndex == -1)
                throw new ArgumentException($"Unknown Colors: {colorModel}");

            return (majorIndex * ColorMap.MinorColors.Length) + (minorIndex + 1);
        }
    }
}
