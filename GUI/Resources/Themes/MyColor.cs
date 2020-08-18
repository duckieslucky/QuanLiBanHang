using System.Drawing;

namespace GUI.Resources.Themes
{
    public class MyColor
    {
        //PROPERTIES
        public static Color PRIMARY_COLOR = FromHex("#2eacea");
        public static Color PRIMARY_DEEP_COLOR = FromHex("#41464c");
        public static Color PRIMARY_FONT_COLOR = Color.White;



        //METHODS
        public static Color FromHex(string hexColor)
        {
            return ColorTranslator.FromHtml(hexColor);
        }

    }
}
