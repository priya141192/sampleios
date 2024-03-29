﻿using System;

using Foundation;
using SampleTask.IOS.Dto;
using SampleTask.IOS.Helper;
using UIKit;

namespace SampleTask.IOS.Cells
{
    public partial class CollectionViewCellType_2 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("CollectionViewCellType_2");
        public static readonly UINib Nib;

        static CollectionViewCellType_2()
        {
            Nib = UINib.FromName("CollectionViewCellType_2", NSBundle.MainBundle);
        }

        protected CollectionViewCellType_2(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        internal void UpdateCell(DoctorDto doctor)
        {
            lblName.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_BOLD, FontManager.FontSize.TITLE);
            lblCategory.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_REGULAR, FontManager.FontSize.SUBTITLE);
            lblDepartment.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_REGULAR, FontManager.FontSize.TITLE);
            lblReviews.Font = CommonMethods.GetFontByType(FontManager.FontType.ROBO_FONT_BOLD, FontManager.FontSize.TITLE);

            ImgDoc.Image = UIImage.FromBundle("ImgTest.jpg");
            lblName.Text = doctor.DocName;
            lblDepartment.Text = doctor.Department;
            lblCategory.Text = doctor.Category;
            lblReviews.Text = doctor.Reviews;
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            ImgDoc.Layer.MasksToBounds = true;
            lblCategory.Layer.MasksToBounds = true;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            ImgDoc.Layer.CornerRadius = 10;
            lblCategory.Layer.CornerRadius = 2;
            float availableLabelWidth = (float)labelContainer.Frame.Size.Width;
            lblName.PreferredMaxLayoutWidth = availableLabelWidth;
            lblName.TranslatesAutoresizingMaskIntoConstraints = false;
            lblName.AdjustsFontSizeToFitWidth = false;
            lblName.LineBreakMode = UILineBreakMode.TailTruncation;
            lblDepartment.PreferredMaxLayoutWidth = availableLabelWidth;
            lblCategory.PreferredMaxLayoutWidth = availableLabelWidth;
            lblReviews.PreferredMaxLayoutWidth = availableLabelWidth;
        }
    }
}
