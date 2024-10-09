using System;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            TestColorUtility();
        }
        // this method tests the GetColorFromPairNumber and GetPairNumberFromColor detailed testcases are written in unit tests 
        private static void TestColorUtility()
        {
            int pairNumber = 4;
            ColorModel testPair1 = ColorUtility.GetColorFromPairNumber(pairNumber);
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.Brown);

            ColorModel testPair2 = new ColorModel { MajorColor = Color.Yellow, MinorColor = Color.Green };
            pairNumber = ColorUtility.GetPairNumberFromColor(testPair2);
            Debug.Assert(pairNumber == 18);
        }
    }
}
