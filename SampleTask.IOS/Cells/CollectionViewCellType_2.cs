using System;

using Foundation;
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
    }
}
