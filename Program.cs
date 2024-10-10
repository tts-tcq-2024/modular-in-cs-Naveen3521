using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Testing various color pair numbers
            TestColorUtility();
        }

        private static void TestColorUtility()
        {
            // Test for pair number 4
            int pairNumber = 4;
            ColorPair testPair1 = ColorUtility.GetColorFromPairNumber(pairNumber);
            Console.WriteLine($"[In]Pair Number: {pairNumber}, [Out] Colors: {testPair1}");
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.Brown);

            // Test for pair number 5
            pairNumber = 5;
            testPair1 = ColorUtility.GetColorFromPairNumber(pairNumber);
            Console.WriteLine($"[In]Pair Number: {pairNumber}, [Out] Colors: {testPair1}");
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.SlateGray);

            // Test for pair number 23
            pairNumber = 23;
            testPair1 = ColorUtility.GetColorFromPairNumber(pairNumber);
            Console.WriteLine($"[In]Pair Number: {pairNumber}, [Out] Colors: {testPair1}");
            Debug.Assert(testPair1.MajorColor == Color.Violet);
            Debug.Assert(testPair1.MinorColor == Color.Green);

            // Testing color to pair number mapping
            ColorPair testPair2 = new ColorPair(Color.Yellow, Color.Green);
            pairNumber = ColorUtility.GetPairNumberFromColor(testPair2);
            Console.WriteLine($"[In]Colors: {testPair2}, [Out] PairNumber: {pairNumber}");
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair(Color.Red, Color.Blue);
            pairNumber = ColorUtility.GetPairNumberFromColor(testPair2);
            Console.WriteLine($"[In]Colors: {testPair2}, [Out] PairNumber: {pairNumber}");
            Debug.Assert(pairNumber == 6);
        }
    }
}
