using System;
using Foundation;
using SampleTask.IOS.Constants;

namespace SampleTask.IOS.Helper
{
    public class FontManager
    {
        public FontManager()
        {
        }
        public enum FontType
        {
            ROBO_FONT_BOLD = 0,
            ROBO_FONT_MEDIUM = 1,
            ROBO_FONT_REGULAR = 2,

        }

        public enum FontSize
        {
            HEADER = 0,
            TITLE = 1,
            DESCRIPTION = 2,
            BUTTON = 3,
            HEADER_LARGE = 4,
            OPTION_LABEL = 5
        }

        public static string GetFontName(FontType Type)
        {
            switch (Type)
            {
                case FontType.ROBO_FONT_BOLD: return "Roboto-Bold";
                case FontType.ROBO_FONT_MEDIUM: return "Roboto-Medium";
                case FontType.ROBO_FONT_REGULAR: return "Roboto-Regular";
                default: return "Roboto-Regular";


            }

        }

        public static int GetFontSize(FontSize Type)
        {
            try
            {
                int fontSize = (int)NSUserDefaults.StandardUserDefaults.IntForKey(StringConstant.UserDefault.fontSizeKey);
                switch (Type)
                {
                    case FontSize.HEADER: return fontSize + 14;
                    case FontSize.TITLE: return fontSize + 12;
                    case FontSize.DESCRIPTION: return fontSize + 8;
                    case FontSize.BUTTON: return fontSize + 6;
                    case FontSize.HEADER_LARGE: return fontSize + 16;
                    case FontSize.OPTION_LABEL: return fontSize + 12;
                    default: return (int)Type;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 10;
            }

        }
    }
}
