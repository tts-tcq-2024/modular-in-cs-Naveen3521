using System.Drawing;

namespace TelCo.ColorCoder
{
  public static class ColorMap
  {
    private static readonly Color[] majorColor = new Color[]
    {
            Color.White, 
            Color.Red, 
            Color.Black, 
            Color.Yellow, 
            Color.Violet 
    };

    private static readonly Color[] minorColors = new Color[] 
    { 
            Color.Blue, 
            Color.Orange, 
            Color.Green, 
            Color.Brown, 
            Color.SlateGray 
    };

    public static Color[] MajorColors => (Color[])majorColors.Clone();
    public static Color[] MinorColors => (Color[])minorColors.Clone();
  }
}
