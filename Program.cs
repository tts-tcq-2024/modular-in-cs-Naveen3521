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

        private static void TestColorUtility()
        {
            int pairNumber = 4;
            ColorModel testPair1 = ColorUtility.GetColorFromPairNumber(pairNumber);
            Console.WriteLine($"[In] Pair Number: {pairNumber}, [Out] Colors: {testPair1}\n");
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = ColorUtility.GetColorFromPairNumber(pairNumber);
            Console.WriteLine($"[In] Pair Number: {pairNumber}, [Out] Colors: {testPair1}\n");
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorUtility.GetColorFromPairNumber(pairNumber);
            Console.WriteLine($"[In] Pair Number: {pairNumber}, [Out] Colors: {testPair1}\n");
            Debug.Assert(testPair1.MajorColor == Color.Violet);
            Debug.Assert(testPair1.MinorColor == Color.Green);

            ColorModel testPair2 = new ColorModel { MajorColor = Color.Yellow, MinorColor = Color.Green };
            pairNumber = ColorUtility.GetPairNumberFromColor(testPair2);
            Console.WriteLine($"[In] Colors: {testPair2}, [Out] PairNumber: {pairNumber}\n");
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorModel { MajorColor = Color.Red, MinorColor = Color.Blue };
            pairNumber = ColorUtility.GetPairNumberFromColor(testPair2);
            Console.WriteLine($"[In] Colors: {testPair2}, [Out] PairNumber: {pairNumber}");
            Debug.Assert(pairNumber == 6);
        }
    }
}
