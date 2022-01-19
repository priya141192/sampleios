using System;

using Foundation;
using SampleTask.IOS.Dto;
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
            ImgDoc.Image = UIImage.FromBundle("ImgTest.jpg");
            lblName.Text = doctor.DocName;
            lblDepartment.Text = doctor.Department;
            lblCategory.Text = doctor.Category;
            lblReviews.Text = doctor.Reviews;
        }
    }
}
