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
            //fonts
            lblTestMon.Font = UIFont.FromName("Roboto-Regular", 15f);
            lblCustName.Font = UIFont.FromName("Roboto-Bold", 10f);
            lblCustAge.Font = UIFont.FromName("Roboto-Bold", 10f);
            lblDays.Font = UIFont.FromName("Roboto-Bold", 10f);
            lblName.Font = UIFont.FromName("Roboto-Bold", 15f);
            lblCategory.Font = UIFont.FromName("Roboto-Regular", 7f);
            lblReviews.Font = UIFont.FromName("Roboto-Regular", 10f);

            lblCustName.Text = customer.CustomerName;
            lblCustAge.Text = customer.CustomerAge;
            lblTestMon.Text = customer.TestMon;
            lblDays.Text = customer.Days;
            ImgCust.Image = UIImage.FromBundle("ImgCustomer.jpg");
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
