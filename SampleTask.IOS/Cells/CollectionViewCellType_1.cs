using System;

using Foundation;
using SampleTask.IOS.Dto;
using SampleTask.IOS.Helper;
using UIKit;

namespace SampleTask.IOS.Cells
{
    public partial class CollectionViewCellType_1 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("CollectionViewCellType_1");
        public static readonly UINib Nib;

        static CollectionViewCellType_1()
        {
            Nib = UINib.FromName("CollectionViewCellType_1", NSBundle.MainBundle);
        }

        protected CollectionViewCellType_1(IntPtr handle) : base(handle)
        {
        }

        internal void UpdateCell(CustomerDto customer)
        {
            //fonts
            lblTestMon.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_BOLD, FontManager.FontSize.HEADER);
            lblCustName.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_BOLD, FontManager.FontSize.TITLE);
            lblCustAge.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_BOLD, FontManager.FontSize.TITLE);
            lblDays.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_BOLD, FontManager.FontSize.TITLE);
            lblName.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_BOLD, FontManager.FontSize.TITLE);
            lblCategory.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_REGULAR, FontManager.FontSize.DESCRIPTION);
            lblReviews.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_REGULAR, FontManager.FontSize.DESCRIPTION);

            lblCustName.Text = customer.CustomerName;
            lblCustAge.Text = customer.CustomerAge;
            lblTestMon.Text = customer.TestMon;
            lblDays.Text = customer.Days;
            ImgCust.Image = UIImage.FromBundle("ImgTooth.jpg");
            ImgProfile.Image = UIImage.FromBundle("ImgTooth.jpg");
            lblName.Text = customer.TestName;
            lblCategory.Text = customer.TestCategory;
            lblReviews.Text = customer.TestReviews;
        }
        
        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            ImgProfile.Layer.MasksToBounds = true;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            ImgProfile.Layer.CornerRadius = (nfloat)(ImgProfile.Frame.Size.Width / 2.0);
        }
    }
}
