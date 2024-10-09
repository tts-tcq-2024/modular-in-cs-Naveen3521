using System; 
using System.Drawing;
using Xunit;
using TelCo.ColorCoder; 

namespace TelCo.ColorCoder.Tests
{
    public class ColorUtilityTests_GetColorFromPairNumber
    {
        [Theory]
        [InlineData(1, Color.White, Color.Blue)]
        [InlineData(5, Color.White, Color.SlateGray)]
        [InlineData(10, Color.Black, Color.Green)]
        [InlineData(18, Color.Yellow, Color.Green)]
        [InlineData(25, Color.Violet, Color.SlateGray)]
        public void GetColorFromPairNumber_ValidPairNumber_ReturnsCorrectColors(int pairNumber, Color expectedMajor, Color expectedMinor)
        {
            // Act
            var result = ColorUtility.GetColorFromPairNumber(pairNumber);

            // Assert
            Assert.Equal(expectedMajor, result.MajorColor);
            Assert.Equal(expectedMinor, result.MinorColor);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(26)]
        public void GetColorFromPairNumber_InvalidPairNumber_ThrowsArgumentOutOfRangeException(int invalidPairNumber)
        {
            // Act & Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => ColorUtility.GetColorFromPairNumber(0));
            Assert.Contains("outside the allowed range", exception.Message);
        }

        [Fact]
        public void GetColorFromPairNumber_NullPairNumber_ThrowsArgumentNullException()
        {
            // Arrange
            int? nullPairNumber = null;

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => ColorUtility.GetColorFromPairNumber(nullPairNumber));
            Assert.Equal("pairNumber", exception.ParamName);
            Assert.Contains("Pair number cannot be null.", exception.Message);
        }
    }
}
