using System.Drawing; 

namespace TelCo.ColorCoder
{
  public static class ColorMap
  {
    private static readonly Color[] majorColors = new Color[]
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

    //read only property For Major Color
    public static Color[] MajorColors => (Color[])majorColors.Clone();
    //read only property for Minor Color
    public static Color[] MinorColors => (Color[])minorColors.Clone();
  }
}
