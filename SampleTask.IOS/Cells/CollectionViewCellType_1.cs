using System;

using Foundation;
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
            // Note: this .ctor should not contain any initialization logic.
        }

        internal void UpdateCell(EmployeeModel student)
        {
            //.Text = student.header;
            //lblOptions.Text = student.option;
        }
    }
}
