using System;
using UIKit;

namespace SampleTask.IOS.Helper
{
    public class CommonMethods
    {
        public CommonMethods()
        {
        }

        public static UIFont GetFontByType(FontManager.FontType FontType, FontManager.FontSize FontSize)
        {
            return UIFont.FromName(FontManager.GetFontName(FontType), FontManager.GetFontSize(FontSize));

        }
    }
}
