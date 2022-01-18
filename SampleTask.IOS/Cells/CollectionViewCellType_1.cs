using System;

using Foundation;
using SampleTask.IOS.Dto;
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
            lblCustName.Text = customer.CustomerName;
            lblCustAge.Text = customer.CustomerAge;
            lblTestMon.Text = customer.TestMon;
            lblDays.Text = customer.Days;
            ImgCust.Image = UIImage.FromBundle("ImgCustomer.jpg");
            ImgProfile.Image = UIImage.FromBundle("ImgTest.jpg");
            lblName.Text = customer.TestName;
            lblCategory.Text = customer.TestCategory;
            lblReviews.Text = customer.TestReviews;
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            ImgProfile.Layer.CornerRadius = 10;
            ImgCust.Layer.CornerRadius = 10;
            ImgProfile.Layer.MasksToBounds = true;
            ImgCust.Layer.MasksToBounds = true;
        }
    }
}
