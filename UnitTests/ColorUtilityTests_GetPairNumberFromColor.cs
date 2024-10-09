using System;
using System.Drawing;
using Xunit;
using TelCo.ColorCoder;

namespace TelCo.ColorCoder.Tests
{
    public class ColorUtilityTests_GetPairNumberFromColor
    {
        [Theory]
        [InlineData(Color.White, Color.Blue, 1)]
        [InlineData(Color.White, Color.SlateGray, 5)]
        [InlineData(Color.Black, Color.Green, 10)]
        [InlineData(Color.Yellow, Color.Green, 18)]
        [InlineData(Color.Violet, Color.SlateGray, 25)]
        public void GetPairNumberFromColor_ValidColorModel_ReturnsCorrectPairNumber(Color major, Color minor, int expectedPairNumber)
        {
            // Arrange
            var colorModel = new ColorModel { MajorColor = major, MinorColor = minor };

            // Act
            var result = ColorUtility.GetPairNumberFromColor(colorModel);

            // Assert
            Assert.Equal(expectedPairNumber, result);
        }

        [Fact]
        public void GetPairNumberFromColor_InvalidColorModel_ThrowsArgumentException()
        {
            // Arrange
            var invalidColorModel = new ColorModel { MajorColor = Color.Red, MinorColor = Color.Pink };

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => ColorUtility.GetPairNumberFromColor(invalidColorModel));
            Assert.Contains("Unknown Colors", exception.Message);
        }
        [Theory]
        [InlineData(Color.Empty, Color.Blue)]
        [InlineData(Color.White, Color.Empty)]
        [InlineData(Color.Empty, Color.Empty)]
        public void GetPairNumberFromColor_EmptyColors_ThrowsArgumentException(Color major, Color minor)
        {
            // Arrange
            var invalidColorModel = new ColorModel { MajorColor = major, MinorColor = minor };

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => ColorUtility.GetPairNumberFromColor(invalidColorModel));
            Assert.Contains("Unknown Colors", exception.Message);
        }
    }
}
