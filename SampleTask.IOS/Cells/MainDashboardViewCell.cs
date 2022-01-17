using System;

using Foundation;
using SampleTask.IOS.DataSources;
using UIKit;

namespace SampleTask.IOS.Cells
{
    public partial class MainDashboardViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MainDashboardViewCell");
        public static readonly UINib Nib;

        static MainDashboardViewCell()
        {
            Nib = UINib.FromName("MainDashboardViewCell", NSBundle.MainBundle);
        }

        protected MainDashboardViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
            
        }

        internal void UpdateCell(EmployeeModel student)
        {
            lblHeader.Text = student.header;
            lblOptions.Text = student.option;
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            dashboardcollectioncell.RegisterNibForCell(UINib.FromName("CollectionViewCellType_1",null), "CellType1");
            dashboardcollectioncell.Source = new CollectionViewType_1_Source();
        }
    }
}
