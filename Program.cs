using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            RunTests();
        }

        private static void RunTests()
        {
            TestGetColorFromPairNumber();
            TestGetPairNumberFromColor();
        }

        private static void TestGetColorFromPairNumber()
        {
            ValidateColor(4, Color.White, Color.Brown);
            ValidateColor(5, Color.White, Color.SlateGray);
            ValidateColor(23, Color.Violet, Color.Green);
        }

        private static void ValidateColor(int pairNumber, Color expectedMajor, Color expectedMinor)
        {
            ColorPair testPair = ColorUtility.GetColorFromPairNumber(pairNumber);
            Debug.Assert(testPair.MajorColor == expectedMajor);
            Debug.Assert(testPair.MinorColor == expectedMinor);
        }

        private static void TestGetPairNumberFromColor()
        {
            ValidatePairNumber(new ColorPair(Color.Yellow, Color.Green), 18);
            ValidatePairNumber(new ColorPair(Color.Red, Color.Blue), 6);
        }

        private static void ValidatePairNumber(ColorPair pair, int expectedNumber)
        {
            int pairNumber = ColorUtility.GetPairNumberFromColor(pair);
            Debug.Assert(pairNumber == expectedNumber);
        }
    }
}
